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
    public partial class PatientEnquiry : Form
    {
        public PatientEnquiry()
        {
            InitializeComponent();
        }

        private void PatientEnquiry_Load(object sender, EventArgs e)
        {
            

        }
        SqlConnection conn = DBConnection.getConnection();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            

            string patinic = txtpatinic.Text.Trim();
 
       
            SqlConnection conn = DBConnection.getConnection();

            SqlDataAdapter adapt = new SqlDataAdapter("select PatientNICNo, TreatmentDate, ConsultationFee, TreatmentDetails from Treatments where PatientNICNo = '" + patinic + "'", conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
