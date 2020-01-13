using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace DentalCare
{
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nic = txtpatinic.Text.Trim();
            string fname = txtpatifn.Text.Trim();
            string lname = txtptiln.Text.Trim();
            string addline1 = txtaddli1.Text.Trim();
            string street = txtstre.Text.Trim();
            string city = txtcity.Text.Trim();
            string front_office_clerksId = cmbfronoffid.Text.Trim();
            string doctors_nic = cmbdocnic.Text;
            bool is_paid = checkispaid.Checked;
            float reg_fee = float.Parse(txtrefee.Text.Trim());
            string appoinment_date = datetpic.Text;


            Patient patient = new Patient(nic, fname, lname, addline1, street, city, front_office_clerksId, doctors_nic, is_paid, reg_fee, appoinment_date);

            PatientDBOper pdbo = new PatientDBOper();


            pdbo.resgisterPatient(patient);
            MessageBox.Show("Successfully Registered the Patient", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            RegistrationFeeInvoice ir = new RegistrationFeeInvoice();
            ir.Show();



        }

        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            LoadNICDOc();
            LoadFronOfId();
        }
        public void LoadNICDOc()
        {
            SqlConnection conn = DBConnection.getConnection();

            DataSet ds = new DataSet();
            string sql = "select * from Doctors";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            cmbdocnic.ValueMember = "NICNo";
            cmbdocnic.DataSource = ds.Tables[0];
            conn.Close();


        }
        public void LoadFronOfId()
        {
            SqlConnection conn = DBConnection.getConnection();

            DataSet ds = new DataSet();
            string sql = "select * from FrontOffices";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            cmbfronoffid.ValueMember = "Empid";
            cmbfronoffid.DataSource = ds.Tables[0];
            conn.Close();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            PatientDBOper mdbo = new PatientDBOper();

            string patnic = txtpatinic.Text.Trim();

            mdbo.deletepatient(patnic);

            MessageBox.Show("Patient Details Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //    private void txtpatinic_Enter(object sender, EventArgs e)
        //    {
        //        string nic_no = txtpatinic.Text.Trim();

        //        PatientDBOper sdbo = new PatientDBOper();

        //        Patient patient = sdbo.findPatient(nic_no);

        //        txtpatifn.Text = patient.getpatientfname();
        //        txtptiln.Text = patient.getpatientlname();
        //        txtaddli1.Text = patient.getaddli1();
        //        txtstre.Text = patient.getstreet();
        //        txtcity.Text = patient.getcity();
        //        cmbfronoffid.Text = patient.getfrontofficeId();
        //        cmbdocnic.Text = patient.getdoctornic();
        //        checkispaid.Checked = patient.getispaid();
        //        txtrefee.Text = patient.getregfee().ToString();
        //        datetpic.Text = patient.getappoinmentdate();
        //    }
        //}

    }
}
