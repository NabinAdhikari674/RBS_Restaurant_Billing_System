using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RBS_Restaurant_Billing_System.Layer_UI
{
    class PrintControl
    {

        public static Bitmap ScrollableControlToBitmap(ScrollableControl canvas, bool fullSize, bool includeHidden)
        {
            canvas.AutoScrollPosition = new Point(0, 0);
            if (includeHidden)
            {
                canvas.SuspendLayout();
                foreach (Control child in canvas.Controls)
                {
                    child.Visible = true;
                }
                canvas.ResumeLayout(true);
            }

            canvas.PerformLayout();
            Size containerSize = canvas.DisplayRectangle.Size;
            if (fullSize)
            {
                containerSize.Width = Math.Max(containerSize.Width, canvas.ClientSize.Width);
                containerSize.Height = Math.Max(containerSize.Height, canvas.ClientSize.Height);
            }
            else
            {
                containerSize = (canvas is Form) ? canvas.PreferredSize : canvas.ClientSize;
            }

            var bitmap = new Bitmap(containerSize.Width, containerSize.Height, PixelFormat.Format32bppArgb);
            bitmap.SetResolution(canvas.DeviceDpi, canvas.DeviceDpi);

            var graphics = Graphics.FromImage(bitmap);
            if (canvas.BackgroundImage != null)
            {
                graphics.DrawImage(canvas.BackgroundImage, new Rectangle(Point.Empty, containerSize));
            }
            else
            {
                graphics.Clear(canvas.BackColor);
            }

            var rtfPrinter = new RichEditPrinter(graphics);

            try
            {
                DrawNestedControls(canvas, canvas, new Rectangle(Point.Empty, containerSize), bitmap, rtfPrinter);
                return bitmap;
            }
            finally
            {
                rtfPrinter.Dispose();
                graphics.Dispose();
            }
        }

        private static void DrawNestedControls(Control outerContainer, Control parent, Rectangle parentBounds, Bitmap bitmap, RichEditPrinter rtfPrinter)
        {
            for (int i = parent.Controls.Count - 1; i >= 0; i--)
            {
                var ctl = parent.Controls[i];
                if (!ctl.Visible || (ctl.Width < 1 || ctl.Height < 1)) continue;

                var clipBounds = Rectangle.Empty;
                if (parent == outerContainer) { clipBounds = ctl.Bounds; }
                else
                {
                    if ((parent != ctl) && parent is ScrollableControl) ////// parent is ScrollableControl scrctl
                    {
                        Size scrContainerSize = parentBounds.Size;
                        if (parent is ScrollableControl scrctl)
                        {

                            if (scrctl.VerticalScroll.Visible) scrContainerSize.Width -= (SystemInformation.VerticalScrollBarWidth + 1);
                            if (scrctl.HorizontalScroll.Visible) scrContainerSize.Height -= (SystemInformation.HorizontalScrollBarHeight + 1);
                        }
                        clipBounds = Rectangle.Intersect(new Rectangle(Point.Empty, scrContainerSize), ctl.Bounds);
                    }

                    if (clipBounds.Width < 1 || clipBounds.Height < 1) continue;
                    var bounds = outerContainer.RectangleToClient(parent.RectangleToScreen(clipBounds));

                    if (ctl is RichTextBox rtb)
                    {
                        rtfPrinter.DrawRtf(rtb.Rtf, outerContainer.Bounds, bounds, ctl.BackColor);
                    }
                    else
                    {
                        ctl.DrawToBitmap(bitmap, bounds);
                    }
                    if (ctl.HasChildren)
                    {
                        DrawNestedControls(outerContainer, ctl, clipBounds, bitmap, rtfPrinter);
                    }
                }
            }
        }

        internal class RichEditPrinter : IDisposable
        {
            Graphics dc = null;
            RTBPrinter rtb = null;

            public RichEditPrinter(Graphics graphics)
            {
                this.dc = graphics;
                this.rtb = new RTBPrinter() { ScrollBars = RichTextBoxScrollBars.None };
            }

            public void DrawRtf(string rtf, Rectangle canvas, Rectangle layoutArea, Color color)
            {
                rtb.Rtf = rtf;
                rtb.Draw(dc, canvas, layoutArea, color);
                rtb.Clear();
            }

            public void Dispose() => this.rtb.Dispose();

            private class RTBPrinter : RichTextBox
            {
                public void Draw(Graphics g, Rectangle hdcArea, Rectangle layoutArea, Color color)
                {
                    using (var brush = new SolidBrush(color))
                    {
                        g.FillRectangle(brush, layoutArea);
                    };

                    IntPtr hdc = g.GetHdc();
                    var canvasAreaTwips = new RECT().ToInches(hdcArea);
                    var layoutAreaTwips = new RECT().ToInches(layoutArea);

                    var formatRange = new FORMATRANGE()
                    {
                        charRange = new CHARRANGE() { cpMax = -1, cpMin = 0 },
                        hdc = hdc,
                        hdcTarget = hdc,
                        rect = layoutAreaTwips,
                        rectPage = canvasAreaTwips
                    };

                    IntPtr lParam = Marshal.AllocCoTaskMem(Marshal.SizeOf(formatRange));
                    Marshal.StructureToPtr(formatRange, lParam, false);

                    SendMessage(this.Handle, EM_FORMATRANGE, (IntPtr)1, lParam);
                    Marshal.FreeCoTaskMem(lParam);
                    g.ReleaseHdc(hdc);
                }

                [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
                internal static extern int SendMessage(IntPtr hWnd, int uMsg, IntPtr wParam, IntPtr lParam);

                internal const int WM_USER = 0x0400;
                // https://docs.microsoft.com/en-us/windows/win32/controls/em-formatrange
                internal const int EM_FORMATRANGE = WM_USER + 57;

                [StructLayout(LayoutKind.Sequential)]
                internal struct RECT
                {
                    public int Left;
                    public int Top;
                    public int Right;
                    public int Bottom;

                    public Rectangle ToRectangle() => Rectangle.FromLTRB(Left, Top, Right, Bottom);
                    public RECT ToInches(Rectangle rectangle)
                    {
                        float inch = 14.92f;
                        return new RECT()
                        {
                            Left = (int)(rectangle.Left * inch),
                            Top = (int)(rectangle.Top * inch),
                            Right = (int)(rectangle.Right * inch),
                            Bottom = (int)(rectangle.Bottom * inch)
                        };
                    }
                }

                // https://docs.microsoft.com/en-us/windows/win32/api/richedit/ns-richedit-formatrange?
                [StructLayout(LayoutKind.Sequential)]
                internal struct FORMATRANGE
                {
                    public IntPtr hdcTarget;      // A HDC for the target device to format for
                    public IntPtr hdc;            // A HDC for the device to render to, if EM_FORMATRANGE is being used to send the output to a device
                    public RECT rect;             // The area within the rcPage rectangle to render to. Units are measured in twips.
                    public RECT rectPage;         // The entire area of a page on the rendering device. Units are measured in twips.
                    public CHARRANGE charRange;   // The range of characters to format (see CHARRANGE)
                }

                [StructLayout(LayoutKind.Sequential)]
                internal struct CHARRANGE
                {
                    public int cpMin;           // First character of range (0 for start of doc)
                    public int cpMax;           // Last character of range (-1 for end of doc)
                }
            }
        }


    }
}
