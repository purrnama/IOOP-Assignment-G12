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
    public partial class FormDeleteCompetition : Form
    {
        private Competition competition;
        public FormDeleteCompetition()
        {
            InitializeComponent();
            competition = new Competition();
        }

        private void FrmDeleteCompetition_Load(object sender, EventArgs e)
        {
            competition.DisplayCompetitionsDataGridDelete(this);
        }

        private void dataGridViewDelete_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            competition.DataGridViewCellDoubleClick(dataGridViewDelete, e, txtBoxDelete, dateTimePickerDelete);
        }

        private void btnDeleteCompetition_Click(object sender, EventArgs e)
        {
            competition.DeleteTableRow(dataGridViewDelete, txtBoxDelete, dateTimePickerDelete);
            competition.DisplayCompetitionsDataGridDelete(this);
        }
    }
}
