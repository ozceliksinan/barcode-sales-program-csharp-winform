using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeSalesProgram
{
    public class Kontrol
    {
        BarcodeSalesDbEntities db = new BarcodeSalesDbEntities();
        Guvenlik guvenlik = new Guvenlik();
        Lic lic = new Lic();

        public bool KontrolYap()
        {
            bool durum = false;

            if (db.Guvenlik.Count() == 0)
            {
                LisansFormuAc();
            }
            else
            {
                Lic lic = new Lic();
                var guvenlik = db.Guvenlik.First();
                if (lic.TarihCoz(guvenlik.baslangic) < DateTime.Now)
                {
                    guvenlik.baslangic = lic.TarihSifrele(DateTime.Now);
                    db.SaveChanges();
                    durum = true;
                }
                if (lic.TarihKontrol(lic.TarihCoz(guvenlik.baslangic), lic.TarihCoz(guvenlik.bitis)))
                {
                    durum = true;
                }
                else
                {
                    durum = false;
                    LisansFormuAc();
                }
            }

            return durum;
        }

        public void LisansFormuAc()
        {
            Lic lic = new Lic();
            fLisans f = new fLisans();
            f.lKontrolNo.Text = lic.EkrandaGoster().ToString();
            f.Show();
        }

        public void Lisansla(string girilenKod)
        {
            int durum = lic.GirilenLisansiKontrolEt(girilenKod);
            switch (durum)
            {
                case 0: // Geçersiz Lisans Kodu //
                    System.Windows.Forms.MessageBox.Show("Girilen Lisans Numarası Geçersizdir...");
                    break;
                case 1:
                    DemoOlustur();
                    break;
                case 2:
                    YillikOlustur();
                    break;
                default:
                    break;
            }
        }

        private int GuvenlikEkliMi()
        {
            return db.Guvenlik.Count();
        }

        private void GuvenlikEkle(string baslangic, string bitis)
        {
            guvenlik.baslangic = baslangic;
            guvenlik.bitis = bitis;
            db.Guvenlik.Add(guvenlik);
            db.SaveChanges();
        }

        private void GuvenlikGuncelle(string baslangic, string bitis)
        {
            var guvenlikGuncelle = db.Guvenlik.First();
            guvenlikGuncelle.baslangic = baslangic;
            guvenlikGuncelle.bitis = bitis;
            db.SaveChanges();
        }

        private void DemoOlustur()
        {
            try
            {
                if (GuvenlikEkliMi() == 0)
                {
                    // Db Ekleme İşlemi //
                    GuvenlikEkle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.DemoTarihOlustur()));
                }
                else
                {
                    // Db Güncelleme İşlemi //
                    GuvenlikGuncelle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.DemoTarihOlustur()));
                }
                System.Windows.Forms.MessageBox.Show("Program 10 Günlük Demo Olarak Kullanıma Açıldı...\n Programı Tekrardan Açınız...");
                Application.Exit();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

        private void YillikOlustur()
        {
            try
            {
                if (GuvenlikEkliMi() == 0)
                {
                    // Db Ekleme İşlemi //
                    GuvenlikEkle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.YillikTarihOlustur()));
                }
                else
                {
                    // Db Güncelleme İşlemi //
                    GuvenlikGuncelle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.YillikTarihOlustur()));
                }
                System.Windows.Forms.MessageBox.Show("Program 1 Yıllık Olarak Kullanıma Açıldı...\n Programı Tekrardan Açınız...");
                Application.Exit();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
    }
}
