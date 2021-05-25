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
        public Form_Dashboard()
        {
            InitializeComponent();
            StartTimer();
        }
        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rBS_DatabaseDataSet.RBS_Menu' table. You can move, or remove it, as needed.
            this.rBS_MenuTableAdapter.Fill(this.rBS_DatabaseDataSet.RBS_Menu);
            tableButtonsSetup();

            
        }
        private void StartTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_Date_frmDashboard.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy | h:mm:s tt");
        }

        private void tableButtonsSetup()
        {
            btn_T1_frmDashboard.Tag = null;
            btn_T2_frmDashboard.Tag = null;
            btn_T3_frmDashboard.Tag = null;
            btn_T4_frmDashboard.Tag = null;
            btn_T5_frmDashboard.Tag = null;
            btn_T6_frmDashboard.Tag = null;
            btn_T7_frmDashboard.Tag = null;
            btn_T8_frmDashboard.Tag = null;

            btn_T1_frmDashboard.Click += handleAllButtonClicks;
            btn_T2_frmDashboard.Click += handleAllButtonClicks;
            btn_T3_frmDashboard.Click += handleAllButtonClicks;
            btn_T4_frmDashboard.Click += handleAllButtonClicks;
            btn_T5_frmDashboard.Click += handleAllButtonClicks;
            btn_T6_frmDashboard.Click += handleAllButtonClicks;
            btn_T7_frmDashboard.Click += handleAllButtonClicks;
            btn_T8_frmDashboard.Click += handleAllButtonClicks;
        }
        private void showUserControl(Control value)
        {
            foreach (Control ctrl in pnl_MenuContainer_frmDashboard.Controls)
            {
                if (ctrl is UserControl)
                {
                    ctrl.Visible = false;
                }
            }
            value.Visible = true;
        }
        private void handleAllButtonClicks(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Tag == null)
            {
                button.Tag = new UserControl_OrderMenu();
                pnl_MenuContainer_frmDashboard.Controls.Add(button.Tag as UserControl);
                showUserControl(button.Tag as UserControl);

            }
            else
            {
                showUserControl(button.Tag as UserControl);
            }
        }
    }
}
