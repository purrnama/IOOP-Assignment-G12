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
        }
    }
}
