using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rest
{
    class cUrunCesitleri
    {
        cGeneral gnl = new cGeneral();

        #region Fields
        private int _UrunTurNo;
        private string _KategoriAd;
        private string _Aciklama;
        #endregion

        #region Properties
        public int UrunTurNo { get => _UrunTurNo; set => _UrunTurNo = value; }
        public string KategoriAd { get => _KategoriAd; set => _KategoriAd = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        #endregion

        public void getByProductTypes(ListView Cesitler, Button btn)
        {
            Cesitler.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select URUNAD, FIYAT, urunler.ID from kategoriler Inner Join urunler on kategoriler.ID=urunler.KATEGORIID Where urunler.KATEGORIID=@KATEGORIID", con);

            string aa = btn.Name;
            int uzunluk = aa.Length;
            cmd.Parameters.Add("@KATEGORIID", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();
            int sayac = 0;

            while (dr.Read())
            {
                Cesitler.Items.Add(dr["URUNAD"].ToString());
                Cesitler.Items[sayac].SubItems.Add(dr["FIYAT"].ToString());
                Cesitler.Items[sayac].SubItems.Add(dr["ID"].ToString());

                sayac++;
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
    }
}
