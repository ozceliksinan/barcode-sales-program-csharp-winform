using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BarcodeSalesProgram
{
    class Yazdir
    {
        public int? IslemNo { get; set; }

        public Yazdir(int? islemno)
        {
            IslemNo = islemno;
        }
        // 58mm Termal Yazıcıya Göre Ayarlandı //
        // 220 Genişlik Px karşılığı vardır //
        PrintDocument pd = new PrintDocument();

        public void YazdirmayaBasla()
        {
            try
            {
                pd.PrintPage += Pd_PrintPage;
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            BarcodeSalesDbEntities db = new BarcodeSalesDbEntities();
            var isyeri = db.Sabit.FirstOrDefault();
            var liste = db.Satis.Where(x => x.IslemNo == IslemNo).ToList();
            if (isyeri != null && liste != null)
            {
                /*
                 * Kağıt Boyutunun belirlenmesinin aşamaları
                 * 1-> Standart başlıkların uzunluğu (Sabit başlıklar 120 px)
                 * 2-> Listedeki her bir ürün için 15px
                 * 3-> Fişin en altında diğer yazdırmak istediklerimiz 120 px
                 * Toplam rulo uzunluğu boyutu bu kadar.
                */
                int kagitUzunluk = 120;
                for (int i = 0; i < liste.Count; i++)
                {
                    kagitUzunluk += 15;
                }
                PaperSize ps58 = new PaperSize("58mm Termal", 220, kagitUzunluk + 120);
                pd.DefaultPageSettings.PaperSize = ps58;

                // Font Bölümü //
                Font fontBaslik = new Font("Calibri", 10, FontStyle.Bold);
                Font fontBilgi = new Font("Calibri", 8, FontStyle.Bold);
                Font fontIcerikBaslik = new Font("Calibri", 8, FontStyle.Underline);

                // Sabit yerleşim kısmı //
                // Fiş kısmın üst bölümü, market bilgileri //
                StringFormat ortala = new StringFormat(StringFormatFlags.FitBlackBox);
                ortala.Alignment = StringAlignment.Center;
                Rectangle rcUnvanKonum = new Rectangle(0, 20, 220, 20);
                e.Graphics.DrawString(isyeri.Unvan, fontBaslik, Brushes.Black, rcUnvanKonum, ortala);
                e.Graphics.DrawString("Telefon: " + isyeri.Telefon, fontBilgi, Brushes.Black, new Point(5, 45));
                e.Graphics.DrawString("İşlem No: " + IslemNo.ToString(), fontBilgi, Brushes.Black, new Point(5, 60));
                e.Graphics.DrawString("Tarih: " + DateTime.Now, fontBilgi, Brushes.Black, new Point(5, 75));
                e.Graphics.DrawString("----------------------------------------------------------", fontBilgi, Brushes.Black, new Point(5, 90));

                // Satış Bilgileri 4'lü Grup Ana Başlık //
                e.Graphics.DrawString("Ürün Adı:", fontIcerikBaslik, Brushes.Black, new Point(5, 1005));
                e.Graphics.DrawString("Miktar: ", fontIcerikBaslik, Brushes.Black, new Point(100, 105));
                e.Graphics.DrawString("Fiyat: ", fontIcerikBaslik, Brushes.Black, new Point(140, 105));
                e.Graphics.DrawString("Tutar: ", fontIcerikBaslik, Brushes.Black, new Point(180, 105));

                // Ürün eklendikçe kağıt bölümü artacak //
                // Kağıt boyutu dinamik olacak //
                int yukseklik = 120;
                double genelToplam = 0;
                foreach (var item in liste)
                {
                    e.Graphics.DrawString(item.UrunAd, fontBilgi, Brushes.Black, new Point(5, yukseklik));
                    e.Graphics.DrawString(item.Miktar.ToString(), fontBilgi, Brushes.Black, new Point(115, yukseklik));
                    e.Graphics.DrawString(Convert.ToDouble(item.SatisFiyat).ToString("C2"), fontBilgi, Brushes.Black, new Point(140, yukseklik));
                    e.Graphics.DrawString(Convert.ToDouble(item.Toplam).ToString("C2"), fontBilgi, Brushes.Black, new Point(180, yukseklik));
                    // Satış Bilgisini Satıra Ekleme İşlemi Bitti //
                    // Bir Alt Satıra Geç //
                    yukseklik += 15;
                    genelToplam += Convert.ToDouble(item.Toplam);
                }
                // Satış Bilgilerinden Sonra Yazdırmak İstenilen Diğer Bilgiler //
                e.Graphics.DrawString("----------------------------------------------------------", fontBilgi, Brushes.Black, new Point(5, yukseklik));
                e.Graphics.DrawString("TOPLAM: " + genelToplam.ToString("C2"), fontBaslik, Brushes.Black, new Point(5, yukseklik + 20));
                e.Graphics.DrawString("----------------------------------------------------------", fontBilgi, Brushes.Black, new Point(5, yukseklik + 40));
                e.Graphics.DrawString("(Mali Değeri Yoktur)", fontBilgi, Brushes.Black, new Point(5, yukseklik + 60));
            }
        }
    }
}
