using System;
using System.Windows.Forms;

namespace RBS_Restaurant_Billing_System.Layer_UI.AdminUI.TransactionsUI
{
    public partial class Form_Transactions : Form
    {
        public Form_Transactions()
        {
            InitializeComponent();
        }

        private void rBS_TransactionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rBS_TransactionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rBS_DatabaseDataSet);

        }

        private void Form_Transactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rBS_DatabaseDataSet.RBS_Transactions' table. You can move, or remove it, as needed.
            this.rBS_TransactionsTableAdapter.Fill(this.rBS_DatabaseDataSet.RBS_Transactions);

        }
    }
}
