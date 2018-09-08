namespace SmartOrder
{
    partial class FormCasingOperations
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new SmartOrder.DataSet1();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMonthlyReport = new System.Windows.Forms.Button();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rvMonthly = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblReport = new System.Windows.Forms.Label();
            this.rvDaily = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new SmartOrder.DataSet1TableAdapters.DataTable1TableAdapter();
            this.DataTable2TableAdapter = new SmartOrder.DataSet1TableAdapters.DataTable2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.DataSet1;
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.BackColor = System.Drawing.Color.Transparent;
            this.btnMonthlyReport.BackgroundImage = global::SmartOrder.Properties.Resources.ReportButton;
            this.btnMonthlyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonthlyReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthlyReport.FlatAppearance.BorderSize = 0;
            this.btnMonthlyReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMonthlyReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMonthlyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyReport.Font = new System.Drawing.Font("OCR A Extended", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMonthlyReport.Location = new System.Drawing.Point(25, 25);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(100, 100);
            this.btnMonthlyReport.TabIndex = 4;
            this.btnMonthlyReport.Text = "Month";
            this.btnMonthlyReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMonthlyReport.UseVisualStyleBackColor = false;
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyReport_Click);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.BackColor = System.Drawing.Color.Transparent;
            this.btnDailyReport.BackgroundImage = global::SmartOrder.Properties.Resources.ReportButton;
            this.btnDailyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDailyReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDailyReport.FlatAppearance.BorderSize = 0;
            this.btnDailyReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDailyReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDailyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailyReport.Font = new System.Drawing.Font("OCR A Extended", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyReport.ForeColor = System.Drawing.Color.Gold;
            this.btnDailyReport.Location = new System.Drawing.Point(25, 158);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(100, 100);
            this.btnDailyReport.TabIndex = 5;
            this.btnDailyReport.Text = "Day";
            this.btnDailyReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDailyReport.UseVisualStyleBackColor = false;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
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
            this.btnBack.Location = new System.Drawing.Point(759, 369);
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
            this.btnExit.Location = new System.Drawing.Point(875, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 110);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rvMonthly
            // 
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.DataTable1BindingSource;
            this.rvMonthly.LocalReport.DataSources.Add(reportDataSource7);
            this.rvMonthly.LocalReport.ReportEmbeddedResource = "SmartOrder.Report1.rdlc";
            this.rvMonthly.Location = new System.Drawing.Point(185, 63);
            this.rvMonthly.Name = "rvMonthly";
            this.rvMonthly.ServerReport.BearerToken = null;
            this.rvMonthly.Size = new System.Drawing.Size(777, 279);
            this.rvMonthly.TabIndex = 11;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.BackColor = System.Drawing.Color.Transparent;
            this.lblReport.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.ForeColor = System.Drawing.Color.Cyan;
            this.lblReport.Location = new System.Drawing.Point(180, 25);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(109, 29);
            this.lblReport.TabIndex = 12;
            this.lblReport.Text = "Report";
            // 
            // rvDaily
            // 
            reportDataSource8.Name = "DataSet1";
            reportDataSource8.Value = this.DataTable2BindingSource;
            this.rvDaily.LocalReport.DataSources.Add(reportDataSource8);
            this.rvDaily.LocalReport.ReportEmbeddedResource = "SmartOrder.Report2.rdlc";
            this.rvDaily.Location = new System.Drawing.Point(185, 63);
            this.rvDaily.Name = "rvDaily";
            this.rvDaily.ServerReport.BearerToken = null;
            this.rvDaily.Size = new System.Drawing.Size(777, 279);
            this.rvDaily.TabIndex = 13;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // FormCasingOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartOrder.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(997, 491);
            this.Controls.Add(this.rvDaily);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.rvMonthly);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDailyReport);
            this.Controls.Add(this.btnMonthlyReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCasingOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCasingOperations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCasingOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMonthlyReport;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private Microsoft.Reporting.WinForms.ReportViewer rvMonthly;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Label lblReport;
        private Microsoft.Reporting.WinForms.ReportViewer rvDaily;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private DataSet1TableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
    }
}