using System;
using System.Windows.Forms;

namespace RBS_Restaurant_Billing_System.Layer_UI.AdminUI.UsersUI
{
    public partial class Form_DeleteUsers : Form
    {
        public Form_DeleteUsers()
        {
            InitializeComponent();
        }

        private void rBS_UsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rBS_UsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rBS_DatabaseDataSet);

        }

        private void Form_DeleteUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rBS_DatabaseDataSet.RBS_Users' table. You can move, or remove it, as needed.
            this.rBS_UsersTableAdapter.Fill(this.rBS_DatabaseDataSet.RBS_Users);

        }
    }
}
