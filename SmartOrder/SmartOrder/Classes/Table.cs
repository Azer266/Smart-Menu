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
    class Table
    {
        General gnl = new General();
        #region Fields
        private int id;
        private int capacity;
        private int serviceTypeId;
        private int status;
        private int ratification;
        private string tableInfo;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int ServiceTypeId { get => serviceTypeId; set => serviceTypeId = value; }
        public int Status { get => status; set => status = value; }
        public int Ratification { get => ratification; set => ratification = value; }
        public string TableInfo { get => tableInfo; set => tableInfo = value; }
        #endregion

        public string SessionSum(int state, string tableId)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Date,TableId From Checks Right Join Tables on Checks.TableId=Tables.Id " +
                "Where Tables.Status=@status and Checks.Status=0 and Tables.Id=@tableId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@status", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@tableId", SqlDbType.Int).Value = Convert.ToInt32(tableId);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        dt = Convert.ToDateTime(dr["date"]).ToString();
                    }
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
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt;
        }

        //public int TableGetByNumber(string TableValue)
        //{
        //    string aa = TableValue;
        //    int length = aa.Length;

        //    return Convert.ToInt32(aa.Substring(length - 1, 1));
        //}

        public bool TableGetByState(int id, int state)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Status from Tables Where Id=@TableId and Status=@state", con);

            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    int control = Convert.ToInt16(cmd.ExecuteScalar());
                    if (control > 0)
                    {
                        result = Convert.ToBoolean(cmd.ExecuteNonQuery());
                    }
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
            return result;
        }

        public void setChangeTableState(string ButonName, int state)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Tables Set Status=@state where Id=@TableNmbr", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                string btnName = ButonName;
                cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;
                cmd.Parameters.Add("@TableNmbr", SqlDbType.Int).Value = btnName.Substring(8);
                cmd.ExecuteNonQuery();
                con.Dispose();
                con.Close();
            }
        }

        public void GetTableCapacity(ComboBox cmb)
        {
            cmb.Items.Clear();
            string state = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From Tables ", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Table t = new Table();
                        if (t.Status == 2)
                        {
                            state = "Dolu";
                        }
                        else if (t.Status == 3)
                        {
                            state = "Açıx Rezervasyon";
                        }
                        else if (t.Status == 4)
                        {
                            state = "Rezerve";
                        }
                        t.Id = Convert.ToInt32(dr["Id"]);
                        t.Capacity = Convert.ToInt32(dr["Capacity"]);
                        t.TableInfo = "Table No: " + Convert.ToInt32(dr["Id"]) + " Capacity: " + Convert.ToInt32(dr["Capacity"]);
                        cmb.Items.Add(t);
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

        public override string ToString()
        {
            return TableInfo;
        }
    }
}
