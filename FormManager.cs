using System;
using System.Collections;
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
    public partial class frmManager : Form
    {
        
        public frmManager()
        {
            InitializeComponent();
        }
        public frmManager(string displayName)
        {
            InitializeComponent();
            
        }

        private void frmManager_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCompetition_Click(object sender, EventArgs e)
        {
            FormAddCompetition frmAddComp = new FormAddCompetition();
            frmAddComp.Show();
        }

        private void btnEditCompetition_Click(object sender, EventArgs e)
        {
            FormEditCompetition frmEditComp = new FormEditCompetition();
            frmEditComp.Show();
        }

        private void btnDeleteCompetition_Click(object sender, EventArgs e)
        {
            FormDeleteCompetition frmDeleteComp = new FormDeleteCompetition();
            frmDeleteComp.Show();  
        }

        private void btnAssignMemberForm_Click(object sender, EventArgs e)
        {

            FormAssignMembers frmAssignMembers = new FormAssignMembers();
            frmAssignMembers.Show();
        }

        private void btnRecordResult_Click(object sender, EventArgs e)
        {
            FormRecordResult frmRecordResult = new FormRecordResult();
            frmRecordResult.Show();
        }
        private void tabCtrlManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrlManager.SelectedIndex == 1)
            {
                lstBoxRecommendedStudent.Items.Clear();
                ArrayList recs = Recommendation.ViewAll();
                foreach (var rec in recs)
                {
                    lstBoxRecommendedStudent.Items.Add(rec);
                }
            }
        }
    }
}
