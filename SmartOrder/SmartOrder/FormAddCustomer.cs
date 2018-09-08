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
    public partial class FormAddCustomer : Form
    {
        public FormAddCustomer()
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

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            if (General.CustomerId > 0)
            {
                Customer ctr = new Customer();
                txtNo.Text = General.CustomerId.ToString();
                ctr.GetIdByClient(Convert.ToInt32(txtNo.Text), txtName, txtSurname, txtAddress, txtTelephone, txtEmail);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTelephone.Text.Length == 10)
            {
                if (txtName.Text == "" || txtSurname.Text == "")
                {
                    MessageBox.Show("The name or surname field can not be left blank.");
                }
                else
                {
                    Customer ctr = new Customer();
                    bool result = ctr.IsThereAnyCustomer(txtTelephone.Text);
                    if (!result)
                    {
                        ctr.Name = txtName.Text;
                        ctr.Surname = txtSurname.Text;
                        ctr.Phone = txtTelephone.Text;
                        ctr.Address = txtAddress.Text;
                        ctr.Email = txtEmail.Text;
                        txtNo.Text = ctr.addClient(ctr).ToString();
                        if (txtNo.Text != "0")
                        {
                            MessageBox.Show("Customer successfully added");
                            FormCustomers frm = new FormCustomers();
                            this.Close();
                            frm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Customer add failed !!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This customer already exists !!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("The phone number must consist of 10 characters !!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTelephone.Text.Length == 10)
            {
                if (txtName.Text == "" || txtSurname.Text == "")
                {
                    MessageBox.Show("The name or surname field can not be left blank.");
                }
                else
                {
                    Customer ctr = new Customer();
                    ctr.Id = Convert.ToInt32(txtNo.Text);
                    ctr.Name = txtName.Text;
                    ctr.Surname = txtSurname.Text;
                    ctr.Phone = txtTelephone.Text;
                    ctr.Address = txtAddress.Text;
                    ctr.Email = txtEmail.Text;
                    bool result = ctr.updateClient(ctr);
                    if (result)
                    {
                        if (txtNo.Text != "0")
                        {
                            MessageBox.Show("Customer successfully updated");
                            FormCustomers frm = new FormCustomers();
                            this.Close();
                            frm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Customer update failed !!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This customer already exists !!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("The phone number must consist of 10 characters !!!");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (General.addCustomer == 0)
            {
                FormReservation frm = new FormReservation();
                General.addCustomer = 1;
                this.Close();
                frm.Show();
            }
            else if (General.addCustomer == 1)
            {
                FormOrders frm = new FormOrders();
                General.addCustomer = 1;
                this.Close();
                frm.Show();
            }
        }
    }
}
