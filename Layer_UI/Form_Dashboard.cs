using RBS_Restaurant_Billing_System.Layer_Logic;
using RBS_Restaurant_Billing_System.Layer_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBS_Restaurant_Billing_System.Layer_UI
{
    
    public partial class Form_Dashboard : Form
    {
        System.Windows.Forms.Timer timer = null;
        Logic_Menu menuL = new Logic_Menu();
        Data_Menu menuD = new Data_Menu();
        static DataTable menuData = null;
        public Form_Dashboard()
        {
            InitializeComponent();
            StartTimer();

        }
        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rBS_DatabaseDataSet.RBS_Menu' table. You can move, or remove it, as needed.
            this.rBS_MenuTableAdapter.Fill(this.rBS_DatabaseDataSet.RBS_Menu);
            TableButtonsSetup();
            menuData = menuD.Select();
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
            if (button.Tag == null)
            {
                button.Tag = new Panel();
                Panel menuPanel = button.Tag as Panel;
                pnl_MenuContainer_frmDashboard.Controls.Add(button.Tag as Panel);
                menuPanel.Dock = DockStyle.Fill;
                menuPanel.Tag = "menuPanel";
                BuildMenuCategories(menuPanel,button.Text);
                BuildBillPanel(button.Text);
            }
            
            ShowMenuPanel(button.Tag as Panel);
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
        
        private void BuildBillPanel(string tablename)
        {
            Panel billPanel = new Panel();
            pnl_bill_frmDashboard.Controls.Add(billPanel);
            billPanel.Dock = DockStyle.Fill;
            billPanel.Tag = "billPanel_" + tablename;
            //billPanel.BackColor = Color.Red; 

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



            TableLayoutPanel billContent = new TableLayoutPanel();
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
            //billContent.BackColor = Color.Green;

            Panel billTotal = new Panel();
            billPanel.Controls.Add(billTotal);
            billTotal.Dock = DockStyle.Bottom;
            //billTotal.Size = new Size(400, 50);
            Label subTotal = new Label();
            subTotal.Text = "SubTotal";
            subTotal.Dock = DockStyle.Top;
            subTotal.TextAlign = ContentAlignment.MiddleRight;
            Label subVAT = new Label();
            subVAT.Text = "VAT";
            subVAT.Dock = DockStyle.Top;
            subVAT.TextAlign = ContentAlignment.MiddleRight;
            Label discount = new Label();
            discount.Text = "Discount";
            discount.Dock = DockStyle.Top;
            discount.TextAlign = ContentAlignment.MiddleRight;
            Label total = new Label();
            total.Text = "TOTAL";
            total.Dock = DockStyle.Bottom;
            total.TextAlign = ContentAlignment.MiddleRight;
            Label cashier = new Label();
            cashier.Text = "Cashier : Leonardo";
            cashier.Dock = DockStyle.Left;
            cashier.TextAlign = ContentAlignment.MiddleCenter;
            cashier.AutoSize = true;
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
                    btMinus.Tag = cat["ItemName"].ToString()+"=-";
                    StyleItemButtons(btMinus);
                    btMinus.Text = "-";
                    btMinus.Dock = DockStyle.Left;
                    btMinus.Visible = true;
                    
                    Label quantityL = new Label();
                    quantityL.Text = "0";
                    StyleItemLabels(quantityL);
                    //quantityL.SendToBack();
                    quantityL.Dock = DockStyle.Fill;
                    quantityL.Visible = true;

                    Button btPlus = new Button();
                    btPlus.Tag = cat["ItemName"].ToString()+"=+";
                    StyleItemButtons(btPlus);
                    btPlus.Text = "+";
                    btPlus.Dock = DockStyle.Right;
                    btPlus.Visible = true;

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
    }
}
