namespace IOOPAssignment_G12
{
    partial class ViewScheduleForm
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
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lstViewSchedule = new System.Windows.Forms.ListBox();
            this.btnBacktoDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Location = new System.Drawing.Point(406, 68);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(122, 23);
            this.btnViewSchedule.TabIndex = 0;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(193, 69);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(179, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // lstViewSchedule
            // 
            this.lstViewSchedule.FormattingEnabled = true;
            this.lstViewSchedule.ItemHeight = 16;
            this.lstViewSchedule.Location = new System.Drawing.Point(193, 117);
            this.lstViewSchedule.Name = "lstViewSchedule";
            this.lstViewSchedule.Size = new System.Drawing.Size(335, 164);
            this.lstViewSchedule.TabIndex = 2;
            // 
            // btnBacktoDashboard
            // 
            this.btnBacktoDashboard.Location = new System.Drawing.Point(193, 316);
            this.btnBacktoDashboard.Name = "btnBacktoDashboard";
            this.btnBacktoDashboard.Size = new System.Drawing.Size(135, 27);
            this.btnBacktoDashboard.TabIndex = 0;
            this.btnBacktoDashboard.Text = "Back to Dashboard";
            this.btnBacktoDashboard.UseVisualStyleBackColor = true;
            // 
            // ViewScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstViewSchedule);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnBacktoDashboard);
            this.Controls.Add(this.btnViewSchedule);
            this.Name = "ViewScheduleForm";
            this.Text = "ViewScheduleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ListBox lstViewSchedule;
        private System.Windows.Forms.Button btnBacktoDashboard;
    }
}