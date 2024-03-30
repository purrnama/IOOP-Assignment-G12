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
        Member currentMember;
        public FormMember()
        {
            InitializeComponent();
        }
        public FormMember(string username)
        {
            InitializeComponent();
            currentMember = new Member(username);
        }
        private void btnEnrollAndPay_Click(object sender, EventArgs e)
        {
            EnrollForm enrollForm = new EnrollForm(currentMember);
            enrollForm.Show();
        }
        private void unenrollButton_Click(object sender, EventArgs e)
        {
            UnenrollForm unenrollForm = new UnenrollForm();
            unenrollForm.Show();
        }

        private void viewScheduleButton_Click(object sender, EventArgs e)
        {
            ViewScheduleForm viewScheduleForm = new ViewScheduleForm();
            viewScheduleForm.Show();
        }

        private void viewPerformanceButton_Click(object sender, EventArgs e)
        {
            ViewPerformanceForm viewPerformanceForm = new ViewPerformanceForm();
            viewPerformanceForm.Show();
        }

        private void viewCompetitionsButton_Click(object sender, EventArgs e)
        {
            viewCompetitionsForm viewCompetitionsForm = new viewCompetitionsForm();
            viewCompetitionsForm.Show();
        }

        private void updateProfileButton_Click(object sender, EventArgs e)
        {
            updateProfileForm updateProfileForm = new updateProfileForm();
            updateProfileForm.Show();
        }

        private void btnSendSuggestion_Click(object sender, EventArgs e)
        {
            sendSuggestionForm sendSuggestionForm = new sendSuggestionForm(currentMember.Username);
            sendSuggestionForm.Show();
        }
    }
}
