using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPAssignment_G12
{
    internal class Competition
    {
        private string _name;
        private DateTime _date;
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

        public string Name { get => _name; set => _name = value; }
        public DateTime Date { get => _date; set => _date = value; }

        public Competition(string name, DateTime date)
        {
            _name = name;
            _date = date;
        }
        public Competition(string name)
        {
            _name = name;
        }

        public string getCompetitionByName()
        {
            string status = null;
            SqlCommand getComp = new SqlCommand("SELECT date FROM competitions WHERE competitionName=@n", conn);
            getComp.Parameters.AddWithValue("@n", _name);

            conn.Open();
            SqlDataReader rd = getComp.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    try
                    {
                        _date = rd.GetDateTime(0);
                    }
                    catch
                    {
                        _date = new DateTime();
                    }
                }
            }
            else
            {
                status = "No competition data found with this subject";
            }
            conn.Close();
            return status;
        }

        public string getStatus()
        {
            DateTime today = DateTime.Today;
            if(_date == null || _date == new DateTime())
            {
                return "Unknown";
            }
            if(_date.Date > today)
            {
                return "Upcoming";
            }
            if(_date < today)
            {
                return "Finished";
            }
            if(_date.Date == today)
            {
                return "Ongoing";
            }
            return "Unknown";
        }
        
    }
}
