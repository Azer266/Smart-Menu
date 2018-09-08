using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartOrder.Classes
{
    class Personnel
    {
        General gnl = new General();
        #region Fields
        private int personnelid;
        private int personnelDutyId;
        private string personnelName;
        private string personnelSurname;
        private string personnelPassword;
        private string personnelUsername;
        private bool personnelStatus;
        #endregion

        #region Properties
        public int Personnelid { get => personnelid; set => personnelid = value; }
        public int PersonnelDutyId { get => personnelDutyId; set => personnelDutyId = value; }
        public string PersonnelName { get => personnelName; set => personnelName = value; }
        public string PersonnelSurname { get => personnelSurname; set => personnelSurname = value; }
        public string PersonnelPassword { get => personnelPassword; set => personnelPassword = value; }
        public string PersonnelUsername { get => personnelUsername; set => personnelUsername = value; }
        public bool PersonnelStatus { get => personnelStatus; set => personnelStatus = value; }
        #endregion

        public bool PersonnelEntryControl(string password, int userId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From Personnels Where Id=@ID and Password=@password and Status=0", con);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = userId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    result = Convert.ToBoolean(cmd.ExecuteScalar());
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }
            return result;
        }

        public void GetPersonnel(ComboBox cmb)
        {
            cmb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From Personnels Where Status=0", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Personnel p = new Personnel();
                        p.Personnelid = Convert.ToInt32(dr["Id"]);
                        p.PersonnelDutyId = Convert.ToInt32(dr["DutyId"]);
                        p.PersonnelName = dr["Name"].ToString();
                        p.PersonnelSurname = dr["Surname"].ToString();
                        p.PersonnelPassword = dr["Password"].ToString();
                        p.PersonnelUsername = dr["Username"].ToString();
                        p.PersonnelStatus = Convert.ToBoolean(dr["Status"]);
                        cmb.Items.Add(p);
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
        }

        public override string ToString()
        {
            return PersonnelName + " " + PersonnelSurname;
        }

        public void GetPersonnelsInfo(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Personnels.*, PersonnelDuties.Duty From Personnels " +
                "Inner Join PersonnelDuties On PersonnelDuties.Id=Personnels.DutyId " +
                "Where Personnels.Status=0", con);
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
                        lv.Items[i].SubItems.Add(dr["DutyId"].ToString());
                        lv.Items[i].SubItems.Add(dr["Duty"].ToString());
                        lv.Items[i].SubItems.Add(dr["Name"].ToString());
                        lv.Items[i].SubItems.Add(dr["Surname"].ToString());
                        i++;
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
        }

        public void GetPersonnelInfoById(ListView lv, int id)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Personnels.*, PersonnelDuties.Duty, From Personnels " +
                "Inner Join PersonnelDuties On PersonnelDuties.Id=Personnels.DutyId " +
                "Where Personnels.Status=0 and Personnels.Id=@id", con);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
                        lv.Items[i].SubItems.Add(dr["DutyId"].ToString());
                        lv.Items[i].SubItems.Add(dr["Duty"].ToString());
                        lv.Items[i].SubItems.Add(dr["Name"].ToString());
                        lv.Items[i].SubItems.Add(dr["Surname"].ToString());
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

        public string GetPersonnelName(int id)
        {
            string result = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Name + ' '+ Surname From Personnels Where Personnels.Status=0 and Personnels.Id=@id", con);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    result = cmd.ExecuteScalar().ToString();
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

        public bool SetPasswordChange(int id, string password)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Personnels Set Password=@password where Id=@id", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
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

        public bool AddPersonnel(Personnel p)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Personnels(DutyId,Name,Surname,Password) values(@dutyId,@name,@surname,@password)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@dutyId", SqlDbType.Int).Value = p.PersonnelDutyId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = p.PersonnelName;
                    cmd.Parameters.Add("@surname", SqlDbType.NVarChar).Value = p.PersonnelSurname;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = p.PersonnelPassword;
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

        public bool UpdatePersonnel(Personnel p)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Personnels Set DutyId=@dutyId, Name=@name, Surname=@surname Where Id=@id", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = p.Personnelid;
                    cmd.Parameters.Add("@dutyId", SqlDbType.Int).Value = p.PersonnelDutyId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = p.PersonnelName;
                    cmd.Parameters.Add("@surname", SqlDbType.NVarChar).Value = p.PersonnelSurname;
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

        public bool DeletePersonnel(int id)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Personnels Set Status=1 Where Id=@id", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
    }
}
