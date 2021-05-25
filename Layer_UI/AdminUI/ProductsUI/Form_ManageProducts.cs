using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBS_Restaurant_Billing_System.Layer_UI.AdminUI.ProductsUI
{
    public partial class Form_ManageProducts : Form
    {
        public Form_ManageProducts()
        {
            InitializeComponent();
        }

        private void rBS_MenuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rBS_MenuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rBS_DatabaseDataSet);

        }

        private void Form_ManageProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rBS_DatabaseDataSet.RBS_Menu' table. You can move, or remove it, as needed.
            this.rBS_MenuTableAdapter.Fill(this.rBS_DatabaseDataSet.RBS_Menu);

        }
    }
}
