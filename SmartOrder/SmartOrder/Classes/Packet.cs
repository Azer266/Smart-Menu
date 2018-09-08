using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SmartOrder.Classes
{
    class Packet
    {
        #region Fields
        private int id;
        private int customerId;
        private int checkId;
        private int paymentTypeId;
        private string description;
        private int status;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public int CheckId { get => checkId; set => checkId = value; }
        public int PaymentTypeId { get => paymentTypeId; set => paymentTypeId = value; }
        public string Description { get => description; set => description = value; }
        public int Status { get => status; set => status = value; }
        #endregion

        General gnl = new General();
        public bool OrderServiceOpen(Packet p)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into PackageOrders(CustomerId,CheckId,PaymentTypeId,Description) values(@customerId,@checkId,@paymentTypeId,@description)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = p.customerId;
                    cmd.Parameters.Add("@checkId", SqlDbType.Int).Value = p.checkId;
                    cmd.Parameters.Add("@paymentTypeId", SqlDbType.Int).Value = p.paymentTypeId;
                    cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = p.description;
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

        public void OrderServiceClose(int id)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update PackageOrders Set PackageOrders.Status=1 Where PackageOrders.CheckId=@checkId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@checkId", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
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
        }

        public int GetPaymentTypeId(int id)
        {
            int paymentType = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select PackageOrders.PaymentTypeId From PackageOrders Inner Join Checks on PackageOrders.CheckId=Checks.Id Where Checks.Id=@checkId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@checkId", SqlDbType.Int).Value = id;
                    paymentType = Convert.ToInt16(cmd.ExecuteScalar());
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
            return paymentType;
        }

        public int GetLastCheckId(int id)
        {
            int nmbr = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Checks.Id From Checks Inner Join PackageOrders on PackageOrders.CheckId=Checks.Id Where (Checks.Status=0) and (PackageOrders.Status=0) and (PackageOrders.CustomerId=@customerId)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = id;
                    nmbr = Convert.ToInt32(cmd.ExecuteScalar());
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
            return nmbr;
        }

        public bool GetControlOpenCheckId(int id)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From Checks where (Status=0) and (Id=@id)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    result = Convert.ToBoolean(cmd.ExecuteScalar());
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
    }
}
