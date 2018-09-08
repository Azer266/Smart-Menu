using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SmartOrder.Classes;

namespace SmartOrder
{
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the application?", "Warning !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm frm = new MenuForm();
            this.Close();
            frm.Show();
        }

        private void Statistic(string title, int ctrId, Color c)
        {
            chartStatistic.Palette = ChartColorPalette.None;
            chartStatistic.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chartStatistic.Series[0].Color = c;
            gbStatistic.Text = title;
            chartStatistic.Series["Sellings"].Points.Clear();
            Product p = new Product();
            p.ProductListByStatisticWithCtrId(lvStatistic, dtpStart, dtpEnd, ctrId);

            if (lvStatistic.Items.Count > 0)
            {
                chartStatistic.Series["Sellings"].Points.Clear();
                for (int i = 0; i < lvStatistic.Items.Count; i++)
                {
                    chartStatistic.Series["Sellings"].Points.AddXY(lvStatistic.Items[i].SubItems[0].Text, lvStatistic.Items[i].SubItems[1].Text);
                }
            }
            else
            {
                MessageBox.Show("There are no statistics to show.");
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            chartStatistic.Palette = ChartColorPalette.None;
            chartStatistic.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chartStatistic.Series[0].Color = Color.Silver;
            Product p = new Product();
            p.ProductsListByStatistic(lvStatistic, dtpStart, dtpEnd);
            gbStatistic.Text = "All";

            if (lvStatistic.Items.Count > 0)
            {
                chartStatistic.Series["Sellings"].Points.Clear();
                for (int i = 0; i < lvStatistic.Items.Count; i++)
                {
                    chartStatistic.Series["Sellings"].Points.AddXY(lvStatistic.Items[i].SubItems[0].Text, lvStatistic.Items[i].SubItems[1].Text);
                }
            }
            else
            {
                MessageBox.Show("There are no statistics to show.");
            }
        }

        private void btnMainCourse_Click(object sender, EventArgs e)
        {
            Statistic("Main Courses Statistic", 1, Color.Maroon);
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            Statistic("Drinks Statistic", 2, Color.OrangeRed);
        }

        private void btnSalad_Click(object sender, EventArgs e)
        {
            Statistic("Salad Statistic", 3, Color.Red);
        }

        private void btnAppetizer_Click(object sender, EventArgs e)
        {
            Statistic("Appetizer Statistic", 4, Color.Salmon);
        }

        private void btnSoup_Click(object sender, EventArgs e)
        {
            Statistic("Soup Statistic", 5, Color.YellowGreen);
        }

        private void btnFastfood_Click(object sender, EventArgs e)
        {
            Statistic("Fast food Statistic", 6, Color.SaddleBrown);
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            Statistic("Pasta Statistic", 7, Color.GreenYellow);
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            Statistic("Dessert Statistic", 8, Color.PaleGreen);
        }
    }
}
