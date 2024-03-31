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
    public partial class ViewScheduleForm : Form
    {
        private Member _member;

        public ViewScheduleForm()
        {
            InitializeComponent();
        }
        public ViewScheduleForm(Member member)
        {
            _member = member;
            InitializeComponent();

        }
        private void ViewScheduleForm_Load(object sender, EventArgs e)
        {
            listBoxSchedule.Items.Clear();
            List<string> schedule = _member.ViewTrainingSchedule();
            foreach (var session in schedule)
            {
                listBoxSchedule.Items.Add(session);
            }
        }
    }
}
