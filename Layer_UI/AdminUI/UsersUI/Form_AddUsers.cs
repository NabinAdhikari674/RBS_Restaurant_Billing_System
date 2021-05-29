using RBS_Restaurant_Billing_System.Layer_Data;
using RBS_Restaurant_Billing_System.Layer_Logic;
using System;
using System.Windows.Forms;

namespace RBS_Restaurant_Billing_System.Layer_UI.AdminUI.UsersUI
{
    public partial class Form_AddUsers : Form
    {
        private Logic_User userL = new Logic_User();
        private Data_User userD = new Data_User();
        private CryptographyManager crypto = new CryptographyManager();
        public Form_AddUsers()
        {
            InitializeComponent();
        }

        private void rBS_UsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rBS_UsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rBS_DatabaseDataSet);

        }

        private void Form_AddUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rBS_DatabaseDataSet.RBS_Users' table. You can move, or remove it, as needed.
            this.rBS_UsersTableAdapter.Fill(this.rBS_DatabaseDataSet.RBS_Users);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pnl_AddUserContainer_frmAD.Visible = true;
            lbl_paswordEmptymsg.Visible = false;
            btn_addUser_frmAD.Text = "Add User";
            input_username.Text = "";
            input_password.Text = "";
            input_email.Text = "";
            comboBox_Role.SelectedText = "";
            input_phone.Text = "";
            input_address.Text = "";
        }

        private void toolStripButton_update_Click(object sender, EventArgs e)
        {
            pnl_AddUserContainer_frmAD.Visible = true;
            lbl_paswordEmptymsg.Visible = true;
            btn_addUser_frmAD.Text = "Update User";
            rBS_UsersDataGridView.Update();
            input_username.Text = "";
            input_password.Text = "";
            input_email.Text = "";
            comboBox_Role.SelectedText = "";
            input_phone.Text = "";
            input_address.Text = "";
        }

        private void btn_addUser_frmAD_Click(object sender, EventArgs e)
        {
            if(btn_addUser_frmAD.Text == "Update User")
            {
                UpdateUser();
                return;
            }
            userL.Username = input_username.Text;
            userL.Password = input_password.Text;
            userL.Email = input_email.Text;
            userL.Role = comboBox_Role.SelectedText;
            try { userL.Phone = int.Parse(input_phone.Text); }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            userL.Address = input_address.Text;

            string salt1 = crypto.GenerateHash(userL.Username, "x2hl3b3i3nStGP3Ba1Gt");
            string salt2 = crypto.GenerateHash(userL.Password, salt1);
            userL.Password = crypto.GenerateHash(input_password.Text, salt2);

            if (userD.Insert(userL))
            {
                MessageBox.Show("User ["+userL.Username+"] Added Sucessfully !!");
                rBS_UsersDataGridView.Update();
                input_username.Text = "";
                input_password.Text = "";
                input_email.Text = "";
                comboBox_Role.SelectedText = "";
                input_phone.Text = "";
                input_address.Text = "";
            }
            else
            {
                MessageBox.Show("User [" + userL.Username + "] COULD NOT be Added. Try Again !!");
            }

        }

        private void UpdateUser()
        {
            userL.Id = int.Parse(input_username.Tag.ToString());
            userL.Username = input_username.Text;

            if (input_password.Text == "")
                userL.Password = input_password.Tag.ToString();
            else
                userL.Password = input_password.Text;

            userL.Email = input_email.Text;
            userL.Role = comboBox_Role.SelectedText;
            userL.Phone = int.Parse(input_phone.Text);
            userL.Address = input_address.Text;

            if (userD.Update(userL))
            {
                MessageBox.Show("Selected user ["+userL.Username+"] Updated Sucessfully !");
                rBS_UsersDataGridView.Update();

            }

        }

        private void rBS_UsersDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            input_username.Tag = rBS_UsersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            input_username.Text = rBS_UsersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            input_email.Text = rBS_UsersDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox_Role.SelectedText = rBS_UsersDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            input_phone.Text = rBS_UsersDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            input_address.Text = rBS_UsersDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            input_password.Text = "";
            input_password.Tag = rBS_UsersDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
