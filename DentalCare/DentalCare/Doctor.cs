using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    class Doctor
    {
        private string nicno;
        private string doctorfname;
        private string doctorlname;
        private string addressl1;
        private string street;
        private string city;
        private string dob;
        private int age;
        private int yearOfExper;
        private string specialization;
        private string manaid;

        public Doctor(string nicno, string fname, string lname, string addressl1, string street, string city, string dob, int age, int yearOfExper, string specialization, string manaid)
        {
            this.nicno = nicno;
            this.doctorfname = fname;
            this.doctorlname = lname;
            this.addressl1 = addressl1;
            this.street = street;
            this.city = city;
            this.dob = dob;
            this.age = age;
            this.yearOfExper = yearOfExper;
            this.specialization = specialization;
            this.manaid = manaid;

        }

        public string getnicno()
        {
            return this.nicno;
        }

        public string getfname()
        {
            return this.doctorfname;
        }

        public string getlname()
        {
            return this.doctorlname;
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

        public string getdob()
        {
            return this.dob;
        }
        public int getage()
        {
            return this.age;
        }

        public int getyearOfExper()
        {
            return this.yearOfExper;
        }

        public string getspecialization()
        {
            return this.specialization;
        }

        public string getmanaid()
        {
            return this.manaid;
        }
    }
}
