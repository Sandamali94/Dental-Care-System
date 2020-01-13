using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    class Patient
    {

        private string nic;
        private string fname;
        private string lname;
        private string addline1;
        private string street;
        private string city;
        private string front_office_clerksId;
        private string doctors_nic;
        private bool is_paid;
        private float reg_fee;
        private string appoinment_date;


        public Patient(string nic, string fname, string lname, string addline1, string street, string city, string front_office_clerksId, string doctors_nic, bool is_paid, float reg_fee, string appoinment_date)
        {
            this.nic = nic;
            this.fname = fname;
            this.lname = lname;
            this.addline1 = addline1;
            this.street = street;
            this.city = city;
            this.front_office_clerksId = front_office_clerksId;
            this.doctors_nic = doctors_nic;
            this.is_paid = is_paid;
            this.reg_fee = reg_fee;
            this.appoinment_date = appoinment_date;

        }
        public string getnic()
        {
            return this.nic;
        }
        public string getpatientfname()
        {
            return this.fname;
        }
        public string getpatientlname()
        {
            return this.lname;
        }
        public string getaddli1()
        {
            return this.addline1;
        }
        public string getstreet()
        {
            return this.street;
        }
        public string getcity()
        {
            return this.city;
        }
        public string getfrontofficeId()
        {
            return this.front_office_clerksId;
        }
        public string getdoctornic()
        {
            return this.doctors_nic;
        }
        public float getregfee()
        {
            return this.reg_fee;
        }
        public bool getispaid()
        {
            return this.is_paid;
        }
        public string getappoinmentdate()
        {
            return this.appoinment_date;
        }
    }
}
