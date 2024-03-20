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
    public partial class FormMember: Form
    {
        public FormMember()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtUsername.Text;
            string pass = txtPassword.Text;

            if (id == "member" && pass == "12345")
            {
                this.Hide();

                FormMember f = new FormMember();
                f.Show();
            }
            else
            {
                MessageBox.Show("Password or Username is incorrect...");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
