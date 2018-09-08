namespace SmartOrder
{
    partial class FormCustomerOrders
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
            this.LVClientDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVSellingDetails = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalOrder = new System.Windows.Forms.Label();
            this.lblGeneralTotal = new System.Windows.Forms.Label();
            this.lblLastOrderDate = new System.Windows.Forms.Label();
            this.LVCustomers = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LVClientDetails
            // 
            this.LVClientDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LVClientDetails.FullRowSelect = true;
            this.LVClientDetails.GridLines = true;
            this.LVClientDetails.Location = new System.Drawing.Point(260, 41);
            this.LVClientDetails.Name = "LVClientDetails";
            this.LVClientDetails.Size = new System.Drawing.Size(380, 170);
            this.LVClientDetails.TabIndex = 0;
            this.LVClientDetails.UseCompatibleStateImageBehavior = false;
            this.LVClientDetails.View = System.Windows.Forms.View.Details;
            this.LVClientDetails.SelectedIndexChanged += new System.EventHandler(this.LVClientDetails_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Surname";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CheckId";
            // 
            // LVSellingDetails
            // 
            this.LVSellingDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.LVSellingDetails.FullRowSelect = true;
            this.LVSellingDetails.GridLines = true;
            this.LVSellingDetails.Location = new System.Drawing.Point(669, 41);
            this.LVSellingDetails.Name = "LVSellingDetails";
            this.LVSellingDetails.Size = new System.Drawing.Size(312, 170);
            this.LVSellingDetails.TabIndex = 1;
            this.LVSellingDetails.UseCompatibleStateImageBehavior = false;
            this.LVSellingDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "SellingId";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Product";
            this.columnHeader7.Width = 130;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Quantity";
            this.columnHeader8.Width = 56;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Price";
            this.columnHeader9.Width = 62;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(393, 226);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(196, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(281, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Toplam Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(389, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Toplam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(389, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Genel Toplam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(389, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "En Son Sifaris:";
            // 
            // lblTotalOrder
            // 
            this.lblTotalOrder.AutoSize = true;
            this.lblTotalOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalOrder.ForeColor = System.Drawing.Color.Gold;
            this.lblTotalOrder.Location = new System.Drawing.Point(524, 260);
            this.lblTotalOrder.Name = "lblTotalOrder";
            this.lblTotalOrder.Size = new System.Drawing.Size(65, 20);
            this.lblTotalOrder.TabIndex = 5;
            this.lblTotalOrder.Text = "Toplam:";
            // 
            // lblGeneralTotal
            // 
            this.lblGeneralTotal.AutoSize = true;
            this.lblGeneralTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneralTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGeneralTotal.ForeColor = System.Drawing.Color.Gold;
            this.lblGeneralTotal.Location = new System.Drawing.Point(524, 290);
            this.lblGeneralTotal.Name = "lblGeneralTotal";
            this.lblGeneralTotal.Size = new System.Drawing.Size(112, 20);
            this.lblGeneralTotal.TabIndex = 6;
            this.lblGeneralTotal.Text = "Genel Toplam:";
            // 
            // lblLastOrderDate
            // 
            this.lblLastOrderDate.AutoSize = true;
            this.lblLastOrderDate.BackColor = System.Drawing.Color.Transparent;
            this.lblLastOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastOrderDate.ForeColor = System.Drawing.Color.Gold;
            this.lblLastOrderDate.Location = new System.Drawing.Point(524, 320);
            this.lblLastOrderDate.Name = "lblLastOrderDate";
            this.lblLastOrderDate.Size = new System.Drawing.Size(114, 20);
            this.lblLastOrderDate.TabIndex = 7;
            this.lblLastOrderDate.Text = "En Son Sifaris:";
            // 
            // LVCustomers
            // 
            this.LVCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.LVCustomers.FullRowSelect = true;
            this.LVCustomers.GridLines = true;
            this.LVCustomers.Location = new System.Drawing.Point(705, 217);
            this.LVCustomers.Name = "LVCustomers";
            this.LVCustomers.Size = new System.Drawing.Size(208, 129);
            this.LVCustomers.TabIndex = 8;
            this.LVCustomers.UseCompatibleStateImageBehavior = false;
            this.LVCustomers.View = System.Windows.Forms.View.Details;
            this.LVCustomers.Visible = false;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "CustomerId";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Customer";
            this.columnHeader11.Width = 84;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "CheckId";
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
            this.btnBack.Location = new System.Drawing.Point(766, 414);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 110);
            this.btnBack.TabIndex = 9;
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
            this.btnExit.Location = new System.Drawing.Point(882, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 110);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormCustomerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartOrder.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 536);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.LVCustomers);
            this.Controls.Add(this.lblLastOrderDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGeneralTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.LVSellingDetails);
            this.Controls.Add(this.LVClientDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomerOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Orders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCustomerOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVClientDetails;
        private System.Windows.Forms.ListView LVSellingDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalOrder;
        private System.Windows.Forms.Label lblGeneralTotal;
        private System.Windows.Forms.Label lblLastOrderDate;
        private System.Windows.Forms.ListView LVCustomers;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}