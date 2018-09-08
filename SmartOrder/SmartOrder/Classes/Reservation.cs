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
    class Reservation
    {
        General gnl = new General();
        #region Fields
        private int id;
        private int customerId;
        private int tableId;
        private int checkId;
        private int numberOfPeople;
        private DateTime date;
        private string description;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public int TableId { get => tableId; set => tableId = value; }
        public int CheckId { get => checkId; set => checkId = value; }
        public int NumberOfPeople { get => numberOfPeople; set => numberOfPeople = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Description { get => description; set => description = value; }
        #endregion

        public int GetByCustomer(int id)
        {
            int clientId = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 CustomerId From Reservations Where TableId=@tableId order by TableId Desc", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@tableId", SqlDbType.Int).Value = id;
                    clientId = Convert.ToInt32(cmd.ExecuteScalar());
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
            return clientId;
        }

        public bool ReservationClose(int id)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Reservations set Status=0 Where CheckId=@checkId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@checkId", SqlDbType.Int).Value = id;
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

        public void GetByClientsId(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Reservations.CustomerId,(Name + Surname) as Client From Reservations" +
                "Inner Join Customers On Reservations.CustomerId=Customers.Id Where Reservations.Status=0", con);
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
                        lv.Items.Add(dr["CustomerId"].ToString());
                        lv.Items[i].SubItems.Add(dr["Client"].ToString());

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

        public void GetOldReservation(ListView lv, int clientId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Reservations.CustomerId, Customers.Name, Customers.Surname, CheckId, Date From Reservations" +
                "Inner Join Customers On Reservations.CustomerId=Customers.Id " +
                "Where Reservations.CustomerId=@ClientId and Reservations.Status=1 order by Reservations.Id Desc", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@ClientId", SqlDbType.Int).Value = clientId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    int i = 0;

                    while (dr.Read())
                    {
                        lv.Items.Add(dr["CustomerId"].ToString());
                        lv.Items[i].SubItems.Add(dr["Name"].ToString());
                        lv.Items[i].SubItems.Add(dr["Surname"].ToString());
                        lv.Items[i].SubItems.Add(dr["CheckId"].ToString());
                        lv.Items[i].SubItems.Add(dr["Date"].ToString());

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

        public DateTime GetLastReservationDate(int clientId)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Date From Reservations" +
                "Where Reservations.CustomerId=@ClientId and Reservations.Status=1 order by Reservations.Id Desc", con);
            cmd.Parameters.Add("@ClientId", SqlDbType.Int).Value = clientId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    dt = Convert.ToDateTime(cmd.ExecuteScalar());
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
            return date;
        }

        public int OpenReservationNumber()
        {
            int number = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select count(*) From Reservations Where Reservations.Status=0", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    number = Convert.ToInt32(cmd.ExecuteNonQuery());
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
            return number;
        }

        public bool GetControlOpenReservation(int clientId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 Reservations.Id From Reservations " +
                "Where Reservations.CustomerId=@ClientId and Status=1 order by Id Desc", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@ClientId", SqlDbType.Int).Value = clientId;
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

        public bool OpenReservation(Reservation r)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Reservations(CustomerId,TableId,CheckId,NumberOfPeople,Date,Description) " +
                "values(@customerId,@tableId,@checkId,@numberOfPeople,@date,@description)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = r.CustomerId;
                    cmd.Parameters.Add("@tableId", SqlDbType.Int).Value = r.TableId;
                    cmd.Parameters.Add("@checkId", SqlDbType.Int).Value = r.CheckId;
                    cmd.Parameters.Add("@numberOfPeople", SqlDbType.Int).Value = r.NumberOfPeople;
                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = r.Date;
                    cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = r.Description;
                    result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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

        public int GetByTableId(int clientId)
        {
            int result = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Reservations.TableId From Reservations" +
                "Inner Join Checks On Reservations.CheckId=Checks.Id Where (Reservations.Status=1) " +
                "and Checks.Status=0 and Reservations.CustomerId=@ClientId", con);
            cmd.Parameters.Add("@ClientId", SqlDbType.Int).Value = clientId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
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
