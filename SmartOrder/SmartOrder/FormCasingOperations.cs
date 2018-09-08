using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartOrder
{
    public partial class FormCasingOperations : Form
    {
        public FormCasingOperations()
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

        private void FormCasingOperations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.DataSet1.DataTable2);
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
            this.rvMonthly.RefreshReport();
            this.rvDaily.RefreshReport();
            rvDaily.Visible = false;
            lblReport.ForeColor = Color.Gainsboro;
            lblReport.Text = "Monthly Report";
        }

        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            lblReport.ForeColor = Color.Gainsboro;
            lblReport.Text = "Monthly Report";
            rvMonthly.Visible = true;
            rvDaily.Visible = false;
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            lblReport.ForeColor = Color.Gold;
            lblReport.Text = "Daily Report";
            rvMonthly.Visible = false;
            rvDaily.Visible = true;
        }
    }
}
