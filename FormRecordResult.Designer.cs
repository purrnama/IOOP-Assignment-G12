namespace IOOPAssignment_G12
{
    partial class FormRecordResult
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
            this.lstBoxSelectComp = new System.Windows.Forms.ListBox();
            this.lblSelectComp = new System.Windows.Forms.Label();
            this.groupBoxRecordResult = new System.Windows.Forms.GroupBox();
            this.lstBoxSelectParticipant = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxRecordResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBoxSelectComp
            // 
            this.lstBoxSelectComp.FormattingEnabled = true;
            this.lstBoxSelectComp.ItemHeight = 18;
            this.lstBoxSelectComp.Location = new System.Drawing.Point(40, 89);
            this.lstBoxSelectComp.Name = "lstBoxSelectComp";
            this.lstBoxSelectComp.Size = new System.Drawing.Size(122, 202);
            this.lstBoxSelectComp.TabIndex = 0;
            // 
            // lblSelectComp
            // 
            this.lblSelectComp.AutoSize = true;
            this.lblSelectComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectComp.Location = new System.Drawing.Point(37, 70);
            this.lblSelectComp.Name = "lblSelectComp";
            this.lblSelectComp.Size = new System.Drawing.Size(125, 16);
            this.lblSelectComp.TabIndex = 1;
            this.lblSelectComp.Text = "Select Competition :";
            // 
            // groupBoxRecordResult
            // 
            this.groupBoxRecordResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxRecordResult.Controls.Add(this.label2);
            this.groupBoxRecordResult.Controls.Add(this.txtBoxResult);
            this.groupBoxRecordResult.Controls.Add(this.lstBoxSelectParticipant);
            this.groupBoxRecordResult.Controls.Add(this.label1);
            this.groupBoxRecordResult.Controls.Add(this.btnSaveResult);
            this.groupBoxRecordResult.Controls.Add(this.lstBoxSelectComp);
            this.groupBoxRecordResult.Controls.Add(this.lblSelectComp);
            this.groupBoxRecordResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRecordResult.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRecordResult.Name = "groupBoxRecordResult";
            this.groupBoxRecordResult.Size = new System.Drawing.Size(622, 378);
            this.groupBoxRecordResult.TabIndex = 2;
            this.groupBoxRecordResult.TabStop = false;
            this.groupBoxRecordResult.Text = "Record Result";
            // 
            // lstBoxSelectParticipant
            // 
            this.lstBoxSelectParticipant.FormattingEnabled = true;
            this.lstBoxSelectParticipant.ItemHeight = 18;
            this.lstBoxSelectParticipant.Location = new System.Drawing.Point(187, 89);
            this.lstBoxSelectParticipant.Name = "lstBoxSelectParticipant";
            this.lstBoxSelectParticipant.Size = new System.Drawing.Size(122, 202);
            this.lstBoxSelectParticipant.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Participants";
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Location = new System.Drawing.Point(373, 192);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(194, 32);
            this.btnSaveResult.TabIndex = 5;
            this.btnSaveResult.Text = "Save Result";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(427, 143);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(140, 24);
            this.txtBoxResult.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Result: ";
            // 
            // FormRecordResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(646, 404);
            this.Controls.Add(this.groupBoxRecordResult);
            this.Name = "FormRecordResult";
            this.Text = "Record Result";
            this.Load += new System.EventHandler(this.FormRecordResult_Load);
            this.groupBoxRecordResult.ResumeLayout(false);
            this.groupBoxRecordResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSelectComp;
        private System.Windows.Forms.Button btnSaveResult;
        public System.Windows.Forms.ListBox lstBoxSelectComp;
        public System.Windows.Forms.ListBox lstBoxSelectParticipant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox groupBoxRecordResult;
        public System.Windows.Forms.TextBox txtBoxResult;
    }
}