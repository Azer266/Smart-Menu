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
    public partial class FormReservation : Form
    {
        public FormReservation()
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

        private void FormReservation_Load(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.GetByClients(LVCustomers);

            Table t = new Table();
            t.GetTableCapacity(cmbTable);

            dtpDate.MinDate = DateTime.Today;
            dtpDate.Format = DateTimePickerFormat.Time;
        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.GetNameByClient(LVCustomers, txtClientName.Text);
        }

        private void txtClientPhone_TextChanged(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.GetTelephoneByClient(LVCustomers, txtClientPhone.Text);
        }

        void clear()
        {
            txtClientName.Clear();
            txtClientPhone.Clear();
            txtClientAddress.Clear();
            txtDate.Clear();
            txtTable.Clear();
            txtPerson.Clear();
        }

        private void btnRezervationOpen_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            if (LVCustomers.SelectedItems.Count > 0)
            {
                bool result = r.GetControlOpenReservation(Convert.ToInt32(LVCustomers.SelectedItems[0].SubItems[0].Text));
                if (!result)
                {
                    if (txtDate.Text != "")
                    {
                        if (txtPerson.Text != "")
                        {
                            Table t = new Table();
                            if (t.TableGetByState(Convert.ToInt32(txtTableNo.Text), 1))
                            {
                                Check c = new Check();
                                c.Date = Convert.ToDateTime(txtDate.Text);
                                c.ServiceTypeId = 5;
                                c.TableId = Convert.ToInt32(txtTableNo.Text);
                                c.Personnelid = General.pId;

                                r.CustomerId = Convert.ToInt32(LVCustomers.SelectedItems[0].SubItems[0].Text);
                                r.TableId = Convert.ToInt32(txtTableNo.Text);
                                r.Date = Convert.ToDateTime(txtDate.Text);
                                r.NumberOfPeople = Convert.ToInt32(txtPerson.Text);
                                r.Description = txtDescription.Text;
                                r.CheckId = c.OpenReservation(c);
                                result = r.OpenReservation(r);

                                t.setChangeTableState("00000000" + txtTableNo.Text, 3);

                                if (result)
                                {
                                    MessageBox.Show("Your reservation has been opened.");
                                    clear();
                                }
                                else
                                {
                                    MessageBox.Show("Your reservation could not be opened.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("The table you want to book is currently full.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select number of person.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select date.");
                    }
                }
                else
                {
                    MessageBox.Show("There is an open reservation on this customer.");
                }
            }
            else
            {
                MessageBox.Show("Please select customer.");
            }
        }

        private void dtpDate_MouseEnter(object sender, EventArgs e)
        {
            dtpDate.Width = 200;
        }

        private void dtpDate_Enter(object sender, EventArgs e)
        {
            dtpDate.Width = 200;
        }

        private void dtpDate_MouseLeave(object sender, EventArgs e)
        {
            dtpDate.Width = 20;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            txtDate.Text = dtpDate.Value.ToString();
        }

        private void cmbPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPerson.Text = cmbPerson.SelectedItem.ToString();
        }

        private void cmbPerson_MouseEnter(object sender, EventArgs e)
        {
            cmbPerson.Width = 200;
        }

        private void cmbPerson_MouseLeave(object sender, EventArgs e)
        {
            cmbPerson.Width = 20;
        }

        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPerson.Enabled = true;
            txtTable.Text = cmbTable.SelectedItem.ToString();

            Table capacity = (Table)cmbTable.SelectedItem;
            int cpt = capacity.Capacity;
            txtTableNo.Text = capacity.Id.ToString();

            cmbPerson.Items.Clear();
            for (int i = 0; i < cpt; i++)
            {
                cmbPerson.Items.Add(i + 1);
            }
        }

        private void cmbTable_MouseEnter(object sender, EventArgs e)
        {
            cmbTable.Width = 300;
        }

        private void cmbTable_MouseLeave(object sender, EventArgs e)
        {
            cmbTable.Width = 20;
        }

        private void btnCustomerOrder_Click(object sender, EventArgs e)
        {
            FormCustomerOrders frm = new FormCustomerOrders();
            this.Close();
            frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddCustomer frm = new FormAddCustomer();
            General.addCustomer = 0;
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
                General.addCustomer = 0;
                General.CustomerId = Convert.ToInt32(LVCustomers.SelectedItems[0].SubItems[0].Text);
                frm.btnUpdate.Visible = true;
                frm.btnAdd.Visible = false;
                this.Close();
                frm.Show();
            }
        }
    }
}
