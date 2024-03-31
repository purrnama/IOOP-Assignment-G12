namespace IOOPAssignment_G12
{
    partial class UnenrollForm
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
            this.btnUnenroll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comLevelSelection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUnenroll
            // 
            this.btnUnenroll.Location = new System.Drawing.Point(328, 216);
            this.btnUnenroll.Name = "btnUnenroll";
            this.btnUnenroll.Size = new System.Drawing.Size(140, 31);
            this.btnUnenroll.TabIndex = 3;
            this.btnUnenroll.Text = "Unenroll";
            this.btnUnenroll.UseVisualStyleBackColor = true;
            this.btnUnenroll.Click += new System.EventHandler(this.btnUnenroll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 16.2F);
            this.label1.Location = new System.Drawing.Point(296, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unenroll Page";
            // 
            // comLevelSelection
            // 
            this.comLevelSelection.FormattingEnabled = true;
            this.comLevelSelection.Items.AddRange(new object[] {
            "Beginner ",
            "intermediate",
            "Advanced"});
            this.comLevelSelection.Location = new System.Drawing.Point(272, 177);
            this.comLevelSelection.Name = "comLevelSelection";
            this.comLevelSelection.Size = new System.Drawing.Size(257, 24);
            this.comLevelSelection.TabIndex = 4;
            // 
            // UnenrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comLevelSelection);
            this.Controls.Add(this.btnUnenroll);
            this.Name = "UnenrollForm";
            this.Text = "Unenroll";
            this.Load += new System.EventHandler(this.Unenroll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUnenroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comLevelSelection;
    }
}