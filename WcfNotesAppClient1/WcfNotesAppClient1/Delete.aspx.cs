using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfNotesAppClient1
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            string id1 = Request.Form["id"];
            int id = Convert.ToInt32(id1);
            int res = sc.deleteNote(id);
            if (res == 1)
            {
                Label1.Visible = true;
                Label1.Text = "Note delete succesfully";
                Response.Redirect("Home.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Note cannot be deleted";
            }
        }
    }
}