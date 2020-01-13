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
    public partial class DailyAppoinmentList : Form
    {
        public DailyAppoinmentList()
        {
            InitializeComponent();
        }
            
        string docnic;
        string appointdate;

        
        private void btnView_Click(object sender, EventArgs e)
        {
            string docnic = txtnic.Text.Trim();
            string appointate = appoindate.Text;

            

            SqlConnection conn = DBConnection.getConnection();

            SqlDataAdapter adapt = new SqlDataAdapter("select * from Patients where Doctor_Nic = '" + docnic + "' AND AppoinmentDate = '" + appointate + "'", conn);
            
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void DailyAppoinmentList_Load(object sender, EventArgs e)
        {
             
        }
    }
}
