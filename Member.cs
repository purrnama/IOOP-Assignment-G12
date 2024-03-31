using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Member
{
    private string _username;
    private string _trainingLevel;
    private bool _paid;
    static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString.ToString());

    public string Username { get => _username; set => _username = value; }
    public string TrainingLevel { get => _trainingLevel; set => _trainingLevel = value; }
    public bool Paid { get => _paid; set => _paid = value; }

    public Member()
    {
    }
    public Member(string username)
    {
        _username = username;
    }

    public void EnrollInTraining(string trainingLevel)
    {
        using (conn)
        {
            string query = "UPDATE Members SET trainingLevel=@tl WHERE username=@u";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@u", _username);
                command.Parameters.AddWithValue("@tl", trainingLevel);

                conn.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public void UnenrollFromTraining(string username, string trainingLevel)
    {
        using (conn)
        {
            string query = "UPDATE Members SET trainingLevel=NULL WHERE username=@username";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@username", username);
                conn.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public List<string> ViewTrainingSchedule()
    {
        List<string> schedule = new List<string>();

        using (conn)
        {
            string query = "SELECT Training.trainingLevel, Training.date FROM Trainings JOIN Members on Training.trainingLevel = Members.trainingLevel where Members.username = @username ";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@username", _username);

                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string trainingLevel = reader.GetString(0);
                        DateTime date = reader.GetDateTime(1);
                        schedule.Add(trainingLevel + " - " + date.ToShortDateString());
                    }
                }
            }
        }

        return schedule;
    }

    public int ViewPerformanceRecord(string username)
    {
        int performance = 0;

        using (conn)
        {
            string query = "SELECT performance FROM Members WHERE username = @username";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@username", username);

                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        performance = reader.GetInt32(0);
                    }
                }
            }
        }

        return performance;
    }

    public List<string> ViewAllCompetitions()
    {
        List<string> competitions = new List<string>();

        using (conn)
        {
            string query = "SELECT competitionName, date FROM Competitions ";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string competitionName = reader.GetString(0);
                        DateTime date = reader.GetDateTime(1);
                        competitions.Add(competitionName + " - " + date.ToShortDateString());
                    }
                }
            }
        }

        return competitions;
    }

    public void SendSuggestion(string username, string subject, string message)
    {
        using (conn)
        {
            string query = "INSERT INTO Suggestions (username, subject, message) VALUES (@username, @subject, @message)";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@subject", subject);
                command.Parameters.AddWithValue("@message", message);

                conn.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public void UpdateProfile(string username, string email, string phone)
    {
        using (conn)
        {
            string query = "UPDATE Users SET email = @email, phone = @phone WHERE username = @username";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@phone", phone);

                conn.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
