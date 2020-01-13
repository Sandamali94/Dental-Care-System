using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DentalCare
{
    public partial class Login : Form
    {
        private SqlConnection conn;

        public Login()
        {
            InitializeComponent();
            txtpass.PasswordChar = '*';
       
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.getConnection();

            string username = txtuname.Text.Trim();
            string password = txtpass.Text.Trim();
            string acctype = cmbacctype.Text;

            if (this.txtuname.Text == "" || this.txtpass.Text == "")
            {
                MessageBox.Show("Please Enter User Name or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            try
            {

                if (cmbacctype.SelectedItem == "Admin")
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM UserAcc WHERE Username='" + username + "' AND Password='" + password + "'", conn);

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        MessageBox.Show("Login Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        AdminPanel ap = new AdminPanel();
                        ap.Show();
                    }
                    else
                    {

                        MessageBox.Show("Invalid username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (cmbacctype.SelectedItem == "Manager")
                {

                    SqlCommand cmd = new SqlCommand("SELECT Username, Password FROM UserAcc WHERE Username='" + username + "' AND Password='" + password + "'", conn);

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        MessageBox.Show("Login Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        ManagerMenu mm = new ManagerMenu();
                        mm.Show();
                    }
                    else
                    {

                        MessageBox.Show("Invalid username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else if (cmbacctype.SelectedItem == "Front Officer")
                {


                    SqlCommand cmd = new SqlCommand("SELECT Username, Password FROM UserAcc WHERE Username='" + username + "' AND Password='" + password + "'", conn);

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        MessageBox.Show("Login Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        ClearkMenu cm = new ClearkMenu();
                        cm.Show();
                    }
                    else
                    {

                        MessageBox.Show("Invalid username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (cmbacctype.SelectedItem == "Doctor")
                {


                    SqlCommand cmd = new SqlCommand("SELECT Username, Password FROM UserAcc WHERE Username='" + username + "' AND Password='" + password + "'", conn);

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        MessageBox.Show("Login Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        DoctorMenu dm = new DoctorMenu();
                        dm.Show();
                    }
                    else
                    {

                        MessageBox.Show("Invalid username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Login Failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtuname.Text = "";
                    this.txtpass.Text = "";
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }  
}

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtuname.Text = "";
            txtpass.Text = "";
            cmbacctype.Text = "";

        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
