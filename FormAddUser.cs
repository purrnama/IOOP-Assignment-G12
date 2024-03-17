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
            if(cBoxRole.SelectedItem.ToString() == "Admin")
            {
                User newUser = new User(txtBoxUsername.Text, txtBoxPassword.Text, txtBoxFullName.Text, txtBoxEmail.Text, txtBoxPhone.Text);
                string status = newUser.AddUser("admin");
                MessageBox.Show(status, "Add User Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // TODO
            if (cBoxRole.SelectedItem.ToString() == "Coach")
            {
                MessageBox.Show("TODO: AddCoach method", "Add User Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (cBoxRole.SelectedItem.ToString() == "Manager")
            {
                MessageBox.Show("TODO: AddManager method", "Add User Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (cBoxRole.SelectedItem.ToString() == "Member")
            {
                MessageBox.Show("TODO: AddMember method", "Add User Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
