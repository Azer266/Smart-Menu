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
    class PersonnelDuty
    {
        General gnl = new General();
        #region Fields
        private int id;
        private string duty;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Duty { get => duty; set => duty = value; }
        #endregion

        public void GetByPersonnelsDuty(ComboBox cmb)
        {
            cmb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From PersonnelDuties", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        PersonnelDuty p = new PersonnelDuty();
                        p.Id = Convert.ToInt32(dr["Id"]);
                        p.Duty = dr["Duty"].ToString();
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

        public string GetByPersonnelDuty(int id)
        {
            string result = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Duty From PersonnelDuties Where Id=@id", con);
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
            return result;
        }

        public override string ToString()
        {
            return Duty;
        }
    }
}
