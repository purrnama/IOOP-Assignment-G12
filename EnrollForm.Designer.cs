namespace IOOPAssignment_G12
{
    partial class EnrollForm
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
            this.comLevel = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comLevel
            // 
            this.comLevel.FormattingEnabled = true;
            this.comLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.comLevel.Location = new System.Drawing.Point(178, 166);
            this.comLevel.Name = "comLevel";
            this.comLevel.Size = new System.Drawing.Size(181, 24);
            this.comLevel.TabIndex = 1;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(175, 147);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(40, 16);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Level";
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(218, 209);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(92, 23);
            this.btnEnroll.TabIndex = 3;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 16.2F);
            this.label1.Location = new System.Drawing.Point(170, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enroll Page";
            // 
            // EnrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.comLevel);
            this.Name = "EnrollForm";
            this.Text = "EnrollForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Label label1;
    }
}