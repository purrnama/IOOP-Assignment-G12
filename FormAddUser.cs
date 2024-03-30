using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOPAssignment_G12
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtBoxUsername.Text == string.Empty)
            {
                MessageBox.Show("Invalid input for username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBoxPassword.Text == string.Empty)
            {
                MessageBox.Show("Invalid input for password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBoxFullName.Text == string.Empty)
            {
                MessageBox.Show("Invalid input for full name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                MailAddress email = new MailAddress(txtBoxEmail.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input for email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Role not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            User newUser = new User(txtBoxUsername.Text, txtBoxPassword.Text, txtBoxFullName.Text, txtBoxEmail.Text, txtBoxPhone.Text);
            if (cBoxRole.SelectedItem.ToString() == "Admin")
            {
                string status = newUser.AddUser("admin");
                if(status == null)
                {

                    MessageBox.Show("Successfully added user" + txtBoxUsername.Text, "Add User Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(status, "Add User Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (cBoxRole.SelectedItem.ToString() == "Coach")
            {
                string status = newUser.AddUser("coach");
                if(status != null)
                {
                    MessageBox.Show(status, "Add User Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Coach newCoach = new Coach(txtBoxUsername.Text, 500);
                string coachStatus = newCoach.AddCoach();
                if (status == null)
                {

                    MessageBox.Show("Successfully added coach with base salary of RM500" + txtBoxUsername.Text, "Add Coach Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(status, "Add Coach Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (cBoxRole.SelectedItem.ToString() == "Manager")
            {
                string status = newUser.AddUser("manager");
            }
            if (cBoxRole.SelectedItem.ToString() == "Member")
            {
                string status = newUser.AddUser("member");
                //TODO: Insert row to member-specific table
            }
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = System.Text.RegularExpressions.Regex.Replace(textboxSender.Text, "[^0-9a-zA-Z ]", "");
            textboxSender.SelectionStart = cursorPosition;
        }

    }
}
