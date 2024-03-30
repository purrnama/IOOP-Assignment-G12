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
    public partial class FormAddCompetition : Form
    {
        private Competition competition;
       
        public TextBox MyBox { get { return txtBoxCompName; } }
        
        

        public FormAddCompetition()
        {
            InitializeComponent();
            competition = new Competition();
        }

        private void txtBoxCompName_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MethodUsingTextBox();
            competition.AddCompetition(this);
            //competition.DisplayCompetitionsInDataGridView;
            
        }

        private void FormAddCompetition_Load(object sender, EventArgs e)
        {
            competition.DisplayCompetitionsInDataGridView(this);
        }



        /* public static void Main(string[] args)
         {
             // Create an instance of MyClass
             Competition myInstance = new Competition();

             // Access the non-static field through the instance
             string value = myInstance.Greeting;

             // Now you can use the value
             MessageBox.Show(value); // Output: Hello, world!
         }*/

        //string addCompName = FormAddCompetition.txtBoxAddCompName.Text;
        /*public string AddCompetitionName
        {
            get { return txtBoxAddCompName.Text; }
            set { txtBoxAddCompName.Text = value; }
        }*/
    }   
}
