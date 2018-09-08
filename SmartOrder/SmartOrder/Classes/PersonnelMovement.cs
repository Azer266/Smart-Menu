using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SmartOrder.Classes
{
    class PersonnelMovement
    {
        General gnl = new General();
        #region Fields
        private int id;
        private int personnelid;
        private string operation;
        private DateTime date;
        private bool status;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public int Personnelid { get => personnelid; set => personnelid = value; }
        public string Operation { get => operation; set => operation = value; }
        public DateTime Date { get => date; set => date = value; }
        public bool Status { get => status; set => status = value; }
        #endregion

        public bool PersonnelActivionSave(PersonnelMovement pm)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into PersonnelMovements(Personnelid,Operation,Date)VALUES(@personnelid,@operation,@date)", con);
            
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@personnelid", SqlDbType.Int).Value = pm.Personnelid;
                    cmd.Parameters.Add("@operation", SqlDbType.VarChar).Value = pm.Operation;
                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = pm.Date;
                    result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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
    }
}
