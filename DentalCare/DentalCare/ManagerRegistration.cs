using System;
using System.Collections;
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
    public partial class ManagerRegistration : Form
    {
        public ManagerRegistration()
        {
            InitializeComponent();
        }

        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
             
            string empid = txtemid.Text.Trim();
            string fname = txtmanfname.Text.Trim();
            string lname = txtmanlname.Text.Trim();
            string addressl1 = txtaddli1.Text.Trim();
            string street = txtstreet.Text.Trim();
            string city = txtcity.Text.Trim();
            string gender;
            if (this.rdbmale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            string dob = dtpdate.Text;
            int age = int.Parse(txtage.Text.Trim());

            Manager manager = new Manager(empid, fname, lname, addressl1, street, city, gender, dob, age);

            ManagerDBOper mdbo = new ManagerDBOper();

            ArrayList list = new ArrayList();
            list.Add(txtcontactmob.Text.Trim());
            list.Add(txtcontacthome.Text.Trim());

            mdbo.RegManager(manager, list);

            MessageBox.Show("Successfully Registered the Manager", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtage_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ManagerRegistration_Load(object sender, EventArgs e)
        {
          

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //string empid = txtemid.Text.Trim();
            //string fname = txtmanfname.Text.Trim();
            //string lname = txtmanlname.Text.Trim();
            //string addressl1 = txtaddli1.Text.Trim();
            //string street = txtstreet.Text.Trim();
            //string city = txtcity.Text.Trim();
            //string gender;
            //if (this.rdbmale.Checked == true)
            //{
            //    gender = "Male";
            //}
            //else
            //{
            //    gender = "Female";
            //}
            //DateTime dob = dtpdate.Value;
            //int age = int.Parse(txtage.Text.Trim());

            //Manager manager = new Manager(empid, fname, lname, addressl1, street, city, gender, dob, age);

            //ManagerDBOper mdbo = new ManagerDBOper();

            //ArrayList list = new ArrayList();
            //list.Add(txtcontactmob.Text.Trim());
            //list.Add(txtcontacthome.Text.Trim());

            //mdbo.RegManager(manager, list);

            MessageBox.Show("Successfully Update the Manager", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //ManagerDBOper mdbo = new ManagerDBOper();

            //string managerid = txtemid.Text.Trim();

            //mdbo.deletemanager(managerid);

            MessageBox.Show("Manager Details Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtage_MouseEnter(object sender, EventArgs e)
        {
            DateTime from = dtpdate.Value;
            DateTime to = DateTime.Now;
            TimeSpan TSpan = to - from;
            double days = TSpan.TotalDays;
            txtage.Text = (days / 365).ToString("0");


        }
    }
}
