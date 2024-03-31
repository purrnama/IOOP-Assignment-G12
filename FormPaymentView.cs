using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IOOPAssignment_G12
{
    public partial class FormPaymentView : Form
    {
        private DataGridView dataGridViewMembers;
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\IOOP-Assignment-G12\DB.mdf;Integrated Security=True";

        public FormPaymentView()
        {
            InitializeComponent();
            DisplayMembers();
        }

        private void DisplayMembers()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // Select data from the "Members" table
                    string query = "SELECT * FROM Members";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        // Enable auto-generation of columns
                        dataGridViewMembers.AutoGenerateColumns = true;
                        // Set the DataGridView to read-only
                        dataGridViewMembers.ReadOnly = true;
                        // Assign the DataTable to the DataSource property of dataGridViewMembers
                        dataGridViewMembers.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Display a prompt indicating no changes are allowed
            MessageBox.Show("No changes allowed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InitializeComponent()
        {
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.AllowUserToAddRows = false;
            this.dataGridViewMembers.AllowUserToDeleteRows = false;
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Location = new System.Drawing.Point(66, 31);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.ReadOnly = true;
            this.dataGridViewMembers.RowHeadersWidth = 51;
            this.dataGridViewMembers.RowTemplate.Height = 24;
            this.dataGridViewMembers.Size = new System.Drawing.Size(510, 281);
            this.dataGridViewMembers.TabIndex = 0;
            // 
            // FormPaymentView
            // 
            this.ClientSize = new System.Drawing.Size(694, 367);
            this.Controls.Add(this.dataGridViewMembers);
            this.Name = "FormPaymentView";
            this.Text = "FormPaymentView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
