using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalCare
{
    public partial class DoctorRegistration : Form
    {
        public DoctorRegistration()
        {
            InitializeComponent();
        }

       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string docnic = txtdocinic.Text.Trim();
            string docfname = txtdocfn.Text.Trim();
            string doclname = txtdocln.Text.Trim();
            string addline1 = txtaddli1.Text.Trim();
            string street = txtstre.Text.Trim();
            string city = txtcity.Text.Trim();
            string dob = datetpic.Text;
            int age = int.Parse(txtage.Text.Trim());      
            int experience = int.Parse(txtexp.Text.Trim());
            string speciali = cmbspecialization.Text;
            string manageid = cmbmanid.Text;


            Doctor doctor = new Doctor(docnic, docfname, doclname, addline1, street, city, dob, age, experience, speciali, manageid);

            DoctorDBOper ddbo = new DoctorDBOper();

           
            ArrayList list = new ArrayList();

            list.Add(txtcontmob.Text.Trim());
            list.Add(txtconhome.Text.Trim());


            ddbo.RegDoctor(doctor, list);
            MessageBox.Show("Successfully Registered the Doctor", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        

        private void DoctorRegistration_Load(object sender, EventArgs e)
        {
            LoadManId();
        }

        private void txtdocinic_Enter(object sender, EventArgs e)
        {
            //string docnic = txtdocinic.Text.Trim();

            //DoctorDBOper ddbo = new DoctorDBOper();
            //Doctor doctor = ddbo.searchdoctors(docnic);

            //txtdocfn.Text = doctor.getfname();
            //txtdocln.Text = doctor.getlname();
            //txtaddli1.Text = doctor.getaddressl1();
            //txtstre.Text = doctor.getstreet();
            //txtcity.Text = doctor.getcity();
            //datetpic.Text = doctor.getdob();
            //txtage.Text = doctor.getage().ToString();
            //txtexp.Text = doctor.getyearOfExper().ToString();
            //cmbspecialization.Text = doctor.getspecialization();
            //cmbmanid.Text = doctor.getmanaid();


        }

        private void txtage_MouseEnter(object sender, EventArgs e)
        {
            DateTime from = datetpic.Value;
            DateTime to = DateTime.Now;
            TimeSpan TSpan = to - from;
            double days = TSpan.TotalDays;
            txtage.Text = (days / 365).ToString("0");


        }
        public void LoadManId()
        {
            SqlConnection conn = DBConnection.getConnection();

            DataSet ds = new DataSet();
            string sql = "select * from Managers";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            cmbmanid.ValueMember = "Empid";
            cmbmanid.DataSource = ds.Tables[0];
            conn.Close();


        }
    }
}
