using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Member
{
    private string connectionString;
    private string _username;
    private string _trainingLevel;
    private int _performance;
    private bool _paid;
    static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

    public string Username { get => _username; set => _username = value; }
    public string TrainingLevel { get => _trainingLevel; set => _trainingLevel = value; }
    public bool Paid { get => _paid; set => _paid = value; }
    public int Performance { get => _performance; set => _performance = value; }

    public Member()
    {
        connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
    }
    public Member(string username)
    {
        connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        _username = username;
    }
    public Member(string username, string trainingLevel, int performance, bool payment)
    {
        _username = username;
        _trainingLevel = trainingLevel;
        _performance = performance;
        _paid = payment;
    }
    public string AddMember()
    {
        string status = null;

        SqlCommand addCoach = new SqlCommand("INSERT INTO Members(username, trainingLevel, performance, payment) VALUES(@u, NULL, 0, 0)", conn);
        addCoach.Parameters.AddWithValue("@u", _username);

        conn.Open();
        int i = addCoach.ExecuteNonQuery();
        if (i == 0)
        {
            status = "Unable to add member " + _username;
        }
        conn.Close();
        return status;
    }

    public void EnrollInTraining(string trainingLevel)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "UPDATE Members SET trainingLevel=@tl WHERE username=@u";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@u", _username);
                command.Parameters.AddWithValue("@tl", trainingLevel);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public void UnenrollFromTraining(string username, string trainingLevel)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Members WHERE username = @username AND trainingLevel = @trainingLevel";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@trainingLevel", trainingLevel);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
    public int ViewPerformanceRecord(string username)
    {
        int performance = 0;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT performance FROM Members WHERE username = @username";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
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

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT competitionName, date FROM Competitions ";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
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
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Suggestions (username, subject, message) VALUES (@username, @subject, @message)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@subject", subject);
                command.Parameters.AddWithValue("@message", message);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public void UpdateProfile(string username, string email, string phone)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "UPDATE Users SET email = @email, phone = @phone WHERE username = @username";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@phone", phone);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
    public List<string> ViewTrainingSchedule()
    {
        List<string> schedule = new List<string>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT trainings.trainingLevel, trainings.date FROM Trainings JOIN Members on Trainings.trainingLevel = Members.trainingLevel where Members.username = @username";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", _username);

                connection.Open();
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
    public static ArrayList ViewAll()
    {
        ArrayList members = new ArrayList();
        SqlCommand listComp = new SqlCommand("SELECT username, trainingLevel, performance, payment FROM members", conn);
        conn.Open();
        SqlDataReader rd = listComp.ExecuteReader();
        if (rd.HasRows)
        {
            while (rd.Read())
            {
                try
                {
                    Member m = new Member(rd.GetString(0), rd.GetString(1), rd.GetInt32(2), rd.GetBoolean(3));
                    members.Add(m);
                }
                catch
                {
                    continue;
                }
            }
        }
        conn.Close();
        return members;
    }
}