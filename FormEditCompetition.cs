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
    public partial class FormEditCompetition : Form
    {
        private Competition competition;
        public FormEditCompetition()
        {
            InitializeComponent();
            competition = new Competition();
            
        }

        private void FormEditCompetition_Load(object sender, EventArgs e)
        {
            competition.DisplayCompetitionsDataGridUpdate(this);
        }

        public void dataGridViewUpdate_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            competition.DataGridViewCellDoubleClick(dataGridViewUpdate, e, txtBoxUpdate, dateTimePickerUpdate);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            competition.UpdateTableRow(dataGridViewUpdate, txtBoxUpdate, dateTimePickerUpdate);
            competition.DisplayCompetitionsDataGridUpdate(this);
            // Get the updated competitionName and date from the TextBox and DateTimePicker
            //string competitionName = txtBoxUpdate.Text;
            //DateTime date = dateTimePickerUpdate.Value;
            //competition.UpdateTableRow(competitionName, date);
            // Create an instance of DatabaseHelper class

            // Call the UpdateTableRow method to update the table row
            //competition.UpdateTableRow(competitionName, date);
        }
    }
}
