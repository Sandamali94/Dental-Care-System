using System;
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
    public partial class RegistrationFeeInvoice : Form
    {
        public RegistrationFeeInvoice()
        {
            InitializeComponent();
        }

        private void RegistrationFeeInvoice_Load(object sender, EventArgs e)
        {
            RegistrationInvoice report = new RegistrationInvoice();
            PatientDataSetTableAdapters.PatientsTableAdapter ta = new DentalCare.PatientDataSetTableAdapters.PatientsTableAdapter();
            PatientDataSet.PatientsDataTable table = ta.GetData();
            report.SetDataSource(table.DefaultView);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            RegistrationInvoice cr = new RegistrationInvoice();
            SqlConnection conn = new SqlConnection();
            conn = DBConnection.getConnection();


            string patientnic = txtdocinic.Text;



            conn.Open();
            string sql = "select * from Patients where NICNo ='" + patientnic + "'";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "Patients");
            DataTable dt = ds.Tables["Patients"];

            cr.SetDataSource(ds.Tables["Patients"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
            conn.Close();
        }
    }
}
