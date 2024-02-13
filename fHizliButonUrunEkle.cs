using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeSalesProgram
{
    public partial class fHizliButonUrunEkle : Form
    {
        public fHizliButonUrunEkle()
        {
            InitializeComponent();
        }

        // Veritabanı değişkeni //
        BarcodeSalesDbEntities db = new BarcodeSalesDbEntities();

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text != "")
            {
                string urunAd = tUrunAra.Text;
                var urunler = db.Urun.Where(a => a.UrunAd.Contains(urunAd)).ToList();
                gridHizliButonEkleUrunler.DataSource = urunler;
            }
        }

        // Satıra çift tıklanınca ürün eklensin //
        private void gridHizliButonEkleUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Satır sayısı 0 ise işlem yapılmasın //
            if (gridHizliButonEkleUrunler.Rows.Count > 0)
            {
                // Bilgiler //
                int id = Convert.ToInt16(lButonID.Text);
                string barkod = gridHizliButonEkleUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                string urunAd = gridHizliButonEkleUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                double fiyat = Convert.ToDouble(gridHizliButonEkleUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString());

                // Güncelleme bilgileri //
                var guncellenecek = db.HizliUrun.Find(id);
                guncellenecek.Barkod = barkod;
                guncellenecek.UrunAd = urunAd;
                guncellenecek.Fiyat = fiyat;
                db.SaveChanges();
                MessageBox.Show("Hızlı Buton Tanımlandı.");

                // Forma veriyi gönderme //
                fSatis f = (fSatis)Application.OpenForms["fSatis"];
                if (f != null)
                {
                    Button b = f.Controls.Find("bHizli" + id, true).FirstOrDefault() as Button;
                    b.Text = urunAd + "\n" + fiyat.ToString("C2");
                }
            }
        }

        private void chTumu_CheckedChanged(object sender, EventArgs e)
        {
            if (chTumu.Checked)
            {
                gridHizliButonEkleUrunler.DataSource = db.Urun.ToList();
                gridHizliButonEkleUrunler.Columns["AlisFiyat"].Visible = false;
                gridHizliButonEkleUrunler.Columns["SatisFiyat"].Visible = false;
                gridHizliButonEkleUrunler.Columns["KdvOrani"].Visible = false;
                gridHizliButonEkleUrunler.Columns["KdvTutari"].Visible = false;
                gridHizliButonEkleUrunler.Columns["Miktar"].Visible = false;
                Islemler.GridDuzenle(gridHizliButonEkleUrunler);
            }
            else
            {
                gridHizliButonEkleUrunler.DataSource = null;
            }
        }
    }
}
