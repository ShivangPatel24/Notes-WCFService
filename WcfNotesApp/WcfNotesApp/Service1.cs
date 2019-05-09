using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfNotesApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public int AddNote(string title, string details, string name)
        {
            int res;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shivang\Documents\NotesDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "insert into Notes(Title, Details, Name) values (@title,@details,@name)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@details", details);
            cmd.Parameters.AddWithValue("@name", name);



            con.Open();
            int tmp = cmd.ExecuteNonQuery();
            if (tmp > 0)
            {
                res = 1;
            }
            else
            {
                res = 0;
            }
            con.Close();
            return res;
        }

        public int deleteNote(int id)
        {
            int res;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shivang\Documents\NotesDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "DELETE FROM Notes WHERE Id=@id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);



            con.Open();
            int tmp = cmd.ExecuteNonQuery();
            if (tmp > 0)
            {
                res = 1;
            }
            else
            {
                res = 0;
            }
            con.Close();
            return res;
        }

        public Notes getNote(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shivang\Documents\NotesDB.mdf;Integrated Security=True;Connect Timeout=30");

            string query = "select * from Notes where Id=@id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            Notes n1 = new Notes();

            con.Open();
            try {
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    n1.Id = rd.GetInt32(0);
                    n1.Title = rd.GetString(1);
                    n1.Details = rd.GetString(2);
                    n1.Name = rd.GetString(3);
                }
                else
                {
                    n1 = null;
                }
                rd.Close();
                con.Close();
            }
            catch(Exception e)
            {
                n1 = null;
            }
            
            //Resp res = new Resp();
            //res.ok = 1;
            return n1;

        }

        public List<Notes> getNotes(string name)
        {
            List<Notes> notes = new List<Notes>();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shivang\Documents\NotesDB.mdf;Integrated Security=True;Connect Timeout=30");

            string query = "select * from Notes where Name=@name";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);

            con.Open();
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        Notes n1 = new Notes();
                        n1.Id = rd.GetInt32(0);
                        n1.Title = rd.GetString(1);
                        n1.Details = rd.GetString(2);
                        n1.Name = rd.GetString(3);

                        notes.Add(n1);
                    }
                }
                else
                {
                    notes = null;
                }
                rd.Close();
                con.Close();
            }
            catch(Exception e)
            {
                notes = null;
            }
            
            //Resp res = new Resp();
            //res.ok = 1;
            return notes;
        }

        public string Login(string email, string pass)
        {
            string res;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shivang\Documents\NotesDB.mdf;Integrated Security=True;Connect Timeout=30");

            string query = "select * from Users where Email=@email and Password=@pass";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", pass);

            con.Open();
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    res = rd.GetString(1);
                }
                else
                {
                    res = null;
                }
                rd.Close();
                con.Close();
            }
            catch(Exception e)
            {
                res = null;
            }
            
            //Resp res = new Resp();
            //res.ok = 1;
            return res;
        }

        public int Register(string email, string pass, string name)
        {
            int res;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shivang\Documents\NotesDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "insert into Users(Name, Password, Email) values (@uname,@pass,@email)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@uname", name);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@email", email);
           
            

            con.Open();
            try
            {
                int tmp = cmd.ExecuteNonQuery();
                if (tmp > 0)
                {
                    res = 1;
                }
                else
                {
                    res = 0;
                }
            }
            catch(Exception e)
            {
                res = 0;
            }
            
            con.Close();
            return res;

        }

        public int UpdateNote(string title,string details,int id)
        {
            int res;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shivang\Documents\NotesDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "UPDATE Notes SET Title=@title,Details=@details WHERE Id=@id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@details", details);
            cmd.Parameters.AddWithValue("@id", id);



            con.Open();
            int tmp = cmd.ExecuteNonQuery();
            if (tmp > 0)
            {
                res = 1;
            }
            else
            {
                res = 0;
            }
            con.Close();
            return res;
        }
    }
}
