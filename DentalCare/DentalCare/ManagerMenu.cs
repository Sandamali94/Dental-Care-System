﻿using System;
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
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }

        

        private void btnIncRep_Click(object sender, EventArgs e)
        {
            IncomeReport ir = new IncomeReport();
            ir.Show();
        }

        private void btnExpeDoc_Click(object sender, EventArgs e)
        {
            ListOfExperiencedDoctors ed = new ListOfExperiencedDoctors();
            ed.Show();
        }

        private void btnDocReg_Click(object sender, EventArgs e)
        {
            DoctorRegistration dr = new DoctorRegistration();
            dr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
