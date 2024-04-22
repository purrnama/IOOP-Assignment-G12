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
    internal class Training
    {
        private string _coachUsername;
        private string _trainingLevel;
        private DateTime _date;
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

        public string CoachUsername { get => _coachUsername; set => _coachUsername = value; }
        public string TrainingLevel { get => _trainingLevel; set => _trainingLevel = value; }
        public DateTime Date { get => _date; set => _date = value; }

        public Training(string coachUsername, string trainingLevel, DateTime date)
        {
            _coachUsername = coachUsername;
            _trainingLevel = trainingLevel;
            _date = date;
        }

        public static ArrayList ViewAllByCoach(string coachUsername, string trainingLevel = null)
        {
            ArrayList trainings = new ArrayList();
            conn.Open();

            SqlCommand viewAll;
            if (trainingLevel != null)
            {
                viewAll = new SqlCommand("SELECT * FROM trainings WHERE coachUsername=@c AND trainingLevel=@t", conn);
                viewAll.Parameters.AddWithValue("@c", coachUsername);
                viewAll.Parameters.AddWithValue("@t", trainingLevel);
            }
            else
            {
                viewAll = new SqlCommand("SELECT coachUsername, trainingLevel, date FROM trainings WHERE coachUsername=@c", conn);
                viewAll.Parameters.AddWithValue("@c", coachUsername);

            }
            SqlDataReader rd = viewAll.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    try
                    {
                        Training t = new Training(rd.GetString(0), rd.GetString(1), rd.GetDateTime(2));
                        trainings.Add(t);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            conn.Close();
            return trainings;
        }
    }
}
