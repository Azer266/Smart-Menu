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
    public partial class FormBill : Form
    {
        public FormBill()
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
            FormOrders frm = new FormOrders();
            this.Close();
            frm.Show();
        }

        Selling sell = new Selling();
        int paymentType = 0;
        private void FormBill_Load(object sender, EventArgs e)
        {
            if (General.ServiceTypeId == 5)
            {
                lblCheckId.Text = General.CheckId.ToString();
                txtActivity.TextChanged += new EventHandler(txtActivity_TextChanged);
                sell.getByOrder(LVBill, General.CheckId);
                if (LVBill.Items.Count > 0)
                {
                    decimal Total = 0;
                    for (int i = 0; i < LVBill.Items.Count; i++)
                    {
                        Total += Convert.ToDecimal(LVBill.Items[i].SubItems[3].Text);
                    }
                    lblTotalPrice.Text = String.Format("{0:0.00}", Total);
                    lblPriceToPay.Text = String.Format("{0:0.00}", Total);
                    decimal tax = Convert.ToDecimal(lblPriceToPay.Text) * 18 / 100;
                    lblTax.Text = String.Format("{0:0.00}", tax);
                }
                gbActivity.Visible = false;
                txtActivity.Clear();
            }
            else if (General.ServiceTypeId == 4)
            {
                lblCheckId.Text = General.CheckId.ToString();
                txtActivity.TextChanged += new EventHandler(txtActivity_TextChanged);
                sell.getByOrder(LVBill, General.CheckId);
                Packet p = new Packet();
                paymentType = p.GetPaymentTypeId(Convert.ToInt16(lblCheckId.Text));
                if (paymentType == 1)
                {
                    rbCash.Checked = true;
                }
                else if (paymentType == 2)
                {
                    rbCreditCard.Checked = true;
                }
                else if (paymentType == 3)
                {
                    rbTicket.Checked = true;
                }
                if (LVBill.Items.Count > 0)
                {
                    decimal Total = 0;
                    for (int i = 0; i < LVBill.Items.Count; i++)
                    {
                        Total += Convert.ToDecimal(LVBill.Items[i].SubItems[3].Text);
                    }
                    lblTotalPrice.Text = String.Format("{0:0.00}", Total);
                    lblPriceToPay.Text = String.Format("{0:0.00}", Total);
                    decimal tax = Convert.ToDecimal(lblPriceToPay.Text) * 18 / 100;
                    lblTax.Text = String.Format("{0:0.00}", tax);
                }
            }
        }

        private void txtActivity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtActivity.Text) < (Convert.ToDecimal(lblTotalPrice.Text)))
                {
                    try
                    {
                        lblDiscount.Text = String.Format("{0:0.00}", Convert.ToDecimal(txtActivity.Text));
                    }
                    catch (Exception)
                    {

                        lblDiscount.Text = String.Format("{0:0.00}", 0);
                    }
                }
                else
                {
                    MessageBox.Show("Discount can not be more than total amount !!!");
                }
            }
            catch (Exception)
            {

                lblDiscount.Text = String.Format("{0:0.00}", 0);
            }
        }

        private void cbxDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDiscount.Checked)
            {
                gbActivity.Visible = true;
                txtActivity.Clear();
            }
            else
            {
                gbActivity.Visible = false;
                txtActivity.Clear();
            }
        }

        private void lblDiscount_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblDiscount.Text) > 0)
            {
                decimal payable = 0;
                lblPriceToPay.Text = lblTotalPrice.Text;
                payable = Convert.ToDecimal(lblPriceToPay.Text) - Convert.ToDecimal(lblDiscount.Text);
                lblPriceToPay.Text = String.Format("{0:0.00}", payable);
            }

            decimal tax = Convert.ToDecimal(lblPriceToPay.Text) * 18 / 100;
            lblTax.Text = String.Format("{0:0.00}", tax);
        }

        Table tb = new Table();
        Reservation reserve = new Reservation();
        Payment pay = new Payment();
        Check ck = new Check();
        Packet package = new Packet();
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (General.ServiceTypeId == 5)
            {
                int tableId = Convert.ToInt32(General.ButtonValue);
                int clientId = 0;

                if (tb.TableGetByState(tableId,4) == true)
                {
                    clientId = reserve.GetByCustomer(tableId);
                }
                else
                {
                    clientId = 1;
                }

                if (rbTicket.Checked)
                {
                    paymentType = 3;
                }
                else if (rbCreditCard.Checked)
                {
                    paymentType = 2;
                }
                else if (rbCash.Checked)
                {
                    paymentType = 1;
                }

                pay.CheckId = Convert.ToInt16(lblCheckId.Text);
                pay.PaymentTypeId = paymentType;
                pay.CustomerId = clientId;
                pay.Subtotal = Convert.ToDecimal(lblPriceToPay.Text);
                pay.Tax = Convert.ToDecimal(lblTax.Text);
                pay.Discount = Convert.ToDecimal(lblDiscount.Text);
                pay.Total = Convert.ToDecimal(lblTotalPrice.Text);

                bool result = pay.billClose(pay);
                if (result)
                {
                    MessageBox.Show("Payment occurred.");
                    tb.setChangeTableState(General.ButtonName, 1);
                    reserve.ReservationClose(Convert.ToInt16(lblCheckId.Text));
                    ck.CheckClose(Convert.ToInt16(lblCheckId.Text), 0);

                    this.Close();
                    FormTables frm = new FormTables();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Payment was not made. Please notify the authorities.");
                }
            }
            else if (General.ServiceTypeId == 4)
            {
                pay.CheckId = Convert.ToInt16(lblCheckId.Text);
                pay.PaymentTypeId = paymentType;
                pay.CustomerId = 1; //müşterinin paket sifariş id gelecek
                pay.Subtotal = Convert.ToDecimal(lblPriceToPay.Text);
                pay.Tax = Convert.ToDecimal(lblTax.Text);
                pay.Discount = Convert.ToDecimal(lblDiscount.Text);
                pay.Total = Convert.ToDecimal(lblTotalPrice.Text);

                bool result = pay.billClose(pay);
                if (result)
                {
                    MessageBox.Show("Payment occurred.");
                    ck.CheckClose(Convert.ToInt16(lblCheckId.Text), 1);
                    package.OrderServiceClose(Convert.ToInt16(lblCheckId.Text));

                    this.Close();
                    MenuForm frm = new MenuForm();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Payment was not made. Please notify the authorities.");
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        Font Title = new Font("Verdana", 15, FontStyle.Bold);
        Font Subtitle = new Font("Verdana", 12, FontStyle.Regular);
        Font Content = new Font("Verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Konak Restaurant", Title, sb, 350, 100, sf);
            e.Graphics.DrawString("................", Subtitle, sb, 350, 120, sf);
            e.Graphics.DrawString("Product Name         Quantity        Price", Subtitle, sb, 150, 250, sf);
            e.Graphics.DrawString("...........................................", Subtitle, sb, 150, 200, sf);
            for (int i = 0; i < LVBill.Items.Count; i++)
            {
                e.Graphics.DrawString(LVBill.Items[i].SubItems[0].Text, Content, sb, 150, 300 + i * 30, sf);
                e.Graphics.DrawString(LVBill.Items[i].SubItems[1].Text, Content, sb, 350, 300 + i * 30, sf);
                e.Graphics.DrawString(LVBill.Items[i].SubItems[3].Text, Content, sb, 420, 300 + i * 30, sf);
            }
            e.Graphics.DrawString("...........................................", Subtitle, sb, 150, 300 + 30 * LVBill.Items.Count, sf);
            e.Graphics.DrawString("Discount     ......" + lblDiscount.Text + " AZN", Subtitle, sb, 250, 300 + 30 * (LVBill.Items.Count + 1), sf);
            e.Graphics.DrawString("Tax          ......" + lblTax.Text + " AZN", Subtitle, sb, 250, 300 + 30 * (LVBill.Items.Count + 2), sf);
            e.Graphics.DrawString("Total        ......" + lblTotalPrice.Text + " AZN", Subtitle, sb, 250, 300 + 30 * (LVBill.Items.Count + 3), sf);
            e.Graphics.DrawString("Price to Pay ......" + lblPriceToPay.Text + " AZN", Subtitle, sb, 250, 300 + 30 * (LVBill.Items.Count + 4), sf);
        }
    }
}
