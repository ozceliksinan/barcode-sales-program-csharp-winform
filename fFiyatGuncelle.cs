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
    public partial class fFiyatGuncelle : Form
    {
        public fFiyatGuncelle()
        {
            InitializeComponent();
        }

        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var db = new BarcodeSalesDbEntities())
                {
                    if (db.Urun.Any(x => x.Barkod == tBarkod.Text))
                    {
                        var getir = db.Urun.Where(x => x.Barkod == tBarkod.Text).SingleOrDefault();
                        lBarkod.Text = getir.Barkod;
                        lUrunAdi.Text = getir.UrunAd;
                        double mevcutFiyat = Convert.ToDouble(getir.SatisFiyat);
                        lMevcutFiyat.Text = mevcutFiyat.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Ürün Kayıtlı Değil...");
                    }
                }
            }
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (tYeniFiyat.Text != "" && lBarkod.Text != "")
            {
                using (var db = new BarcodeSalesDbEntities())
                {
                    var guncellenecek = db.Urun.Where(x => x.Barkod == lBarkod.Text).SingleOrDefault();
                    guncellenecek.SatisFiyat = Islemler.DoubleYap(tYeniFiyat.Text);
                    int kdvOrani = Convert.ToInt16(guncellenecek.KdvOrani);
                    Math.Round(Islemler.DoubleYap(tYeniFiyat.Text) * kdvOrani / 100, 2);
                    db.SaveChanges();
                    MessageBox.Show("Yeni Fiyat Kaydedildi...");
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Ürün Okutunuz...");
            }
        }

        private void Temizle()
        {
            lBarkod.Text = "";
            lUrunAdi.Text = "";
            lMevcutFiyat.Text = "";
            tBarkod.Clear();
            tYeniFiyat.Clear();
            tBarkod.Focus();
        }

        private void fFiyatGuncelle_Load(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
