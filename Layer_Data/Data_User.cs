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
    class Data_User
    {
        static string dataConString = ConfigurationManager.ConnectionStrings["RBS_Restaurant_Billing_System.Properties.Settings.Database_RBSConnectionString"].ConnectionString;

        #region SELECT _Data_ FROM RBS_USERS
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(dataConString);
            DataTable table = new DataTable();
            string sql = "SELECT * FROM RBS_USERS";

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

        #region INSERT _Data_ INTO USER
        public bool Insert(Logic_User user)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(dataConString);
            String sql = "INSERT INTO RBS_USERS (Username,Email,Password,Role,Phone,Address) ";
            sql += "VALUES (@Username,@Email,@Password,@Role,@Phone,@Address)";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@Phone", user.Phone);
                cmd.Parameters.AddWithValue("@Address", user.Address);

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

        #region UPDATE _DATA_ IN USER
        public bool Update(Logic_User user)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(dataConString);
            string sql = "UPDATE RBS_USERS SET Username=@Username,Email=@Email,Password=@Password,Role=@Role,Phone=@Phone,Address=@Address ";
            sql += "WHERE Id=@Id";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@Phone", user.Phone);
                cmd.Parameters.AddWithValue("@Address", user.Address);

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

        #region DELETE _DATA_ FROM USER
        public bool Delete(Logic_User user)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(dataConString);
            string sql = "DELETE FROM RBS_USERS ";
            sql += "WHERE Id=@Id";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", user.Id);

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
