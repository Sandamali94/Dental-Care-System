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
    public partial class CreateUserAccounts : Form
    {
        public CreateUserAccounts()
        {
            InitializeComponent();
            txtpass.PasswordChar = '*';
            txtpass.MaxLength = 8;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtuname.Text.Trim();
            string password = txtpass.Text.Trim();
            string acctype = comacctype.Text.Trim();
            

            CreateUsers createUsers = new CreateUsers(username, password, acctype);

            CreateUsersDBOpe cubo = new CreateUsersDBOpe();

            cubo.RegUser(createUsers);

            MessageBox.Show("Successfully Created a Account", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CreateUserAccounts_Load(object sender, EventArgs e)
        {

        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtuname.Text = "";
            txtpass.Text = "";
            comacctype.Text = "";
        }
    }
}
