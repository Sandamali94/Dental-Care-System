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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void btnaubmit_Click(object sender, EventArgs e)
        {

            string dconic = cmbdocnic.Text;
            string patinic = cmbpatnic.Text;
            int treatcode = int.Parse(txttreatcode.Text.Trim());
            string treatdate = dtptreatdate.Text;
            float treatfee = float.Parse(txttreatfee.Text.Trim());
            float consultfee = float.Parse(txtconsulrfee.Text.Trim());
            string treatdeta = txttreatdetail.Text.Trim();
 
            Pay pay = new Pay(dconic, patinic, treatcode, treatdate, treatfee, consultfee, treatdeta);

            PaymentDBOpera pdbo = new PaymentDBOpera();            

            pdbo.resgistertreatment(pay);

            MessageBox.Show("Treatment Details Inserted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Payments_Load(object sender, EventArgs e)
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
            string sql = "select * from Patients";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            cmbpatnic.ValueMember = "NICNo";
            cmbpatnic.DataSource = ds.Tables[0];
            conn.Close();


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtconsulrfee_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            InvoiceRegistration ir = new InvoiceRegistration();
            ir.Show();
        }
    }
}
