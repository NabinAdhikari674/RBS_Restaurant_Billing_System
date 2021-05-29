using RBS_Restaurant_Billing_System.Layer_Logic;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RBS_Restaurant_Billing_System.Layer_Data
{
    class Data_Transactions
    {
        static string dataConString = ConfigurationManager.ConnectionStrings["RBS_Restaurant_Billing_System.Properties.Settings.RBS_DatabaseConnectionString"].ConnectionString;

        #region INSERT _DATA_ INTO RBS_TRANSACTIONS
        public bool Insert(Logic_Transactions transaction)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(dataConString);
            String sql = "INSERT INTO RBS_TRANSACTIONS (Cashier,Amount,Items) ";
            sql += "VALUES ((SELECT Username from RBS_USERS WHERE Username=@Username),@Amount,@Items)";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", transaction.Cashier);
                cmd.Parameters.AddWithValue("@Amount", transaction.Amount);
                cmd.Parameters.AddWithValue("@Items", transaction.Items);

                conn.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    success = true;

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        #endregion


    }
}
