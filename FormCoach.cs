using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace IOOPAssignment_G12
{
    public partial class FormCoach : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Source\\Repos\\IOOP-Assignment-G12\\DB.mdf;Integrated Security=True";
        private DataTable dataTable = new DataTable();
        private string loggedInUser;

        public FormCoach(string displayname)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            loggedInUser = displayname;
            coachUsernameTextBox.Text = loggedInUser; // Set the coachUsernameTextBox text to the logged-in user
            coachUsernameTextBox.Enabled = false;
            CheckUserRole();
            Display();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged; // Subscribe to the SelectionChanged event

        }
       


        private void CheckUserRole()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Role FROM Users WHERE username = @username", con);
                    cmd.Parameters.AddWithValue("@Username", loggedInUser);
                    var role = cmd.ExecuteScalar();
                    if (role != null && role.ToString().Equals("Coach", StringComparison.OrdinalIgnoreCase))
                    {
                        // User is a coach, allow access to coach forms
                        tabPage2.Enabled = true; 
                    }
                    else
                    {
                        // User is not a coach, deny access to coach forms
                        tabPage2.Enabled = false; 
                        MessageBox.Show("You are not authorized to access coach forms.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void Display()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT coachUsername, trainingLevel, [Date] FROM Trainings WHERE coachUsername = @CoachUsername"; // Modify SQL query
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    // Pass the logged-in user's username as a parameter
                    adapter.SelectCommand.Parameters.AddWithValue("@CoachUsername", loggedInUser);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve data from form controls
                string coachUsername = coachUsernameTextBox.Text;
                string trainingLevel = trainingLevelTextBox.Text;
                string date = dateTextBox.Text;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // Insert data into the table
                    SqlCommand cmd = new SqlCommand("INSERT INTO Trainings (coachUsername, trainingLevel, [Date]) VALUES (@coachUsername, @trainingLevel, @Date)", con);
                    cmd.Parameters.AddWithValue("@coachUsername", coachUsername);
                    cmd.Parameters.AddWithValue("@trainingLevel", trainingLevel);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.ExecuteNonQuery();
                }
                Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0) // Check if any rows are selected
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Retrieve data from the textboxes
                    string coachUsername = coachUsernameTextBox.Text;
                    string trainingLevel = trainingLevelTextBox.Text;
                    string date = dateTextBox.Text;

                    // Prompt the user to confirm the edit
                    DialogResult confirmResult = MessageBox.Show("Do you want to save the changes?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        // Update the database with the changes
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("UPDATE Trainings SET trainingLevel = @trainingLevel, [Date] = @Date WHERE coachUsername = @coachUsername AND [Date] = @OldDate", con);
                            cmd.Parameters.AddWithValue("@trainingLevel", trainingLevel);
                            cmd.Parameters.AddWithValue("@Date", date);
                            cmd.Parameters.AddWithValue("@coachUsername", coachUsername);
                            cmd.Parameters.AddWithValue("@OldDate", selectedRow.Cells["Date"].Value); // Use the old date to identify the record
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Record updated successfully.", "Edit Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Display();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to edit.", "Edit Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    coachUsernameTextBox.Text = selectedRow.Cells["coachUsername"].Value.ToString();
                    trainingLevelTextBox.Text = selectedRow.Cells["trainingLevel"].Value.ToString();
                    dateTextBox.Text = selectedRow.Cells["Date"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }





        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                        string coachUsername = selectedRow.Cells["coachUsername"].Value.ToString();
                        string trainingLevel = selectedRow.Cells["trainingLevel"].Value.ToString();
                        string date = selectedRow.Cells["Date"].Value.ToString();

                        DateTime dateToDelete;
                        if (!DateTime.TryParse(date, out dateToDelete))
                        {
                            MessageBox.Show("Invalid date format.", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM Trainings WHERE coachUsername = @coachUsername AND trainingLevel = @trainingLevel AND [Date] = @Date", con);
                            cmd.Parameters.AddWithValue("@coachUsername", coachUsername);
                            cmd.Parameters.AddWithValue("@trainingLevel", trainingLevel);
                            cmd.Parameters.AddWithValue("@Date", dateToDelete);
                            cmd.ExecuteNonQuery();
                        }

                        Display();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            FormPaymentView paymentViewForm = new FormPaymentView();

            // Show the form
            paymentViewForm.Show();
        }

        private void buttonRecommendation_Click(object sender, EventArgs e)
        {
            string coachUsername = "coachUsername"; 
            RecommendationsForm recommendationsForm = new RecommendationsForm(coachUsername);
            recommendationsForm.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            FormUpdate updateForm = new FormUpdate(loggedInUser);
            updateForm.ShowDialog();
        }

        private void FormCoach_Load(object sender, EventArgs e)
        {

        }
    }
}

   


