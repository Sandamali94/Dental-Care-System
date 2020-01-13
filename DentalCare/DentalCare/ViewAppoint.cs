using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DentalCare
{
    class ViewAppoint
    {
        //private DataSet ds;
        private string Docnic;
        private DateTime Appointdate;
        

        public ViewAppoint(string docnic, DateTime appointdate)
        {
            this.Docnic = docnic;
            this.Appointdate = appointdate;
            
            
        }
        public string getdocnic()
        {
            return this.Docnic;
        }
        public DateTime getappointdate()
        {
            return this.Appointdate;
        }
        //public DataSet getds()
        //{
        //    return this.ds;
        //}
    }
}
