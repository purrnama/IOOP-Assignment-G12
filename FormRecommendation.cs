using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IOOPAssignment_G12
{
    public partial class RecommendationsForm : Form
    {
        private DataGridView dataGridViewRecommendations;
        private Button buttonRecommend;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private readonly string coachUsername;

        public RecommendationsForm(string coachUsername)
        {
            InitializeComponent();
            this.coachUsername = coachUsername;
            DisplayRecommendations();
        }

        private void DisplayRecommendations()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Members";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        // Enable auto-generation of columns
                        dataGridViewRecommendations.AutoGenerateColumns = true;
                        // Set the DataGridView to read-only
                        dataGridViewRecommendations.ReadOnly = true;
                        // Assign the DataTable to the DataSource property of dataGridViewRecommendations
                        dataGridViewRecommendations.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.dataGridViewRecommendations = new System.Windows.Forms.DataGridView();
            this.buttonRecommend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecommendations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRecommendations
            // 
            this.dataGridViewRecommendations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecommendations.Location = new System.Drawing.Point(12, 28);
            this.dataGridViewRecommendations.Name = "dataGridViewRecommendations";
            this.dataGridViewRecommendations.RowHeadersWidth = 51;
            this.dataGridViewRecommendations.Size = new System.Drawing.Size(551, 347);
            this.dataGridViewRecommendations.TabIndex = 0;
            // 
            // buttonRecommend
            // 
            this.buttonRecommend.Location = new System.Drawing.Point(615, 166);
            this.buttonRecommend.Name = "buttonRecommend";
            this.buttonRecommend.Size = new System.Drawing.Size(142, 49);
            this.buttonRecommend.TabIndex = 1;
            this.buttonRecommend.Text = "Recommend";
            this.buttonRecommend.UseVisualStyleBackColor = true;
            this.buttonRecommend.Click += new System.EventHandler(this.buttonRecommend_Click);
            // 
            // RecommendationsForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRecommend);
            this.Controls.Add(this.dataGridViewRecommendations);
            this.Name = "RecommendationsForm";
            this.Text = "Recommendations";
            this.Load += new System.EventHandler(this.RecommendationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecommendations)).EndInit();
            this.ResumeLayout(false);

        }

        private void RecommendationsForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonRecommend_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRecommendations.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewRecommendations.SelectedRows[0];
                    string memberUsername = selectedRow.Cells["username"].Value.ToString();

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        // Retrieve the coach's username based on their role
                        SqlCommand getCoachUsernameCmd = new SqlCommand("SELECT username FROM Users WHERE Role = 'Coach'", con);
                        string coachUsername = getCoachUsernameCmd.ExecuteScalar()?.ToString();

                        if (!string.IsNullOrEmpty(coachUsername))
                        {
                            // Coach username retrieved successfully, proceed with the recommendation insertion
                            SqlCommand insertCmd = new SqlCommand("INSERT INTO Recommendations (coachUsername, memberUsername) VALUES (@coachUsername, @memberUsername)", con);
                            insertCmd.Parameters.AddWithValue("@coachUsername", coachUsername);
                            insertCmd.Parameters.AddWithValue("@memberUsername", memberUsername);
                            insertCmd.ExecuteNonQuery();

                            MessageBox.Show("Member recommended to the manager.", "Recommend", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No coach found. Cannot proceed with recommendation.", "Recommend", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a member to recommend.", "Recommend", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




    }
}
