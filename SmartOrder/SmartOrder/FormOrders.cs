using System;
using System.Collections;
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
    public partial class FormOrders : Form
    {
        public FormOrders()
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
            FormTables frm = new FormTables();
            this.Close();
            frm.Show();
        }

        private void AmountOperation(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            txtAmount.Text += clicked.Text;
        }

        int tableId; int checkId;
        private void FormOrders_Load(object sender, EventArgs e)
        {
            lblTableNumber.Text = General.ButtonValue;
            Table tb = new Table();
            tableId = Convert.ToInt16(General.ButtonValue);

            if (tb.TableGetByState(tableId, 2) == true || tb.TableGetByState(tableId, 4) == true)
            {
                Check ck = new Check();
                checkId = ck.getByCheck(tableId);
                Selling orders = new Selling();
                orders.getByOrder(LVOrders, checkId);
            }
        }

        private void GetByCategory(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            Category ctr = new Category();
            ctr.getByProductTypes(LVMenu, clicked);
        }

        int counter = 0; int counter2 = 0; //counter2 istifade olunmaya biler
        private void LVMenu_DoubleClick(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                txtAmount.Text = "1";
            }
            if (LVMenu.Items.Count > 0)
            {
                counter = LVOrders.Items.Count;
                LVOrders.Items.Add(LVMenu.SelectedItems[0].Text);
                LVOrders.Items[counter].SubItems.Add(txtAmount.Text);
                LVOrders.Items[counter].SubItems.Add(LVMenu.SelectedItems[0].SubItems[2].Text);
                LVOrders.Items[counter].SubItems.Add((Convert.ToDecimal(LVMenu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal(txtAmount.Text)).ToString());
                LVOrders.Items[counter].SubItems.Add("0");
                counter2 = LVNewAdd.Items.Count;
                LVOrders.Items[counter].SubItems.Add(counter2.ToString());

                LVNewAdd.Items.Add(checkId.ToString());
                LVNewAdd.Items[counter2].SubItems.Add(LVMenu.SelectedItems[0].SubItems[2].Text);
                LVNewAdd.Items[counter2].SubItems.Add(txtAmount.Text);
                LVNewAdd.Items[counter2].SubItems.Add(tableId.ToString());
                LVNewAdd.Items[counter2].SubItems.Add(counter2.ToString());

                counter2++;
                txtAmount.Text = "";
            }
        }

        ArrayList deleted = new ArrayList();
        private void btnOrder_Click(object sender, EventArgs e)
        {
            /** 
             1 Table Empty
             2 Table Full
             3 Table Reserved
             4 Full Reserved
            */

            Table tb = new Table();
            Check ck = new Check();
            FormTables frmTable = new FormTables();
            Selling saveOrder = new Selling();

            bool result = false;
            if (tb.TableGetByState(tableId, 1) == true)
            {
                ck.ServiceTypeId = 1;
                ck.Personnelid = 1;
                ck.TableId = tableId;
                ck.Date = DateTime.Now;
                result = ck.setByCheckNew(ck);
                tb.setChangeTableState(General.ButtonName, 2);

                if (LVOrders.Items.Count > 0)
                {
                    for (int i = 0; i < LVOrders.Items.Count; i++)
                    {
                        saveOrder.TableId = tableId;
                        saveOrder.ProductId = Convert.ToInt32(LVOrders.Items[i].SubItems[2].Text);
                        saveOrder.CheckId = ck.getByCheck(tableId);
                        saveOrder.Quantity = Convert.ToInt32(LVOrders.Items[i].SubItems[1].Text);
                        saveOrder.setSaveOrder(saveOrder);
                    }
                    this.Close();
                    frmTable.Show();
                }
            }
            else if (tb.TableGetByState(tableId, 2) == true || tb.TableGetByState(tableId, 4) == true)
            {
                if (LVNewAdd.Items.Count > 0)
                {
                    for (int i = 0; i < LVNewAdd.Items.Count; i++)
                    {
                        saveOrder.TableId = tableId;
                        saveOrder.ProductId = Convert.ToInt32(LVNewAdd.Items[i].SubItems[1].Text);
                        saveOrder.CheckId = ck.getByCheck(tableId);
                        saveOrder.Quantity = Convert.ToInt32(LVNewAdd.Items[i].SubItems[2].Text);
                        saveOrder.setSaveOrder(saveOrder);
                    }
                }
                if (deleted.Count > 0)
                {
                    foreach (string item in deleted)
                    {
                        saveOrder.setDeleteOrder(Convert.ToInt32(item));
                    }
                }
                this.Close();
                frmTable.Show();
            }
            else if (tb.TableGetByState(tableId, 3) == true)
            {
                //ck.ServiceTypeId = 1;
                //ck.Personnelid = 1;
                //ck.TableId = tableId;
                //ck.Date = DateTime.Now;
                //result = ck.setByCheckNew(ck);
                tb.setChangeTableState(General.ButtonName, 4);

                if (LVOrders.Items.Count > 0)
                {
                    for (int i = 0; i < LVOrders.Items.Count; i++)
                    {
                        saveOrder.TableId = tableId;
                        saveOrder.ProductId = Convert.ToInt32(LVOrders.Items[i].SubItems[2].Text);
                        saveOrder.CheckId = ck.getByCheck(tableId);
                        saveOrder.Quantity = Convert.ToInt32(LVOrders.Items[i].SubItems[1].Text);
                        saveOrder.setSaveOrder(saveOrder);
                    }
                    this.Close();
                    frmTable.Show();
                }
            }
        }

        private void LVOrders_DoubleClick(object sender, EventArgs e)
        {
            if (LVOrders.Items.Count > 0)
            {
                if (LVOrders.SelectedItems[0].SubItems[4].Text != "0")
                {
                    Selling saveOrder = new Selling();
                    saveOrder.setDeleteOrder(Convert.ToInt32(LVOrders.SelectedItems[0].SubItems[4].Text));
                }
                else
                {
                    for (int i = 0; i < LVNewAdd.Items.Count; i++)
                    {
                        if (LVNewAdd.Items[i].SubItems[4].Text == LVOrders.SelectedItems[0].SubItems[5].Text)
                        {
                            LVNewAdd.Items.RemoveAt(i);
                        }
                    }
                }

                LVOrders.Items.RemoveAt(LVOrders.SelectedItems[0].Index);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "";
                LVMenu.Items.Clear();
            }
            else
            {
                Category ctr = new Category();
                ctr.getByProductSearch(LVMenu, Convert.ToInt16(txtSearch.Text));
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            General.CheckId = checkId;
            General.ServiceTypeId = 5;
            FormBill frm = new FormBill();
            this.Close();
            frm.Show();
        }
    }
}
