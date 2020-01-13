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
    public partial class ClearkMenu : Form
    {
        public ClearkMenu()
        {
            InitializeComponent();
        }

        private void btnPatiRegi_Click(object sender, EventArgs e)
        {
            PatientRegistration pr = new PatientRegistration();
            pr.Show();
        }

        private void btnAppoiHand_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPaymen_Click(object sender, EventArgs e)
        {
            Payments p = new Payments();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
