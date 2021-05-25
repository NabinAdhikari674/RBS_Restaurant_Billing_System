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

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
