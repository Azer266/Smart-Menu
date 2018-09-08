using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SmartOrder.Classes
{
    class Payment
    {
        General gnl = new General();
        #region Fields
        private int id;
        private int checkId;
        private int paymentTypeId;
        private int customerId;
        private decimal subtotal;
        private decimal tax;
        private decimal discount;
        private decimal total;
        private DateTime date;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public int CheckId { get => checkId; set => checkId = value; }
        public int PaymentTypeId { get => paymentTypeId; set => paymentTypeId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public decimal Tax { get => tax; set => tax = value; }
        public decimal Discount { get => discount; set => discount = value; }
        public decimal Total { get => total; set => total = value; }
        public DateTime Date { get => date; set => date = value; }
        #endregion

        public bool billClose(Payment p)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into BillPayments(CheckId,PaymentTypeId,CustomerId,Subtotal,Tax,Discount,Total) values(@checkId,@paymentTypeId,@customerId,@subtotal,@tax,@discount,@total)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@checkId", SqlDbType.Int).Value = p.checkId;
                    cmd.Parameters.Add("@paymentTypeId", SqlDbType.Int).Value = p.paymentTypeId;
                    cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = p.customerId;
                    cmd.Parameters.Add("@subtotal", SqlDbType.Decimal).Value = p.subtotal;
                    cmd.Parameters.Add("@tax", SqlDbType.Decimal).Value = p.tax;
                    cmd.Parameters.Add("@discount", SqlDbType.Decimal).Value = p.discount;
                    cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = p.total;
                    result = Convert.ToBoolean(cmd.ExecuteNonQuery());
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }

        public decimal TotalAmountForCustumer(int id)
        {
            decimal total = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select sum(Total) as TotalAmount From BillPayments Where CustomerId=@customerId)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = id;
                    total = Convert.ToDecimal(cmd.ExecuteScalar());
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return total;
        }
    }
}
