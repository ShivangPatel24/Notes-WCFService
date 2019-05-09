using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfNotesAppClient1
{
    public partial class View : System.Web.UI.Page
    {
        ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                string id1 = Request.Form["id"];
                int id = Convert.ToInt32(id1);
                ServiceReference1.Notes note;
                note = sc.getNote(id);
                Label1.Text = note.Title;
                Label2.Text = note.Details;

            }
            else
            {
              Response.Redirect("Home.aspx");
           }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           Response.Redirect("Home.aspx");
        }
    }
}