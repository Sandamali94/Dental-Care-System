using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DentalCare
{
    public partial class FrontOfficeRegistration : Form
    {
        public FrontOfficeRegistration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string empid = txtemid.Text.Trim();
            string frontOfficefname = txtfrontfname.Text.Trim();
            string frontOfficelname = txtfrontlname.Text.Trim();
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

            FrontOffice frontOffice = new FrontOffice(empid, frontOfficefname, frontOfficelname, addressl1, street, city, gender, dob, age);

            FrontOfficeDBOper fdbo = new FrontOfficeDBOper();

            ArrayList list = new ArrayList();
            list.Add(txtcontactmob.Text.Trim());
            list.Add(txtcontacthome.Text.Trim());

            fdbo.RegFrontOffice(frontOffice, list);

            MessageBox.Show("Successfully Registered the Front Officer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrontOfficeRegistration_Load(object sender, EventArgs e)
        {
            

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
