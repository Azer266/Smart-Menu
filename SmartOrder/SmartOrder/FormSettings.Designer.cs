namespace SmartOrder
{
    partial class FormSettings
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbPersonnels = new System.Windows.Forms.ComboBox();
            this.lblRNewPassword = new System.Windows.Forms.Label();
            this.lblPersonnel = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtRNewPassword = new System.Windows.Forms.TextBox();
            this.txtPersonnelid = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPUpdate = new System.Windows.Forms.Button();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.btnPSave = new System.Windows.Forms.Button();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.cmbPersonnelDuties = new System.Windows.Forms.ComboBox();
            this.txtPRPassword = new System.Windows.Forms.TextBox();
            this.txtPPassword = new System.Windows.Forms.TextBox();
            this.txtPSurname = new System.Windows.Forms.TextBox();
            this.txtPDutyId = new System.Windows.Forms.TextBox();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.lblDuty = new System.Windows.Forms.Label();
            this.lblRPassword = new System.Windows.Forms.Label();
            this.lblAddPassword = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.LVPersonnel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPosition = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPasswordUpdate = new System.Windows.Forms.Button();
            this.lblRNPassword = new System.Windows.Forms.Label();
            this.lblNPassword = new System.Windows.Forms.Label();
            this.txtRNPassword = new System.Windows.Forms.TextBox();
            this.txtNPassword = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::SmartOrder.Properties.Resources.backButton;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(1083, 429);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 110);
            this.btnBack.TabIndex = 7;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::SmartOrder.Properties.Resources.Exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1199, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 110);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.cmbPersonnels);
            this.groupBox1.Controls.Add(this.lblRNewPassword);
            this.groupBox1.Controls.Add(this.lblPersonnel);
            this.groupBox1.Controls.Add(this.lblNewPassword);
            this.groupBox1.Controls.Add(this.txtRNewPassword);
            this.groupBox1.Controls.Add(this.txtPersonnelid);
            this.groupBox1.Controls.Add(this.txtNewPassword);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(25, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 246);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = global::SmartOrder.Properties.Resources.update;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(253, 82);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 100);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbPersonnels
            // 
            this.cmbPersonnels.FormattingEnabled = true;
            this.cmbPersonnels.Location = new System.Drawing.Point(210, 30);
            this.cmbPersonnels.Name = "cmbPersonnels";
            this.cmbPersonnels.Size = new System.Drawing.Size(143, 33);
            this.cmbPersonnels.TabIndex = 11;
            this.cmbPersonnels.SelectedIndexChanged += new System.EventHandler(this.cmbPersonnels_SelectedIndexChanged);
            // 
            // lblRNewPassword
            // 
            this.lblRNewPassword.AutoSize = true;
            this.lblRNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRNewPassword.Location = new System.Drawing.Point(7, 148);
            this.lblRNewPassword.Name = "lblRNewPassword";
            this.lblRNewPassword.Size = new System.Drawing.Size(231, 31);
            this.lblRNewPassword.TabIndex = 10;
            this.lblRNewPassword.Text = "R New Password:";
            // 
            // lblPersonnel
            // 
            this.lblPersonnel.AutoSize = true;
            this.lblPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonnel.Location = new System.Drawing.Point(7, 27);
            this.lblPersonnel.Name = "lblPersonnel";
            this.lblPersonnel.Size = new System.Drawing.Size(144, 31);
            this.lblPersonnel.TabIndex = 10;
            this.lblPersonnel.Text = "Personnel:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPassword.Location = new System.Drawing.Point(7, 70);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(204, 31);
            this.lblNewPassword.TabIndex = 10;
            this.lblNewPassword.Text = "New Password:";
            // 
            // txtRNewPassword
            // 
            this.txtRNewPassword.Location = new System.Drawing.Point(13, 188);
            this.txtRNewPassword.Name = "txtRNewPassword";
            this.txtRNewPassword.Size = new System.Drawing.Size(143, 31);
            this.txtRNewPassword.TabIndex = 10;
            // 
            // txtPersonnelid
            // 
            this.txtPersonnelid.Location = new System.Drawing.Point(359, 32);
            this.txtPersonnelid.Name = "txtPersonnelid";
            this.txtPersonnelid.Size = new System.Drawing.Size(20, 31);
            this.txtPersonnelid.TabIndex = 10;
            this.txtPersonnelid.Visible = false;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(13, 110);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(143, 31);
            this.txtNewPassword.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnPUpdate);
            this.groupBox2.Controls.Add(this.btnPDelete);
            this.groupBox2.Controls.Add(this.btnPSave);
            this.groupBox2.Controls.Add(this.btnPAdd);
            this.groupBox2.Controls.Add(this.cmbPersonnelDuties);
            this.groupBox2.Controls.Add(this.txtPRPassword);
            this.groupBox2.Controls.Add(this.txtPPassword);
            this.groupBox2.Controls.Add(this.txtPSurname);
            this.groupBox2.Controls.Add(this.txtPDutyId);
            this.groupBox2.Controls.Add(this.txtPId);
            this.groupBox2.Controls.Add(this.txtPName);
            this.groupBox2.Controls.Add(this.lblDuty);
            this.groupBox2.Controls.Add(this.lblRPassword);
            this.groupBox2.Controls.Add(this.lblAddPassword);
            this.groupBox2.Controls.Add(this.lblSurname);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(436, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 355);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnPUpdate
            // 
            this.btnPUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnPUpdate.BackgroundImage = global::SmartOrder.Properties.Resources.update;
            this.btnPUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPUpdate.FlatAppearance.BorderSize = 0;
            this.btnPUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPUpdate.Location = new System.Drawing.Point(339, 236);
            this.btnPUpdate.Name = "btnPUpdate";
            this.btnPUpdate.Size = new System.Drawing.Size(100, 100);
            this.btnPUpdate.TabIndex = 7;
            this.btnPUpdate.UseVisualStyleBackColor = false;
            this.btnPUpdate.Click += new System.EventHandler(this.btnPUpdate_Click);
            // 
            // btnPDelete
            // 
            this.btnPDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnPDelete.BackgroundImage = global::SmartOrder.Properties.Resources.remove;
            this.btnPDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDelete.FlatAppearance.BorderSize = 0;
            this.btnPDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDelete.Location = new System.Drawing.Point(233, 236);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(100, 100);
            this.btnPDelete.TabIndex = 6;
            this.btnPDelete.UseVisualStyleBackColor = false;
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // btnPSave
            // 
            this.btnPSave.BackColor = System.Drawing.Color.Transparent;
            this.btnPSave.BackgroundImage = global::SmartOrder.Properties.Resources.save;
            this.btnPSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPSave.FlatAppearance.BorderSize = 0;
            this.btnPSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSave.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPSave.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnPSave.Location = new System.Drawing.Point(127, 236);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.Size = new System.Drawing.Size(100, 100);
            this.btnPSave.TabIndex = 5;
            this.btnPSave.Text = "Save";
            this.btnPSave.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPSave.UseVisualStyleBackColor = false;
            this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click);
            // 
            // btnPAdd
            // 
            this.btnPAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnPAdd.BackgroundImage = global::SmartOrder.Properties.Resources.add;
            this.btnPAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPAdd.FlatAppearance.BorderSize = 0;
            this.btnPAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAdd.Location = new System.Drawing.Point(21, 236);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(100, 100);
            this.btnPAdd.TabIndex = 4;
            this.btnPAdd.UseVisualStyleBackColor = false;
            this.btnPAdd.Click += new System.EventHandler(this.btnPAdd_Click);
            // 
            // cmbPersonnelDuties
            // 
            this.cmbPersonnelDuties.FormattingEnabled = true;
            this.cmbPersonnelDuties.Location = new System.Drawing.Point(289, 188);
            this.cmbPersonnelDuties.Name = "cmbPersonnelDuties";
            this.cmbPersonnelDuties.Size = new System.Drawing.Size(150, 33);
            this.cmbPersonnelDuties.TabIndex = 2;
            this.cmbPersonnelDuties.SelectedIndexChanged += new System.EventHandler(this.cmbPersonnelDuties_SelectedIndexChanged);
            // 
            // txtPRPassword
            // 
            this.txtPRPassword.Location = new System.Drawing.Point(289, 151);
            this.txtPRPassword.Name = "txtPRPassword";
            this.txtPRPassword.Size = new System.Drawing.Size(150, 31);
            this.txtPRPassword.TabIndex = 1;
            // 
            // txtPPassword
            // 
            this.txtPPassword.Location = new System.Drawing.Point(289, 110);
            this.txtPPassword.Name = "txtPPassword";
            this.txtPPassword.Size = new System.Drawing.Size(150, 31);
            this.txtPPassword.TabIndex = 1;
            // 
            // txtPSurname
            // 
            this.txtPSurname.Location = new System.Drawing.Point(289, 70);
            this.txtPSurname.Name = "txtPSurname";
            this.txtPSurname.Size = new System.Drawing.Size(150, 31);
            this.txtPSurname.TabIndex = 1;
            // 
            // txtPDutyId
            // 
            this.txtPDutyId.Location = new System.Drawing.Point(261, 190);
            this.txtPDutyId.Name = "txtPDutyId";
            this.txtPDutyId.Size = new System.Drawing.Size(22, 31);
            this.txtPDutyId.TabIndex = 1;
            this.txtPDutyId.Visible = false;
            // 
            // txtPId
            // 
            this.txtPId.Location = new System.Drawing.Point(261, 27);
            this.txtPId.Name = "txtPId";
            this.txtPId.Size = new System.Drawing.Size(22, 31);
            this.txtPId.TabIndex = 1;
            this.txtPId.Visible = false;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(289, 27);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(150, 31);
            this.txtPName.TabIndex = 1;
            // 
            // lblDuty
            // 
            this.lblDuty.AutoSize = true;
            this.lblDuty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDuty.Location = new System.Drawing.Point(15, 192);
            this.lblDuty.Name = "lblDuty";
            this.lblDuty.Size = new System.Drawing.Size(79, 31);
            this.lblDuty.TabIndex = 0;
            this.lblDuty.Text = "Duty:";
            // 
            // lblRPassword
            // 
            this.lblRPassword.AutoSize = true;
            this.lblRPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRPassword.Location = new System.Drawing.Point(15, 151);
            this.lblRPassword.Name = "lblRPassword";
            this.lblRPassword.Size = new System.Drawing.Size(169, 31);
            this.lblRPassword.TabIndex = 0;
            this.lblRPassword.Text = "R Password:";
            // 
            // lblAddPassword
            // 
            this.lblAddPassword.AutoSize = true;
            this.lblAddPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddPassword.Location = new System.Drawing.Point(15, 110);
            this.lblAddPassword.Name = "lblAddPassword";
            this.lblAddPassword.Size = new System.Drawing.Size(142, 31);
            this.lblAddPassword.TabIndex = 0;
            this.lblAddPassword.Text = "Password:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(15, 70);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(131, 31);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(15, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // LVPersonnel
            // 
            this.LVPersonnel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LVPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LVPersonnel.FullRowSelect = true;
            this.LVPersonnel.GridLines = true;
            this.LVPersonnel.Location = new System.Drawing.Point(6, 24);
            this.LVPersonnel.Name = "LVPersonnel";
            this.LVPersonnel.Size = new System.Drawing.Size(382, 97);
            this.LVPersonnel.TabIndex = 10;
            this.LVPersonnel.UseCompatibleStateImageBehavior = false;
            this.LVPersonnel.View = System.Windows.Forms.View.Details;
            this.LVPersonnel.SelectedIndexChanged += new System.EventHandler(this.LVPersonnel_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 31;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DutyId";
            this.columnHeader2.Width = 31;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Duty";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 83;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Surname";
            this.columnHeader5.Width = 95;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPosition.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPosition.Location = new System.Drawing.Point(31, 9);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(89, 25);
            this.lblPosition.TabIndex = 11;
            this.lblPosition.Text = "Position";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnPasswordUpdate);
            this.groupBox3.Controls.Add(this.lblRNPassword);
            this.groupBox3.Controls.Add(this.lblNPassword);
            this.groupBox3.Controls.Add(this.txtRNPassword);
            this.groupBox3.Controls.Add(this.txtNPassword);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(916, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 223);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // btnPasswordUpdate
            // 
            this.btnPasswordUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnPasswordUpdate.BackgroundImage = global::SmartOrder.Properties.Resources.update;
            this.btnPasswordUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasswordUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasswordUpdate.FlatAppearance.BorderSize = 0;
            this.btnPasswordUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPasswordUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPasswordUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordUpdate.Location = new System.Drawing.Point(253, 78);
            this.btnPasswordUpdate.Name = "btnPasswordUpdate";
            this.btnPasswordUpdate.Size = new System.Drawing.Size(100, 100);
            this.btnPasswordUpdate.TabIndex = 12;
            this.btnPasswordUpdate.UseVisualStyleBackColor = false;
            this.btnPasswordUpdate.Click += new System.EventHandler(this.btnPasswordUpdate_Click);
            // 
            // lblRNPassword
            // 
            this.lblRNPassword.AutoSize = true;
            this.lblRNPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRNPassword.Location = new System.Drawing.Point(7, 116);
            this.lblRNPassword.Name = "lblRNPassword";
            this.lblRNPassword.Size = new System.Drawing.Size(231, 31);
            this.lblRNPassword.TabIndex = 10;
            this.lblRNPassword.Text = "R New Password:";
            // 
            // lblNPassword
            // 
            this.lblNPassword.AutoSize = true;
            this.lblNPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNPassword.Location = new System.Drawing.Point(7, 38);
            this.lblNPassword.Name = "lblNPassword";
            this.lblNPassword.Size = new System.Drawing.Size(204, 31);
            this.lblNPassword.TabIndex = 10;
            this.lblNPassword.Text = "New Password:";
            // 
            // txtRNPassword
            // 
            this.txtRNPassword.Location = new System.Drawing.Point(13, 156);
            this.txtRNPassword.Name = "txtRNPassword";
            this.txtRNPassword.Size = new System.Drawing.Size(143, 31);
            this.txtRNPassword.TabIndex = 10;
            // 
            // txtNPassword
            // 
            this.txtNPassword.Location = new System.Drawing.Point(13, 78);
            this.txtNPassword.Name = "txtNPassword";
            this.txtNPassword.Size = new System.Drawing.Size(143, 31);
            this.txtNPassword.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.LVPersonnel);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Location = new System.Drawing.Point(25, 298);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 134);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartOrder.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1321, 551);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPersonnels;
        private System.Windows.Forms.Label lblRNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtRNewPassword;
        private System.Windows.Forms.TextBox txtPersonnelid;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView LVPersonnel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbPersonnelDuties;
        private System.Windows.Forms.TextBox txtPRPassword;
        private System.Windows.Forms.TextBox txtPPassword;
        private System.Windows.Forms.TextBox txtPSurname;
        private System.Windows.Forms.TextBox txtPDutyId;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label lblDuty;
        private System.Windows.Forms.Label lblRPassword;
        private System.Windows.Forms.Label lblAddPassword;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblPersonnel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPasswordUpdate;
        private System.Windows.Forms.Label lblRNPassword;
        private System.Windows.Forms.Label lblNPassword;
        private System.Windows.Forms.TextBox txtRNPassword;
        private System.Windows.Forms.TextBox txtNPassword;
        private System.Windows.Forms.Button btnPAdd;
        private System.Windows.Forms.Button btnPUpdate;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.Button btnPSave;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}