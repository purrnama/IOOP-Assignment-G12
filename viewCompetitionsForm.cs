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
    public partial class ViewCompetitionsForm : Form
    {
        private Member currentMember;

        public ViewCompetitionsForm(Member member)
        {
            InitializeComponent();
            currentMember = member;
        }

        private void ViewCompetitionsForm_Load_1(object sender, EventArgs e)
        {

            listBoxCompetitions.Items.Clear();
            List<string> competitions = currentMember.ViewAllCompetitions();
            foreach (var competition in competitions)
            {
                listBoxCompetitions.Items.Add(competition);
            }
        }
    }
}
