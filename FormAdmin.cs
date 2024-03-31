using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOPAssignment_G12
{
    public partial class frmAdmin : Form
    {
        User currentUser;
        public frmAdmin()
        {
            InitializeComponent();
        }
        public frmAdmin(string username)
        {
            InitializeComponent();
            lblUser.Text = username;
            currentUser = new User(username);
        }

        private void refreshProfile()
        {
            User.ViewProfile(currentUser);
            txtBoxEditUsername.Text = currentUser.Username;
            txtBoxEditPassword.Text = string.Empty;
            txtBoxEditFullName.Text = currentUser.FullName;
            txtBoxEditEmail.Text = currentUser.Email;
            txtBoxEditPhone.Text = currentUser.Phone;
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            frmAddUser frmAddUser = new frmAddUser();
            frmAddUser.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 1)
            {
                lstBoxUsers.Items.Clear();
                ArrayList users = User.ViewAll();
                foreach (var user in users)
                {
                    lstBoxUsers.Items.Add(user);
                }
            }
            if (tabControl1.SelectedIndex == 2)
            {
                lstBoxCoaches.Items.Clear();
                ArrayList coaches = User.ViewAll("coach");
                foreach (var coach in coaches)
                {
                    lstBoxCoaches.Items.Add(coach);
                }
            }
            if (tabControl1.SelectedIndex == 3)
            {
                lstBoxCompetitions.Items.Clear();
                ArrayList comps = new ArrayList();
                //TODO: put this in Competition class
                //BEGIN
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
                SqlCommand listComp = new SqlCommand("SELECT competitionName FROM competitions", conn);
                conn.Open();
                SqlDataReader rd = listComp.ExecuteReader();
                while (rd.Read())
                {
                    try
                    {
                        comps.Add(rd.GetString(0));
                    }
                    catch
                    {
                        continue;
                    }
                }
                conn.Close();
                //END
                foreach(var comp in comps)
                {
                    lstBoxCompetitions.Items.Add(comp);
                }


            }
            if (tabControl1.SelectedIndex == 4)
            {
                lstBoxFeedback.Items.Clear();
                ArrayList feedbacks = Suggestion.viewAll();
                foreach(var feedback in feedbacks)
                {
                    lstBoxFeedback.Items.Add(feedback);
                }
            }
            if (tabControl1.SelectedIndex == 5)
            {
                refreshProfile();
            }
        }

        private void lstBoxUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            User selected = new User(lstBoxUsers.SelectedItem.ToString());
            User.ViewProfile(selected);

            txtBoxUsername.Text = selected.Username;
            txtboxFullName.Text = selected.FullName;
            txtBoxRole.Text = selected.Role;

            /* Prevent admin from manipulating other admins
            if(txtBoxRole.Text == "admin")
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            */
        }
        private void lstBoxFeedback_SelectedIndexChanged(object sender, EventArgs e)
        {
            Suggestion selected = new Suggestion(lstBoxFeedback.SelectedItem.ToString());
            string status = selected.getSuggestionBySubject();
            if(status == null)
            {
                lblFeedbackFrom.Text = selected.Username;
                lblFeedbackSubject.Text = selected.Subject;
                txtBoxFeedbackMessage.Text = selected.Message;
            }
        }

        private void btnUpdateProfileCancel_Click(object sender, EventArgs e)
        {
            refreshProfile();
        }

        private void txtBoxEditUsername_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = System.Text.RegularExpressions.Regex.Replace(textboxSender.Text, "[^0-9a-zA-Z ]", "");
            textboxSender.SelectionStart = cursorPosition;
            if (txtBoxEditUsername.Text != currentUser.Username)
            {
                txtBoxEditUsername.BackColor = SystemColors.Info;
            }
            else
            {
                txtBoxEditUsername.BackColor = SystemColors.Window;
            }
        }

        private void txtBoxEditPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxEditPassword.Text == currentUser.Password || txtBoxEditPassword.Text == String.Empty)
            {
                txtBoxEditPassword.BackColor = SystemColors.Window;
            }
            else
            {
                txtBoxEditPassword.BackColor = SystemColors.Info;
            }
        }

        private void txtBoxEditFullName_TextChanged(object sender, EventArgs e)
        {

            if (txtBoxEditFullName.Text != currentUser.FullName)
            {
                txtBoxEditFullName.BackColor = SystemColors.Info;
            }
            else
            {
                txtBoxEditFullName.BackColor = SystemColors.Window;
            }
        }

        private void txtBoxEditEmail_TextChanged(object sender, EventArgs e)
        {

            if (txtBoxEditEmail.Text != currentUser.Email)
            {
                txtBoxEditEmail.BackColor = SystemColors.Info;
            }
            else
            {
                txtBoxEditEmail.BackColor = SystemColors.Window;
            }
        }

        private void txtBoxEditPhone_TextChanged(object sender, EventArgs e)
        {

            if (txtBoxEditPhone.Text != currentUser.Phone)
            {
                txtBoxEditPhone.BackColor = SystemColors.Info;
            }
            else
            {
                txtBoxEditPhone.BackColor = SystemColors.Window;
            }
        }

        private void btnUpdateProfileSave_Click(object sender, EventArgs e)
        {
            if (txtBoxEditUsername.Text == string.Empty)
            {
                MessageBox.Show("Invalid input for username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBoxEditFullName.Text == string.Empty)
            {
                MessageBox.Show("Invalid input for full name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBoxEditEmail.Text != string.Empty)
            {
                try
                {
                    MailAddress email = new MailAddress(txtBoxEditEmail.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input for email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            string  newUsername = currentUser.Username,
                    newPassword = currentUser.Password,
                    newFullName = currentUser.FullName,
                    newEmail = currentUser.Email,
                    newPhone = currentUser.Phone;
            if (txtBoxEditUsername.Text != currentUser.Username)
            {
                newUsername = txtBoxEditUsername.Text;
            }
            if (txtBoxEditPassword.Text != currentUser.Password && txtBoxEditPassword.Text != string.Empty)
            {
                newPassword = txtBoxEditPassword.Text;
            }
            if (txtBoxEditFullName.Text != currentUser.FullName)
            {
                newFullName = txtBoxEditFullName.Text;
            }
            if (txtBoxEditEmail.Text != currentUser.Email)
            {
                newEmail = txtBoxEditEmail.Text;
            }
            if (txtBoxEditPhone.Text != currentUser.Phone)
            {
                newPhone = txtBoxEditPhone.Text;
            }
            string status = User.UpdateProfile(currentUser, newUsername, newPassword, newFullName, newEmail, newPhone);
            if(status == null)
            {
                MessageBox.Show("Profile updated successfully", "Update Profile Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentUser.Username = newUsername;
                currentUser.Password = newPassword;
                currentUser.FullName = newFullName;
                currentUser.Email = newEmail;
                currentUser.Phone = newPhone;
                refreshProfile();
            }
            else
            {
                MessageBox.Show(status, "Update Profile Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtBoxUsername.Text != string.Empty)
            {
                var warning = MessageBox.Show("User " + txtBoxUsername.Text + " will be deleted. All user role data for this user will be discarded. This action cannot be undone. Are you sure?", "Attention Required", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(warning == DialogResult.Cancel)
                {
                    return;
                }
                User selected = new User(lstBoxUsers.SelectedItem.ToString());
                User.ViewProfile(selected);
                string status = User.DeleteUser(selected);
                if (status == null)
                {
                    MessageBox.Show("Successfully deleted user " + selected.Username, "Delete User Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(status, "Delete User Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txtBoxUsername.Text != string.Empty)
            {
                frmEditUser frmEditUser = new frmEditUser(txtBoxUsername.Text);
                frmEditUser.ShowDialog();
            }
        }

        private void lstBoxCompetitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Competition selected = new Competition(lstBoxCompetitions.SelectedItem.ToString());
            string status = selected.getCompetitionByName();
            if(status == null)
            {
                lblCompetitionDate.Text = selected.Date.ToShortDateString();
                lblCompetitionStatus.Text = selected.getStatus();
            }
        }
    }
}
