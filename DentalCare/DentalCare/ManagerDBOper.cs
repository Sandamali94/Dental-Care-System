using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DentalCare
{
    class ManagerDBOper
    {
        SqlConnection conn = null;

        public ManagerDBOper()
        {
            conn = DBConnection.getConnection();
        }
        public void RegManager(Manager manager, ArrayList contactno)
        {
            try
            {
                string empid = manager.getempid();
                string fname = manager.getfname();
                string lname = manager.getlname();
                string addressl1 = manager.getaddressl1();
                string street = manager.getstreet();
                string city = manager.getcity();
                string gender = manager.getgender();
                string dob = manager.getdob();
                int age = manager.getage();

                //Open the Connection
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Managers values ('" + empid + "', '" + fname + "','" + lname + "','" + addressl1 + "'," +
                    "'" + street + "','" + city + "','" + gender + "', '" + dob + "', '" + age + "')", conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand("Insert into EmployeeContacts values ('" + empid + "', '" + contactno[0] + "')", conn);
                SqlCommand cmd2 = new SqlCommand("Insert into EmployeeContacts values ('" + empid + "', '" + contactno[1] + "')", conn);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                //Close the Connection
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //public Manager searchmanager(string managerID)
        //{
        //    conn.Open();

        //    SqlCommand cmd = new SqlCommand("Select * from Managers where Empid = '" + managerID + "'", conn);

        //    SqlDataReader rd = cmd.ExecuteReader();

        //    Manager manager = null;

        //    while (rd.Read())
        //    {
        //        string stuid = rd[0].ToString();
        //        string stuname = rd[1].ToString();
        //        int stuage = int.Parse(rd[2].ToString());
        //        float stugpa = float.Parse(rd[3].ToString());

        //        Manager = new Manager(empid, fname, lname, addressl1, street, city, gender, dob, age);
        //    }

        //    conn.Close();
        //    return manager;

        //}

        public void updatemanager(Manager manager)
        {
            try
            {
                string empid = manager.getempid();
                string fname = manager.getfname();
                string lname = manager.getlname();
                string addressl1 = manager.getaddressl1();
                string street = manager.getstreet();
                string city = manager.getcity();
                string gender = manager.getgender();
                string dob = manager.getdob();
                int age = manager.getage();

                //Open the Connection
                conn.Open();

                //Execute the Query
                SqlCommand cmd = new SqlCommand("UPDATE Managers SET Empid='" + empid + "', ManFname='" + fname + "', ManFname='" + lname + "'," +
                    "Addline1='" + addressl1 + "', Street='" + street + "', City='" + city + "', Gender='" + gender + "', DOB='" + dob + "', " +
                    "Age='" + age + "' WHERE Empid = '" + empid + "'", conn);

                cmd.ExecuteNonQuery();

                //Close Connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void deletemanager(string managerID)
        {
            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("DELETE FROM Managers WHERE Empid = '" + managerID + "'", conn);

                cmd.ExecuteNonQuery();

                conn.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
