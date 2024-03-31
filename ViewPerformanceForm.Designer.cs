namespace IOOPAssignment_G12
{
    partial class ViewPerformanceForm
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
            this.labelPerformanceTitle = new System.Windows.Forms.Label();
            this.lblPerformance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPerformanceTitle
            // 
            this.labelPerformanceTitle.AutoSize = true;
            this.labelPerformanceTitle.Location = new System.Drawing.Point(337, 110);
            this.labelPerformanceTitle.Name = "labelPerformanceTitle";
            this.labelPerformanceTitle.Size = new System.Drawing.Size(113, 16);
            this.labelPerformanceTitle.TabIndex = 0;
            this.labelPerformanceTitle.Text = "Performance Title";
            // 
            // lblPerformance
            // 
            this.lblPerformance.AutoSize = true;
            this.lblPerformance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPerformance.Location = new System.Drawing.Point(340, 136);
            this.lblPerformance.Name = "lblPerformance";
            this.lblPerformance.Size = new System.Drawing.Size(102, 18);
            this.lblPerformance.TabIndex = 0;
            this.lblPerformance.Text = "                               ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Performance";
            // 
            // ViewPerformanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPerformance);
            this.Controls.Add(this.labelPerformanceTitle);
            this.Name = "ViewPerformanceForm";
            this.Text = "ViewPerformanceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPerformanceTitle;
        private System.Windows.Forms.Label lblPerformance;
        private System.Windows.Forms.Label label1;
    }
}