 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;

namespace DentalCare
{
    class PatientDBOper
    {
        SqlConnection conn = null;

        public PatientDBOper()

        {

            conn = DBConnection.getConnection();

        }     

      
        public void resgisterPatient(Patient patient)
        {
            try
            {
                string nic = patient.getnic();
                string fname = patient.getpatientfname();
                string lname = patient.getpatientlname();
                string addline1 = patient.getaddli1();
                string street = patient.getstreet();
                string city = patient.getcity();
                string front_office_clerksId = patient.getfrontofficeId();
                string doctors_nic = patient.getdoctornic();
                bool is_paid = patient.getispaid();
                float reg_fee = patient.getregfee();
                string appoinment_date = patient.getappoinmentdate();

                //Open the Connection
                conn.Open();

                //Execute Query
                SqlCommand cmd1 = new SqlCommand("Insert into Patients values('" + nic + "','" + fname + "','" + lname + "','" + addline1 + "','" + street + "','" + city + "','" + front_office_clerksId + "','" + doctors_nic + "','" + is_paid + "','" + reg_fee + "','" + appoinment_date + "')", conn);
                cmd1.ExecuteNonQuery();

                

                //Close Connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //public Patient findPatient(string nic)
        //{
        //    conn.Open();

        //    SqlCommand cmd = new SqlCommand("select *  from Patients where NICNo ='" + nic + "'", conn);



        //    SqlDataReader rd = cmd.ExecuteReader();



        //    Patient patient = null;
        //    while (rd.Read())
        //    {
        //        string nic_no = rd[0].ToString();
        //        string fname = rd[1].ToString();
        //        string lname = rd[2].ToString();
        //        string addressl1 = rd[3].ToString();
        //        string street = rd[4].ToString();
        //        string city = rd[5].ToString();
        //        string front_office_clerksId = rd[6].ToString();
        //        string doctors_nic = rd[7].ToString();
        //        bool is_paid = bool.Parse(rd[8].ToString());
        //        float reg_fee = float.Parse(rd[9].ToString());
        //        string appointment_date = rd[10].ToString();


        //        patient = new Patient(nic_no, fname, lname, addressl1, street, city, front_office_clerksId, doctors_nic, is_paid, reg_fee, appointment_date);


        //    }
        //    conn.Close();
        //    return patient;
        //}


        public void updatpatient(Patient patient)
        {
            try
            {
                string nic = patient.getnic();
                string fname = patient.getpatientfname();
                string lname = patient.getpatientlname();
                string addline1 = patient.getaddli1();
                string street = patient.getstreet();
                string city = patient.getcity();
                string front_office_clerksId = patient.getfrontofficeId();
                string doctors_nic = patient.getdoctornic();
                bool is_paid = patient.getispaid();
                float reg_fee = patient.getregfee();
                string appoinment_date = patient.getappoinmentdate();

                //Open the Connection
                conn.Open();

                //Execute the Query
                SqlCommand cmd = new SqlCommand("UPDATE Patients SET NICNo='" + nic + "', PatientFname='" + fname + "', PatientLname='" + lname + "'," +
                    "Addline1='" + addline1 + "', Street='" + street + "', City='" + city + "', FrontOfficeId='" + front_office_clerksId + "', Doctor_Nic='" + doctors_nic + "', " +
                    "IsPaid='" + is_paid + "', Reg_fee='"+reg_fee+"', AppoinmentDate='"+appoinment_date+"' WHERE NICNo = '" + nic + "'", conn);

                cmd.ExecuteNonQuery();

                //Close Connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void deletepatient(string nic)
        {
            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("DELETE FROM Patients WHERE NICNo = '" + nic + "'", conn);

                cmd.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

    }
}
