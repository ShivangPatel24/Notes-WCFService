using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfNotesAppClient1
{
    public partial class Update : System.Web.UI.Page
    {
        ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
        ServiceReference1.Notes note;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            if (!IsPostBack)
            {
                string id1 = Request.Form["id"];
                int id = Convert.ToInt32(id1);
                note = sc.getNote(id);
                TextBox1.Text = note.Title;
                TextBox2.Text = note.Details;
                HiddenField1.Value = id1;
            }
            else
            {
                int id = Convert.ToInt32(HiddenField1.Value.ToString());
                int res = sc.UpdateNote(TextBox1.Text.ToString(), TextBox2.Text.ToString(), id);
                if (res == 1)
                {
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "Update Failed";
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(HiddenField1.Value.ToString());
            int res = sc.UpdateNote(TextBox1.Text.ToString(), TextBox2.Text.ToString(), id);
            if (res == 1)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Update failed";

            }
        }
    }
}