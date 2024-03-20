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
    public partial class frmEditUser : Form
    {
        User editUser;
        public frmEditUser()
        {
            InitializeComponent();
        }
        public frmEditUser(string username)
        {
            InitializeComponent();
            editUser = new User(username);
            User.ViewProfile(editUser);
            txtBoxUsername.Text = editUser.Username;
            txtBoxPassword.Text = editUser.Password;
            txtBoxFullName.Text = editUser.FullName;
            txtBoxEmail.Text = editUser.Email;
            txtBoxPhone.Text = editUser.Phone;
            switch (editUser.Role)
            {
                case "member": cBoxRole.SelectedIndex = 0; break;
                case "coach": cBoxRole.SelectedIndex= 1; break;
                case "manager": cBoxRole.SelectedIndex = 2; break;
                case "admin": cBoxRole.SelectedIndex= 3; break;
            }
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = System.Text.RegularExpressions.Regex.Replace(textboxSender.Text, "[^0-9a-zA-Z ]", "");
            textboxSender.SelectionStart = cursorPosition;
            if (txtBoxUsername.Text != editUser.Username)
            {
                txtBoxUsername.BackColor = SystemColors.Info;
            }
            else
            {
                txtBoxUsername.BackColor = SystemColors.Window;
            }
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxPassword.Text != editUser.Password)
            {
                txtBoxPassword.BackColor = SystemColors.Info;
            }
            else
            {
                txtBoxPassword.BackColor= SystemColors.Window;
            }
        }

        private void txtBoxFullName_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxFullName.Text != editUser.FullName)
            {
                txtBoxFullName.BackColor = SystemColors.Info;
            }
            else
            {
                txtBoxFullName.BackColor= SystemColors.Window;
            }
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxEmail.Text != editUser.Email)
            {
                txtBoxEmail.BackColor = SystemColors.Info;
            }
            else
            {
                txtBoxEmail.BackColor= SystemColors.Window;
            }
        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxPhone.Text != editUser.Phone)
            {
                txtBoxPhone.BackColor = SystemColors.Info;
            }
            else
            {
                txtBoxPhone.BackColor= SystemColors.Window;
            }
        }

        private void cBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBoxRole.SelectedIndex.ToString().ToLower() != editUser.Role) { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtBoxUsername.Text == string.Empty)
            {
                MessageBox.Show("Invalid input for username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (cBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Role not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string newUsername = editUser.Username,
                    newPassword = editUser.Password,
                    newFullName = editUser.FullName,
                    newEmail = editUser.Email,
                    newPhone = editUser.Phone,
                    newRole = editUser.Role;
            
            if (txtBoxUsername.Text != editUser.Username)
            {
                newUsername = txtBoxUsername.Text;
            }
            if (txtBoxPassword.Text != editUser.Password && txtBoxPassword.Text != string.Empty)
            {
                newPassword = txtBoxPassword.Text;
            }
            if (txtBoxFullName.Text != editUser.FullName)
            {
                newFullName = txtBoxFullName.Text;
            }
            if (txtBoxEmail.Text != editUser.Email)
            {
                newEmail = txtBoxEmail.Text;
            }
            if (txtBoxPhone.Text != editUser.Phone)
            {
                newPhone = txtBoxPhone.Text;
            }
            if (cBoxRole.SelectedItem.ToString().ToLower() != editUser.Role)
            {
                newRole = cBoxRole.SelectedItem.ToString().ToLower();
                var warning = MessageBox.Show("User role will be changed from " + editUser.Role + " to " + newRole + ". Any previous user role data will be discarded. This action cannot be undone. Are you sure?", "Attention Required", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(warning == DialogResult.Cancel)
                {
                    return;
                }

            }
            if (newRole == "admin")
            {

            }
            string status = User.UpdateProfile(editUser, newUsername, newPassword, newFullName, newEmail, newPhone);
            if (status == null)
            {
                MessageBox.Show("Profile updated successfully", "Update Profile Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show(status, "Update Profile Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
