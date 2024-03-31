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
    internal class Coach
    {
        private string _username;
        private decimal _salary;
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

        public decimal Salary { get => _salary; set => _salary = value; }
        public string Username { get => _username; set => _username = value; }
        
        public Coach(string username, decimal salary)
        {
            _username = username;
            _salary = salary;
        }
        public Coach(string username)
        {
            _username = username;
        }

        public string AddCoach()
        {
            string status = null;

            SqlCommand addCoach = new SqlCommand("INSERT INTO Coaches(username, salary) VALUES(@u, @s)", conn);
            addCoach.Parameters.AddWithValue("@u", _username);
            addCoach.Parameters.AddWithValue("@s", _salary);

            conn.Open();
            int i = addCoach.ExecuteNonQuery();
            if (i == 0)
            {
                status = "Unable to add coach " + _username;
            }
            conn.Close();
            return status;
        }

        public string GetCoachByName()
        {
            string status = null;
            SqlCommand getCoach = new SqlCommand("SELECT salary FROM coaches WHERE username=@u", conn);
            getCoach.Parameters.AddWithValue("@u", _username);

            conn.Open();
            SqlDataReader rd = getCoach.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    try
                    {
                        _salary = rd.GetDecimal(0);
                    }
                    catch
                    {
                        _salary = 0;
                    }
                }
            }
            else
            {
                status = "No coach data found with this username";
            }
            conn.Close();
            return status;
        }
    }

}
