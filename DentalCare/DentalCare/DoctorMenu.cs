using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalCare
{
    public partial class DoctorMenu : Form
    {
        public DoctorMenu()
        {
            InitializeComponent();
        }

        private void btnPatientEnq_Click(object sender, EventArgs e)
        {
            PatientEnquiry pe = new PatientEnquiry();
            pe.Show();
            
        }       

        private void btnVieDaiAppo_Click(object sender, EventArgs e)
        {
            DailyAppoinmentList da = new DailyAppoinmentList();
            da.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
