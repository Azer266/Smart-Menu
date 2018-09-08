namespace SmartOrder
{
    partial class FormKitchen
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.LVProducts = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVCategory = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.txtCtrId = new System.Windows.Forms.TextBox();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtPrdId = new System.Windows.Forms.TextBox();
            this.txtPrdPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrdName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCtrDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCtrName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbProduct = new System.Windows.Forms.RadioButton();
            this.rbCategory = new System.Windows.Forms.RadioButton();
            this.panelCategory.SuspendLayout();
            this.panelProduct.SuspendLayout();
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
            this.btnBack.Location = new System.Drawing.Point(767, 484);
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
            this.btnExit.Location = new System.Drawing.Point(883, 484);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 110);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(410, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 100);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(304, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 100);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::SmartOrder.Properties.Resources.searc;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(516, 277);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 100);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::SmartOrder.Properties.Resources.remove;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(622, 277);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 100);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // LVProducts
            // 
            this.LVProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.LVProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LVProducts.FullRowSelect = true;
            this.LVProducts.GridLines = true;
            this.LVProducts.Location = new System.Drawing.Point(178, 383);
            this.LVProducts.Name = "LVProducts";
            this.LVProducts.Size = new System.Drawing.Size(547, 200);
            this.LVProducts.TabIndex = 14;
            this.LVProducts.UseCompatibleStateImageBehavior = false;
            this.LVProducts.View = System.Windows.Forms.View.Details;
            this.LVProducts.SelectedIndexChanged += new System.EventHandler(this.LVProducts_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            this.columnHeader4.Width = 25;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CategoryId";
            this.columnHeader5.Width = 25;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Category";
            this.columnHeader6.Width = 165;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Product";
            this.columnHeader7.Width = 165;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Price";
            this.columnHeader8.Width = 160;
            // 
            // LVCategory
            // 
            this.LVCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.LVCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LVCategory.FullRowSelect = true;
            this.LVCategory.GridLines = true;
            this.LVCategory.Location = new System.Drawing.Point(307, 383);
            this.LVCategory.Name = "LVCategory";
            this.LVCategory.Size = new System.Drawing.Size(418, 200);
            this.LVCategory.TabIndex = 15;
            this.LVCategory.UseCompatibleStateImageBehavior = false;
            this.LVCategory.View = System.Windows.Forms.View.Details;
            this.LVCategory.Visible = false;
            this.LVCategory.SelectedIndexChanged += new System.EventHandler(this.LVCategory_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Id";
            this.columnHeader9.Width = 29;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Category";
            this.columnHeader10.Width = 170;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Description";
            this.columnHeader11.Width = 211;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSearch.Location = new System.Drawing.Point(173, 229);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(320, 25);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "The product you want to search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(499, 227);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(226, 29);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.Color.Transparent;
            this.panelCategory.Controls.Add(this.txtCtrId);
            this.panelCategory.Controls.Add(this.txtCtrDescription);
            this.panelCategory.Controls.Add(this.label3);
            this.panelCategory.Controls.Add(this.txtCtrName);
            this.panelCategory.Controls.Add(this.label2);
            this.panelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelCategory.Location = new System.Drawing.Point(178, 70);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(547, 144);
            this.panelCategory.TabIndex = 18;
            // 
            // txtCtrId
            // 
            this.txtCtrId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCtrId.Location = new System.Drawing.Point(289, 58);
            this.txtCtrId.Name = "txtCtrId";
            this.txtCtrId.Size = new System.Drawing.Size(23, 29);
            this.txtCtrId.TabIndex = 22;
            this.txtCtrId.Visible = false;
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.Transparent;
            this.panelProduct.Controls.Add(this.label6);
            this.panelProduct.Controls.Add(this.cmbCategory);
            this.panelProduct.Controls.Add(this.txtPrdId);
            this.panelProduct.Controls.Add(this.txtPrdPrice);
            this.panelProduct.Controls.Add(this.label4);
            this.panelProduct.Controls.Add(this.txtPrdName);
            this.panelProduct.Controls.Add(this.label5);
            this.panelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelProduct.Location = new System.Drawing.Point(178, 69);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(547, 144);
            this.panelProduct.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(124, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Category Name:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.White;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(318, 15);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(226, 32);
            this.cmbCategory.TabIndex = 23;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // txtPrdId
            // 
            this.txtPrdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrdId.Location = new System.Drawing.Point(289, 58);
            this.txtPrdId.Name = "txtPrdId";
            this.txtPrdId.Size = new System.Drawing.Size(23, 29);
            this.txtPrdId.TabIndex = 22;
            this.txtPrdId.Visible = false;
            // 
            // txtPrdPrice
            // 
            this.txtPrdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrdPrice.Location = new System.Drawing.Point(318, 102);
            this.txtPrdPrice.Name = "txtPrdPrice";
            this.txtPrdPrice.Size = new System.Drawing.Size(226, 29);
            this.txtPrdPrice.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(124, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Price:";
            // 
            // txtPrdName
            // 
            this.txtPrdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrdName.Location = new System.Drawing.Point(318, 58);
            this.txtPrdName.Name = "txtPrdName";
            this.txtPrdName.Size = new System.Drawing.Size(226, 29);
            this.txtPrdName.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(124, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Product Name:";
            // 
            // txtCtrDescription
            // 
            this.txtCtrDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCtrDescription.Location = new System.Drawing.Point(318, 102);
            this.txtCtrDescription.Name = "txtCtrDescription";
            this.txtCtrDescription.Size = new System.Drawing.Size(226, 29);
            this.txtCtrDescription.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(124, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Description:";
            // 
            // txtCtrName
            // 
            this.txtCtrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCtrName.Location = new System.Drawing.Point(318, 58);
            this.txtCtrName.Name = "txtCtrName";
            this.txtCtrName.Size = new System.Drawing.Size(226, 29);
            this.txtCtrName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(124, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Category Name:";
            // 
            // rbProduct
            // 
            this.rbProduct.AutoSize = true;
            this.rbProduct.BackColor = System.Drawing.Color.Transparent;
            this.rbProduct.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProduct.ForeColor = System.Drawing.Color.LawnGreen;
            this.rbProduct.Location = new System.Drawing.Point(588, 28);
            this.rbProduct.Name = "rbProduct";
            this.rbProduct.Size = new System.Drawing.Size(134, 35);
            this.rbProduct.TabIndex = 19;
            this.rbProduct.TabStop = true;
            this.rbProduct.Text = "Select product";
            this.rbProduct.UseVisualStyleBackColor = false;
            this.rbProduct.CheckedChanged += new System.EventHandler(this.rbProduct_CheckedChanged);
            // 
            // rbCategory
            // 
            this.rbCategory.AutoSize = true;
            this.rbCategory.BackColor = System.Drawing.Color.Transparent;
            this.rbCategory.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCategory.ForeColor = System.Drawing.Color.LawnGreen;
            this.rbCategory.Location = new System.Drawing.Point(414, 29);
            this.rbCategory.Name = "rbCategory";
            this.rbCategory.Size = new System.Drawing.Size(141, 35);
            this.rbCategory.TabIndex = 24;
            this.rbCategory.TabStop = true;
            this.rbCategory.Text = "Select category";
            this.rbCategory.UseVisualStyleBackColor = false;
            this.rbCategory.CheckedChanged += new System.EventHandler(this.rbCategory_CheckedChanged);
            // 
            // FormKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartOrder.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 606);
            this.Controls.Add(this.rbCategory);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.rbProduct);
            this.Controls.Add(this.panelCategory);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.LVCategory);
            this.Controls.Add(this.LVProducts);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKitchen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitchen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKitchen_Load);
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView LVProducts;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView LVCategory;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.TextBox txtCtrId;
        private System.Windows.Forms.TextBox txtCtrDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCtrName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtPrdId;
        private System.Windows.Forms.TextBox txtPrdPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrdName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbProduct;
        private System.Windows.Forms.RadioButton rbCategory;
    }
}