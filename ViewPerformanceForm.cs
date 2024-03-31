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
    public partial class ViewPerformanceForm : Form
    {
        private readonly Member _member;

        // Constructor that takes a Member object
        public ViewPerformanceForm(Member member)
        {
            InitializeComponent();
            _member = member;
        }

        // Load event for the form to populate the performance label
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            int performanceScore = _member.ViewPerformanceRecord(_member.Username);
            lblPerformance.Text = performanceScore.ToString();
        }
    }
}
