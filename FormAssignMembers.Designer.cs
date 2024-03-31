namespace IOOPAssignment_G12
{
    partial class FormAssignMembers
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
            this.groupBoxAssignMember = new System.Windows.Forms.GroupBox();
            this.listBoxAddMembers = new System.Windows.Forms.ListBox();
            this.lblAddMembers = new System.Windows.Forms.Label();
            this.lblCompetitionID = new System.Windows.Forms.Label();
            this.txtBoxCompID = new System.Windows.Forms.TextBox();
            this.dataGridViewCompTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewParticipantTable = new System.Windows.Forms.DataGridView();
            this.btnAssignMember = new System.Windows.Forms.Button();
            this.lblCompID = new System.Windows.Forms.Label();
            this.groupBoxAssignMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipantTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAssignMember
            // 
            this.groupBoxAssignMember.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxAssignMember.Controls.Add(this.lblCompID);
            this.groupBoxAssignMember.Controls.Add(this.btnAssignMember);
            this.groupBoxAssignMember.Controls.Add(this.dataGridViewParticipantTable);
            this.groupBoxAssignMember.Controls.Add(this.dataGridViewCompTable);
            this.groupBoxAssignMember.Controls.Add(this.txtBoxCompID);
            this.groupBoxAssignMember.Controls.Add(this.lblCompetitionID);
            this.groupBoxAssignMember.Controls.Add(this.lblAddMembers);
            this.groupBoxAssignMember.Controls.Add(this.listBoxAddMembers);
            this.groupBoxAssignMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAssignMember.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAssignMember.Name = "groupBoxAssignMember";
            this.groupBoxAssignMember.Size = new System.Drawing.Size(749, 529);
            this.groupBoxAssignMember.TabIndex = 0;
            this.groupBoxAssignMember.TabStop = false;
            this.groupBoxAssignMember.Text = "Assign Members into Competitions";
            // 
            // listBoxAddMembers
            // 
            this.listBoxAddMembers.FormattingEnabled = true;
            this.listBoxAddMembers.ItemHeight = 18;
            this.listBoxAddMembers.Location = new System.Drawing.Point(15, 68);
            this.listBoxAddMembers.Name = "listBoxAddMembers";
            this.listBoxAddMembers.Size = new System.Drawing.Size(157, 202);
            this.listBoxAddMembers.TabIndex = 0;
            // 
            // lblAddMembers
            // 
            this.lblAddMembers.AutoSize = true;
            this.lblAddMembers.Location = new System.Drawing.Point(12, 47);
            this.lblAddMembers.Name = "lblAddMembers";
            this.lblAddMembers.Size = new System.Drawing.Size(170, 18);
            this.lblAddMembers.TabIndex = 1;
            this.lblAddMembers.Text = "Select Members to Add :";
            // 
            // lblCompetitionID
            // 
            this.lblCompetitionID.AutoSize = true;
            this.lblCompetitionID.Location = new System.Drawing.Point(193, 70);
            this.lblCompetitionID.Name = "lblCompetitionID";
            this.lblCompetitionID.Size = new System.Drawing.Size(114, 18);
            this.lblCompetitionID.TabIndex = 2;
            this.lblCompetitionID.Text = "Competition ID :";
            // 
            // txtBoxCompID
            // 
            this.txtBoxCompID.Location = new System.Drawing.Point(528, 70);
            this.txtBoxCompID.Name = "txtBoxCompID";
            this.txtBoxCompID.Size = new System.Drawing.Size(100, 24);
            this.txtBoxCompID.TabIndex = 3;
            // 
            // dataGridViewCompTable
            // 
            this.dataGridViewCompTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompTable.Location = new System.Drawing.Point(16, 290);
            this.dataGridViewCompTable.Name = "dataGridViewCompTable";
            this.dataGridViewCompTable.Size = new System.Drawing.Size(340, 221);
            this.dataGridViewCompTable.TabIndex = 4;
            this.dataGridViewCompTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompTable_CellContentDoubleClick);
            // 
            // dataGridViewParticipantTable
            // 
            this.dataGridViewParticipantTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipantTable.Location = new System.Drawing.Point(372, 290);
            this.dataGridViewParticipantTable.Name = "dataGridViewParticipantTable";
            this.dataGridViewParticipantTable.Size = new System.Drawing.Size(362, 221);
            this.dataGridViewParticipantTable.TabIndex = 5;
            // 
            // btnAssignMember
            // 
            this.btnAssignMember.Location = new System.Drawing.Point(472, 188);
            this.btnAssignMember.Name = "btnAssignMember";
            this.btnAssignMember.Size = new System.Drawing.Size(222, 57);
            this.btnAssignMember.TabIndex = 6;
            this.btnAssignMember.Text = "Assign Members";
            this.btnAssignMember.UseVisualStyleBackColor = true;
            this.btnAssignMember.Click += new System.EventHandler(this.btnAssignMember_Click);
            // 
            // lblCompID
            // 
            this.lblCompID.AutoSize = true;
            this.lblCompID.Location = new System.Drawing.Point(323, 70);
            this.lblCompID.Name = "lblCompID";
            this.lblCompID.Size = new System.Drawing.Size(0, 18);
            this.lblCompID.TabIndex = 7;
            // 
            // FormAssignMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(773, 553);
            this.Controls.Add(this.groupBoxAssignMember);
            this.Name = "FormAssignMembers";
            this.Text = "Assign Members";
            this.Load += new System.EventHandler(this.FormAssignMembers_Load);
            this.groupBoxAssignMember.ResumeLayout(false);
            this.groupBoxAssignMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipantTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAssignMember;
        private System.Windows.Forms.Label lblAddMembers;
        public System.Windows.Forms.ListBox listBoxAddMembers;
        private System.Windows.Forms.Button btnAssignMember;
        private System.Windows.Forms.TextBox txtBoxCompID;
        private System.Windows.Forms.Label lblCompetitionID;
        public System.Windows.Forms.DataGridView dataGridViewCompTable;
        public System.Windows.Forms.DataGridView dataGridViewParticipantTable;
        public System.Windows.Forms.Label lblCompID;
    }
}