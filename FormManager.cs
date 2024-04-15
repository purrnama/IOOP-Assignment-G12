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
    public partial class frmManager : Form
    {
        FormAddCompetition frmAddComp = new FormAddCompetition();
        FormEditCompetition frmEditComp = new FormEditCompetition();
        FormDeleteCompetition frmDeleteComp = new FormDeleteCompetition();
        FormAssignMembers frmAssignMembers = new FormAssignMembers();
        FormRecordResult frmRecordResult = new FormRecordResult();
        
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
            frmAddComp.Show();
        }

        private void btnEditCompetition_Click(object sender, EventArgs e)
        {
            frmEditComp.Show();
        }

        private void btnDeleteCompetition_Click(object sender, EventArgs e)
        {
            frmDeleteComp.Show();  
        }

        private void btnAssignMemberForm_Click(object sender, EventArgs e)
        {
            frmAssignMembers.Show();
        }

        private void btnRecordResult_Click(object sender, EventArgs e)
        {
            frmRecordResult.Show();
        }

    }
}
