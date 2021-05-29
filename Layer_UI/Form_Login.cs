using RBS_Restaurant_Billing_System.Layer_Data;
using RBS_Restaurant_Billing_System.Layer_Logic;
using RBS_Restaurant_Billing_System.Layer_UI.AdminUI;
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
    public partial class Form_Login : Form
    {
        private Logic_User userLogic = new Logic_User();
        private Data_User userData = new Data_User();
        private CryptographyManager crypto = new CryptographyManager();
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_login_frmLoginScreen_Click(object sender, EventArgs e)
        {

            userLogic.Username = txtB_user_frmLoginScreen.Text.ToString();
            userLogic.Password = txtB_pass_frmLoginScreen.Text.ToString();
            DataTable user = userData.SelectUser(userLogic);
            if (user.Rows.Count > 0)
            {
                string salt1 = crypto.GenerateHash(userLogic.Username,"x2hl3b3i3nStGP3Ba1Gt");
                string salt2 = crypto.GenerateHash(userLogic.Password, salt1);
                
                if (crypto.Authenticate(userLogic.Password, user.Rows[0]["Password"].ToString(), salt2) )
                {
                    if (chkB_adminPnl_frmLoginScreen.Checked && user.Rows[0]["Role"].ToString() == "Admin")
                    {
                        MessageBox.Show("You have Logged in As ADMIN [" + userLogic.Username + "]");
                        Program.SetMainForm(new Form_AdminDashboard(user));
                        Program.ShowMainForm();
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("You have Logged In as [" + userLogic.Username + "]");
                        Program.SetMainForm(new Form_Dashboard(user));
                        Program.ShowMainForm();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Username/Password is Incorrect");
                }

            }

        }
    }
}
