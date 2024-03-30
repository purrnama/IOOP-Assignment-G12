using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IOOPAssignment_G12
{
    public partial class FormCoach : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Source\\Repos\\IOOP-Assignment-G12\\DB.mdf;Integrated Security=True";
        private DataTable dataTable = new DataTable();

        public FormCoach()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            Display();
        }

        private void Display()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Trainings"; // Assuming you want to fetch all data from the Trainings table
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            
        }
    }

    class Trainings
    {
        private string Coach;
        private string Training;
        private string Date;


        public Trainings(string CoachUsername, string TrainingType, string Datee)
        {
            Coach = CoachUsername;
            Training = TrainingType;
            Date = Datee;

        }






    }
}

