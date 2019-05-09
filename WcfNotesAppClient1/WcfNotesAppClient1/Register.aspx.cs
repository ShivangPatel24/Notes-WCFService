using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfNotesAppClient1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text.ToString();
            string pass = TextBox2.Text.ToString();
            string email = TextBox4.Text.ToString();
            int res;
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            try
            {
                res = sc.Register(email, pass, name);
                if (res == 1)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Response.Redirect("Register.aspx");
                }
            }
            catch(Exception ex)
            {
                Response.Redirect("Register.aspx");
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}