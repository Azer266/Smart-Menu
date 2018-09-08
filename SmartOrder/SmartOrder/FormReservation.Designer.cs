namespace SmartOrder
{
    partial class FormReservation
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
            this.LVCustomers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRezervationOpen = new System.Windows.Forms.Button();
            this.btnCustomerOrder = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.txtTableNo = new System.Windows.Forms.TextBox();
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
            this.btnBack.Location = new System.Drawing.Point(1023, 481);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 110);
            this.btnBack.TabIndex = 32;
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
            this.btnExit.Location = new System.Drawing.Point(1139, 481);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 110);
            this.btnExit.TabIndex = 33;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LVCustomers
            // 
            this.LVCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.LVCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LVCustomers.FullRowSelect = true;
            this.LVCustomers.GridLines = true;
            this.LVCustomers.Location = new System.Drawing.Point(501, 84);
            this.LVCustomers.MultiSelect = false;
            this.LVCustomers.Name = "LVCustomers";
            this.LVCustomers.Size = new System.Drawing.Size(743, 241);
            this.LVCustomers.TabIndex = 34;
            this.LVCustomers.UseCompatibleStateImageBehavior = false;
            this.LVCustomers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 26;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Surname";
            this.columnHeader3.Width = 139;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Address";
            this.columnHeader4.Width = 137;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telephone";
            this.columnHeader5.Width = 146;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "E-mail";
            this.columnHeader6.Width = 158;
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Location = new System.Drawing.Point(986, 47);
            this.txtClientAddress.Multiline = true;
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.Size = new System.Drawing.Size(258, 31);
            this.txtClientAddress.TabIndex = 38;
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtClientPhone.Location = new System.Drawing.Point(744, 47);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(230, 31);
            this.txtClientPhone.TabIndex = 39;
            this.txtClientPhone.TextChanged += new System.EventHandler(this.txtClientPhone_TextChanged);
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtClientName.Location = new System.Drawing.Point(501, 47);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(230, 31);
            this.txtClientName.TabIndex = 40;
            this.txtClientName.TextChanged += new System.EventHandler(this.txtClientName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(981, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(739, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Telephone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(496, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Name";
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
            this.btnUpdate.Location = new System.Drawing.Point(819, 331);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 100);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRezervationOpen
            // 
            this.btnRezervationOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnRezervationOpen.BackgroundImage = global::SmartOrder.Properties.Resources.Book_now;
            this.btnRezervationOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRezervationOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervationOpen.FlatAppearance.BorderSize = 0;
            this.btnRezervationOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRezervationOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRezervationOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervationOpen.Location = new System.Drawing.Point(713, 331);
            this.btnRezervationOpen.Name = "btnRezervationOpen";
            this.btnRezervationOpen.Size = new System.Drawing.Size(100, 100);
            this.btnRezervationOpen.TabIndex = 43;
            this.btnRezervationOpen.UseVisualStyleBackColor = false;
            this.btnRezervationOpen.Click += new System.EventHandler(this.btnRezervationOpen_Click);
            // 
            // btnCustomerOrder
            // 
            this.btnCustomerOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomerOrder.BackgroundImage = global::SmartOrder.Properties.Resources.save;
            this.btnCustomerOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomerOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerOrder.FlatAppearance.BorderSize = 0;
            this.btnCustomerOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCustomerOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCustomerOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerOrder.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerOrder.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCustomerOrder.Location = new System.Drawing.Point(607, 331);
            this.btnCustomerOrder.Name = "btnCustomerOrder";
            this.btnCustomerOrder.Size = new System.Drawing.Size(100, 100);
            this.btnCustomerOrder.TabIndex = 42;
            this.btnCustomerOrder.UseVisualStyleBackColor = false;
            this.btnCustomerOrder.Click += new System.EventHandler(this.btnCustomerOrder_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::SmartOrder.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(501, 331);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 100);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDate.Location = new System.Drawing.Point(212, 50);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(230, 31);
            this.txtDate.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Select Table:";
            // 
            // txtTable
            // 
            this.txtTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTable.Location = new System.Drawing.Point(212, 96);
            this.txtTable.Name = "txtTable";
            this.txtTable.ReadOnly = true;
            this.txtTable.Size = new System.Drawing.Size(230, 31);
            this.txtTable.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Number of person:";
            // 
            // txtPerson
            // 
            this.txtPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPerson.Location = new System.Drawing.Point(212, 143);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.ReadOnly = true;
            this.txtPerson.Size = new System.Drawing.Size(230, 31);
            this.txtPerson.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(12, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.Location = new System.Drawing.Point(212, 189);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(230, 136);
            this.txtDescription.TabIndex = 46;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDate.Location = new System.Drawing.Point(448, 50);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(20, 31);
            this.dtpDate.TabIndex = 47;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            this.dtpDate.Enter += new System.EventHandler(this.dtpDate_Enter);
            this.dtpDate.MouseEnter += new System.EventHandler(this.dtpDate_MouseEnter);
            this.dtpDate.MouseLeave += new System.EventHandler(this.dtpDate_MouseLeave);
            // 
            // cmbTable
            // 
            this.cmbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(448, 94);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(20, 33);
            this.cmbTable.TabIndex = 48;
            this.cmbTable.SelectedIndexChanged += new System.EventHandler(this.cmbTable_SelectedIndexChanged);
            this.cmbTable.MouseEnter += new System.EventHandler(this.cmbTable_MouseEnter);
            this.cmbTable.MouseLeave += new System.EventHandler(this.cmbTable_MouseLeave);
            // 
            // cmbPerson
            // 
            this.cmbPerson.Enabled = false;
            this.cmbPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPerson.FormattingEnabled = true;
            this.cmbPerson.Location = new System.Drawing.Point(448, 141);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(20, 33);
            this.cmbPerson.TabIndex = 48;
            this.cmbPerson.SelectedIndexChanged += new System.EventHandler(this.cmbPerson_SelectedIndexChanged);
            this.cmbPerson.MouseEnter += new System.EventHandler(this.cmbPerson_MouseEnter);
            this.cmbPerson.MouseLeave += new System.EventHandler(this.cmbPerson_MouseLeave);
            // 
            // txtTableNo
            // 
            this.txtTableNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTableNo.Location = new System.Drawing.Point(474, 96);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.ReadOnly = true;
            this.txtTableNo.Size = new System.Drawing.Size(20, 31);
            this.txtTableNo.TabIndex = 46;
            this.txtTableNo.Visible = false;
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartOrder.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 603);
            this.Controls.Add(this.cmbPerson);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTableNo);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRezervationOpen);
            this.Controls.Add(this.btnCustomerOrder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtClientAddress);
            this.Controls.Add(this.txtClientPhone);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LVCustomers);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtClientAddress;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRezervationOpen;
        private System.Windows.Forms.Button btnCustomerOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.ListView LVCustomers;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.ComboBox cmbPerson;
        private System.Windows.Forms.TextBox txtTableNo;
    }
}