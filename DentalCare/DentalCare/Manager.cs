using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    class Manager
    {
        //Variable declaration
        private string empid;
        private string managerfname;
        private string managerlname;
        private string addressl1;
        private string street;
        private string city;
        private string gender;
        private string dob;
        private int age;

        //Parameterized Constructor
        public Manager(string empid, string fname, string lname, string addressl1, string street, string city, 
            string gender, string dob, int age)
        {
            this.empid = empid;
            this.managerfname = fname;
            this.managerlname = lname;
            this.addressl1 = addressl1;
            this.street = street;
            this.city = city;
            this.gender = gender;
            this.dob = dob;
            this.age = age;

        }

        //Getters
        public string getempid()
        {
            return this.empid;
        }

        public string getfname()
        {
            return this.managerfname;
        }

        public string getlname()
        {
            return this.managerlname;
        }

        public string getaddressl1()
        {
            return this.addressl1;
        }
        public string getstreet()
        {
            return this.street;
        }

        public string getcity()
        {
            return this.city;
        }

        public string getgender()
        {
            return this.gender;
        }

        public string getdob()
        {
            return this.dob;
        }
        public int getage()
        {
            return this.age;
        }

    }
}
