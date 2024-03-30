namespace IOOPAssignment_G12
{
    partial class frmManager
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
            this.tabCtrlManager = new System.Windows.Forms.TabControl();
            this.tabPgManageCompetition = new System.Windows.Forms.TabPage();
            this.btnViewStudent = new System.Windows.Forms.Button();
            this.btnRecordResult = new System.Windows.Forms.Button();
            this.btnAssignMember = new System.Windows.Forms.Button();
            this.btnDeleteCompetition = new System.Windows.Forms.Button();
            this.btnEditCompetition = new System.Windows.Forms.Button();
            this.btnAddCompetition = new System.Windows.Forms.Button();
            this.tabPgRecommendedStudent = new System.Windows.Forms.TabPage();
            this.lstBoxRecommendedStudent = new System.Windows.Forms.ListBox();
            this.tabPgUpdateProfile = new System.Windows.Forms.TabPage();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeUsername = new System.Windows.Forms.Button();
            this.tabCtrlManager.SuspendLayout();
            this.tabPgManageCompetition.SuspendLayout();
            this.tabPgRecommendedStudent.SuspendLayout();
            this.tabPgUpdateProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlManager
            // 
            this.tabCtrlManager.Controls.Add(this.tabPgManageCompetition);
            this.tabCtrlManager.Controls.Add(this.tabPgRecommendedStudent);
            this.tabCtrlManager.Controls.Add(this.tabPgUpdateProfile);
            this.tabCtrlManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlManager.Location = new System.Drawing.Point(44, 12);
            this.tabCtrlManager.Name = "tabCtrlManager";
            this.tabCtrlManager.SelectedIndex = 0;
            this.tabCtrlManager.Size = new System.Drawing.Size(386, 453);
            this.tabCtrlManager.TabIndex = 0;
            // 
            // tabPgManageCompetition
            // 
            this.tabPgManageCompetition.Controls.Add(this.btnViewStudent);
            this.tabPgManageCompetition.Controls.Add(this.btnRecordResult);
            this.tabPgManageCompetition.Controls.Add(this.btnAssignMember);
            this.tabPgManageCompetition.Controls.Add(this.btnDeleteCompetition);
            this.tabPgManageCompetition.Controls.Add(this.btnEditCompetition);
            this.tabPgManageCompetition.Controls.Add(this.btnAddCompetition);
            this.tabPgManageCompetition.Location = new System.Drawing.Point(4, 24);
            this.tabPgManageCompetition.Name = "tabPgManageCompetition";
            this.tabPgManageCompetition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgManageCompetition.Size = new System.Drawing.Size(378, 425);
            this.tabPgManageCompetition.TabIndex = 0;
            this.tabPgManageCompetition.Text = "Manage Competition";
            this.tabPgManageCompetition.UseVisualStyleBackColor = true;
            // 
            // btnViewStudent
            // 
            this.btnViewStudent.Location = new System.Drawing.Point(47, 338);
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.Size = new System.Drawing.Size(287, 34);
            this.btnViewStudent.TabIndex = 5;
            this.btnViewStudent.Text = "View Students";
            this.btnViewStudent.UseVisualStyleBackColor = true;
            // 
            // btnRecordResult
            // 
            this.btnRecordResult.Location = new System.Drawing.Point(47, 282);
            this.btnRecordResult.Name = "btnRecordResult";
            this.btnRecordResult.Size = new System.Drawing.Size(287, 33);
            this.btnRecordResult.TabIndex = 4;
            this.btnRecordResult.Text = "Record Results";
            this.btnRecordResult.UseVisualStyleBackColor = true;
            // 
            // btnAssignMember
            // 
            this.btnAssignMember.Location = new System.Drawing.Point(47, 225);
            this.btnAssignMember.Name = "btnAssignMember";
            this.btnAssignMember.Size = new System.Drawing.Size(287, 35);
            this.btnAssignMember.TabIndex = 3;
            this.btnAssignMember.Text = "Assign Members";
            this.btnAssignMember.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCompetition
            // 
            this.btnDeleteCompetition.Location = new System.Drawing.Point(47, 169);
            this.btnDeleteCompetition.Name = "btnDeleteCompetition";
            this.btnDeleteCompetition.Size = new System.Drawing.Size(287, 36);
            this.btnDeleteCompetition.TabIndex = 2;
            this.btnDeleteCompetition.Text = "Delete Competition";
            this.btnDeleteCompetition.UseVisualStyleBackColor = true;
            // 
            // btnEditCompetition
            // 
            this.btnEditCompetition.Location = new System.Drawing.Point(47, 110);
            this.btnEditCompetition.Name = "btnEditCompetition";
            this.btnEditCompetition.Size = new System.Drawing.Size(287, 35);
            this.btnEditCompetition.TabIndex = 1;
            this.btnEditCompetition.Text = "Edit Competition";
            this.btnEditCompetition.UseVisualStyleBackColor = true;
            this.btnEditCompetition.Click += new System.EventHandler(this.btnEditCompetition_Click);
            // 
            // btnAddCompetition
            // 
            this.btnAddCompetition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCompetition.Location = new System.Drawing.Point(47, 52);
            this.btnAddCompetition.Name = "btnAddCompetition";
            this.btnAddCompetition.Size = new System.Drawing.Size(287, 32);
            this.btnAddCompetition.TabIndex = 0;
            this.btnAddCompetition.Text = "Add Competition";
            this.btnAddCompetition.UseVisualStyleBackColor = true;
            this.btnAddCompetition.Click += new System.EventHandler(this.btnAddCompetition_Click);
            // 
            // tabPgRecommendedStudent
            // 
            this.tabPgRecommendedStudent.Controls.Add(this.lstBoxRecommendedStudent);
            this.tabPgRecommendedStudent.Location = new System.Drawing.Point(4, 24);
            this.tabPgRecommendedStudent.Name = "tabPgRecommendedStudent";
            this.tabPgRecommendedStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgRecommendedStudent.Size = new System.Drawing.Size(378, 425);
            this.tabPgRecommendedStudent.TabIndex = 1;
            this.tabPgRecommendedStudent.Text = "Recommended Students";
            this.tabPgRecommendedStudent.UseVisualStyleBackColor = true;
            // 
            // lstBoxRecommendedStudent
            // 
            this.lstBoxRecommendedStudent.FormattingEnabled = true;
            this.lstBoxRecommendedStudent.ItemHeight = 15;
            this.lstBoxRecommendedStudent.Location = new System.Drawing.Point(103, 72);
            this.lstBoxRecommendedStudent.Name = "lstBoxRecommendedStudent";
            this.lstBoxRecommendedStudent.Size = new System.Drawing.Size(173, 259);
            this.lstBoxRecommendedStudent.TabIndex = 0;
            // 
            // tabPgUpdateProfile
            // 
            this.tabPgUpdateProfile.Controls.Add(this.btnChangePassword);
            this.tabPgUpdateProfile.Controls.Add(this.btnChangeUsername);
            this.tabPgUpdateProfile.Location = new System.Drawing.Point(4, 24);
            this.tabPgUpdateProfile.Name = "tabPgUpdateProfile";
            this.tabPgUpdateProfile.Size = new System.Drawing.Size(378, 425);
            this.tabPgUpdateProfile.TabIndex = 2;
            this.tabPgUpdateProfile.Text = "Update Profile";
            this.tabPgUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(40, 112);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(190, 35);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // btnChangeUsername
            // 
            this.btnChangeUsername.Location = new System.Drawing.Point(40, 44);
            this.btnChangeUsername.Name = "btnChangeUsername";
            this.btnChangeUsername.Size = new System.Drawing.Size(190, 38);
            this.btnChangeUsername.TabIndex = 0;
            this.btnChangeUsername.Text = "Change Username";
            this.btnChangeUsername.UseVisualStyleBackColor = true;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(472, 491);
            this.Controls.Add(this.tabCtrlManager);
            this.MaximizeBox = false;
            this.Name = "frmManager";
            this.Text = "Manager Panel";
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.tabCtrlManager.ResumeLayout(false);
            this.tabPgManageCompetition.ResumeLayout(false);
            this.tabPgRecommendedStudent.ResumeLayout(false);
            this.tabPgUpdateProfile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlManager;
        private System.Windows.Forms.TabPage tabPgManageCompetition;
        private System.Windows.Forms.TabPage tabPgRecommendedStudent;
        private System.Windows.Forms.Button btnDeleteCompetition;
        private System.Windows.Forms.Button btnEditCompetition;
        private System.Windows.Forms.Button btnAddCompetition;
        private System.Windows.Forms.Button btnAssignMember;
        private System.Windows.Forms.TabPage tabPgUpdateProfile;
        private System.Windows.Forms.Button btnRecordResult;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeUsername;
        private System.Windows.Forms.Button btnViewStudent;
        private System.Windows.Forms.ListBox lstBoxRecommendedStudent;
    }
}