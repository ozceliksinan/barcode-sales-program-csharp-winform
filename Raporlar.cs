using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeSalesProgram
{
    static class Raporlar
    {
        /*
         * Raporları export ederken hata alınırsa CTRL + ALT + E tuşları ile Özel Durum Ayarları açılır.
         * Managed Debugging Assistants pasif hale getirilir.
        */

        public static string Baslik { get; set; }
        public static string TarihBaslangic { get; set; }
        public static string TarihBitis { get; set; }
        public static string SatisNakit { get; set; }
        public static string SatisKart { get; set; }
        public static string IadeNakit { get; set; }
        public static string IadeKart { get; set; }
        public static string GelirNakit { get; set; }
        public static string GelirKart { get; set; }
        public static string GiderNakit { get; set; }
        public static string GiderKart { get; set; }
        public static string KdvToplam { get; set; }
        public static string KartKomisyon { get; set; }

        public static void RaporSayfasiRaporu(DataGridView dgv)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<IslemOzet> list = new List<IslemOzet>();
            list.Clear();

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new IslemOzet
                {
                    IslemNo = Convert.ToInt32(dgv.Rows[i].Cells["IslemNo"].Value.ToString()),
                    Iade = Convert.ToBoolean(dgv.Rows[i].Cells["Iade"].Value),
                    OdemeSekli = dgv.Rows[i].Cells["OdemeSekli"].Value.ToString(),
                    Nakit = Islemler.DoubleYap(dgv.Rows[i].Cells["Nakit"].Value.ToString()),
                    Kart = Islemler.DoubleYap(dgv.Rows[i].Cells["Kart"].Value.ToString()),
                    Gelir = Convert.ToBoolean(dgv.Rows[i].Cells["Gelir"].Value.ToString()),
                    Gider = Convert.ToBoolean(dgv.Rows[i].Cells["Gider"].Value.ToString()),
                    AlisFiyatToplam = Islemler.DoubleYap(dgv.Rows[i].Cells["AlisFiyatToplam"].Value.ToString()),
                    Aciklama = dgv.Rows[i].Cells["Aciklama"].Value.ToString(),
                    Tarih = Convert.ToDateTime(dgv.Rows[i].Cells["Tarih"].Value.ToString()),
                    Kullanici = dgv.Rows[i].Cells["Kullanici"].Value.ToString()
                });
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "dsGenelRapor";
            rs.Value = list;

            fRaporGoster f = new fRaporGoster();
            f.reportViewer1.LocalReport.DataSources.Clear();
            f.reportViewer1.LocalReport.DataSources.Add(rs);
            f.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpGenelRapor.rdlc";

            ReportParameter[] prm = new ReportParameter[13];
            prm[0] = new ReportParameter("Baslik", Baslik);
            prm[1] = new ReportParameter("TarihBaslangic", TarihBaslangic);
            prm[2] = new ReportParameter("TarihBitis", TarihBitis);
            prm[3] = new ReportParameter("SatisNakit", SatisNakit);
            prm[4] = new ReportParameter("SatisKart", SatisKart);
            prm[5] = new ReportParameter("IadeNakit", IadeNakit);
            prm[6] = new ReportParameter("IadeKart", IadeKart);
            prm[7] = new ReportParameter("GelirNakit", GelirNakit);
            prm[8] = new ReportParameter("GelirKart", GelirKart);
            prm[9] = new ReportParameter("GiderNakit", GiderNakit);
            prm[10] = new ReportParameter("GiderKart", GiderKart);
            prm[11] = new ReportParameter("KdvToplam", KdvToplam);
            prm[12] = new ReportParameter("KartKomisyon", KartKomisyon);
            f.reportViewer1.LocalReport.SetParameters(prm);
            f.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            f.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            f.ShowDialog();

            Cursor.Current = Cursors.Default;
        }

        public static void StokRaporu(DataGridView dgv)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<Urun> list = new List<Urun>();
            list.Clear();

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new Urun
                {
                    Barkod = dgv.Rows[i].Cells["Barkod"].Value.ToString(),
                    UrunAd = dgv.Rows[i].Cells["UrunAd"].Value.ToString(),
                    Birim = dgv.Rows[i].Cells["Birim"].Value.ToString(),
                    SatisFiyat = Islemler.DoubleYap(dgv.Rows[i].Cells["SatisFiyat"].Value.ToString()),
                    Miktar = Islemler.DoubleYap(dgv.Rows[i].Cells["Miktar"].Value.ToString()),
                    Aciklama = dgv.Rows[i].Cells["Aciklama"].Value.ToString()
                });
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "dsStokUrun";
            rs.Value = list;

            fRaporGoster f = new fRaporGoster();
            f.reportViewer1.LocalReport.DataSources.Clear();
            f.reportViewer1.LocalReport.DataSources.Add(rs);
            f.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpStokUrun.rdlc";

            ReportParameter[] prm = new ReportParameter[3];
            prm[0] = new ReportParameter("Baslik", Baslik);
            prm[1] = new ReportParameter("TarihBaslangic", TarihBaslangic);
            prm[2] = new ReportParameter("TarihBitis", TarihBitis);
            f.reportViewer1.LocalReport.SetParameters(prm);
            f.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            f.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            f.ShowDialog();

            Cursor.Current = Cursors.Default;
        }

        public static void StokIzlemeRaporu(DataGridView dgv)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<StokHareket> list = new List<StokHareket>();
            list.Clear();

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new StokHareket
                {
                    Barkod = dgv.Rows[i].Cells["Barkod"].Value.ToString(),
                    UrunAd = dgv.Rows[i].Cells["UrunAd"].Value.ToString(),
                    UrunGrup = dgv.Rows[i].Cells["UrunGrup"].Value.ToString(),
                    Birim = dgv.Rows[i].Cells["Birim"].Value.ToString(),
                    Miktar = Islemler.DoubleYap(dgv.Rows[i].Cells["Miktar"].Value.ToString()),
                    Kullanici = dgv.Rows[i].Cells["Kullanici"].Value.ToString(),
                    Tarih = Convert.ToDateTime(dgv.Rows[i].Cells["Tarih"].Value.ToString())
                });
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "dsStokIzleme";
            rs.Value = list;

            fRaporGoster f = new fRaporGoster();
            f.reportViewer1.LocalReport.DataSources.Clear();
            f.reportViewer1.LocalReport.DataSources.Add(rs);
            f.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpStokIzleme.rdlc";

            ReportParameter[] prm = new ReportParameter[3];
            prm[0] = new ReportParameter("Baslik", Baslik);
            prm[1] = new ReportParameter("TarihBaslangic", TarihBaslangic);
            prm[2] = new ReportParameter("TarihBitis", TarihBitis);
            f.reportViewer1.LocalReport.SetParameters(prm);
            f.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            f.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            f.ShowDialog();

            Cursor.Current = Cursors.Default;
        }
    }
}
