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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User(txtBoxUsername.Text, txtBoxPassword.Text);
            string status = user.Login();
            if (status != null)
            {
                MessageBox.Show(status, "Login Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtBoxUsername.Text = string.Empty;
            txtBoxPassword.Text = string.Empty;
        }
    }
}
