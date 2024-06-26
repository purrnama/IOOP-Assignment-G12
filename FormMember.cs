﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOPAssignment_G12
{
    public partial class FormMember: Form
    {
        private string username;

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
        private void btnSendSuggestion_Click(object sender, EventArgs e)
        {
            sendSuggestionForm sendSuggestionForm = new sendSuggestionForm(currentMember.Username);
            sendSuggestionForm.Show();
        }
        private void btnUnenroll_Click_1(object sender, EventArgs e)
        {
            UnenrollForm unenroll = new UnenrollForm(currentMember);
            unenroll.Show();
        }

        private void FormMember_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            updateProfileForm updateForm = new updateProfileForm();
            updateForm.ShowDialog();
        }

        private void btnTrainingSchedule_Click(object sender, EventArgs e)
        {
            if (currentMember != null)
            {
                ViewScheduleForm viewScheduleForm = new ViewScheduleForm(currentMember);
                viewScheduleForm.Show();
            }
            else
            {
                MessageBox.Show("No member information available.");
            }
        }

        private void btnPerformanceRecord_Click(object sender, EventArgs e)
        {
            ViewPerformanceForm performanceForm = new ViewPerformanceForm(currentMember);
            performanceForm.ShowDialog();
        }

        private void btnAllCompetition_Click(object sender, EventArgs e)
        {
            ViewCompetitionsForm competitionsForm = new ViewCompetitionsForm(currentMember);
            competitionsForm.ShowDialog();
        }
    }
}
