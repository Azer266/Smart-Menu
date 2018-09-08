using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SmartOrder.Classes
{
    class Selling
    {
        General gnl = new General();

        #region Fields
        private int id;
        private int checkId;
        private int productId;
        private int tableId;
        private int quantity;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public int CheckId { get => checkId; set => checkId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int TableId { get => tableId; set => tableId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        #endregion

        public void getByOrder(ListView lv, int id)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select ProductName, Price, Sellings.Id, Sellings.ProductId, Sellings.Quantity from Sellings Inner Join Products on Sellings.ProductId=Products.Id Where Sellings.CheckId=@checkId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@checkId", SqlDbType.Int).Value = id;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    int counter = 0;

                    while (dr.Read())
                    {
                        lv.Items.Add(dr["ProductName"].ToString());
                        lv.Items[counter].SubItems.Add(dr["Quantity"].ToString());
                        lv.Items[counter].SubItems.Add(dr["ProductId"].ToString());
                        lv.Items[counter].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["Price"]) * Convert.ToDecimal(dr["Quantity"])));
                        lv.Items[counter].SubItems.Add(dr["Id"].ToString());

                        counter++;
                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }

        public bool setSaveOrder(Selling information)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Sellings(CheckId,ProductId,Quantity,TableId) values(@checkId,@productId,@quantity,@tableId)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@checkId", SqlDbType.Int).Value = information.checkId;
                    cmd.Parameters.Add("@productId", SqlDbType.Int).Value = information.productId;
                    cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = information.quantity;
                    cmd.Parameters.Add("@tableId", SqlDbType.Int).Value = information.tableId;
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

        public void setDeleteOrder(int id)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Delete from Sellings Where Id=@id", con);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Dispose();
                con.Close();
            }
        }

        public decimal GeneralTotal(int clientId)
        {
            decimal Total = 0;

            //Select SUM(dbo.Sellings.Quantity* dbo.Products.Price) AS Price FROM " +
            //    "Customers INNER JOIN dbo.PackageOrders ON dbo.Customers.Id = dbo.PackageOrders.CustomerId " +
            //    "INNER JOIN dbo.Checks ON dbo.Checks.Id = dbo.PackageOrders.CheckId " +
            //    "INNER JOIN dbo.Sellings ON dbo.Checks.Id = dbo.Sellings.CheckId " +
            //    "INNER JOIN dbo.Products ON dbo.Products.Id = dbo.Sellings.ProductId " +
            //    "WHERE(dbo.PackageOrders.CustomerId = @customerId) AND(dbo.PackageOrders.Status = 0)

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select SUM(Total) From BillPayments Where CustomerId=@customerId", con);

            cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = clientId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    Total = Convert.ToDecimal(cmd.ExecuteScalar());
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
            return Total;
        }

        public void packetOrderDetails(ListView lv, int id)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Sellings.Id as sellingId,Products.ProductName,Products.Price,Sellings.Quantity " +
                "From Sellings Inner Join Checks ON Checks.Id=Sellings.CheckId Inner Join Products ON Products.Id=Sellings.ProductId " +
                "Where Sellings.CheckId=@checkId", con);
            cmd.Parameters.Add("@checkId", SqlDbType.Int).Value = id;
            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    int counter = 0;

                    while (dr.Read())
                    {
                        lv.Items.Add(dr["sellingId"].ToString());
                        lv.Items[counter].SubItems.Add(dr["ProductName"].ToString());
                        lv.Items[counter].SubItems.Add(dr["Quantity"].ToString());
                        lv.Items[counter].SubItems.Add(dr["Price"].ToString());

                        counter++;
                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
    }
}
