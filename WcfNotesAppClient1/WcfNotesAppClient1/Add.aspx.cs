using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfNotesAppClient1
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = (string)Session["name"];
            string title = TextBox1.Text.ToString();
            string details = TextBox2.Text.ToString();
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            int res = sc.AddNote(title, details, name);
            if (res == 1)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Note not added";
            }
        }
    }
}