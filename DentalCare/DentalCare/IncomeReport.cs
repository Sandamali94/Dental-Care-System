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
    public partial class IncomeReport : Form
    {
        public IncomeReport()
        {
            InitializeComponent();
        }

        private void IncomeReport_Load(object sender, EventArgs e)
        {
            Incomereportd report = new Incomereportd();
            IncomeDataSetTableAdapters.DataTable1TableAdapter ta = new DentalCare.IncomeDataSetTableAdapters.DataTable1TableAdapter();
            IncomeDataSet.DataTable1DataTable table = ta.GetData();
            report.SetDataSource(table.DefaultView);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();

        }
    }
}
