using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login_register
{
    public partial class Userreg : System.Web.UI.Page
    {
        concls clsobj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(reg_id) from login";
            string reg = clsobj.fn_scalar(sel);
            int Reg_id = 0;
            if(reg=="")
            {
                Reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(reg);
                Reg_id = newregid + 1;
            }

            string ins = "insert into user_reg values(" + Reg_id + ",'" + TextBox1.Text + "'," + TextBox2.Text + ")";
            int i = clsobj.fn_nonquery(ins);
            if(i==1)
            {
                string inslog = "insert into login values(" + Reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','user','active')";
                int j = clsobj.fn_nonquery(inslog);
                if(j==1)
                {
                    Label5.Text = "Inserted";
                }
            }
        }
    }
}