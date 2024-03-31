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
    public partial class sendSuggestionForm : Form
    {
        private Member member;
        private string username; // The username of the member sending the suggestion
        public sendSuggestionForm()
        {
            InitializeComponent();
        }
        public sendSuggestionForm(string memberUsername)
        {
            InitializeComponent();

            // Instantiate the MemberService
            member = new Member();

            // Store the passed-in username
            username = memberUsername;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Call the SendSuggestion method from the MemberService
            member.SendSuggestion(username, txtSuggestion.Text);
            MessageBox.Show("Suggestion sent successfully.");
            this.Close(); // Optionally close the form after sending the suggestion
        }
    }
}
