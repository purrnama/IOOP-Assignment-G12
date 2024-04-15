namespace IOOPAssignment_G12
{
    partial class frmCoach
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.trainingLevelTextBox = new System.Windows.Forms.TextBox();
            this.coachUsernameTextBox = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTrain = new System.Windows.Forms.Label();
            this.labelCoach = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRecommendation = new System.Windows.Forms.Button();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(16, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Linen;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.buttonEdit);
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.dateTextBox);
            this.tabPage1.Controls.Add(this.trainingLevelTextBox);
            this.tabPage1.Controls.Add(this.coachUsernameTextBox);
            this.tabPage1.Controls.Add(this.labelDate);
            this.tabPage1.Controls.Add(this.labelTrain);
            this.tabPage1.Controls.Add(this.labelCoach);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(553, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TrainingSchedule";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 83);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(392, 191);
            this.dataGridView1.TabIndex = 9;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonDelete.Font = new System.Drawing.Font("Noto Sans", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(458, 231);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(76, 36);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonEdit.Font = new System.Drawing.Font("Noto Sans", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(458, 165);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(76, 33);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonAdd.Font = new System.Drawing.Font("Noto Sans", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(458, 98);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(76, 32);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(373, 15);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(123, 19);
            this.dateTextBox.TabIndex = 5;
            // 
            // trainingLevelTextBox
            // 
            this.trainingLevelTextBox.Location = new System.Drawing.Point(136, 50);
            this.trainingLevelTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trainingLevelTextBox.Name = "trainingLevelTextBox";
            this.trainingLevelTextBox.Size = new System.Drawing.Size(145, 19);
            this.trainingLevelTextBox.TabIndex = 4;
            // 
            // coachUsernameTextBox
            // 
            this.coachUsernameTextBox.Location = new System.Drawing.Point(136, 15);
            this.coachUsernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.coachUsernameTextBox.Name = "coachUsernameTextBox";
            this.coachUsernameTextBox.Size = new System.Drawing.Size(145, 19);
            this.coachUsernameTextBox.TabIndex = 3;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Noto Sans", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(324, 15);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(40, 19);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date";
            // 
            // labelTrain
            // 
            this.labelTrain.AutoSize = true;
            this.labelTrain.Font = new System.Drawing.Font("Noto Sans", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrain.Location = new System.Drawing.Point(7, 50);
            this.labelTrain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrain.Name = "labelTrain";
            this.labelTrain.Size = new System.Drawing.Size(96, 19);
            this.labelTrain.TabIndex = 1;
            this.labelTrain.Text = "TrainingLevel";
            // 
            // labelCoach
            // 
            this.labelCoach.AutoSize = true;
            this.labelCoach.Font = new System.Drawing.Font("Noto Sans", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoach.Location = new System.Drawing.Point(6, 11);
            this.labelCoach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCoach.Name = "labelCoach";
            this.labelCoach.Size = new System.Drawing.Size(117, 19);
            this.labelCoach.TabIndex = 0;
            this.labelCoach.Text = "CoachUsername";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Linen;
            this.tabPage2.Controls.Add(this.buttonUpdate);
            this.tabPage2.Controls.Add(this.buttonRecommendation);
            this.tabPage2.Controls.Add(this.buttonPayment);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(553, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Others";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(192, 167);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(147, 54);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update Profile";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRecommendation
            // 
            this.buttonRecommendation.Location = new System.Drawing.Point(325, 58);
            this.buttonRecommendation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRecommendation.Name = "buttonRecommendation";
            this.buttonRecommendation.Size = new System.Drawing.Size(147, 52);
            this.buttonRecommendation.TabIndex = 3;
            this.buttonRecommendation.Text = "Recommendations";
            this.buttonRecommendation.UseVisualStyleBackColor = true;
            this.buttonRecommendation.Click += new System.EventHandler(this.buttonRecommendation_Click);
            // 
            // buttonPayment
            // 
            this.buttonPayment.Location = new System.Drawing.Point(82, 58);
            this.buttonPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(147, 52);
            this.buttonPayment.TabIndex = 2;
            this.buttonPayment.Text = "Payments Table";
            this.buttonPayment.UseVisualStyleBackColor = true;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // frmCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCoach";
            this.Text = "FormCoach";
            this.Load += new System.EventHandler(this.FormCoach_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox trainingLevelTextBox;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTrain;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox coachUsernameTextBox;
        private System.Windows.Forms.Label labelCoach;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRecommendation;
        private System.Windows.Forms.Button buttonPayment;
    }
}