using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace IOOPAssignment_G12
{
    public partial class FormUpdate : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Source\Repos\IOOP-Assignment-G12\DB.mdf;Integrated Security=True";

        // Define a global variable to store the logged-in user's username
        private string loggedInUsername;

        public FormUpdate(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
            SetUsername();
        }

        private void SetUsername()
        {
            try
            {
                // Display the logged-in username in the textbox and make it read-only
                textBoxUsername.Text = loggedInUsername;
                textBoxUsername.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
    {
        try
        {
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;

            DialogResult result = MessageBox.Show("Would you like to update your profile?", "Update Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Proceed with the update
                UpdateProfile(email, phone, loggedInUsername);
            }
            else
            {
                // Cancel the update
                MessageBox.Show("Update canceled.", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void UpdateProfile(string email, string phone, string username)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE users SET email = @email, phone = @phone WHERE username = @username", con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@username", username);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Profile updated successfully.", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update profile.", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void FormUpdate_Load(object sender, EventArgs e)
    {
        // Set the text of textBoxUsername to the logged-in coach's username

        // Make the textBoxUsername read-only
        textBoxUsername.ReadOnly = true;
    }
}
}

