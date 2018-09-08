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
    class Category
    {
        General gnl = new General();

        #region Fields
        private int id;
        private string categoryName;
        private string description;
        private bool status;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public string Description { get => description; set => description = value; }
        public bool Status { get => status; set => status = value; }
        #endregion

        public void getByProductTypes(ListView lv, Button btn)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select ProductName, Price, Products.Id from Categories Inner Join Products on Categories.Id=Products.CategoryId Where Categories.Description=@description and Categories.Status=0", con);

            string ctrName = btn.Name.Substring(3);
            cmd.Parameters.AddWithValue("@description", ctrName);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                int counter = 0;

                while (dr.Read())
                {
                    lv.Items.Add(dr["ProductName"].ToString());
                    lv.Items[counter].SubItems.Add(dr["Price"].ToString());
                    lv.Items[counter].SubItems.Add(dr["Id"].ToString());

                    counter++;
                }
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }

        public void getByProductSearch(ListView lv, int id)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Products Where Id=@id and Categories.Status=0", con);
            
            cmd.Parameters.AddWithValue("@id", id);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;

                while (dr.Read())
                {
                    lv.Items.Add(dr["ProductName"].ToString());
                    lv.Items[i].SubItems.Add(dr["Price"].ToString());
                    lv.Items[i].SubItems.Add(dr["Id"].ToString());

                    i++;
                }
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        //urunCesitleriniGetir
        public void GetCategories(ComboBox cmb)
        {
            cmb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From Categories Where Status = 0", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Category c = new Category();
                        c.Id = Convert.ToInt32(dr["Id"]);
                        c.CategoryName = Convert.ToString(dr["CategoryName"]);
                        c.Description = dr["Description"].ToString();
                        cmb.Items.Add(c);
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
        //urunCesitleriniGetir
        public void GetCategories(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From Categories Where Status = 0", con);
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
                        lv.Items[i].SubItems.Add(dr["CategoryName"].ToString());
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
        //urunCesitleriniGetir
        public void CategorySearch(ListView lv, string name)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From Categories Where Status = 0 and CategoryName Like '%' + @name + '%'", con);
            cmd.Parameters.AddWithValue("@name", name);
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
                        lv.Items[i].SubItems.Add(dr["CategoryName"].ToString());
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
        //urunKategoriEkle
        public int AddCategory(Category c)
        {
            int result = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Categories(CategoryName,Description) values(@categoryName,@description)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@categoryName", SqlDbType.NVarChar).Value = c.CategoryName;
                    cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = c.Description;
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
        //urunKategoriGuncelle
        public int UpdateCategory(Category c)
        {
            int result = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Categories Set CategoryName=@categoryName, Description=@description Where Id=@id", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = c.Id;
                    cmd.Parameters.Add("@categoryName", SqlDbType.NVarChar).Value = c.CategoryName;
                    cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = c.Description;
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
        //urunKategoriSil
        public int DeleteCategory(int id)
        {
            int result = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Categories Set Status=1 Where Id=@id", con);
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

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
