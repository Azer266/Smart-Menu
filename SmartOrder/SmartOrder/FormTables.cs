using SmartOrder.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartOrder
{
    public partial class FormTables : Form
    {
        public FormTables()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the application?", "Warning !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm frm = new MenuForm();
            this.Close();
            frm.Show();
        }

        private void AllBtnClick(object sender, EventArgs e)
        {
            FormOrders frm = new FormOrders();
            Button clicked = sender as Button;
            General.ButtonValue = clicked.Text.Replace("\n", String.Empty).Replace("\r", String.Empty);
            General.ButtonName = clicked.Name;
            this.Close();
            frm.Show();
        }

        General gnl = new General();
        private void FormTables_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Status,Id From Tables",con);
            SqlDataReader dr = null;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is Button)
                        {
                            if (item.Name == "btnTable" + dr["Id"].ToString() && dr["Status"].ToString() == "1")
                            {
                                item.ForeColor = Color.Green;
                                //item.BackColor = Color.Green;
                                //item.BackgroundImage = (Image)(Properties.Resources.bookTableButtonWhite);
                            }
                            else if (item.Name == "btnTable" + dr["Id"].ToString() && dr["Status"].ToString() == "2")
                            {
                                Table tb = new Table();
                                DateTime dt1 = Convert.ToDateTime(tb.SessionSum(2, dr["Id"].ToString()));
                                DateTime dt2 = DateTime.Now;

                                string st1 = Convert.ToDateTime(tb.SessionSum(2, dr["Id"].ToString())).ToShortTimeString();
                                string st2 = DateTime.Now.ToShortTimeString();

                                DateTime t1 = dt1.AddMinutes(DateTime.Parse(st1).TimeOfDay.TotalMinutes);
                                DateTime t2 = dt2.AddMinutes(DateTime.Parse(st2).TimeOfDay.TotalMinutes);

                                var difference = t2 - t1;

                                //item.Text = String.Format("{0}{1}{2}",
                                //    difference.Days > 0 ? string.Format("{0} Gün", difference.Days) : "",
                                //    difference.Hours > 0 ? string.Format("{0} Saat", difference.Hours) : "",
                                //    difference.Minutes > 0 ? string.Format("{0} Dəqiqə", difference.Minutes) : "").Trim() + " \n\n\n" + dr["Id"].ToString();

                                item.ForeColor = Color.Red;
                            }
                            else if (item.Name == "btnTable" + dr["Id"].ToString() && dr["Status"].ToString() == "3")
                            {
                                item.ForeColor = Color.Silver;
                            }

                            else if (item.Name == "btnTable" + dr["Id"].ToString() && dr["Status"].ToString() == "4")
                            {
                                item.ForeColor = Color.Blue;
                            }
                        }
                    }
                }
                con.Close();
            }
        }
    }
}
