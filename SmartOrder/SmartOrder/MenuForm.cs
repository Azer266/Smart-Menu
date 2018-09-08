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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnTables_Paint(object sender, PaintEventArgs e)
        {
            Font myFont = new Font("Algerian", 20);

            Brush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Sienna);
            e.Graphics.TranslateTransform(10, 115);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Tables", myFont, myBrush, 0, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the application?", "Warning !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            FormTables frm = new FormTables();
            this.Close();
            frm.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            FormReservation frm = new FormReservation();
            this.Close();
            frm.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FormCustomers frm = new FormCustomers();
            this.Close();
            frm.Show();
        }

        private void btnPackageService_Click(object sender, EventArgs e)
        {
            FormPacket frm = new FormPacket();
            this.Close();
            frm.Show();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            FormKitchen frm = new FormKitchen();
            this.Close();
            frm.Show();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            FormCasingOperations frm = new FormCasingOperations();
            this.Close();
            frm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReports frm = new FormReports();
            this.Close();
            frm.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FormSettings frm = new FormSettings();
            this.Close();
            frm.Show();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            FormLock frm = new FormLock();
            this.Close();
            frm.Show();
        }
    }
}
