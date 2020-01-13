using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    class Pay
    {
        private string dconic;
        private string patinic;
        private int treatcode;
        private string treatdate;
        private float treatfee;
        private float consultfee;
        private string treatdeta;

        
        public Pay(string dconic, string patinic, int treatcode, string treatdate, float treatfee, float consultfee, string treatdeta)
        {

            this.dconic = dconic;
            this.patinic = patinic;
            this.treatcode = treatcode;
            this.treatdate = treatdate;
            this.treatfee = treatfee;
            this.consultfee = consultfee;
            this.treatdeta = treatdeta;


        }
        public string getdconic()
        {
            return this.dconic;
        }
        public string getpatinic()
        {
            return this.patinic;
        }
        public int gettreatcode()
        {
            return this.treatcode;
        }
        public string gettreatdate()
        {
            return this.treatdate;
        }
        public float gettreatfee()
        {
            return this.treatfee;
        }
        public float getconsultfee()
        {
            return this.consultfee;
        }
        public string gettreatdeta()
        {
            return this.treatdeta;
        }
        
        
        
    }
}
