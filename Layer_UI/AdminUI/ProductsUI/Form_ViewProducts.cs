using System;
using System.Windows.Forms;

namespace RBS_Restaurant_Billing_System.Layer_UI.AdminUI.ProductsUI
{
    public partial class Form_ViewProducts : Form
    {
        public Form_ViewProducts()
        {
            InitializeComponent();
        }

        private void rBS_MenuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rBS_MenuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rBS_DatabaseDataSet);

        }

        private void Form_ViewProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rBS_DatabaseDataSet.RBS_Menu' table. You can move, or remove it, as needed.
            this.rBS_MenuTableAdapter.Fill(this.rBS_DatabaseDataSet.RBS_Menu);

        }
    }
}
