using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    class Log
    {
        private string Username;
        private string Password;
        private string acctype;

        public Log()
        {
            this.Username = null;
            this.Password = null;
            this.acctype = null;
        }

        public Log(string uname, string pass, string acctype)
        {
            this.Username = uname;
            this.Password = pass;
            this.acctype = acctype;
        }

        public string getUsername()
        {
            return this.Username;
        }

        public string getPassword()
        {
            return this.Password;
        }
        public string getAcctype()
        {
            return this.acctype;
        }

    }
}
