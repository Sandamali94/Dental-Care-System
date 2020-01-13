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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnmanreg_Click(object sender, EventArgs e)
        {
            ManagerRegistration mr = new ManagerRegistration();
            mr.Show();
        }

        private void btnfrontoffice_Click(object sender, EventArgs e)
        {
            FrontOfficeRegistration fr = new FrontOfficeRegistration();
            fr.Show();
        }

        private void btnUseAcc_Click(object sender, EventArgs e)
        {
            CreateUserAccounts cua = new CreateUserAccounts();
            cua.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();

        }
    }
}
