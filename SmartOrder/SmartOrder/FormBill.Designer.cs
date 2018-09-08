namespace SmartOrder
{
    partial class FormBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBill));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDiscount = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPriceToPay = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbActivity = new System.Windows.Forms.GroupBox();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbTicket = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.LVBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblCheckId = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbActivity.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbxDiscount);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(63, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special Discount";
            // 
            // cbxDiscount
            // 
            this.cbxDiscount.AutoSize = true;
            this.cbxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDiscount.Location = new System.Drawing.Point(22, 41);
            this.cbxDiscount.Name = "cbxDiscount";
            this.cbxDiscount.Size = new System.Drawing.Size(168, 28);
            this.cbxDiscount.TabIndex = 0;
            this.cbxDiscount.Text = "Apply a discount";
            this.cbxDiscount.UseVisualStyleBackColor = true;
            this.cbxDiscount.CheckedChanged += new System.EventHandler(this.cbxDiscount_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblPriceToPay);
            this.groupBox2.Controls.Add(this.lblTotalPrice);
            this.groupBox2.Controls.Add(this.lblTax);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblDiscount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(476, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 187);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Subtotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tax";
            // 
            // lblPriceToPay
            // 
            this.lblPriceToPay.AutoSize = true;
            this.lblPriceToPay.Location = new System.Drawing.Point(162, 132);
            this.lblPriceToPay.Name = "lblPriceToPay";
            this.lblPriceToPay.Size = new System.Drawing.Size(27, 29);
            this.lblPriceToPay.TabIndex = 9;
            this.lblPriceToPay.Text = "0";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(162, 103);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(27, 29);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "0";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(162, 74);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(27, 29);
            this.lblTax.TabIndex = 9;
            this.lblTax.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(266, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 29);
            this.label13.TabIndex = 9;
            this.label13.Text = "AZN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 29);
            this.label12.TabIndex = 9;
            this.label12.Text = "AZN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(266, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 29);
            this.label11.TabIndex = 9;
            this.label11.Text = "AZN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "AZN";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(162, 45);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(27, 29);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "0";
            this.lblDiscount.TextChanged += new System.EventHandler(this.lblDiscount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Discount";
            // 
            // gbActivity
            // 
            this.gbActivity.BackColor = System.Drawing.Color.Transparent;
            this.gbActivity.Controls.Add(this.txtActivity);
            this.gbActivity.Controls.Add(this.label1);
            this.gbActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbActivity.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbActivity.Location = new System.Drawing.Point(63, 371);
            this.gbActivity.Name = "gbActivity";
            this.gbActivity.Size = new System.Drawing.Size(219, 115);
            this.gbActivity.TabIndex = 0;
            this.gbActivity.TabStop = false;
            this.gbActivity.Text = "Special Activity";
            this.gbActivity.Visible = false;
            // 
            // txtActivity
            // 
            this.txtActivity.Location = new System.Drawing.Point(10, 68);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(189, 31);
            this.txtActivity.TabIndex = 1;
            this.txtActivity.TextChanged += new System.EventHandler(this.txtActivity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter discount amount";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.rbTicket);
            this.groupBox4.Controls.Add(this.rbCreditCard);
            this.groupBox4.Controls.Add(this.rbCash);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Location = new System.Drawing.Point(476, 214);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 187);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment type";
            // 
            // rbTicket
            // 
            this.rbTicket.AutoSize = true;
            this.rbTicket.Location = new System.Drawing.Point(15, 123);
            this.rbTicket.Name = "rbTicket";
            this.rbTicket.Size = new System.Drawing.Size(103, 33);
            this.rbTicket.TabIndex = 0;
            this.rbTicket.TabStop = true;
            this.rbTicket.Text = "Ticket";
            this.rbTicket.UseVisualStyleBackColor = true;
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(15, 84);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(165, 33);
            this.rbCreditCard.TabIndex = 0;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(15, 45);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(90, 33);
            this.rbCash.TabIndex = 0;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
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
            this.btnBack.Location = new System.Drawing.Point(744, 432);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 110);
            this.btnBack.TabIndex = 5;
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
            this.btnExit.Location = new System.Drawing.Point(860, 432);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 110);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LVBill
            // 
            this.LVBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LVBill.FullRowSelect = true;
            this.LVBill.GridLines = true;
            this.LVBill.Location = new System.Drawing.Point(63, 48);
            this.LVBill.Name = "LVBill";
            this.LVBill.Size = new System.Drawing.Size(345, 205);
            this.LVBill.TabIndex = 7;
            this.LVBill.UseCompatibleStateImageBehavior = false;
            this.LVBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ProductId";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SellingId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(59, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Orders";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImage = global::SmartOrder.Properties.Resources.printer;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(618, 432);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 110);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BackgroundImage = global::SmartOrder.Properties.Resources.pay_button;
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Location = new System.Drawing.Point(502, 432);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(110, 110);
            this.btnPay.TabIndex = 5;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblCheckId
            // 
            this.lblCheckId.AutoSize = true;
            this.lblCheckId.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCheckId.ForeColor = System.Drawing.Color.Gold;
            this.lblCheckId.Location = new System.Drawing.Point(155, 21);
            this.lblCheckId.Name = "lblCheckId";
            this.lblCheckId.Size = new System.Drawing.Size(27, 24);
            this.lblCheckId.TabIndex = 8;
            this.lblCheckId.Text = "id";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartOrder.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 554);
            this.Controls.Add(this.lblCheckId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LVBill);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbActivity);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbActivity.ResumeLayout(false);
            this.gbActivity.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxDiscount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbActivity;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView LVBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPriceToPay;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbTicket;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblCheckId;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}