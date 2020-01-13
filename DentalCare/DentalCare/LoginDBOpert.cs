using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace DentalCare
{
    class LoginDBOpert: Log
    {
        SqlConnection conn = null;
        

        public LoginDBOpert()
        {
            conn = DBConnection.getConnection();
        }

        public void Login(Log login)
        {
            string uname = login.getUsername();
            string password = login.getPassword();
            string acctype = login.getAcctype();


        } 
                
        

    
}
}
