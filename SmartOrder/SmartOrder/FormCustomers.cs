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
    public partial class FormCustomers : Form
    {
        public FormCustomers()
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

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            Customer ctr = new Customer();
            ctr.GetByClients(LVCustomers);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddCustomer frm = new FormAddCustomer();
            General.addCustomer = 1;
            frm.btnUpdate.Visible = false;
            frm.btnAdd.Visible = true;
            this.Close();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (LVCustomers.SelectedItems.Count > 0)
            {
                FormAddCustomer frm = new FormAddCustomer();
                General.addCustomer = 1;
                General.CustomerId = Convert.ToInt32(LVCustomers.SelectedItems[0].SubItems[0].Text);
                frm.btnAdd.Visible = false;
                frm.btnUpdate.Visible = true;
                this.Close();
                frm.Show();
            }
        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
            Customer ctr = new Customer();
            ctr.GetNameByClient(LVCustomers, txtClientName.Text);
        }

        private void txtClientSurname_TextChanged(object sender, EventArgs e)
        {
            Customer ctr = new Customer();
            ctr.GetSurnameByClient(LVCustomers, txtClientSurname.Text);
        }

        private void txtClientPhone_TextChanged(object sender, EventArgs e)
        {
            Customer ctr = new Customer();
            ctr.GetTelephoneByClient(LVCustomers, txtClientPhone.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtClientCheckId.Text != "")
            {
                General.CheckId = Convert.ToInt32(txtClientCheckId.Text);
                Packet package = new Packet();
                bool result = package.GetControlOpenCheckId(General.CheckId);
                if (result)
                {
                    FormBill frm = new FormBill();
                    General.ServiceTypeId = 4;
                    this.Close();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("There is no admission number " + txtClientCheckId.Text);
                }
            }
            else
            {
                MessageBox.Show("Please enter the check number");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FormCustomerOrders frm = new FormCustomerOrders();
            this.Close();
            frm.Show();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
