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
    public partial class EnrollForm : Form
    {
        Member currentMember;
        public EnrollForm()
        {
            InitializeComponent();
        }
        public EnrollForm(Member member)
        {
            InitializeComponent();
            currentMember = member;
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            currentMember.EnrollInTraining(comLevel.SelectedItem.ToString().ToLower());
            MessageBox.Show("Updated training level");
        }
    }
}
