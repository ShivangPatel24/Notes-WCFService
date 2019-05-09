using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WcfNotesAppClient1
{
    public partial class Home : System.Web.UI.Page
    {
        ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
        ServiceReference1.Notes[] notes;
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = (string)Session["name"];
            if (name == null)
            {
                Response.Redirect("Login.aspx");
            }
            notes = sc.getNotes(name);
            Label1.Text = "Welcome," + name;
            Label1.Style["font-weight"] = "bold";
            
            if (notes != null)
            {
                int i=0;
                char a = 'a';
                char b = 'A';
                int t = 1000;
                int k = 100;
                foreach (ServiceReference1.Notes note in notes)
                {
                    //HtmlInputText input;
                    //HtmlTable tbl = new HtmlTable();
                    //HtmlTableRow row;
                    //HtmlTableCell cell;
                    string HtmlContent = "<table>";

                    //Here we have to update record based  for question  
                    //we can store id in name parameter for choice so we can further update choice for questions
                    HtmlContent += "<tr><form method='POST'>";
                    HtmlContent += "<td></td>";
                    HtmlContent += "<td></td></form></tr>";
                    HtmlContent += "<tr><form method='POST' action='/View.aspx'>" + "<td><input type='hidden' name='id' id='"+i+"' value='"+note.Id+"'/></td>";
                    HtmlContent += "<td><input type='text' name='title' id='"+t+"' value='" + note.Title + "' disabled/></td>";
                    HtmlContent += "<td><input type='Submit' value='View'/></td></form></tr>";
                    HtmlContent += "<tr><form method='POST' action='/Update.aspx'>" + "<td><input type='hidden' id='"+a+"' name='id' value='" + note.Id + "'/></td>";
                    HtmlContent += "<td><input type='Submit' value='Update'/></td></form></tr>";
                    HtmlContent += "<tr><form method='POST' action='/Delete.aspx'>" + "<td><input type='hidden' name='id' id='"+b+"' value='" + note.Id + "'/></td>";
                    HtmlContent += "<td><input type='Submit' value='Delete'/></td></form></tr>";

                    HtmlContent += "</table><br><br>";
                    i++;
                    a++;
                    b++;
                    t++;
                    string str = "literal" + k;
                    placeHolder.Controls.Add(new Literal() { ID = str, Text = HtmlContent });
                    k++;
                }
            }
            else
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["name"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}