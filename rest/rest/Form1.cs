using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        cGeneral gnl = new cGeneral();

        private void Form1_Load(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.personelGetByInformation(cbKullanici);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            cPersoneller per = new cPersoneller();
            bool result = per.personelEntryControl(txtSifre.Text, cGeneral._personelId);

            if (result)
            {
                cPersonelHareketleri ph = new cPersonelHareketleri();
                ph.PersonelId = cGeneral._personelId;
                ph.Islem = "Giris Yapti";
                ph.Tarih = DateTime.Now;
                ph.PersonelActionSave(ph);

                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }

            else
            {
                MessageBox.Show("Sifre Yalnis?", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cbKullanici.SelectedItem;
            cGeneral._personelId = p.PersonelId;
            cGeneral._gorevId = p.PersonelGorevId;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Warning !!!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
