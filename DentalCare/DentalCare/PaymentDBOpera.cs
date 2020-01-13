using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace DentalCare
{
    class PaymentDBOpera
    {
        SqlConnection conn = null;

        public PaymentDBOpera()

        {
            conn = DBConnection.getConnection();
        }


        public void resgistertreatment(Pay pay)
        {
            string dconic = pay.getdconic();
            string patinic = pay.getpatinic();
            string treatdate = pay.gettreatdate();
            float treatfee = pay.gettreatfee();
            float consultfee = pay.getconsultfee();
            int treatcode = pay.gettreatcode();        
            string treatdeta = pay.gettreatdeta();
           

            conn.Open();

            SqlCommand cmd1 = new SqlCommand("Insert into Treatments values ('" + dconic + "','" + patinic + "','" + treatdate + "','"+ treatfee + "','" + consultfee + "', '" + treatcode + "','" + treatdeta + "')", conn);

            cmd1.ExecuteNonQuery();


            conn.Close();
        }
    }
}
