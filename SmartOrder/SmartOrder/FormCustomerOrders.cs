using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartOrder.Classes;

namespace SmartOrder
{
    public partial class FormCustomerOrders : Form
    {
        public FormCustomerOrders()
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
            FormCustomers frm = new FormCustomers();
            this.Close();
            frm.Show();
        }

        private void FormCustomerOrders_Load(object sender, EventArgs e)
        {
            Check ck = new Check();
            int numberButtons = ck.FindNumberOfOpenPackageChecks();
            ck.getByOpenPacketChecks(LVCustomers);
            int lower = 50;
            int left = 1;
            int chamber = Convert.ToInt32(Math.Ceiling(Math.Sqrt(numberButtons)));

            for (int i = 1; i <= numberButtons; i++)
            {
                Button btn = new Button();
                btn.AutoSize = false;
                btn.Size = new Size(179, 80);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Name = LVCustomers.Items[i - 1].SubItems[0].Text;
                btn.Text = LVCustomers.Items[i - 1].SubItems[1].Text;
                btn.Font = new Font(btn.Font.FontFamily.Name, 18);
                btn.Location = new Point(left, lower);
                this.Controls.Add(btn);

                left += btn.Width + 5;

                if (i==2)
                {
                    left = 1;
                    lower += 50;
                }

                btn.Click += new EventHandler(dynamicMethod);
                btn.MouseEnter += new EventHandler(dynamicMethod2);
            }

        }

        protected void dynamicMethod(object sender, EventArgs e)
        {
            Button dynamicBtn = (sender as Button);
            Packet p = new Packet();
            FormBill frm = new FormBill();
            General.ServiceTypeId = 4;
            General.CheckId = p.GetLastCheckId(Convert.ToInt32(dynamicBtn.Name));
            frm.Show();
        }

        protected void dynamicMethod2(object sender, EventArgs e)
        {
            Button dynamicBtn = (sender as Button);
            Packet p = new Packet();
            Customer ctr = new Customer();
            ctr.GetByClientDetails(LVClientDetails, Convert.ToInt32(dynamicBtn.Name));
            lastOrderDate();
            LVSellingDetails.Items.Clear();
            Selling s = new Selling();
            FormBill frm = new FormBill();
            General.ServiceTypeId = 4;
            //General.CheckId = p.GetLastCheckId(Convert.ToInt32(dynamicBtn.Name));
            lblGeneralTotal.Text = s.GeneralTotal(Convert.ToInt32(dynamicBtn.Name)).ToString() + " $";
        }

        void lastOrderDate()
        {
            if (LVClientDetails.Items.Count>0)
            {
                int i = LVClientDetails.Items.Count;
                lblLastOrderDate.Text = LVClientDetails.Items[i - 1].SubItems[3].Text;
                txtTotal.Text = i + "Ədət";
            }
        }

        void Sum()
        {
            int registerNumber = LVSellingDetails.Items.Count;
            decimal total = 0;
            for (int i = 0; i < registerNumber; i++)
            {
                total += Convert.ToDecimal(LVSellingDetails.Items[i].SubItems[2].Text) * Convert.ToDecimal(LVSellingDetails.Items[i].SubItems[3].Text);
            }
            lblTotalOrder.Text = total.ToString() + " $";
        }

        private void LVClientDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVClientDetails.SelectedItems.Count>0)
            {
                Selling s = new Selling();
                s.packetOrderDetails(LVSellingDetails, Convert.ToInt32(LVClientDetails.SelectedItems[0].SubItems[4].Text));
                Sum();
                lblGeneralTotal.Text = s.GeneralTotal(Convert.ToInt32(LVClientDetails.SelectedItems[0].SubItems[0].Text)).ToString() + " $";
            }
        }
    }
}
