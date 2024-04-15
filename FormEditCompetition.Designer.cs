namespace IOOPAssignment_G12
{
    partial class FormEditCompetition
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
            this.groupBoxEditCompetition = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewUpdate = new System.Windows.Forms.DataGridView();
            this.dateTimePickerUpdate = new System.Windows.Forms.DateTimePicker();
            this.txtBoxUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEditCompetition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEditCompetition
            // 
            this.groupBoxEditCompetition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxEditCompetition.Controls.Add(this.btnUpdate);
            this.groupBoxEditCompetition.Controls.Add(this.dataGridViewUpdate);
            this.groupBoxEditCompetition.Controls.Add(this.dateTimePickerUpdate);
            this.groupBoxEditCompetition.Controls.Add(this.txtBoxUpdate);
            this.groupBoxEditCompetition.Controls.Add(this.label2);
            this.groupBoxEditCompetition.Controls.Add(this.label1);
            this.groupBoxEditCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEditCompetition.Location = new System.Drawing.Point(14, 12);
            this.groupBoxEditCompetition.Name = "groupBoxEditCompetition";
            this.groupBoxEditCompetition.Size = new System.Drawing.Size(598, 451);
            this.groupBoxEditCompetition.TabIndex = 0;
            this.groupBoxEditCompetition.TabStop = false;
            this.groupBoxEditCompetition.Text = "Edit  Competition";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(402, 84);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 45);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridViewUpdate
            // 
            this.dataGridViewUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdate.Location = new System.Drawing.Point(23, 216);
            this.dataGridViewUpdate.Name = "dataGridViewUpdate";
            this.dataGridViewUpdate.Size = new System.Drawing.Size(551, 211);
            this.dataGridViewUpdate.TabIndex = 4;
            this.dataGridViewUpdate.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUpdate_CellContentDoubleClick);
            // 
            // dateTimePickerUpdate
            // 
            this.dateTimePickerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerUpdate.Location = new System.Drawing.Point(94, 138);
            this.dateTimePickerUpdate.Name = "dateTimePickerUpdate";
            this.dateTimePickerUpdate.Size = new System.Drawing.Size(246, 24);
            this.dateTimePickerUpdate.TabIndex = 3;
            // 
            // txtBoxUpdate
            // 
            this.txtBoxUpdate.Location = new System.Drawing.Point(94, 53);
            this.txtBoxUpdate.Multiline = true;
            this.txtBoxUpdate.Name = "txtBoxUpdate";
            this.txtBoxUpdate.Size = new System.Drawing.Size(246, 29);
            this.txtBoxUpdate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // FormEditCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(628, 475);
            this.Controls.Add(this.groupBoxEditCompetition);
            this.Name = "FormEditCompetition";
            this.Text = "Edit Competition";
            this.Load += new System.EventHandler(this.FormEditCompetition_Load);
            this.groupBoxEditCompetition.ResumeLayout(false);
            this.groupBoxEditCompetition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEditCompetition;
        private System.Windows.Forms.DateTimePicker dateTimePickerUpdate;
        private System.Windows.Forms.TextBox txtBoxUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.DataGridView dataGridViewUpdate;
    }
}