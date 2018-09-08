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
    class Customer
    {
        General gnl = new General();

        #region Fields
        private int id;
        private string name;
        private string surname;
        private string address;
        private string phone;
        private string email;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        #endregion

        public bool IsThereAnyCustomer(string telephone)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "IsThereAnyCustomer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = telephone;
            cmd.Parameters.Add("@result", SqlDbType.Int);
            cmd.Parameters["@result"].Direction = ParameterDirection.Output;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    result = Convert.ToBoolean(cmd.Parameters["@result"].Value);
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public int addClient(Customer c)
        {
            int result = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Customers(Name,Surname,Address,Phone,Email) values(@name,@surname,@address,@phone,@email); Select SCOPE_IDENTITY()", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = c.Name;
                    cmd.Parameters.Add("@surname", SqlDbType.NVarChar).Value = c.Surname;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = c.Address;
                    cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = c.Phone;
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = c.Email;
                    result = Convert.ToInt16(cmd.ExecuteScalar());
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

        public bool updateClient(Customer c)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Customers Set Name=@name, Surname=@surname, Address=@address, Phone=@phone, Email=@email Where Id=@id", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = c.Id;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = c.Name;
                    cmd.Parameters.Add("@surname", SqlDbType.NVarChar).Value = c.Surname;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = c.Address;
                    cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = c.Phone;
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = c.Email;
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

        public void GetByClients(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From Customers", con);
            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    int i = 0;

                    while (dr.Read())
                    {
                        lv.Items.Add(dr["Id"].ToString());
                        lv.Items[i].SubItems.Add(dr["Name"].ToString());
                        lv.Items[i].SubItems.Add(dr["Surname"].ToString());
                        lv.Items[i].SubItems.Add(dr["Address"].ToString());
                        lv.Items[i].SubItems.Add(dr["Phone"].ToString());
                        lv.Items[i].SubItems.Add(dr["Email"].ToString());

                        i++;
                    }
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

        public void GetIdByClient(int id, TextBox name, TextBox surname, TextBox address, TextBox phone, TextBox email)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From Customers Where Id=@id", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        name.Text = dr["Name"].ToString();
                        surname.Text = dr["Surname"].ToString();
                        address.Text = dr["Address"].ToString();
                        phone.Text = dr["Phone"].ToString();
                        email.Text = dr["Email"].ToString();
                    }
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

        public void GetNameByClient(ListView lv, string name)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From Customers Where Name Like @name + '%'", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    int i = 0;

                    while (dr.Read())
                    {
                        lv.Items.Add(dr["Id"].ToString());
                        lv.Items[i].SubItems.Add(dr["Name"].ToString());
                        lv.Items[i].SubItems.Add(dr["Surname"].ToString());
                        lv.Items[i].SubItems.Add(dr["Address"].ToString());
                        lv.Items[i].SubItems.Add(dr["Phone"].ToString());
                        lv.Items[i].SubItems.Add(dr["Email"].ToString());

                        i++;
                    }
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

        public void GetSurnameByClient(ListView lv, string surname)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From Customers Where Surname Like @surname + '%'", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@surname", SqlDbType.NVarChar).Value = surname;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    int i = 0;

                    while (dr.Read())
                    {
                        lv.Items.Add(dr["Id"].ToString());
                        lv.Items[i].SubItems.Add(dr["Name"].ToString());
                        lv.Items[i].SubItems.Add(dr["Surname"].ToString());
                        lv.Items[i].SubItems.Add(dr["Address"].ToString());
                        lv.Items[i].SubItems.Add(dr["Phone"].ToString());
                        lv.Items[i].SubItems.Add(dr["Email"].ToString());

                        i++;
                    }
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

        public void GetTelephoneByClient(ListView lv, string phone)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From Customers Where Phone Like @phone + '%'", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    int i = 0;

                    while (dr.Read())
                    {
                        lv.Items.Add(dr["Id"].ToString());
                        lv.Items[i].SubItems.Add(dr["Name"].ToString());
                        lv.Items[i].SubItems.Add(dr["Surname"].ToString());
                        lv.Items[i].SubItems.Add(dr["Address"].ToString());
                        lv.Items[i].SubItems.Add(dr["Phone"].ToString());
                        lv.Items[i].SubItems.Add(dr["Email"].ToString());

                        i++;
                    }
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

        public void GetByClientDetails(ListView lv, int clientId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select PackageOrders.CustomerId,PackageOrders.CheckId,Customers.Name,Customers.Surname," +
                "CONVERT(varchar(10),Checks.Date,104) as Date From Checks Inner Join PackageOrders on " +
                "PackageOrders.CheckId = Checks.Id Inner Join Customers on PackageOrders.CustomerId = Customers.Id " +
                "Where Checks.ServiceTypeId = 4 and PackageOrders.CustomerId = @customerId", con);
            //Where Checks.ServiceTypeId = 4 and Checks.Status = 0 and PackageOrders.CustomerId = @customerId
            cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = clientId;
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
                        lv.Items.Add(dr["CustomerId"].ToString());
                        lv.Items[counter].SubItems.Add(dr["Name"].ToString());
                        lv.Items[counter].SubItems.Add(dr["Surname"].ToString());
                        lv.Items[counter].SubItems.Add(dr["Date"].ToString());
                        lv.Items[counter].SubItems.Add(dr["CheckId"].ToString());

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
