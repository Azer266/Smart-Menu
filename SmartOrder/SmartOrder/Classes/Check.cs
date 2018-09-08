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
    class Check
    {
        General gnl = new General();

        #region Fields
        private int id;
        private int serviceTypeId;
        private int personnelid;
        private int tableId;
        private DateTime date;
        private int status;
        private decimal sum;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public int ServiceTypeId { get => serviceTypeId; set => serviceTypeId = value; }
        public int Personnelid { get => personnelid; set => personnelid = value; }
        public int TableId { get => tableId; set => tableId = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Status { get => status; set => status = value; }
        public decimal Sum { get => sum; set => sum = value; }
        #endregion
        
        public int getByCheck(int id)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 Id from Checks Where TableId=@tableId Order by Id desc", con);

            cmd.Parameters.Add("@tableId", SqlDbType.Int).Value = id;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    id = Convert.ToInt32(cmd.ExecuteScalar());
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
            return id;
        }

        public bool setByCheckNew(Check c)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Checks(ServiceTypeId,Date,Personnelid,TableId,Status) values(@serviceTypeId,@date,@personnelid,@tableId,@status)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@serviceTypeId", SqlDbType.Int).Value = c.serviceTypeId;
                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = c.date;
                    cmd.Parameters.Add("@personnelid", SqlDbType.Int).Value = c.personnelid;
                    cmd.Parameters.Add("@tableId", SqlDbType.Int).Value = c.tableId;
                    cmd.Parameters.Add("@status", SqlDbType.Bit).Value = 0;
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

        public void CheckClose(int id, int state)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Checks set Status = @state Where Id=@checkId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@checkId", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;
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

        public int FindNumberOfOpenPackageChecks()
        {
            int result = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select count(*) as Number From Checks Where (Status=0) and (ServiceTypeId=4)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void getByOpenPacketChecks(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select PackageOrders.CustomerId, " +
                "Customers.Name + ' ' + Customers.Surname as Client, Checks.Id as CheckId from PackageOrders " +
                "Inner Join Customers on Customers.Id=PackageOrders.CustomerId " +
                "Inner Join Checks on Checks.Id=PackageOrders.CheckId Where Checks.Status=0", con);
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
                        lv.Items[counter].SubItems.Add(dr["Client"].ToString());
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

        //public void getByClientDetails(ListView lv, int clientId)
        //{
        //    lv.Items.Clear();
        //    SqlConnection con = new SqlConnection(gnl.conString);
        //    SqlCommand cmd = new SqlCommand("Select PackageOrders.CustomerId,PackageOrders.CheckId,Customers.Name,Customers.Surname,CONVERT(varchar(10),Checks.Date,104) as Date " +
        //        "From Checks Inner Join PackageOrders on PackageOrders.CheckId = Checks.Id Inner Join Customers on PackageOrders.CustomerId = Customers.Id" +
        //        "Where Checks.ServiceTypeId = 4 and Checks.Status = 1 and PackageOrders.CustomerId = @clientId", con);
        //    SqlDataReader dr = null;

        //    try
        //    {
        //        if (con.State == ConnectionState.Closed)
        //        {
        //            con.Open();
        //            dr = cmd.ExecuteReader();
        //            int counter = 0;

        //            while (dr.Read())
        //            {
        //                lv.Items.Add(dr["CustomerId"].ToString());
        //                lv.Items[counter].SubItems.Add(dr["Name"].ToString());
        //                lv.Items[counter].SubItems.Add(dr["Surname"].ToString());
        //                lv.Items[counter].SubItems.Add(dr["Date"].ToString());
        //                lv.Items[counter].SubItems.Add(dr["CheckId"].ToString());

        //                counter++;
        //            }
        //            con.Close();
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        string error = ex.Message;
        //    }
        //    finally
        //    {
        //        dr.Close();
        //        con.Dispose();
        //        con.Close();
        //    }
        //}

        public int OpenReservation(Check c)
        {
            int result = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Checks(ServiceTypeId,Date,Personnelid,TableId,Status) " +
                "values(@serviceTypeId,@date,@personnelid,@tableId,@status); Select scope_IDENTITY()", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@serviceTypeId", SqlDbType.Int).Value = c.serviceTypeId;
                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = c.date;
                    cmd.Parameters.Add("@personnelid", SqlDbType.Int).Value = c.personnelid;
                    cmd.Parameters.Add("@tableId", SqlDbType.Int).Value = c.tableId;
                    cmd.Parameters.Add("@status", SqlDbType.Int).Value = 1;
                    result = Convert.ToInt32(cmd.ExecuteScalar());
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
