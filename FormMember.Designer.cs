namespace IOOPAssignment_G12
{
    partial class FormMember
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
            this.btnEnrollAndPay = new System.Windows.Forms.Button();
            this.btnUnenroll = new System.Windows.Forms.Button();
            this.btnTrainingSchedule = new System.Windows.Forms.Button();
            this.btnPerformanceRecord = new System.Windows.Forms.Button();
            this.btnAllCompetition = new System.Windows.Forms.Button();
            this.btnSendSuggestion = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnrollAndPay
            // 
            this.btnEnrollAndPay.Location = new System.Drawing.Point(27, 32);
            this.btnEnrollAndPay.Name = "btnEnrollAndPay";
            this.btnEnrollAndPay.Size = new System.Drawing.Size(172, 40);
            this.btnEnrollAndPay.TabIndex = 0;
            this.btnEnrollAndPay.Text = "Enroll and Pay";
            this.btnEnrollAndPay.UseVisualStyleBackColor = true;
            this.btnEnrollAndPay.Click += new System.EventHandler(this.btnEnrollAndPay_Click);
            // 
            // btnUnenroll
            // 
            this.btnUnenroll.Location = new System.Drawing.Point(27, 108);
            this.btnUnenroll.Name = "btnUnenroll";
            this.btnUnenroll.Size = new System.Drawing.Size(172, 40);
            this.btnUnenroll.TabIndex = 0;
            this.btnUnenroll.Text = "Unenroll";
            this.btnUnenroll.UseVisualStyleBackColor = true;
            // 
            // btnTrainingSchedule
            // 
            this.btnTrainingSchedule.Location = new System.Drawing.Point(27, 184);
            this.btnTrainingSchedule.Name = "btnTrainingSchedule";
            this.btnTrainingSchedule.Size = new System.Drawing.Size(172, 40);
            this.btnTrainingSchedule.TabIndex = 0;
            this.btnTrainingSchedule.Text = "Training Schedule";
            this.btnTrainingSchedule.UseVisualStyleBackColor = true;
            // 
            // btnPerformanceRecord
            // 
            this.btnPerformanceRecord.Location = new System.Drawing.Point(304, 32);
            this.btnPerformanceRecord.Name = "btnPerformanceRecord";
            this.btnPerformanceRecord.Size = new System.Drawing.Size(172, 40);
            this.btnPerformanceRecord.TabIndex = 0;
            this.btnPerformanceRecord.Text = "Performance Record";
            this.btnPerformanceRecord.UseVisualStyleBackColor = true;
            // 
            // btnAllCompetition
            // 
            this.btnAllCompetition.Location = new System.Drawing.Point(304, 108);
            this.btnAllCompetition.Name = "btnAllCompetition";
            this.btnAllCompetition.Size = new System.Drawing.Size(172, 40);
            this.btnAllCompetition.TabIndex = 0;
            this.btnAllCompetition.Text = "All Competition";
            this.btnAllCompetition.UseVisualStyleBackColor = true;
            // 
            // btnSendSuggestion
            // 
            this.btnSendSuggestion.Location = new System.Drawing.Point(304, 184);
            this.btnSendSuggestion.Name = "btnSendSuggestion";
            this.btnSendSuggestion.Size = new System.Drawing.Size(172, 40);
            this.btnSendSuggestion.TabIndex = 0;
            this.btnSendSuggestion.Text = "Send Suggestion";
            this.btnSendSuggestion.UseVisualStyleBackColor = true;
            this.btnSendSuggestion.Click += new System.EventHandler(this.btnSendSuggestion_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(169, 247);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(172, 40);
            this.btnUpdateProfile.TabIndex = 0;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSendSuggestion);
            this.groupBox1.Controls.Add(this.btnUpdateProfile);
            this.groupBox1.Controls.Add(this.btnEnrollAndPay);
            this.groupBox1.Controls.Add(this.btnUnenroll);
            this.groupBox1.Controls.Add(this.btnAllCompetition);
            this.groupBox1.Controls.Add(this.btnTrainingSchedule);
            this.groupBox1.Controls.Add(this.btnPerformanceRecord);
            this.groupBox1.Location = new System.Drawing.Point(78, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member dashboard";
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMember";
            this.Text = "FormMember";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnrollAndPay;
        private System.Windows.Forms.Button btnUnenroll;
        private System.Windows.Forms.Button btnTrainingSchedule;
        private System.Windows.Forms.Button btnPerformanceRecord;
        private System.Windows.Forms.Button btnAllCompetition;
        private System.Windows.Forms.Button btnSendSuggestion;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}