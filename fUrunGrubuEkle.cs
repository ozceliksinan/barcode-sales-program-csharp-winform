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
    public partial class fUrunGrubuEkle : Form
    {
        public fUrunGrubuEkle()
        {
            InitializeComponent();
        }

        BarcodeSalesDbEntities db = new BarcodeSalesDbEntities();

        private void fUrunGrubuEkle_Load(object sender, EventArgs e)
        {
            GrupDoldur();
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (tUrunGrupAd.Text == "")
            {
                MessageBox.Show("Lütfen Ürün Grup Bilgisini Giriniz...");
            }
            else
            {
                UrunGrup ug = new UrunGrup();
                ug.UrunGrupAd = tUrunGrupAd.Text;
                db.UrunGrup.Add(ug);
                db.SaveChanges();
                GrupDoldur();
                tUrunGrupAd.Clear();
                MessageBox.Show("Ürün Grubu Eklendi...");

                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                if (f != null)
                {
                    f.GrupDoldur();
                }
            }
        }

        private void GrupDoldur()
        {
            listUrunGrup.DisplayMember = "UrunGrupAd";
            listUrunGrup.ValueMember = "Id";
            listUrunGrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            int grupId = Convert.ToInt32(listUrunGrup.SelectedValue.ToString());
            string grupAd = listUrunGrup.Text;
            DialogResult onay = MessageBox.Show(grupAd + " grubunu silmek istiyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo);

            if (onay == DialogResult.Yes)
            {
                var grup = db.UrunGrup.FirstOrDefault(x => x.Id == grupId);
                db.UrunGrup.Remove(grup);
                db.SaveChanges();
                GrupDoldur();
                tUrunGrupAd.Focus();
                MessageBox.Show(grupAd + "ürün grubu silindi...");

                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                f.GrupDoldur();
            }
        }
    }
}
