using RBS_Restaurant_Billing_System.Layer_Logic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBS_Restaurant_Billing_System.Layer_Data
{
    class Data_Menu
    {
        static string dataConString = ConfigurationManager.ConnectionStrings["RBS_Restaurant_Billing_System.Properties.Settings.RBS_DatabaseConnectionString"].ConnectionString;

        #region SELECT _Data_ FROM RBS_MENU
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(dataConString);
            DataTable table = new DataTable();
            string sql = "SELECT * FROM RBS_MENU";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(table);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                conn.Close();
            }
            return table;
        }

        #endregion
    }
}
