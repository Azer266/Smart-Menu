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
    class Product
    {
        General gnl = new General();

        #region Fields
        private int id;
        private int categoryId;
        private string productName;
        private decimal price;
        private string description;
        private bool status;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public decimal Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public bool Status { get => status; set => status = value; }
        #endregion

        //urunleriListele
        public void ProductsList(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Products.*, Categories.CategoryName From Products " +
                "Inner Join Categories On Categories.Id=Products.CategoryId " +
                "Where Products.Status=0", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    int i = 0;
                    while (dr.Read())
                    {
                        lv.Items.Add(dr["Id"].ToString());
                        lv.Items[i].SubItems.Add(dr["CategoryId"].ToString());
                        lv.Items[i].SubItems.Add(dr["CategoryName"].ToString());
                        lv.Items[i].SubItems.Add(dr["ProductName"].ToString());
                        lv.Items[i].SubItems.Add(string.Format("{0:0#00.0}", dr["Price"].ToString()));
                        lv.Items[i].SubItems.Add(dr["Description"].ToString());
                        i++;
                    }
                    dr.Close();
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }
        //urunleriListeleByUrunAdi
        public void GetProductByName(ListView lv, string name)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Products.*, Categories.CategoryName From Products " +
                "Inner Join Categories On Categories.Id=Products.CategoryId " +
                "Where Products.Status = 0 and ProductName like '%' + @name + '%'", con);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    int i = 0;
                    while (dr.Read())
                    {
                        lv.Items.Add(dr["Id"].ToString());
                        lv.Items[i].SubItems.Add(dr["CategoryId"].ToString());
                        lv.Items[i].SubItems.Add(dr["CategoryName"].ToString());
                        lv.Items[i].SubItems.Add(dr["ProductName"].ToString());
                        lv.Items[i].SubItems.Add(string.Format("{0:0#00.0}", dr["Price"].ToString()));
                        lv.Items[i].SubItems.Add(dr["Description"].ToString());
                        i++;
                    }
                    dr.Close();
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }
        //urunleriListeleByUrunAdi - ID gore listeleme
        public void GetProductById(ListView lv, int ctrId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Products.*, Categories.CategoryName From Products " +
                "Inner Join Categories On Categories.Id=Products.CategoryId " +
                "Where Products.Status=0 and CategoryId=@ctrid", con);
            cmd.Parameters.Add("@ctrid", SqlDbType.Int).Value = ctrId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    int i = 0;
                    while (dr.Read())
                    {
                        lv.Items.Add(dr["Id"].ToString());
                        lv.Items[i].SubItems.Add(dr["CategoryId"].ToString());
                        lv.Items[i].SubItems.Add(dr["CategoryName"].ToString());
                        lv.Items[i].SubItems.Add(dr["ProductName"].ToString());
                        lv.Items[i].SubItems.Add(string.Format("{0:0#00.0}", dr["Price"].ToString()));
                        lv.Items[i].SubItems.Add(dr["Description"].ToString());
                        i++;
                    }
                    dr.Close();
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }
        //urunleriListeleStatistiklereGore
        public void ProductsListByStatistic(ListView lv, DateTimePicker start, DateTimePicker finish)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 10 Products.ProductName, SUM(Sellings.Quantity) as Quantity From Categories " +
                "Inner Join Products ON Categories.Id=Products.CategoryId " +
                "Inner Join Sellings ON Products.Id=Sellings.ProductId " +
                "Inner Join Checks On Sellings.CheckId=Checks.Id " +
                "Where (CONVERT(datetime,Date,104) BETWEEN CONVERT(datetime,@start,104) AND CONVERT(datetime,@finish,104)) " +
                "group by Products.ProductName order by Quantity desc", con);
            //DateTime yerine VarChar ola biler
            cmd.Parameters.Add("@start", SqlDbType.DateTime).Value = start.Value.ToShortDateString();
            cmd.Parameters.Add("@finish", SqlDbType.DateTime).Value = finish.Value.ToShortDateString();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    int i = 0;
                    while (dr.Read())
                    {
                        lv.Items.Add(dr["ProductName"].ToString());
                        lv.Items[i].SubItems.Add(dr["Quantity"].ToString());
                        i++;
                    }
                    dr.Close();
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }
        //urunleriListeleStatistiklereGoreId
        public void ProductListByStatisticWithCtrId(ListView lv, DateTimePicker start, DateTimePicker finish, int CtrId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 10 Products.ProductName, SUM(Sellings.Quantity) as Quantity From Categories " +
                "Inner Join Products ON Categories.Id=Products.CategoryId " +
                "Inner Join Sellings ON Products.Id=Sellings.ProductId " +
                "Inner Join Checks On Sellings.CheckId=Checks.Id " +
                "Where (CONVERT(datetime,Date,104) BETWEEN CONVERT(datetime,@start,104) " +
                "AND CONVERT(datetime,@finish,104)) AND (Products.CategoryId=@categoryId)" +
                "group by Products.ProductName order by Quantity desc", con);
            //DateTime yerine VarChar ola biler
            cmd.Parameters.Add("@start", SqlDbType.DateTime).Value = start.Value.ToShortDateString();
            cmd.Parameters.Add("@finish", SqlDbType.DateTime).Value = finish.Value.ToShortDateString();
            cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = CtrId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    int i = 0;
                    while (dr.Read())
                    {
                        lv.Items.Add(dr["ProductName"].ToString());
                        lv.Items[i].SubItems.Add(dr["Quantity"].ToString());
                        i++;
                    }
                    dr.Close();
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }
        //urunEkle
        public int AddProduct(Product p)
        {
            int result = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Products(CategoryId,ProductName,Price,Description) values(@categoryId,@productName,@price,@description)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = p.CategoryId;
                    cmd.Parameters.Add("@productName", SqlDbType.NVarChar).Value = p.ProductName;
                    cmd.Parameters.Add("@price", SqlDbType.Money).Value = p.Price;
                    cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = p.Description;
                    result = Convert.ToInt32(cmd.ExecuteNonQuery());
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
        //urunGuncelle
        public int UpdateProduct(Product p)
        {
            int result = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Products Set CategoryId=@categoryId, ProductName=@productName, Price=@price, Description=@description Where Id=@id", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = p.Id;
                    cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = p.CategoryId;
                    cmd.Parameters.Add("@productName", SqlDbType.NVarChar).Value = p.ProductName;
                    cmd.Parameters.Add("@price", SqlDbType.Money).Value = p.Price;
                    cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = p.Description;
                    result = Convert.ToInt32(cmd.ExecuteNonQuery());
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
        //urunSil
        public int DeleteProduct(int id)
        {
            int result = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Products Set Status=1 Where Id=@id", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    result = Convert.ToInt32(cmd.ExecuteNonQuery());
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
        //urunSil
        public int DeleteProductSameCatgory(int ctrId)
        {
            int result = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Products Set Status=1 Where CategoryId=@id", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = ctrId;
                    result = Convert.ToInt32(cmd.ExecuteNonQuery());
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
        //if ile urunSil
        public int DeleteProductSameCatgory(int id,int control)
        {
            int result = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            string sql = "Update Products Set Status=1 Where ";
            if (control == 1)
            {
                sql += "CategoryId=@id";
            }
            else
            {
                sql += "Id=@id";
            }
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    result = Convert.ToInt32(cmd.ExecuteNonQuery());
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
    }
}
