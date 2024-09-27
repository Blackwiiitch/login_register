using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace login_register
{
    public class concls
    {
        SqlConnection con;
        SqlCommand cmd;
        public concls()
        {
            con = new SqlConnection(@"server=LAPTOP-V3357R30\SQLEXPRESS;database=Adm_reg2;Integrated security=true");
        }
        public int fn_nonquery(string sql)
        {
            cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string fn_scalar(string sqlquery)
        {
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
    }

}