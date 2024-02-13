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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void bGiris_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void GirisYap()
        {
            if (tKullaniciAdi.Text != "" && tSifre.Text != "")
            {
                try
                {
                    using (var db = new BarcodeSalesDbEntities())
                    {
                        if (db.Kullanici.Any())
                        {
                            var bak = db.Kullanici.Where(x => x.KullaniciAd == tKullaniciAdi.Text && x.Sifre == tSifre.Text).FirstOrDefault();
                            if (bak != null)
                            {
                                Cursor.Current = Cursors.WaitCursor;

                                // Lisans kontrol //
                                Kontrol kontrol = new Kontrol();
                                if (kontrol.KontrolYap())
                                {
                                    fBaslangic f = new fBaslangic();
                                    f.bSatisIslemi.Enabled = (bool)bak.Satis;
                                    f.bGenelRapor.Enabled = (bool)bak.Rapor;
                                    f.bStok.Enabled = (bool)bak.Stok;
                                    f.bUrunGiris.Enabled = (bool)bak.UrunGiris;
                                    f.bAyarlar.Enabled = (bool)bak.Ayarlar;
                                    f.bFiyatGuncelle.Enabled = (bool)bak.FiyatGuncelle;
                                    f.bYedekleme.Enabled = (bool)bak.Yedekleme;
                                    f.lKullanici.Text = bak.AdSoyad;
                                    var isyeri = db.Sabit.FirstOrDefault();
                                    f.lIsyeri.Text = isyeri.Unvan;
                                    f.Show();
                                    this.Hide();
                                }
                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {
                                MessageBox.Show("Hatalı Giriş...");
                            }
                        }
                        else
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            Kullanici k = new Kullanici();
                            k.AdSoyad = "admin";
                            k.Ayarlar = true;
                            k.EPosta = "admin";
                            k.FiyatGuncelle = true;
                            k.KullaniciAd = "admin";
                            k.Yedekleme = true;
                            k.Rapor = true;
                            k.Satis = true;
                            k.Sifre = "admin";
                            k.Stok = true;
                            k.Telefon = "admin";
                            k.UrunGiris = true;
                            db.Kullanici.Add(k);
                            db.SaveChanges();

                            var bak = db.Kullanici.Where(x => x.KullaniciAd == tKullaniciAdi.Text && x.Sifre == tSifre.Text).FirstOrDefault();
                            fBaslangic f = new fBaslangic();
                            f.bSatisIslemi.Enabled = (bool)bak.Satis;
                            f.bGenelRapor.Enabled = (bool)bak.Rapor;
                            f.bStok.Enabled = (bool)bak.Stok;
                            f.bUrunGiris.Enabled = (bool)bak.UrunGiris;
                            f.bAyarlar.Enabled = (bool)bak.Ayarlar;
                            f.bFiyatGuncelle.Enabled = (bool)bak.FiyatGuncelle;
                            f.bYedekleme.Enabled = (bool)bak.Yedekleme;
                            f.lKullanici.Text = bak.AdSoyad;
                            var isyeri = db.Sabit.FirstOrDefault();
                            f.lIsyeri.Text = isyeri.Unvan;
                            f.Show();
                            this.Hide();
                            Cursor.Current = Cursors.Default;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GirisYap();
            }
        }
    }
}
