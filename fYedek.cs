using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeSalesProgram
{
    public partial class fYedek : Form
    {
        public fYedek()
        {
            InitializeComponent();
        }

        private void bYedekSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Veri dosyasını seçiniz|*bak";
            ofd.ShowDialog();
            tDosya.Text = ofd.FileName;
        }

        private void bYukle_Click(object sender, EventArgs e)
        {
            if (tDosya.Text != "")
            {
                try
                {
                    string strSql = @"data source = (LocalDB)\MSSQLLocalDb;attachdbfilename=|DataDirectory|\BarcodeSalesDb.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
                    Cursor.Current = Cursors.WaitCursor;
                    string yedekYolu = tDosya.Text;
                    Application.DoEvents();
                    string str = Application.StartupPath + @"\BarcodeSalesDb.mdf";
                    using (SqlConnection connection = new SqlConnection(strSql))
                    {
                        connection.Open();
                        SqlCommand isle = new SqlCommand(@"USE Master; If Exists(Select * From sys.databases where name='BarcodeSalesDb') Drop Database[" + str + "];RESTORE DATABASE[" + str + "] FROM DISK=N'" + tDosya.Text + "'", connection);
                        isle.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("Veriler Geri Yüklendi...");
                    Process.Start(Application.StartupPath + "BarcodeSalesProgram.exe");
                    Cursor.Current = Cursors.Default;
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
