using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPAssignment_G12
{
    internal class Suggestion
    {
        private string _username;
        private string _subject;
        private string _message;
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

        public string Username { get => _username; set => _username = value; }
        public string Message { get => _message; set => _message = value; }
        public string Subject { get => _subject; set => _subject = value; }

        public Suggestion(string subject)
        {
            _subject = subject;
        }
        public Suggestion(string username, string message)
        {
            _username = username;
            _message = message;
        }

        public static ArrayList viewAll()
        {
            ArrayList sugs = new ArrayList();
            SqlCommand listFb = new SqlCommand("SELECT subject FROM suggestions", conn);
            conn.Open();
            SqlDataReader rd = listFb.ExecuteReader();
            while (rd.Read())
            {
                try
                {
                    sugs.Add(rd.GetString(0));
                }
                catch
                {
                    continue;
                }
            }
            conn.Close();
            return sugs;
        }

        public string getSuggestionBySubject()
        {
            string status = null;
            SqlCommand getMsg = new SqlCommand("SELECT username, message FROM suggestions WHERE subject=@s", conn);
            getMsg.Parameters.AddWithValue("@s", _subject);

            conn.Open();
            SqlDataReader rd = getMsg.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    try
                    {
                        _username = rd.GetString(0);
                    }
                    catch
                    {
                        _username = string.Empty;
                    }
                    try
                    {
                        _message = rd.GetString(1);
                    }
                    catch
                    {
                        _message = string.Empty;
                    }
                }
            } else
            {
                status = "No suggestion data found with this subject";
            }
            conn.Close();
            return status;
        }
    }
}
