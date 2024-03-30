namespace IOOPAssignment_G12
{
    partial class FormAddCompetition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxAddComp = new System.Windows.Forms.GroupBox();
            this.textBoxSample = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lstBoxAssignParticipants = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblNumberOfPlayers = new System.Windows.Forms.Label();
            this.dateTimePickerComp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCompetitionVenue = new System.Windows.Forms.Label();
            this.lblCompetitionName = new System.Windows.Forms.Label();
            this.txtBoxCompName = new System.Windows.Forms.TextBox();
            this.grpBoxAddComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxAddComp
            // 
            this.grpBoxAddComp.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoxAddComp.Controls.Add(this.textBoxSample);
            this.grpBoxAddComp.Controls.Add(this.btnSave);
            this.grpBoxAddComp.Controls.Add(this.dataGridView1);
            this.grpBoxAddComp.Controls.Add(this.lstBoxAssignParticipants);
            this.grpBoxAddComp.Controls.Add(this.textBox3);
            this.grpBoxAddComp.Controls.Add(this.lblNumberOfPlayers);
            this.grpBoxAddComp.Controls.Add(this.dateTimePickerComp);
            this.grpBoxAddComp.Controls.Add(this.label1);
            this.grpBoxAddComp.Controls.Add(this.textBox2);
            this.grpBoxAddComp.Controls.Add(this.lblCompetitionVenue);
            this.grpBoxAddComp.Controls.Add(this.lblCompetitionName);
            this.grpBoxAddComp.Controls.Add(this.txtBoxCompName);
            this.grpBoxAddComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxAddComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAddComp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpBoxAddComp.Location = new System.Drawing.Point(12, 12);
            this.grpBoxAddComp.Name = "grpBoxAddComp";
            this.grpBoxAddComp.Size = new System.Drawing.Size(644, 474);
            this.grpBoxAddComp.TabIndex = 0;
            this.grpBoxAddComp.TabStop = false;
            this.grpBoxAddComp.Text = "Competition Form";
            // 
            // textBoxSample
            // 
            this.textBoxSample.Location = new System.Drawing.Point(172, 172);
            this.textBoxSample.Name = "textBoxSample";
            this.textBoxSample.Size = new System.Drawing.Size(100, 24);
            this.textBoxSample.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(212, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(223, 33);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 153);
            this.dataGridView1.TabIndex = 10;
            // 
            // lstBoxAssignParticipants
            // 
            this.lstBoxAssignParticipants.FormattingEnabled = true;
            this.lstBoxAssignParticipants.ItemHeight = 18;
            this.lstBoxAssignParticipants.Items.AddRange(new object[] {
            "John",
            "Jack",
            "Jason",
            "Jess",
            "Jamal"});
            this.lstBoxAssignParticipants.Location = new System.Drawing.Point(430, 24);
            this.lstBoxAssignParticipants.Name = "lstBoxAssignParticipants";
            this.lstBoxAssignParticipants.ScrollAlwaysVisible = true;
            this.lstBoxAssignParticipants.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBoxAssignParticipants.Size = new System.Drawing.Size(185, 220);
            this.lstBoxAssignParticipants.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(172, 220);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 24);
            this.textBox3.TabIndex = 8;
            // 
            // lblNumberOfPlayers
            // 
            this.lblNumberOfPlayers.AutoSize = true;
            this.lblNumberOfPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPlayers.Location = new System.Drawing.Point(16, 225);
            this.lblNumberOfPlayers.Name = "lblNumberOfPlayers";
            this.lblNumberOfPlayers.Size = new System.Drawing.Size(150, 16);
            this.lblNumberOfPlayers.TabIndex = 7;
            this.lblNumberOfPlayers.Text = "Number of Competitors :";
            // 
            // dateTimePickerComp
            // 
            this.dateTimePickerComp.Location = new System.Drawing.Point(80, 142);
            this.dateTimePickerComp.Name = "dateTimePickerComp";
            this.dateTimePickerComp.Size = new System.Drawing.Size(260, 24);
            this.dateTimePickerComp.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 89);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 24);
            this.textBox2.TabIndex = 3;
            // 
            // lblCompetitionVenue
            // 
            this.lblCompetitionVenue.AutoSize = true;
            this.lblCompetitionVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitionVenue.Location = new System.Drawing.Point(16, 89);
            this.lblCompetitionVenue.Name = "lblCompetitionVenue";
            this.lblCompetitionVenue.Size = new System.Drawing.Size(52, 16);
            this.lblCompetitionVenue.TabIndex = 2;
            this.lblCompetitionVenue.Text = "Venue :";
            // 
            // lblCompetitionName
            // 
            this.lblCompetitionName.AutoSize = true;
            this.lblCompetitionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitionName.Location = new System.Drawing.Point(16, 39);
            this.lblCompetitionName.Name = "lblCompetitionName";
            this.lblCompetitionName.Size = new System.Drawing.Size(50, 16);
            this.lblCompetitionName.TabIndex = 1;
            this.lblCompetitionName.Text = "Name :";
            // 
            // txtBoxCompName
            // 
            this.txtBoxCompName.Location = new System.Drawing.Point(80, 39);
            this.txtBoxCompName.Multiline = true;
            this.txtBoxCompName.Name = "txtBoxCompName";
            this.txtBoxCompName.Size = new System.Drawing.Size(260, 24);
            this.txtBoxCompName.TabIndex = 0;
            this.txtBoxCompName.TextChanged += new System.EventHandler(this.txtBoxCompName_TextChanged);
            // 
            // FormAddCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(668, 498);
            this.Controls.Add(this.grpBoxAddComp);
            this.MaximizeBox = false;
            this.Name = "FormAddCompetition";
            this.Text = "Add Competition";
            this.Load += new System.EventHandler(this.FormAddCompetition_Load);
            this.grpBoxAddComp.ResumeLayout(false);
            this.grpBoxAddComp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxAddComp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCompetitionVenue;
        private System.Windows.Forms.Label lblCompetitionName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblNumberOfPlayers;
        private System.Windows.Forms.ListBox lstBoxAssignParticipants;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtBoxCompName;
        private System.Windows.Forms.TextBox textBoxSample;
        public System.Windows.Forms.DateTimePicker dateTimePickerComp;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}