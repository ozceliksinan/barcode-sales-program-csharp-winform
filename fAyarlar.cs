using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeSalesProgram
{
    public partial class fAyarlar : Form
    {
        public fAyarlar()
        {
            InitializeComponent();
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (bKaydet.Text == "Kaydet")
            {
                if (tAdSoyad.Text != "" && tTelefon.Text != "" && tEposta.Text != "" && tKullanici.Text != "" && tSifre.Text != "" && tSifreTekrar.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        try
                        {
                            using (var db = new BarcodeSalesDbEntities())
                            {
                                if (!db.Kullanici.Any(x => x.KullaniciAd == tKullanici.Text))
                                {
                                    Kullanici k = new Kullanici();
                                    k.AdSoyad = tAdSoyad.Text;
                                    k.Telefon = tTelefon.Text;
                                    k.EPosta = tEposta.Text;
                                    k.KullaniciAd = tKullanici.Text.Trim();
                                    k.Sifre = tSifre.Text;

                                    // Checkbox check
                                    k.Satis = chSatisEkrani.Checked;
                                    k.Rapor = chRaporEkrani.Checked;
                                    k.Stok = chStok.Checked;
                                    k.UrunGiris = chUrunGiris.Checked;
                                    k.Ayarlar = chAyarlar.Checked;
                                    k.FiyatGuncelle = chFiyatGuncelle.Checked;
                                    k.Yedekleme = chYedekleme.Checked;

                                    // Add & Save Database
                                    db.Kullanici.Add(k);
                                    db.SaveChanges();
                                    MessageBox.Show("Yeni Kullanıcı Eklendi...");
                                    Temizle();
                                    Doldur();
                                }
                                else
                                {
                                    MessageBox.Show("Bu Kullanıcı Zaten Kayıtlı...");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girilen Şifreler Uyuşmamaktadır...");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz...");
                }
            }
            else if (bKaydet.Text == "Düzenle")
            {
                if (tAdSoyad.Text != "" && tTelefon.Text != "" && tEposta.Text != "" && tKullanici.Text != "" && tSifre.Text != "" && tSifreTekrar.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        int id = Convert.ToInt16(lKullaniciId.Text);
                        using (var db = new BarcodeSalesDbEntities())
                        {
                            var guncelle = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                            guncelle.AdSoyad = tAdSoyad.Text;
                            guncelle.Telefon = tTelefon.Text;
                            guncelle.EPosta = tEposta.Text;
                            guncelle.KullaniciAd = tKullanici.Text.Trim();
                            guncelle.Sifre = tSifre.Text;

                            // Checkbox check
                            guncelle.Satis = chSatisEkrani.Checked;
                            guncelle.Rapor = chRaporEkrani.Checked;
                            guncelle.Stok = chStok.Checked;
                            guncelle.UrunGiris = chUrunGiris.Checked;
                            guncelle.Ayarlar = chAyarlar.Checked;
                            guncelle.FiyatGuncelle = chFiyatGuncelle.Checked;
                            guncelle.Yedekleme = chYedekleme.Checked;

                            db.SaveChanges();
                            MessageBox.Show("Kullanıcı Güncellemesi Yapıldı");
                            bKaydet.Text = "Kaydet";
                            Temizle();
                            Doldur();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girilen Şifreler Uyuşmamaktadır...");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz...");
                }
            }
        }

        private void Temizle()
        {
            tAdSoyad.Clear();
            tTelefon.Clear();
            tEposta.Clear();
            tKullanici.Clear();
            tSifre.Clear();
            tSifreTekrar.Clear();
            chSatisEkrani.Checked = false;
            chRaporEkrani.Checked = false;
            chStok.Checked = false;
            chUrunGiris.Checked = false;
            chAyarlar.Checked = false;
            chFiyatGuncelle.Checked = false;
            chYedekleme.Checked = false;

            tAdSoyad.Focus();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridListeKullanici.Rows.Count > 0)
            {
                int id = Convert.ToInt32(gridListeKullanici.CurrentRow.Cells["Id"].Value.ToString());
                lKullaniciId.Text = id.ToString();
                using (var db = new BarcodeSalesDbEntities())
                {
                    var getir = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                    tAdSoyad.Text = getir.AdSoyad;
                    tTelefon.Text = getir.Telefon;
                    tEposta.Text = getir.EPosta;
                    tKullanici.Text = getir.KullaniciAd;
                    tSifre.Text = getir.Sifre;
                    tSifreTekrar.Text = getir.Sifre;
                    chSatisEkrani.Checked = (bool)getir.Satis;
                    chRaporEkrani.Checked = (bool)getir.Rapor;
                    chStok.Checked = (bool)getir.Stok;
                    chUrunGiris.Checked = (bool)getir.UrunGiris;
                    chAyarlar.Checked = (bool)getir.Ayarlar;
                    chFiyatGuncelle.Checked = (bool)getir.FiyatGuncelle;
                    chYedekleme.Checked = (bool)getir.Yedekleme;

                    bKaydet.Text = "Düzenle";
                    Doldur();
                }
            }
            else
            {
                MessageBox.Show("Kullanici Seçiniz...");
            }
        }

        private void fAyarlar_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Doldur();
            Cursor.Current = Cursors.Default;
        }

        private void Doldur()
        {
            using (var db = new BarcodeSalesDbEntities())
            {
                if (db.Kullanici.Any())
                {
                    gridListeKullanici.DataSource = db.Kullanici.Select(x => new { x.Id, x.AdSoyad, x.KullaniciAd, x.Telefon, x.EPosta }).ToList();

                }
                Islemler.SabitVarsayilan();
                var yazici = db.Sabit.FirstOrDefault();
                chYazmaDurumu.Checked = (bool)yazici.Yazici;

                var sabitler = db.Sabit.FirstOrDefault();
                tKartKomisyon.Text = sabitler.KartKomisyon.ToString();

                var teraziOnEk = db.Terazi.ToList();
                cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                cmbTeraziOnEk.ValueMember = "Id";
                cmbTeraziOnEk.DataSource = teraziOnEk;

                tIsyeriAdSoyad.Text = sabitler.AdSoyad;
                tIsyeriUnvan.Text = sabitler.Unvan;
                tIsyeriAdres.Text = sabitler.Adres;
                tIsyeriTelefon.Text = sabitler.Telefon;
                tIsyeriEposta.Text = sabitler.Eposta;
            }
        }

        private void chYazmaDurumu_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new BarcodeSalesDbEntities())
            {
                if (chYazmaDurumu.Checked)
                {
                    Islemler.SabitVarsayilan();
                    var ayarla = db.Sabit.FirstOrDefault();
                    ayarla.Yazici = true;
                    db.SaveChanges();
                    chYazmaDurumu.Text = "Yazma Durumu Aktif";
                }
                else
                {
                    Islemler.SabitVarsayilan();
                    var ayarla = db.Sabit.FirstOrDefault();
                    ayarla.Yazici = false;
                    db.SaveChanges();
                    chYazmaDurumu.Text = "Yazma Durumu Pasif";
                }
            }
        }

        private void bKartKomisyonAyarla_Click(object sender, EventArgs e)
        {
            if (tKartKomisyon.Text != "")
            {
                using (var db = new BarcodeSalesDbEntities())
                {
                    var sabit = db.Sabit.FirstOrDefault();
                    sabit.KartKomisyon = Convert.ToInt16(tKartKomisyon.Text);
                    db.SaveChanges();
                    MessageBox.Show("Kart Komisyon Bilgisi Güncellendi...");
                }
            }
            else
            {
                MessageBox.Show("Kart Komisyon Bilgisini Giriniz...");
            }
        }

        private void bTeraziOnEkKaydet_Click(object sender, EventArgs e)
        {
            if (tTeraziOnEk.Text != "")
            {
                int onEk = Convert.ToInt16(tTeraziOnEk.Text);
                using (var db = new BarcodeSalesDbEntities())
                {
                    if (db.Terazi.Any(x => x.TeraziOnEk == onEk))
                    {
                        MessageBox.Show(onEk.ToString() + " Ön Ek Zaten Kayıtlı...");
                    }
                    else
                    {
                        Terazi t = new Terazi();
                        t.TeraziOnEk = onEk;
                        db.Terazi.Add(t);
                        db.SaveChanges();
                        MessageBox.Show("Bilgiler Kaydedildi...");
                        cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                        cmbTeraziOnEk.ValueMember = "Id";
                        cmbTeraziOnEk.DataSource = db.Terazi.ToList();
                        tTeraziOnEk.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Terazi Ön Ek Bilgisi Girinizi...");
            }
        }

        private void bTeraziOnEkSil_Click(object sender, EventArgs e)
        {
            if (cmbTeraziOnEk.Text != "")
            {
                int onEkId = Convert.ToInt16(cmbTeraziOnEk.SelectedValue);
                DialogResult onay = MessageBox.Show(cmbTeraziOnEk.Text + " Ön Eki Silmek İstiyor Musunuz?", "Terazi Ön Ek Silme İşlemi", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    using (var db = new BarcodeSalesDbEntities())
                    {
                        var onEk = db.Terazi.Find(onEkId);
                        db.Terazi.Remove(onEk);
                        db.SaveChanges();
                        // Cmb Yenile
                        cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                        cmbTeraziOnEk.ValueMember = "Id";
                        cmbTeraziOnEk.DataSource = db.Terazi.ToList();
                        MessageBox.Show("Ön Ek Silindi...");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Ön Ek Seçiniz...");
            }
        }

        private void bIsyeriKaydet_Click(object sender, EventArgs e)
        {
            if (tIsyeriAdSoyad.Text != "" && tIsyeriUnvan.Text != "" && tIsyeriAdres.Text != "" && tIsyeriTelefon.Text != "" && tIsyeriEposta.Text != "")
            {
                using (var db = new BarcodeSalesDbEntities())
                {
                    var isyeri = db.Sabit.FirstOrDefault();
                    isyeri.AdSoyad = tIsyeriAdSoyad.Text;
                    isyeri.Unvan = tIsyeriUnvan.Text;
                    isyeri.Adres = tIsyeriAdres.Text;
                    isyeri.Telefon = tIsyeriTelefon.Text;
                    isyeri.Eposta = tIsyeriEposta.Text;
                    db.SaveChanges();
                    MessageBox.Show("İşyeri Bilgileri Kaydedildi...");
                    var yeni = db.Sabit.FirstOrDefault();
                    tIsyeriAdres.Text = yeni.AdSoyad;
                    tIsyeriUnvan.Text = yeni.Unvan;
                    tIsyeriAdres.Text = yeni.Adres;
                    tIsyeriTelefon.Text = yeni.Telefon;
                    tIsyeriEposta.Text = yeni.Eposta;
                }
            }
        }

        private void bYedektenYukle_Click(object sender, EventArgs e)
        {
            fYedek fYedek = new fYedek();
            fYedek.Show();
        }

        private void bYedekle_Click(object sender, EventArgs e)
        {
            Islemler.Backup();
        }
    }
}
