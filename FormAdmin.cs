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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        public frmAdmin(string username)
        {
            InitializeComponent();
            lblUser.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddUser frmAddUser = new frmAddUser();
            frmAddUser.ShowDialog();
        }
    }
}
