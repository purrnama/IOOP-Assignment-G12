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
    public partial class FormAssignMembers : Form
    {
        private Competition competition;
        public FormAssignMembers()
        {
            InitializeComponent();
            competition = new Competition();
        }

        private void FormAssignMembers_Load(object sender, EventArgs e)
        {
            competition.PopulateListbox(listBoxAddMembers);
            competition.DisplayCompetitionsDataGridAssign(this);
            competition.DisplayParticipantDataGridAssign(this);
        }

        private void dataGridViewCompTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            competition.DataGridViewCellClickAssign(dataGridViewCompTable, e, lblCompID);
        }

        private void btnAssignMember_Click(object sender, EventArgs e)
        {
            competition.FillParticipantTable(dataGridViewParticipantTable, int.Parse(lblCompID.Text), listBoxAddMembers.SelectedItem.ToString());
            competition.DisplayParticipantDataGridAssign(this);
        }
    }
}
