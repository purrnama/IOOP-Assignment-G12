namespace IOOPAssignment_G12
{
    partial class frmAdmin
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.txtBoxRole = new System.Windows.Forms.TextBox();
            this.txtboxFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBoxUsers = new System.Windows.Forms.ListBox();
            this.tabIncome = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabCompetitions = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lstParticipantRankings = new System.Windows.Forms.ListBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lstCompetitions = new System.Windows.Forms.ListBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.btnUpdateProfileCancel = new System.Windows.Forms.Button();
            this.btnUpdateProfileSave = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtBoxEditPassword = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtBoxEditUsername = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBoxEditPhone = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBoxEditFullName = new System.Windows.Forms.TextBox();
            this.txtBoxEditEmail = new System.Windows.Forms.TextBox();
            this.tabFeedback = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabIncome.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabCompetitions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.Location = new System.Drawing.Point(431, 20);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUser.Size = new System.Drawing.Size(305, 19);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(68, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "APU Tennis Club Portal";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabWelcome);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Controls.Add(this.tabIncome);
            this.tabControl1.Controls.Add(this.tabCompetitions);
            this.tabControl1.Controls.Add(this.tabFeedback);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 420);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabWelcome
            // 
            this.tabWelcome.Location = new System.Drawing.Point(4, 28);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabWelcome.Size = new System.Drawing.Size(720, 388);
            this.tabWelcome.TabIndex = 0;
            this.tabWelcome.Text = "Welcome";
            this.tabWelcome.UseVisualStyleBackColor = true;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.btnDelete);
            this.tabUsers.Controls.Add(this.btnEdit);
            this.tabUsers.Controls.Add(this.btnCreateNew);
            this.tabUsers.Controls.Add(this.txtBoxRole);
            this.tabUsers.Controls.Add(this.txtboxFullName);
            this.tabUsers.Controls.Add(this.label3);
            this.tabUsers.Controls.Add(this.txtBoxUsername);
            this.tabUsers.Controls.Add(this.label2);
            this.tabUsers.Controls.Add(this.label1);
            this.tabUsers.Controls.Add(this.lstBoxUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 28);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(720, 388);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(369, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 28);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(369, 156);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 28);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(134, 343);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(122, 28);
            this.btnCreateNew.TabIndex = 7;
            this.btnCreateNew.Text = "Create New";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // txtBoxRole
            // 
            this.txtBoxRole.Location = new System.Drawing.Point(466, 101);
            this.txtBoxRole.Name = "txtBoxRole";
            this.txtBoxRole.ReadOnly = true;
            this.txtBoxRole.Size = new System.Drawing.Size(170, 26);
            this.txtBoxRole.TabIndex = 6;
            // 
            // txtboxFullName
            // 
            this.txtboxFullName.Location = new System.Drawing.Point(466, 65);
            this.txtboxFullName.Name = "txtboxFullName";
            this.txtboxFullName.ReadOnly = true;
            this.txtboxFullName.Size = new System.Drawing.Size(170, 26);
            this.txtboxFullName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Role:";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(466, 29);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.ReadOnly = true;
            this.txtBoxUsername.Size = new System.Drawing.Size(170, 26);
            this.txtBoxUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // lstBoxUsers
            // 
            this.lstBoxUsers.FormattingEnabled = true;
            this.lstBoxUsers.ItemHeight = 19;
            this.lstBoxUsers.Location = new System.Drawing.Point(134, 29);
            this.lstBoxUsers.Name = "lstBoxUsers";
            this.lstBoxUsers.Size = new System.Drawing.Size(214, 308);
            this.lstBoxUsers.TabIndex = 0;
            this.lstBoxUsers.SelectedValueChanged += new System.EventHandler(this.lstBoxUsers_SelectedValueChanged);
            // 
            // tabIncome
            // 
            this.tabIncome.Controls.Add(this.groupBox2);
            this.tabIncome.Controls.Add(this.groupBox1);
            this.tabIncome.Location = new System.Drawing.Point(4, 28);
            this.tabIncome.Name = "tabIncome";
            this.tabIncome.Size = new System.Drawing.Size(720, 388);
            this.tabIncome.TabIndex = 2;
            this.tabIncome.Text = "Income";
            this.tabIncome.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(311, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 345);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Review Coach Income";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(219, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 21);
            this.label18.TabIndex = 13;
            this.label18.Text = " ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(215, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 19);
            this.label19.TabIndex = 14;
            this.label19.Text = "Training Level";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(219, 301);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 21);
            this.label17.TabIndex = 12;
            this.label17.Text = "RM 0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(219, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 21);
            this.label16.TabIndex = 11;
            this.label16.Text = "RM 0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(219, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 21);
            this.label15.TabIndex = 8;
            this.label15.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(215, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 19);
            this.label14.TabIndex = 10;
            this.label14.Text = "Current Earnings";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(215, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 19);
            this.label13.TabIndex = 9;
            this.label13.Text = "Fee per Training";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(215, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 19);
            this.label12.TabIndex = 8;
            this.label12.Text = "Sessions";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(25, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 289);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(23, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 345);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monthly Overview";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(140, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "RM 0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(24, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "RM 0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(24, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "RM 0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(24, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "RM 0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total Income:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Advanced";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Intermediate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Beginner";
            // 
            // tabCompetitions
            // 
            this.tabCompetitions.Controls.Add(this.groupBox3);
            this.tabCompetitions.Controls.Add(this.label20);
            this.tabCompetitions.Controls.Add(this.lstCompetitions);
            this.tabCompetitions.Location = new System.Drawing.Point(4, 28);
            this.tabCompetitions.Name = "tabCompetitions";
            this.tabCompetitions.Size = new System.Drawing.Size(720, 388);
            this.tabCompetitions.TabIndex = 3;
            this.tabCompetitions.Text = "Competition Results";
            this.tabCompetitions.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.lstParticipantRankings);
            this.groupBox3.Location = new System.Drawing.Point(251, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 289);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Competition Details";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label29.Location = new System.Drawing.Point(29, 165);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(15, 21);
            this.label29.TabIndex = 10;
            this.label29.Text = " ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label28.Location = new System.Drawing.Point(29, 78);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(20, 21);
            this.label28.TabIndex = 9;
            this.label28.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(25, 49);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(104, 19);
            this.label27.TabIndex = 7;
            this.label27.Text = "Participants";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(25, 134);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 19);
            this.label21.TabIndex = 6;
            this.label21.Text = "Status";
            // 
            // lstParticipantRankings
            // 
            this.lstParticipantRankings.FormattingEnabled = true;
            this.lstParticipantRankings.ItemHeight = 19;
            this.lstParticipantRankings.Location = new System.Drawing.Point(224, 49);
            this.lstParticipantRankings.Name = "lstParticipantRankings";
            this.lstParticipantRankings.Size = new System.Drawing.Size(186, 213);
            this.lstParticipantRankings.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(25, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(115, 19);
            this.label20.TabIndex = 3;
            this.label20.Text = "Competitions";
            // 
            // lstCompetitions
            // 
            this.lstCompetitions.FormattingEnabled = true;
            this.lstCompetitions.ItemHeight = 19;
            this.lstCompetitions.Location = new System.Drawing.Point(29, 60);
            this.lstCompetitions.Name = "lstCompetitions";
            this.lstCompetitions.Size = new System.Drawing.Size(201, 289);
            this.lstCompetitions.TabIndex = 2;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.btnUpdateProfileCancel);
            this.tabSettings.Controls.Add(this.btnUpdateProfileSave);
            this.tabSettings.Controls.Add(this.groupBox5);
            this.tabSettings.Controls.Add(this.groupBox4);
            this.tabSettings.Location = new System.Drawing.Point(4, 28);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(720, 388);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "Update Profile";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProfileCancel
            // 
            this.btnUpdateProfileCancel.Location = new System.Drawing.Point(229, 341);
            this.btnUpdateProfileCancel.Name = "btnUpdateProfileCancel";
            this.btnUpdateProfileCancel.Size = new System.Drawing.Size(122, 28);
            this.btnUpdateProfileCancel.TabIndex = 9;
            this.btnUpdateProfileCancel.Text = "Cancel";
            this.btnUpdateProfileCancel.UseVisualStyleBackColor = true;
            this.btnUpdateProfileCancel.Click += new System.EventHandler(this.btnUpdateProfileCancel_Click);
            // 
            // btnUpdateProfileSave
            // 
            this.btnUpdateProfileSave.Location = new System.Drawing.Point(357, 341);
            this.btnUpdateProfileSave.Name = "btnUpdateProfileSave";
            this.btnUpdateProfileSave.Size = new System.Drawing.Size(164, 28);
            this.btnUpdateProfileSave.TabIndex = 8;
            this.btnUpdateProfileSave.Text = "Save changes";
            this.btnUpdateProfileSave.UseVisualStyleBackColor = true;
            this.btnUpdateProfileSave.Click += new System.EventHandler(this.btnUpdateProfileSave_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.txtBoxEditPassword);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.txtBoxEditUsername);
            this.groupBox5.Location = new System.Drawing.Point(157, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(428, 125);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "User Information";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(57, 43);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 19);
            this.label24.TabIndex = 0;
            this.label24.Text = "Username:";
            // 
            // txtBoxEditPassword
            // 
            this.txtBoxEditPassword.Location = new System.Drawing.Point(210, 72);
            this.txtBoxEditPassword.Name = "txtBoxEditPassword";
            this.txtBoxEditPassword.PasswordChar = '*';
            this.txtBoxEditPassword.Size = new System.Drawing.Size(154, 26);
            this.txtBoxEditPassword.TabIndex = 3;
            this.txtBoxEditPassword.TextChanged += new System.EventHandler(this.txtBoxEditPassword_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(57, 75);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(94, 19);
            this.label25.TabIndex = 1;
            this.label25.Text = "Password:";
            // 
            // txtBoxEditUsername
            // 
            this.txtBoxEditUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxEditUsername.Location = new System.Drawing.Point(210, 40);
            this.txtBoxEditUsername.Name = "txtBoxEditUsername";
            this.txtBoxEditUsername.Size = new System.Drawing.Size(154, 26);
            this.txtBoxEditUsername.TabIndex = 2;
            this.txtBoxEditUsername.TextChanged += new System.EventHandler(this.txtBoxEditUsername_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtBoxEditPhone);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtBoxEditFullName);
            this.groupBox4.Controls.Add(this.txtBoxEditEmail);
            this.groupBox4.Location = new System.Drawing.Point(157, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 164);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contact Information";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(57, 42);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 19);
            this.label26.TabIndex = 0;
            this.label26.Text = "Full Name:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(57, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 19);
            this.label22.TabIndex = 0;
            this.label22.Text = "Email:";
            // 
            // txtBoxEditPhone
            // 
            this.txtBoxEditPhone.Location = new System.Drawing.Point(210, 103);
            this.txtBoxEditPhone.Name = "txtBoxEditPhone";
            this.txtBoxEditPhone.Size = new System.Drawing.Size(154, 26);
            this.txtBoxEditPhone.TabIndex = 3;
            this.txtBoxEditPhone.TextChanged += new System.EventHandler(this.txtBoxEditPhone_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(57, 106);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(131, 19);
            this.label23.TabIndex = 1;
            this.label23.Text = "Phone Number:";
            // 
            // txtBoxEditFullName
            // 
            this.txtBoxEditFullName.Location = new System.Drawing.Point(210, 39);
            this.txtBoxEditFullName.Name = "txtBoxEditFullName";
            this.txtBoxEditFullName.Size = new System.Drawing.Size(154, 26);
            this.txtBoxEditFullName.TabIndex = 2;
            this.txtBoxEditFullName.TextChanged += new System.EventHandler(this.txtBoxEditFullName_TextChanged);
            // 
            // txtBoxEditEmail
            // 
            this.txtBoxEditEmail.Location = new System.Drawing.Point(210, 71);
            this.txtBoxEditEmail.Name = "txtBoxEditEmail";
            this.txtBoxEditEmail.Size = new System.Drawing.Size(154, 26);
            this.txtBoxEditEmail.TabIndex = 2;
            this.txtBoxEditEmail.TextChanged += new System.EventHandler(this.txtBoxEditEmail_TextChanged);
            // 
            // tabFeedback
            // 
            this.tabFeedback.Location = new System.Drawing.Point(4, 28);
            this.tabFeedback.Name = "tabFeedback";
            this.tabFeedback.Size = new System.Drawing.Size(720, 388);
            this.tabFeedback.TabIndex = 5;
            this.tabFeedback.Text = "Feedback";
            this.tabFeedback.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IOOPAssignment_G12.Properties.Resources.Tennis_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(752, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmin";
            this.Text = "Admin Panel";
            this.tabControl1.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            this.tabIncome.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCompetitions.ResumeLayout(false);
            this.tabCompetitions.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.TabPage tabIncome;
        private System.Windows.Forms.TabPage tabCompetitions;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.TextBox txtBoxRole;
        private System.Windows.Forms.TextBox txtboxFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxUsers;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstParticipantRankings;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ListBox lstCompetitions;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBoxEditPhone;
        private System.Windows.Forms.TextBox txtBoxEditEmail;
        private System.Windows.Forms.Button btnUpdateProfileCancel;
        private System.Windows.Forms.Button btnUpdateProfileSave;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBoxEditPassword;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtBoxEditUsername;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtBoxEditFullName;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabFeedback;
    }
}