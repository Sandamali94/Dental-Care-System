 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace DentalCare
{
    class DoctorDBOper
    {
        SqlConnection conn = null;

        public DoctorDBOper()
        {
            conn = DBConnection.getConnection();
        }
        public void RegDoctor(Doctor doctor, ArrayList contactno)
        {
            try
            {
                string nicno = doctor.getnicno();
                string doctorfname = doctor.getfname();
                string doctorlname = doctor.getlname();
                string addressl1 = doctor.getaddressl1();
                string street = doctor.getstreet();
                string city = doctor.getcity();
                string dob = doctor.getdob();
                int age = doctor.getage();
                int yearOfExper = doctor.getyearOfExper();
                string specialization = doctor.getspecialization();
                string manaid = doctor.getmanaid();


                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into Doctors values ('" + nicno + "', '" + doctorfname + "','" + doctorlname + "','" + addressl1 + "', '" + street + "', '" + city + "', '" + dob + "', '" + age + "', '" + yearOfExper + "', '" + specialization + "', '" + manaid + "')", conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand("Insert into DoctorContacts values ('" + nicno + "', '" + contactno[0] + "')", conn);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("Insert into DoctorContacts values ('" + nicno + "', '" + contactno[1] + "')", conn);
                cmd2.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void loartable(Doctor doctor)
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Doctors", conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

        }

        //public Doctor searchdoctors(string docnicno)
        //{
        //    conn.Open();

        //    SqlCommand cmd = new SqlCommand("select * from Doctors where NICNo = '" + docnicno + "'", conn);

        //    SqlDataReader rd = cmd.ExecuteReader();

        //    Doctor doctor = null;

        //    while (rd.Read())
        //    {


        //        string nicno = rd[0].ToString();
        //        string doctorfname = rd[1].ToString();
        //        string doctorlname = rd[2].ToString();
        //        string addressl1 = rd[3].ToString();
        //        string street = rd[4].ToString();
        //        string city = rd[5].ToString();
        //        string dob = rd[6].ToString();
        //        int age = int.Parse(rd[7].ToString());
        //        int yearOfExper = int.Parse(rd[8].ToString());
        //        string specialization = rd[9].ToString();
        //        string manaid = rd[10].ToString();


        //        doctor = new Doctor(nicno, doctorfname, doctorlname, addressl1, street, city, dob, age, yearOfExper, specialization, manaid);
        //    }
        //    conn.Close();
        //    return doctor;

        //}
    }
}
