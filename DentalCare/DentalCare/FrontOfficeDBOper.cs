using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;

namespace DentalCare
{
    class FrontOfficeDBOper
    {
        SqlConnection conn = null;

        public FrontOfficeDBOper()
        {
            conn = DBConnection.getConnection();
        }
        public void RegFrontOffice(FrontOffice frontOffice, ArrayList contactno)
        {

            string empid = frontOffice.getempid();
            string frontOfficefname = frontOffice.getfname();
            string frontOfficelname = frontOffice.getlname();
            string addressl1 = frontOffice.getaddressl1();
            string street = frontOffice.getstreet();
            string city = frontOffice.getcity();
            string gender = frontOffice.getgender();
            string dob = frontOffice.getdob();
            int age = frontOffice.getage();


            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into FrontOffices values ('" + empid + "', '" + frontOfficefname + "','" + frontOfficelname + "','" + addressl1 + "', '" + street + "', '" + city + "', '" + gender + "', '" + dob + "', '" + age + "')", conn);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("Insert into EmployeeContacts values ('" + empid + "', '" + contactno[0] + "')", conn);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("Insert into EmployeeContacts values ('" + empid + "', '" + contactno[1] + "')", conn);           
            cmd2.ExecuteNonQuery();
            conn.Close();

        }
    }
}
