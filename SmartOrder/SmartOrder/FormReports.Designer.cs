namespace SmartOrder
{
    partial class FormReports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.btnFastfood = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnAppetizer = new System.Windows.Forms.Button();
            this.btnPasta = new System.Windows.Forms.Button();
            this.btnSalad = new System.Windows.Forms.Button();
            this.btnSoup = new System.Windows.Forms.Button();
            this.btnMainCourse = new System.Windows.Forms.Button();
            this.gbStatistic = new System.Windows.Forms.GroupBox();
            this.lvStatistic = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chartStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAll = new System.Windows.Forms.Button();
            this.gbMenu.SuspendLayout();
            this.gbStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).BeginInit();
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
            this.btnBack.Location = new System.Drawing.Point(763, 497);
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
            this.btnExit.Location = new System.Drawing.Point(879, 497);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 110);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStart.Location = new System.Drawing.Point(316, 15);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(140, 25);
            this.lblStart.TabIndex = 11;
            this.lblStart.Text = "Starting date:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnd.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEnd.Location = new System.Drawing.Point(316, 69);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(104, 25);
            this.lblEnd.TabIndex = 11;
            this.lblEnd.Text = "End date:";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpStart.Location = new System.Drawing.Point(480, 12);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(273, 29);
            this.dtpStart.TabIndex = 12;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpEnd.Location = new System.Drawing.Point(480, 65);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(273, 29);
            this.dtpEnd.TabIndex = 12;
            // 
            // gbMenu
            // 
            this.gbMenu.BackColor = System.Drawing.Color.Transparent;
            this.gbMenu.Controls.Add(this.btnFastfood);
            this.gbMenu.Controls.Add(this.btnDrink);
            this.gbMenu.Controls.Add(this.btnDessert);
            this.gbMenu.Controls.Add(this.btnAppetizer);
            this.gbMenu.Controls.Add(this.btnPasta);
            this.gbMenu.Controls.Add(this.btnSalad);
            this.gbMenu.Controls.Add(this.btnSoup);
            this.gbMenu.Controls.Add(this.btnMainCourse);
            this.gbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbMenu.Location = new System.Drawing.Point(26, 108);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(264, 486);
            this.gbMenu.TabIndex = 13;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Menu";
            // 
            // btnFastfood
            // 
            this.btnFastfood.BackColor = System.Drawing.Color.Transparent;
            this.btnFastfood.BackgroundImage = global::SmartOrder.Properties.Resources.Fastfood;
            this.btnFastfood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFastfood.FlatAppearance.BorderSize = 0;
            this.btnFastfood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFastfood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFastfood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFastfood.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFastfood.ForeColor = System.Drawing.Color.SeaShell;
            this.btnFastfood.Location = new System.Drawing.Point(148, 251);
            this.btnFastfood.Name = "btnFastfood";
            this.btnFastfood.Size = new System.Drawing.Size(110, 110);
            this.btnFastfood.TabIndex = 2;
            this.btnFastfood.Text = "Fast\r\n\r\n\r\nFood";
            this.btnFastfood.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFastfood.UseVisualStyleBackColor = false;
            this.btnFastfood.Click += new System.EventHandler(this.btnFastfood_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.BackColor = System.Drawing.Color.Transparent;
            this.btnDrink.BackgroundImage = global::SmartOrder.Properties.Resources.Drinks;
            this.btnDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrink.FlatAppearance.BorderSize = 0;
            this.btnDrink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDrink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrink.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDrink.ForeColor = System.Drawing.Color.SeaShell;
            this.btnDrink.Location = new System.Drawing.Point(148, 19);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(110, 110);
            this.btnDrink.TabIndex = 2;
            this.btnDrink.Text = "Drinks";
            this.btnDrink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDrink.UseVisualStyleBackColor = false;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.BackColor = System.Drawing.Color.Transparent;
            this.btnDessert.BackgroundImage = global::SmartOrder.Properties.Resources.dessert;
            this.btnDessert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDessert.FlatAppearance.BorderSize = 0;
            this.btnDessert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDessert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDessert.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDessert.ForeColor = System.Drawing.Color.SeaShell;
            this.btnDessert.Location = new System.Drawing.Point(148, 367);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(110, 110);
            this.btnDessert.TabIndex = 2;
            this.btnDessert.Text = "Desserts";
            this.btnDessert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDessert.UseVisualStyleBackColor = false;
            this.btnDessert.Click += new System.EventHandler(this.btnDessert_Click);
            // 
            // btnAppetizer
            // 
            this.btnAppetizer.BackColor = System.Drawing.Color.Salmon;
            this.btnAppetizer.BackgroundImage = global::SmartOrder.Properties.Resources.appetizers;
            this.btnAppetizer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAppetizer.FlatAppearance.BorderSize = 0;
            this.btnAppetizer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAppetizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAppetizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppetizer.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAppetizer.ForeColor = System.Drawing.Color.SeaShell;
            this.btnAppetizer.Location = new System.Drawing.Point(148, 135);
            this.btnAppetizer.Name = "btnAppetizer";
            this.btnAppetizer.Size = new System.Drawing.Size(110, 110);
            this.btnAppetizer.TabIndex = 2;
            this.btnAppetizer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAppetizer.UseVisualStyleBackColor = false;
            this.btnAppetizer.Click += new System.EventHandler(this.btnAppetizer_Click);
            // 
            // btnPasta
            // 
            this.btnPasta.BackColor = System.Drawing.Color.Transparent;
            this.btnPasta.BackgroundImage = global::SmartOrder.Properties.Resources.Pasta;
            this.btnPasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasta.FlatAppearance.BorderSize = 0;
            this.btnPasta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPasta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasta.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPasta.ForeColor = System.Drawing.Color.Chocolate;
            this.btnPasta.Location = new System.Drawing.Point(6, 367);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(110, 110);
            this.btnPasta.TabIndex = 2;
            this.btnPasta.Text = "Pastas";
            this.btnPasta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPasta.UseVisualStyleBackColor = false;
            this.btnPasta.Click += new System.EventHandler(this.btnPasta_Click);
            // 
            // btnSalad
            // 
            this.btnSalad.BackColor = System.Drawing.Color.Transparent;
            this.btnSalad.BackgroundImage = global::SmartOrder.Properties.Resources.salata;
            this.btnSalad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalad.FlatAppearance.BorderSize = 0;
            this.btnSalad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalad.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalad.ForeColor = System.Drawing.Color.SeaShell;
            this.btnSalad.Location = new System.Drawing.Point(6, 135);
            this.btnSalad.Name = "btnSalad";
            this.btnSalad.Size = new System.Drawing.Size(110, 110);
            this.btnSalad.TabIndex = 2;
            this.btnSalad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalad.UseVisualStyleBackColor = false;
            this.btnSalad.Click += new System.EventHandler(this.btnSalad_Click);
            // 
            // btnSoup
            // 
            this.btnSoup.BackColor = System.Drawing.Color.Transparent;
            this.btnSoup.BackgroundImage = global::SmartOrder.Properties.Resources.Soup;
            this.btnSoup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSoup.FlatAppearance.BorderSize = 0;
            this.btnSoup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSoup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSoup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoup.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoup.ForeColor = System.Drawing.Color.SeaShell;
            this.btnSoup.Location = new System.Drawing.Point(6, 251);
            this.btnSoup.Name = "btnSoup";
            this.btnSoup.Size = new System.Drawing.Size(110, 110);
            this.btnSoup.TabIndex = 2;
            this.btnSoup.Text = "Soups";
            this.btnSoup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSoup.UseVisualStyleBackColor = false;
            this.btnSoup.Click += new System.EventHandler(this.btnSoup_Click);
            // 
            // btnMainCourse
            // 
            this.btnMainCourse.BackColor = System.Drawing.Color.Transparent;
            this.btnMainCourse.BackgroundImage = global::SmartOrder.Properties.Resources.MeanCourse;
            this.btnMainCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainCourse.FlatAppearance.BorderSize = 0;
            this.btnMainCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMainCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMainCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainCourse.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMainCourse.ForeColor = System.Drawing.Color.SeaShell;
            this.btnMainCourse.Location = new System.Drawing.Point(6, 19);
            this.btnMainCourse.Name = "btnMainCourse";
            this.btnMainCourse.Size = new System.Drawing.Size(110, 110);
            this.btnMainCourse.TabIndex = 2;
            this.btnMainCourse.Text = "Main \r\n\r\n\r\nCourses";
            this.btnMainCourse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMainCourse.UseVisualStyleBackColor = false;
            this.btnMainCourse.Click += new System.EventHandler(this.btnMainCourse_Click);
            // 
            // gbStatistic
            // 
            this.gbStatistic.BackColor = System.Drawing.Color.Transparent;
            this.gbStatistic.Controls.Add(this.lvStatistic);
            this.gbStatistic.Controls.Add(this.chartStatistic);
            this.gbStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbStatistic.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbStatistic.Location = new System.Drawing.Point(315, 108);
            this.gbStatistic.Name = "gbStatistic";
            this.gbStatistic.Size = new System.Drawing.Size(617, 361);
            this.gbStatistic.TabIndex = 14;
            this.gbStatistic.TabStop = false;
            this.gbStatistic.Text = "Statistic";
            // 
            // lvStatistic
            // 
            this.lvStatistic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvStatistic.FullRowSelect = true;
            this.lvStatistic.GridLines = true;
            this.lvStatistic.Location = new System.Drawing.Point(516, 19);
            this.lvStatistic.Name = "lvStatistic";
            this.lvStatistic.Size = new System.Drawing.Size(42, 26);
            this.lvStatistic.TabIndex = 1;
            this.lvStatistic.UseCompatibleStateImageBehavior = false;
            this.lvStatistic.View = System.Windows.Forms.View.Details;
            this.lvStatistic.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            // 
            // chartStatistic
            // 
            this.chartStatistic.BackColor = System.Drawing.Color.Transparent;
            this.chartStatistic.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartStatistic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistic.Legends.Add(legend1);
            this.chartStatistic.Location = new System.Drawing.Point(6, 42);
            this.chartStatistic.Name = "chartStatistic";
            this.chartStatistic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Label = "Sellings";
            series1.Legend = "Legend1";
            series1.Name = "Sellings";
            this.chartStatistic.Series.Add(series1);
            this.chartStatistic.Size = new System.Drawing.Size(605, 295);
            this.chartStatistic.TabIndex = 0;
            this.chartStatistic.Text = "chart1";
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.BackgroundImage = global::SmartOrder.Properties.Resources.AllProducts;
            this.btnAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.Gold;
            this.btnAll.Location = new System.Drawing.Point(26, 15);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(264, 79);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "All Products";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartOrder.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 619);
            this.Controls.Add(this.gbStatistic);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbMenu.ResumeLayout(false);
            this.gbStatistic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnFastfood;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnAppetizer;
        private System.Windows.Forms.Button btnPasta;
        private System.Windows.Forms.Button btnSalad;
        private System.Windows.Forms.Button btnSoup;
        private System.Windows.Forms.Button btnMainCourse;
        private System.Windows.Forms.GroupBox gbStatistic;
        private System.Windows.Forms.ListView lvStatistic;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistic;
        private System.Windows.Forms.Button btnAll;
    }
}