using RBS_Restaurant_Billing_System.Layer_Logic;
using RBS_Restaurant_Billing_System.Layer_Data;
using RBS_Restaurant_Billing_System.Layer_UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace RBS_Restaurant_Billing_System.Layer_UI
{
    
    public partial class Form_Dashboard : Form
    {
        System.Windows.Forms.Timer timer = null;

        Logic_Transactions logic_Transactions = new Logic_Transactions();
        Data_Transactions transactionD = new Data_Transactions();
        Data_Menu menuD = new Data_Menu();
        static DataTable menuData = null;
        //Logic_User logic_User = new Logic_User();
        //Data_User userD = new Data_User();

        static Control activeBill = null;
        static Control activeMenu = null;
        static Control activeButton = null;
        static List<Control> pendingTables = new List<Control>();

        static DataTable loggedUser;


        public Form_Dashboard(DataTable user)
        {
            InitializeComponent();
            StartTimer();
            loggedUser = user;

        }
        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rBS_DatabaseDataSet.RBS_Menu' table. You can move, or remove it, as needed.
            this.rBS_MenuTableAdapter.Fill(this.rBS_DatabaseDataSet.RBS_Menu);
            TableButtonsSetup();
            menuData = menuD.Select();
            lbl_username_frmDashboard.Text = "User : " + loggedUser.Rows[0]["Username"].ToString();
        }

        


        #region Clock

        private void StartTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_Date_frmDashboard.Text = DateTime.Now.ToString("ddd, dd MMMM yyyy | h:mm:s tt");
        }
        #endregion
        

        
        private void TableButtonsSetup()
        {
            btn_T1_frmDashboard.Tag = null;
            btn_T2_frmDashboard.Tag = null;
            btn_T3_frmDashboard.Tag = null;
            btn_T4_frmDashboard.Tag = null;
            btn_T5_frmDashboard.Tag = null;
            btn_T6_frmDashboard.Tag = null;
            btn_T7_frmDashboard.Tag = null;
            btn_T8_frmDashboard.Tag = null;

            btn_T1_frmDashboard.Click += HandleTableButtonClicks;
            btn_T2_frmDashboard.Click += HandleTableButtonClicks;
            btn_T3_frmDashboard.Click += HandleTableButtonClicks;
            btn_T4_frmDashboard.Click += HandleTableButtonClicks;
            btn_T5_frmDashboard.Click += HandleTableButtonClicks;
            btn_T6_frmDashboard.Click += HandleTableButtonClicks;
            btn_T7_frmDashboard.Click += HandleTableButtonClicks;
            btn_T8_frmDashboard.Click += HandleTableButtonClicks;
        }
        
        private void HandleTableButtonClicks(object sender, EventArgs e)
        {
            Button button = sender as Button;
             ///57, 21, 51
            if (button.Tag == null)
            {
                button.Tag = new Panel();
                Panel menuPanel = button.Tag as Panel;
                pnl_MenuContainer_frmDashboard.Controls.Add(button.Tag as Panel);
                menuPanel.Dock = DockStyle.Fill;


                menuPanel.Tag = new Panel();
                Panel billPanel = menuPanel.Tag as Panel;
                billPanel.AutoScroll = true;
                pnl_billContainer_frmDashboard.Controls.Add(billPanel);
                billPanel.Dock = DockStyle.Fill;
                //billPanel.Tag = "billPanel_" + button.Text;

                BuildMenuCategories(menuPanel,button.Text);
                BuildBillPanel(billPanel,button.Text);
            }
            activeBill = (button.Tag as Panel).Tag as Panel;
            activeMenu = button.Tag as Panel;
            if(activeButton!=null & !pendingTables.Contains(activeButton))
            {
                activeButton.BackColor = Color.FromArgb(19,7,17);
            } 
            else if(activeButton != null & pendingTables.Contains(activeButton))
            {
                activeButton.BackColor = Color.FromArgb(57, 21, 51);
            }
            activeButton = button;
            if (pendingTables.Contains(activeButton))
            {
                btn_pending_frmDashboard.BackColor = Color.FromArgb(149, 34, 153);
            }
            else
                btn_pending_frmDashboard.BackColor = Color.FromArgb(19, 7, 17);
            activeButton.BackColor = Color.FromArgb(149, 34, 153);
            ShowMenuPanel(button.Tag as Panel);
            ShowBillPanel((button.Tag as Panel).Tag as Panel);
        }
        
        private void ShowMenuPanel(Control value)
        {
            foreach (Control ctrl in pnl_MenuContainer_frmDashboard.Controls)
            {
                if (ctrl is Panel)
                {
                    ctrl.Visible = false;
                }
            }

            value.Visible = true;
        }
        
        private void ShowBillPanel(Control value)
        {
            foreach (Control ctrl in pnl_billContainer_frmDashboard.Controls)
            {
                if(ctrl is Panel)
                {
                    ctrl.Visible = false; 
                }
            }
            value.Visible = true;
        }

        private void BuildMenuCategories(Panel menuPanel,string tablename)
        {
            Panel sidePanel = new Panel();
            menuPanel.Controls.Add(sidePanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Size = new Size(169, 341);
            //sidePanel.BackColor = Color.Black; ///!!!!!!!!!!!!!!!!!1
            sidePanel.Visible = true;

            Label label = new Label
            {
                Text = "Menu Groups ["+tablename+"]"
            };
            StyleCatLabels(label);
            sidePanel.Controls.Add(label);
            label.Visible = true;

            List<string> catList = new List<string>();
            foreach (DataRow cat in menuData.Rows)
            {
                if(!catList.Contains(cat["Category"].ToString())){
                    Button bt = new Button();
                    bt.Tag = null;
                    bt.Text = cat["Category"].ToString();
                    StyleCatButtons(bt);
                    sidePanel.Controls.Add(bt);
                    bt.Dock = DockStyle.Top;
                    bt.Visible = true;
                    bt.Click += HandleCatButtonClicks;
                    catList.Add(cat["Category"].ToString());
                }
            }
            label.SendToBack();
            label.Dock = DockStyle.Top;
        }
        
        private void BuildBillPanel(Panel billPanel,string tablename)
        {
            Panel billIntro = new Panel();
            billPanel.Controls.Add(billIntro);
            billIntro.Dock = DockStyle.Top;
            billIntro.BorderStyle = BorderStyle.FixedSingle;

            Label businessName = new Label();
            businessName.Text = "Foodie Seoul by Gautam";
            businessName.Dock = DockStyle.Top;
            businessName.TextAlign = ContentAlignment.MiddleCenter;

            PictureBox businessLogo = new PictureBox();
            businessLogo.Image = Properties.Resources.LOGO;
            businessLogo.SizeMode = PictureBoxSizeMode.Zoom;
            businessLogo.Dock = DockStyle.Fill;

            Label businessTag = new Label();
            businessTag.Text = "We Serve Better!";
            businessTag.Dock = DockStyle.Bottom;
            businessTag.TextAlign = ContentAlignment.MiddleCenter;
            businessTag.Size = new Size(410, 20);
            billIntro.Controls.Add(businessName);
            billIntro.Controls.Add(businessTag);
            billIntro.Controls.Add(businessLogo);

            Panel billDetail = new Panel();
            billPanel.Controls.Add(billDetail);
            billDetail.BringToFront();
            billDetail.Dock = DockStyle.Top;
            billDetail.Size = new Size(410, 20);
            Label billNumber = new Label();
            billNumber.Text = "BillNumber";
            billNumber.TextAlign = ContentAlignment.MiddleLeft;
            billNumber.Dock = DockStyle.Left;
            Label billTableName = new Label();
            billTableName.Text = tablename;
            billTableName.TextAlign = ContentAlignment.MiddleCenter;
            billTableName.Dock = DockStyle.Fill;
            Label billDate = new Label();
            billDate.Text = "Bill Date";
            billDate.TextAlign = ContentAlignment.MiddleRight;
            billDate.Dock = DockStyle.Right;
            billDetail.Controls.Add(billNumber);
            billDetail.Controls.Add(billDate);
            billDetail.Controls.Add(billTableName);



            billPanel.Tag = new TableLayoutPanel();
            TableLayoutPanel billContent = billPanel.Tag as TableLayoutPanel;
            billContent.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            billContent.ColumnCount = 4;
            billContent.RowCount = 1;
            billContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            billContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            billContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            billContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));

            billContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            billContent.Controls.Add(new Label() { Text = "Items"}, 0, 0);
            billContent.Controls.Add(new Label() { Text = "Rate" }, 1, 0);
            billContent.Controls.Add(new Label() { Text = "Quantity" }, 2, 0);
            billContent.Controls.Add(new Label() { Text = "Total" }, 3, 0);

            billPanel.Controls.Add(billContent);
            billContent.Dock = DockStyle.Top;
            billContent.BringToFront();
            billContent.AutoSize = true;
            //billContent.AutoScroll = true;
            //billContent.BackColor = Color.Green;

            billContent.Tag = new Panel();
            Panel billTotal = billContent.Tag as Panel;
            billPanel.Controls.Add(billTotal);
            billTotal.Dock = DockStyle.Bottom;
            //billTotal.Size = new Size(400, 50);
            Label subTotal = new Label();
            subTotal.Text = "SubTotal : 0";
            subTotal.Dock = DockStyle.Top;
            subTotal.TextAlign = ContentAlignment.MiddleRight;
            Label subVAT = new Label();
            subVAT.Text = "VAT : 13%";
            subVAT.Dock = DockStyle.Top;
            subVAT.TextAlign = ContentAlignment.MiddleRight;
            Label discount = new Label();
            discount.Text = "Discount : 10%";
            discount.Dock = DockStyle.Top;
            discount.TextAlign = ContentAlignment.MiddleRight;
            Label total = new Label();
            total.Text = "TOTAL : 0";
            total.Dock = DockStyle.Bottom;
            total.TextAlign = ContentAlignment.MiddleRight;
            Label cashier = new Label();
            cashier.Text = "Cashier : "+ loggedUser.Rows[0]["Username"].ToString();
            cashier.Dock = DockStyle.Left;
            cashier.TextAlign = ContentAlignment.MiddleCenter;
            cashier.AutoSize = true;
            billTotal.Tag = subTotal;
            subTotal.Tag = subVAT;
            subVAT.Tag = discount;
            discount.Tag = total;
            total.Tag = cashier;
            billTotal.Controls.Add(cashier);
            billTotal.Controls.Add(discount);
            billTotal.Controls.Add(subVAT);
            billTotal.Controls.Add(subTotal);
            billTotal.Controls.Add(total);


            Label billFooter = new Label();
            billFooter.Size = new Size(70, 20);
            billFooter.BorderStyle = BorderStyle.FixedSingle;
            billFooter.Text = "Thank Your For Eating with Us Foodie !";
            billFooter.TextAlign = ContentAlignment.MiddleCenter;
            billPanel.Controls.Add(billFooter);
            billFooter.Dock = DockStyle.Bottom;
        }
        
        private void StyleCatButtons(Button bt)
        {
            bt.FlatStyle = FlatStyle.Flat;
            bt.FlatAppearance.BorderSize = 1;
            bt.FlatAppearance.BorderColor = Color.FromArgb(49, 30, 57);
            bt.BackColor = Color.FromArgb(19, 7, 17);
            bt.ForeColor = Color.WhiteSmoke;
            bt.Cursor = Cursors.Hand;
            bt.Font = new Font((string)"Calibri", (float)14.5, FontStyle.Regular);
            bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(57, 21, 51);
            bt.TextAlign = ContentAlignment.MiddleLeft;
            bt.Margin = new Padding(10);
            bt.Size = new Size(169, 45);
        }
        
        private void StyleCatLabels(Label lbl)
        {
            lbl.FlatStyle = FlatStyle.Flat;
            lbl.ForeColor = Color.WhiteSmoke;
            lbl.Font = new Font((string)"Calibri", (float)12, FontStyle.Regular);
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Margin = new Padding(10);
            lbl.Size = new Size(169, 45);
        }
       
        

        
        
        private void HandleCatButtonClicks(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Tag == null)
            {
                button.Tag = new TableLayoutPanel();
                TableLayoutPanel itemsPanel = button.Tag as TableLayoutPanel;
                //itemsPanel.BackColor = Color.Red;  // !!!!!!!!!!!!!!!!!!!!!!!
                button.Parent.Parent.Controls.Add(button.Tag as TableLayoutPanel);
                itemsPanel.BringToFront();
                itemsPanel.Dock = DockStyle.Top;
                itemsPanel.AutoSize = true;
                //itemsPanel.Size = new Size(383, 319);
                //itemsPanel.Anchor = AnchorStyles.Left; ;
                Console.WriteLine(button.Parent.Parent.Name);
                itemsPanel.Tag = "itemPanel";
                BuildMenuItems(itemsPanel,button.Text);
            }
            ShowItemPanel(button.Tag as TableLayoutPanel);
        }
        
        private void ShowItemPanel(Panel itemPanel)
        {
            foreach (Control ctrl in itemPanel.Parent.Controls)
            {
                if (ctrl.Tag is "itemPanel")
                {
                    ctrl.Visible = false;
                }
            }
            itemPanel.Visible = true;
        }
        
        private void BuildMenuItems(TableLayoutPanel itemPanel,string category)
        {
            itemPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            itemPanel.ColumnCount = 3;
            itemPanel.RowCount = 1;
            itemPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            itemPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            itemPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));

            itemPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            itemPanel.Controls.Add(new Label() { Text = "Items ["+category+"]" }, 0, 0);
            itemPanel.Controls.Add(new Label() { Text = "Price" }, 1, 0);
            itemPanel.Controls.Add(new Label() { Text = "Quantity" }, 2, 0);

            foreach (DataRow cat in menuData.Rows)
            {
                if (cat["Category"].ToString() == category)
                {
                    Panel panel = new Panel();

                    Button btMinus = new Button();
                    btMinus.Name = cat["ItemName"].ToString()+"^"+cat["Price"]+"^-";
                    StyleItemButtons(btMinus);
                    btMinus.Click += HandleQuantityandBill;
                    btMinus.Text = "-";
                    btMinus.Dock = DockStyle.Left;
                    btMinus.Visible = true;
                    
                    Label quantityL = new Label();
                    quantityL.Text = "0";
                    StyleItemLabels(quantityL);
                    quantityL.Dock = DockStyle.Fill;
                    quantityL.Visible = true;

                    Button btPlus = new Button();
                    btPlus.Name = cat["ItemName"].ToString() + "^" + cat["Price"] + "^+";
                    StyleItemButtons(btPlus);
                    btPlus.Click += HandleQuantityandBill;
                    btPlus.Text = "+";
                    btPlus.Dock = DockStyle.Right;
                    btPlus.Visible = true;

                    btMinus.Tag = quantityL;
                    btPlus.Tag = quantityL;
                    panel.Controls.Add(btPlus);
                    panel.Controls.Add(btMinus);
                    panel.Controls.Add(quantityL);



                    itemPanel.RowCount += 1;
                    itemPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
                    itemPanel.Controls.Add(new Label() { Text = cat["ItemName"].ToString() }, 0,itemPanel.RowCount-1);
                    itemPanel.Controls.Add(new Label() { Text = cat["Price"].ToString() }, 1, itemPanel.RowCount - 1);
                    itemPanel.Controls.Add(panel, 2, itemPanel.RowCount - 1);
                    //bt.Click += HandleItemButtonClick;
                }
            }
        }
        
        private void StyleItemButtons(Button bt)
        {
            bt.FlatStyle = FlatStyle.Flat;
            bt.FlatAppearance.BorderSize = 0;
            bt.FlatAppearance.BorderColor = Color.FromArgb(49, 30, 57);
            bt.BackColor = Color.FromArgb(19, 7, 17);
            bt.ForeColor = Color.WhiteSmoke;
            bt.Cursor = Cursors.Hand;
            bt.Font = new Font((string)"Calibri", (float)12.5, FontStyle.Regular);
            bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(57, 21, 51);
            //bt.Margin = new Padding(10);
            bt.Size = new Size(50, 45);
        }
        
        private void StyleItemLabels(Label lbl)
        {
            lbl.FlatStyle = FlatStyle.Flat;
            lbl.ForeColor = Color.WhiteSmoke;
            //lbl.BackColor = Color.Red;
            lbl.Font = new Font((string)"Calibri", (float)12, FontStyle.Regular);
            lbl.Margin = new Padding(10);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Size = new Size(50, 45);
        }
    


        
        private void HandleQuantityandBill(object sender, EventArgs e)
        {
            Button button = sender as Button;
            TableLayoutPanel billTable = activeBill.Tag as TableLayoutPanel; // 4 Columns // Item Rate Quantity Total
            List<string> stringList = (button.Name).ToString().Split('^').ToList();

            int x = FindRow(billTable, stringList[0]);

            if (stringList[2]=="+")
            {
                if (x != -1)
                {
                    Control quantity = billTable.GetControlFromPosition(2, x);
                    int q = int.Parse(quantity.Text)+1;
                    quantity.Text = q.ToString();
                    Control rate = billTable.GetControlFromPosition(1, x);
                    float t = float.Parse(rate.Text)*q;
                    Control total = billTable.GetControlFromPosition(3, x);
                    total.Text = t.ToString();

                    (button.Tag as Label).Text = q.ToString();
                    ReTotalBill(billTable);
                }
                else
                {
                    billTable.RowCount += 1;
                    billTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));

                    billTable.Controls.Add(new Label() { Text = stringList[0] }, 0, billTable.RowCount - 1);
                    billTable.Controls.Add(new Label() { Text = stringList[1] }, 1, billTable.RowCount - 1);
                    billTable.Controls.Add(new Label() { Text = "1" }, 2, billTable.RowCount - 1);
                    billTable.Controls.Add(new Label() { Text = stringList[1] }, 3, billTable.RowCount - 1);

                    (button.Tag as Label).Text = "1";
                    ReTotalBill(billTable);
                }
                

            }
            else if (stringList[2] == "-")
            {
                if(x != -1)
                {
                    Control quantity = billTable.GetControlFromPosition(2, x);
                    int q = int.Parse(quantity.Text) - 1;
                    if (q <= 0)
                    {
                        RemoveRow(billTable, x);
                        (button.Tag as Label).Text = q.ToString();
                        ReTotalBill(billTable);
                        return;
                    }
                    quantity.Text = q.ToString();
                    Control rate = billTable.GetControlFromPosition(1, x);
                    float t = float.Parse(rate.Text) * q;
                    Control total = billTable.GetControlFromPosition(3, x);
                    total.Text = t.ToString();

                    (button.Tag as Label).Text = q.ToString();
                    ReTotalBill(billTable);
                }

            }

        }

        private int FindRow(TableLayoutPanel panel, string query)
        {
            for(int i = 1; i < panel.RowCount; i++)
            {
                Control control = panel.GetControlFromPosition(0, i);
                if(control.Text == query)
                {
                    return i;
                }
            }
            return -1;
        }
        
        private void RemoveRow(TableLayoutPanel panel, int rowIndex)
        {
            if (rowIndex >= panel.RowCount)
            {
                return;
            }

            // delete all controls of row that we want to delete
            for (int i = 0; i < panel.ColumnCount; i++)
            {
                var control = panel.GetControlFromPosition(i, rowIndex);
                panel.Controls.Remove(control);
            }

            // move up row controls that comes after row we want to remove
            for (int i = rowIndex + 1; i < panel.RowCount; i++)
            {
                for (int j = 0; j < panel.ColumnCount; j++)
                {
                    var control = panel.GetControlFromPosition(j, i);
                    if (control != null)
                    {
                        panel.SetRow(control, i - 1);
                    }
                }
            }

            var removeStyle = panel.RowCount - 1;

            if (panel.RowStyles.Count > removeStyle)
                panel.RowStyles.RemoveAt(removeStyle);

            panel.RowCount--;
        }

        private void ReTotalBill(TableLayoutPanel table)
        {
            Panel tPanel = table.Tag as Panel;
            Label subTotal = tPanel.Tag as Label;
            Label vat = subTotal.Tag as Label;
            Label discount = vat.Tag as Label;
            Label gtotal = discount.Tag as Label;

            float st = 0;
            float vt = float.Parse(vat.Text.Split(':')[1].Substring(0,3));
            float dt = float.Parse(discount.Text.Split(':')[1].Substring(0, 3));
            float gt;

            

            for (int i = 1; i< table.RowCount; i++)
            {
                Control control = table.GetControlFromPosition(3,i);
                float x = float.Parse(control.Text);
                st += x;
            }

            gt = st;
            gt += (st * vt / (float)100);
            gt -= (st * dt / (float)100);

            subTotal.Text = "Sub Total : " + st.ToString();
            gtotal.Text = "Grand Total : "+ gt.ToString();
        }

        private void btn_cancel_frmDashboard_Click(object sender, EventArgs e)
        {
            if(activeButton != null)
            {
                
                var confirmResult = MessageBox.Show("Are You Sure To CANCEL "+activeButton.Text+" Order ?", "Confirm To Cancel ["+activeButton.Text+"] Order", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    activeButton.Tag = null;
                    if (pendingTables.Contains(activeButton))
                        pendingTables.Remove(activeButton);
                    activeButton.BackColor = Color.FromArgb(19, 7, 17);
                    btn_pending_frmDashboard.BackColor = Color.FromArgb(19, 7, 17);
                    pnl_MenuContainer_frmDashboard.Controls.Remove(activeMenu);
                    pnl_billContainer_frmDashboard.Controls.Remove(activeBill);
                    activeButton = null;
                    //pnl_MenuContainer_frmDashboard.Refresh();
                    //pnl_billContainer_frmDashboard.Refresh();
                }
            }      
        }

        private void btn_pending_frmDashboard_Click(object sender, EventArgs e)
        {
            if (activeButton != null)
            {
                if(!pendingTables.Contains(activeButton))
                    pendingTables.Add(activeButton);
                btn_pending_frmDashboard.BackColor = Color.FromArgb(149, 34, 153);
            }
        }
        
        private void cancelPendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pendingTables.Contains(activeButton))
                pendingTables.Remove(activeButton);
            btn_pending_frmDashboard.BackColor = Color.FromArgb(19,7,17);
        }

        
        private void btn_checkout_frmDashboard_Click(object sender, EventArgs e)
        {
            if (activeButton != null)
            {
                TableLayoutPanel billTable = activeBill.Tag as TableLayoutPanel;
                ReTotalBill(billTable);
                Panel billTotals = billTable.Tag as Panel;

                if (!(billTable.RowCount>1))
                {
                    return;
                }

                Label subTotal = billTotals.Tag as Label;
                Label vat = subTotal.Tag as Label;
                Label discount = vat.Tag as Label;
                Label gtotal = discount.Tag as Label;
                Label casier = gtotal.Tag as Label;

                logic_Transactions.Amount = float.Parse(gtotal.Text.Split(':')[1]);
                logic_Transactions.Cashier = casier.Text.Split(':')[1].ToString().Trim();

                for (int i = 1; i < billTable.RowCount; i++)
                {
                    Control item = billTable.GetControlFromPosition(0, i);
                    Control quantity = billTable.GetControlFromPosition(2, i);
                    logic_Transactions.Items += item.Text.ToString() + "X" + quantity.Text.ToString() + ",";
                }

                var confirmResult = MessageBox.Show("Confirm To CHECKOUT " + activeButton.Text + " Order", "Confirm To CHECKOUT [" + activeButton.Text + "] Order", MessageBoxButtons.YesNo);
                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }

                bool x = transactionD.Insert(logic_Transactions);
                if (x)
                    MessageBox.Show("Bill Checked out !");
                else
                {
                    MessageBox.Show("COULD NOT Checkout Bill ! Try Again !!");
                    return;
                }
                if (pendingTables.Contains(activeButton))
                    pendingTables.Remove(activeButton);
                btn_pending_frmDashboard.BackColor = Color.FromArgb(19, 7, 17);
                activeButton.Tag = null;
                if (pendingTables.Contains(activeButton))
                    pendingTables.Remove(activeButton);
                activeButton.BackColor = Color.FromArgb(19, 7, 17);
                pnl_MenuContainer_frmDashboard.Controls.Remove(activeMenu);
                pnl_billContainer_frmDashboard.Controls.Remove(activeBill);
                activeButton = null;
            }

            

        }

        private void btn_print_frmDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print Function Coming Soon !!");
            //printPreviewDialog.Document = printDocument;
            //printDocument.
            //printPreviewDialog.ShowDialog();
            


        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Foodie Seoul By Gautam", new Font((string)"Calibri", (float)12, FontStyle.Regular), Brushes.Black, new Point(50, 20));

        }

        private void btn_menu_frmDashboard_Click(object sender, EventArgs e)
        {
            Program.SetMainForm(new Form_Login());
            Program.ShowMainForm();
            //this.Close();
        }
    }
}
