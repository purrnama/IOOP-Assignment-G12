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

            //users
            if (tabControl1.SelectedIndex == 1)
            {
                lstBoxUsers.Items.Clear();
                ArrayList users = User.ViewAll();
                foreach (var user in users)
                {
                    lstBoxUsers.Items.Add(user);
                }
            }
            //income
            if (tabControl1.SelectedIndex == 2)
            {
                decimal beginnerIncome = 0;
                decimal intermediateIncome = 0;
                decimal advancedIncome = 0;
                lstBoxCoaches.Items.Clear();
                ArrayList coaches = User.ViewAll("coach");
                foreach (var coach in coaches)
                {
                    lstBoxCoaches.Items.Add(coach);
                }
                ArrayList members = Member.ViewAll();
                foreach (Member member in members)
                {
                    if (member.Paid)
                    {
                        if(member.TrainingLevel == "beginner")
                        {
                            beginnerIncome += 20;
                        }
                        if (member.TrainingLevel == "intermediate")
                        {
                            intermediateIncome += 30;
                        }
                        if (member.TrainingLevel == "advanced")
                        {
                            advancedIncome += 50;
                        }
                    }
                }
                decimal totalIncome = beginnerIncome + intermediateIncome + advancedIncome;
                lblIncomeBeginner.Text = "RM" + beginnerIncome.ToString("0.00");
                lblIncomeIntermediate.Text = "RM" + intermediateIncome.ToString("0.00");
                lblIncomeAdvanced.Text = "RM" + advancedIncome.ToString("0.00");
                lblIncomeTotal.Text = "RM" + totalIncome.ToString("0.00");
            }
            //competition
            if (tabControl1.SelectedIndex == 3)
            {
                lstBoxCompetitions.Items.Clear();
                ArrayList comps = Competition.ViewAll();
                foreach(var comp in comps)
                {
                    lstBoxCompetitions.Items.Add(comp);
                }
                

            }
            //feedback
            if (tabControl1.SelectedIndex == 4)
            {
                lstBoxFeedback.Items.Clear();
                ArrayList feedbacks = Suggestion.viewAll();
                foreach(var feedback in feedbacks)
                {
                    lstBoxFeedback.Items.Add(feedback);
                }
            }
            //update profile
            if (tabControl1.SelectedIndex == 5)
            {
                refreshProfile();
            }
        }

        private void lstBoxUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstBoxUsers.SelectedItem == null)
            {
                return;
            }
            User selected = new User(lstBoxUsers.SelectedItem.ToString());
            User.ViewProfile(selected);

            txtBoxUsername.Text = selected.Username;
            txtboxFullName.Text = selected.FullName;
            txtBoxRole.Text = selected.Role;
        }
        private void lstBoxFeedback_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxUsers.SelectedItem == null)
            {
                return;
            }
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
            if (lstBoxUsers.SelectedItem == null)
            {
                return;
            }
            Competition selected = new Competition(lstBoxCompetitions.SelectedItem.ToString());
            string status = selected.getCompetitionByName();
            if(status == null)
            {
                lblCompetitionDate.Text = selected.Date.ToShortDateString();
                lblCompetitionStatus.Text = selected.getStatus();
            }
            ArrayList participants = selected.getParticipants();
            lblCompetitionParticipants.Text = participants.Count.ToString();
            lstBoxParticipantRankings.Items.Clear();
            foreach (Participant p in participants)
            {
                User pUser = new User(p.Username);
                User.ViewProfile(pUser);
                string item = pUser.FullName + (p.Results == null ? "" : " - " + p.Results);
                lstBoxParticipantRankings.Items.Add(item);
            }
        }

        private void lstBoxCoaches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxUsers.SelectedItem == null)
            {
                return;
            }
            User selected = new User(lstBoxCoaches.SelectedItem.ToString());
            User.ViewProfile(selected);
            Coach selectedCoach = new Coach(selected.Username);
            string status = selectedCoach.GetCoachByName();
            if(status == null)
            {
                lblIncomeCoachSalary.Text = "RM" + selectedCoach.Salary.ToString("0.00");
            }
            ArrayList trainings = Training.ViewAllByCoach(selectedCoach.Username);
            lblIncomeSessions.Text = trainings.Count.ToString();
        }
    }
}
