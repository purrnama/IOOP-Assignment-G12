using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOPAssignment_G12
{
    public partial class updateProfileForm : Form
    {
        public updateProfileForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = "yourUsername"; // Replace with the actual username
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;

            Member member = new Member(username);
            member.UpdateProfile(username, email, phone);

            MessageBox.Show("Profile updated successfully.");
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            // Assuming you have a way to get the current username
            string username = "yourUsername"; // Replace with the actual username
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;

            Member member = new Member(username);
            member.UpdateProfile(username, email, phone);

            MessageBox.Show("Profile updated successfully.");
        }
    }
}

