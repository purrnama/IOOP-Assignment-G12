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
    public partial class FormRecordResult : Form
    {
        private Competition competition;
        public FormRecordResult()
        {
            InitializeComponent();
            competition = new Competition();
        }

        private void FormRecordResult_Load(object sender, EventArgs e)
        {
            competition.AddCompListBox(lstBoxSelectComp);
            competition.AddParticipantList(lstBoxSelectParticipant);
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            //competition.RecordResult(txtBoxResult.Text,lstBoxSelectComp.ToString(),lstBoxSelectComp.ToString());
            competition.UpdateParticipantResult(lstBoxSelectComp.ToString(), lstBoxSelectComp.ToString(), txtBoxResult.Text);
        }
    }
}
