using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace IOOPAssignment_G12
{
    internal class Competition
    {
        private string oldCompetitionName;
        //private object newDate;
        private int _id;
        private string _name;
        private DateTime _date;
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

        public string Name { get => _name; set => _name = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public int Id { get => _id; set => _id = value; }

        public Competition()
        {

        }

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
            SqlCommand getComp = new SqlCommand("SELECT id, date FROM competitions WHERE competitionName=@n", conn);
            getComp.Parameters.AddWithValue("@n", _name);

            conn.Open();
            SqlDataReader rd = getComp.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    try
                    {
                        _date = rd.GetDateTime(1);
                    }
                    catch
                    {
                        _date = new DateTime();
                    }
                    try
                    {
                        _id = rd.GetInt32(0);
                    }
                    catch
                    {
                        _id = new int();
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
            if (_date == null || _date == new DateTime())
            {
                return "Unknown";
            }
            if (_date.Date > today)
            {
                return "Upcoming";
            }
            if (_date < today)
            {
                return "Finished";
            }
            if (_date.Date == today)
            {
                return "Ongoing";
            }
            return "Unknown";
        }

        public ArrayList getParticipants()
        {
            ArrayList participants = new ArrayList();
            SqlCommand getPart = new SqlCommand("SELECT competitionId, participantUsername, results FROM participants WHERE competitionId=@i", conn);
            getPart.Parameters.AddWithValue("@i", _id);

            conn.Open();
            SqlDataReader rd = getPart.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    try
                    {
                        Participant p = new Participant(rd.GetInt32(0), rd.GetString(1), rd.GetString(2));
                        participants.Add(p);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            conn.Close();
            return participants;
        }
        /*
        public void AddCompetition(FormAddCompetition form)
        {
            //string text = FormAddCompetition.txtBoxCompName.Text;


            try
            {
                conn.Open();
                cmd = new SqlCommand("insert into Competitions (CompetitionName,Date) values('" +FormAddCompetition.txtBoxCompName.Text + "')");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
        public void AddCompetition(FormAddCompetition form)
        {
            // Ensure that form is not null
            if (form != null)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(form.txtBoxCompName.Text))
                    {
                        MessageBox.Show("Required Data is missing");
                        return; // Exit the method if the competition name is empty
                    }
                    // Open connection
                    conn.Open();

                    // Create a parameterized query to avoid SQL injection
                    string query = "INSERT INTO Competitions (CompetitionName, Date) VALUES (@CompetitionName, @Date)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // Create a data adapter to retrieve data from the Competitions table
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Competitions", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    form.dataGridView1.DataSource = dt;

                    // Set parameter values
                    cmd.Parameters.AddWithValue("@CompetitionName", form.txtBoxCompName.Text);
                    // Add other parameters as needed (e.g., Date)
                    cmd.Parameters.AddWithValue("@Date", form.dateTimePickerComp.Value); // Assuming Date is the current date/time

                    // Execute the query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Save Successful");
                    DisplayCompetitionsInDataGridView(form);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Close connection
                    conn.Close();
                }

            }
        }
        public void DisplayCompetitionsInDataGridView(FormAddCompetition form)
        {
            try
            {
                // Create a data adapter to retrieve data from the Competitions table
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Competitions", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the DataTable to the DataGridView
                form.dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplayCompetitionsDataGridUpdate(FormEditCompetition form)
        {
            try
            {
                // Create a data adapter to retrieve data from the Competitions table
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Competitions", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the DataTable to the DataGridView
                form.dataGridViewUpdate.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DataGridViewCellDoubleClick(DataGridView dataGridViewUpdate, DataGridViewCellEventArgs e, TextBox txtBoxUpdate, DateTimePicker dateTimePickerUpdate)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewUpdate.Rows[e.RowIndex];
                oldCompetitionName = selectedRow.Cells["CompetitionName"].Value.ToString();
                string competitionName = oldCompetitionName;
                DateTime date = Convert.ToDateTime(selectedRow.Cells["Date"].Value);

                // Populate TextBox and DateTimePicker controls with the selected values
                txtBoxUpdate.Text = competitionName;
                dateTimePickerUpdate.Value = date;
            }
        }

        public void UpdateTableRow(DataGridView dataGridView, TextBox textBox, DateTimePicker dateTimePicker)
        {
            // Get the modified competition name and date from TextBox and DateTimePicker
            string newCompetitionName = textBox.Text;
            DateTime newDate = dateTimePicker.Value;

            // Get the original competition name from the DataGridView
            string oldCompetitionName = dataGridView.CurrentRow.Cells["CompetitionName"].Value.ToString();

            // Update the database with the modified values
            // string connectionString = "Your_Connection_String";
            //using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Competitions SET CompetitionName = @NewCompetitionName, Date = @NewDate WHERE CompetitionName = @OldCompetitionName";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NewCompetitionName", newCompetitionName);
                    cmd.Parameters.AddWithValue("@NewDate", newDate);
                    cmd.Parameters.AddWithValue("@OldCompetitionName", oldCompetitionName);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Row updated successfully!");
                        //DisplayCompetitionsDataGridUpdate(form);
                    }
                    else
                    {
                        MessageBox.Show("No matching record found for update.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating row: " + ex.Message);
                }
            }
        }
        public void DisplayCompetitionsDataGridDelete(FormDeleteCompetition form)
        {
            try
            {
                // Create a data adapter to retrieve data from the Competitions table
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Competitions", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the DataTable to the DataGridView
                form.dataGridViewDelete.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteTableRow(DataGridView dataGridView, TextBox txtBoxDelete, DateTimePicker dateTimePickerDelete)
        {
            // Get the original competition name from the selected row in the DataGridView
            string competitionName = dataGridView.CurrentRow.Cells["CompetitionName"].Value.ToString();

            // Delete the row from the database
            //string connectionString = "Your_Connection_String";
            //using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM Competitions WHERE CompetitionName = @CompetitionName AND Date = @Date";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CompetitionName", competitionName);
                    cmd.Parameters.AddWithValue("@Date", dateTimePickerDelete.Value);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Row deleted successfully!");
                        // Optionally, you may refresh the DataGridView here if needed
                    }
                    else
                    {
                        MessageBox.Show("No matching record found for deletion.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting row: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
        public void PopulateListbox(ListBox listBox)
        {
            conn.Open();
            SqlCommand getMembers = new SqlCommand("SELECT username FROM members", conn);

            SqlDataReader rd = getMembers.ExecuteReader();
            while (rd.Read())
            {
                try
                {
                    listBox.Items.Add(rd.GetString(0));
                }
                catch
                {
                    continue;
                }
            }
            conn.Close();
        }
        public void DisplayCompetitionsDataGridAssign(FormAssignMembers form)
        {
            try
            {
                // Create a data adapter to retrieve data from the Competitions table
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Competitions", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the DataTable to the DataGridView
                form.dataGridViewCompTable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplayParticipantDataGridAssign(FormAssignMembers form)
        {
            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Participants", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the DataTable to the DataGridView
                form.dataGridViewParticipantTable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Method to handle DataGridView cell double click event
        public void DataGridViewCellClickAssign(DataGridView dataGridView, DataGridViewCellEventArgs e, Label label)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                string id = selectedRow.Cells["ID"].Value.ToString(); // Assuming "ID" is the column name
                label.Text = id; // Populate the label with the ID value
            }
        }
        public void FillParticipantTable(DataGridView dataGridView, int competitionId, string username)
        {


            // Update the database with the modified values
            // string connectionString = "Your_Connection_String";
            //using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Participants(competitionId, participantUsername) VALUES(@c, @p)", conn);
                    cmd.Parameters.AddWithValue("@c", competitionId);
                    cmd.Parameters.AddWithValue("@p", username);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Row updated successfully!");
                        //DisplayCompetitionsDataGridUpdate(form);
                    }
                    else
                    {
                        MessageBox.Show("No matching record found for update.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating row: " + ex.Message);
                }
                conn.Close();
            }

        }
        public void AddCompListBox(ListBox listBox)
        {
            conn.Open();
            SqlCommand getCompName = new SqlCommand("SELECT competitionName FROM Competitions", conn);

            SqlDataReader rd = getCompName.ExecuteReader();
            while (rd.Read())
            {
                try
                {
                    listBox.Items.Add(rd.GetString(0));
                }
                catch
                {
                    continue;
                }
            }
            conn.Close();
        }
        public void AddParticipantList(ListBox listBox)
        {
            conn.Open();
            SqlCommand getParticipants = new SqlCommand("SELECT participantUsername FROM Participants", conn);

            SqlDataReader rd = getParticipants.ExecuteReader();
            while (rd.Read())
            {
                try
                {
                    listBox.Items.Add(rd.GetString(0));
                }
                catch
                {
                    continue;
                }
            }
            conn.Close();
        }
        /*public void RecordResult(string result, string competitionName, string username)
        {
            try
            {
                //string resultText = txtBoxResult.Text;
                conn.Open();

                // Create SQL command to insert data into the table
                string query = "UPDATE participants SET results=@r WHERE competitionId=@c AND participantUsername=@p";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameter for the result value
                cmd.Parameters.AddWithValue("@r", result);
                cmd.Parameters.AddWithValue("@c", competitionName );
                cmd.Parameters.AddWithValue("@p", username);


                // Execute the command
                cmd.ExecuteNonQuery();

                MessageBox.Show("Result saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting result: " + ex.Message);
            };
        }*/
        public void UpdateParticipantResult(string competitionName, string participantUsername, string result)
        {
            try
            {
                conn.Open();

                // Create SQL command to update the results column in the participants table
                string query = "UPDATE Participants SET Result = @Result WHERE CompetitionName = @competitionName AND participantUsername = @ParticipantUsername";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters for competition name, participant username, and result
                cmd.Parameters.AddWithValue("@CompetitionName", competitionName);
                cmd.Parameters.AddWithValue("@ParticipantUsername", participantUsername);
                cmd.Parameters.AddWithValue("@Result", result);

                // Execute the command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if any rows were affected
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Result updated successfully!");
                }
                else
                {
                    MessageBox.Show("No matching record found for update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating result: " + ex.Message);
            }

        }
    }
}


        