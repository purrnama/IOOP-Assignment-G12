namespace IOOPAssignment_G12
{
    partial class FormDeleteCompetition
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
            this.dataGridViewDelete = new System.Windows.Forms.DataGridView();
            this.lblCompNameDelete = new System.Windows.Forms.Label();
            this.lblDatePickerDelete = new System.Windows.Forms.Label();
            this.txtBoxDelete = new System.Windows.Forms.TextBox();
            this.dateTimePickerDelete = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteCompetition = new System.Windows.Forms.Button();
            this.groupBoxDeleteCompetition = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).BeginInit();
            this.groupBoxDeleteCompetition.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDelete
            // 
            this.dataGridViewDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelete.Location = new System.Drawing.Point(20, 219);
            this.dataGridViewDelete.Name = "dataGridViewDelete";
            this.dataGridViewDelete.Size = new System.Drawing.Size(597, 239);
            this.dataGridViewDelete.TabIndex = 0;
            this.dataGridViewDelete.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDelete_CellContentDoubleClick);
            // 
            // lblCompNameDelete
            // 
            this.lblCompNameDelete.AutoSize = true;
            this.lblCompNameDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompNameDelete.Location = new System.Drawing.Point(17, 65);
            this.lblCompNameDelete.Name = "lblCompNameDelete";
            this.lblCompNameDelete.Size = new System.Drawing.Size(60, 18);
            this.lblCompNameDelete.TabIndex = 1;
            this.lblCompNameDelete.Text = "Name : ";
            // 
            // lblDatePickerDelete
            // 
            this.lblDatePickerDelete.AutoSize = true;
            this.lblDatePickerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePickerDelete.Location = new System.Drawing.Point(17, 131);
            this.lblDatePickerDelete.Name = "lblDatePickerDelete";
            this.lblDatePickerDelete.Size = new System.Drawing.Size(47, 18);
            this.lblDatePickerDelete.TabIndex = 2;
            this.lblDatePickerDelete.Text = "Date :";
            // 
            // txtBoxDelete
            // 
            this.txtBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDelete.Location = new System.Drawing.Point(80, 62);
            this.txtBoxDelete.Multiline = true;
            this.txtBoxDelete.Name = "txtBoxDelete";
            this.txtBoxDelete.Size = new System.Drawing.Size(239, 28);
            this.txtBoxDelete.TabIndex = 3;
            // 
            // dateTimePickerDelete
            // 
            this.dateTimePickerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDelete.Location = new System.Drawing.Point(80, 131);
            this.dateTimePickerDelete.Name = "dateTimePickerDelete";
            this.dateTimePickerDelete.Size = new System.Drawing.Size(239, 24);
            this.dateTimePickerDelete.TabIndex = 4;
            // 
            // btnDeleteCompetition
            // 
            this.btnDeleteCompetition.Location = new System.Drawing.Point(385, 84);
            this.btnDeleteCompetition.Name = "btnDeleteCompetition";
            this.btnDeleteCompetition.Size = new System.Drawing.Size(181, 47);
            this.btnDeleteCompetition.TabIndex = 5;
            this.btnDeleteCompetition.Text = "Delete";
            this.btnDeleteCompetition.UseVisualStyleBackColor = true;
            this.btnDeleteCompetition.Click += new System.EventHandler(this.btnDeleteCompetition_Click);
            // 
            // groupBoxDeleteCompetition
            // 
            this.groupBoxDeleteCompetition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxDeleteCompetition.Controls.Add(this.dateTimePickerDelete);
            this.groupBoxDeleteCompetition.Controls.Add(this.dataGridViewDelete);
            this.groupBoxDeleteCompetition.Controls.Add(this.btnDeleteCompetition);
            this.groupBoxDeleteCompetition.Controls.Add(this.lblCompNameDelete);
            this.groupBoxDeleteCompetition.Controls.Add(this.txtBoxDelete);
            this.groupBoxDeleteCompetition.Controls.Add(this.lblDatePickerDelete);
            this.groupBoxDeleteCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDeleteCompetition.Location = new System.Drawing.Point(25, 12);
            this.groupBoxDeleteCompetition.Name = "groupBoxDeleteCompetition";
            this.groupBoxDeleteCompetition.Size = new System.Drawing.Size(641, 477);
            this.groupBoxDeleteCompetition.TabIndex = 6;
            this.groupBoxDeleteCompetition.TabStop = false;
            this.groupBoxDeleteCompetition.Text = "Delete Competition";
            // 
            // FormDeleteCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(688, 501);
            this.Controls.Add(this.groupBoxDeleteCompetition);
            this.Name = "FormDeleteCompetition";
            this.Text = "Delete Competition";
            this.Load += new System.EventHandler(this.FrmDeleteCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).EndInit();
            this.groupBoxDeleteCompetition.ResumeLayout(false);
            this.groupBoxDeleteCompetition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCompNameDelete;
        private System.Windows.Forms.Label lblDatePickerDelete;
        private System.Windows.Forms.TextBox txtBoxDelete;
        private System.Windows.Forms.DateTimePicker dateTimePickerDelete;
        private System.Windows.Forms.Button btnDeleteCompetition;
        private System.Windows.Forms.GroupBox groupBoxDeleteCompetition;
        public System.Windows.Forms.DataGridView dataGridViewDelete;
    }
}