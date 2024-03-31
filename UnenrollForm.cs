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
    public partial class UnenrollForm : Form
    {
        Member currentMember;
        public UnenrollForm()
        {
            InitializeComponent();
        }
        public UnenrollForm(Member member)
        {
            InitializeComponent();
            this.currentMember = member;
        }

        private void Unenroll_Load(object sender, EventArgs e)
        {

        }

        private void btnUnenroll_Click(object sender, EventArgs e)
        {
            currentMember.UnenrollFromTraining(currentMember.Username,(string) comLevelSelection.SelectedItem);
            MessageBox.Show("Unenrolled Successfully");
        }
    }
}
