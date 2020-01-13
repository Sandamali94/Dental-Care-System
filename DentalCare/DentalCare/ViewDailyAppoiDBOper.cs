using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalCare
{
    class ViewDailyAppoiDBOper
    {
        SqlConnection conn = null;

        public ViewDailyAppoiDBOper()

        {

            conn = DBConnection.getConnection();

        }
        //public void Appoinmentlist(ViewAppoint viewp)
        //{
        //    conn.Open();

        //    string docnic = viewp.getdocnic();
        //    DateTime appoindate = viewp.getappointdate();

        //    SqlDataAdapter adapt = new SqlDataAdapter("select * from Patients where Doctor_Nic = '" + docnic + "' AND AppoinmentDate = '" + appoindate.Date + "'", conn);
        //    //SqlDataAdapter adapt = new SqlDataAdapter("select * from Patients where Doctor_Nic = '804587152v ' AND AppoinmentDate = '2019-10-07'", conn);
        //    DataSet ds = new DataSet();
        //    //DataTable dt = new DataTable();
        //    adapt.Fill(ds);
        //    DailyAppoinmentList dal = new DailyAppoinmentList();
        //    dal.dataGridView1.DataSource = ds.Tables[0].DefaultView;
        //    //return dt;

        //    conn.Close();

        //}
    }
}
