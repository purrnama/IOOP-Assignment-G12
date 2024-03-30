using System;
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
        private int _id;
        private string _username;
        private string _message;
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

        public int Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Message { get => _message; set => _message = value; }

        public Suggestion(int id)
        {
            _id = id;
        }
        public Suggestion(string username, string message)
        {
            _username = username;
            _message = message;
        }

        public string getSuggestionById()
        {
            string status = null;
            SqlCommand getMsg = new SqlCommand("SELECT username, message FROM suggestions WHERE id=@i", conn);
            getMsg.Parameters.AddWithValue("@i", _id);

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
                status = "No suggestion data found with this id";
            }
            conn.Close();
            return status;
        }
    }
}
