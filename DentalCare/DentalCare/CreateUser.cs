using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    class CreateUsers
    {
        private string username;
        private string password;
        private string acctype;
   
        public CreateUsers(string username, string password, string acctype)
        {
            this.username = username;
            this.password = password;
            this.acctype = acctype;
            
        }

        public string getusername()
        {
            return this.username;
        }

        public string getpassword()
        {
            return this.password;
        }

        public string getacctype()
        {
            return this.acctype;
        }

    }
}
