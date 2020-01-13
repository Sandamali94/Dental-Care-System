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
    public partial class InvoiceRegistration : Form
    {
        public InvoiceRegistration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtdocinic_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TreatmentInvoice ti = new TreatmentInvoice();
            SqlConnection conn = new SqlConnection();
            conn = DBConnection.getConnection();


            string patientnic = txtdocinic.Text;



            conn.Open();
            string sql = "select * from Treatments where PatientNICNo ='" + patientnic + "'";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "Treatments");
            DataTable dt = ds.Tables["Treatments"];

            ti.SetDataSource(ds.Tables["Treatments"]);
            crystalReportViewer1.ReportSource = ti;
            crystalReportViewer1.Refresh();
            conn.Close();

        }

        private void InvoiceRegistration_Load(object sender, EventArgs e)
        {

            TreatmentInvoice report = new TreatmentInvoice();
            TreatmentDataSetTableAdapters.DataTable1TableAdapter ta = new DentalCare.TreatmentDataSetTableAdapters.DataTable1TableAdapter();
            TreatmentDataSet.DataTable1DataTable table = ta.GetData();
            report.SetDataSource(table.DefaultView);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
