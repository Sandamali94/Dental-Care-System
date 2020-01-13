using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalCare
{
    class CreateUsersDBOpe
    {
        SqlConnection conn = null;

        public CreateUsersDBOpe()
        {
            conn = DBConnection.getConnection();
        }
        public void RegUser(CreateUsers createUsers)
        {
            try
            {
                string username = createUsers.getusername();
                string password = createUsers.getpassword();
                string accoutype = createUsers.getacctype();

                
                conn.Open();

                SqlCommand cmd = new SqlCommand("Insert into UserAcc values ('" + username + "', '" + password + "', '"+accoutype+"')", conn);
                cmd.ExecuteNonQuery();
                
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

}
