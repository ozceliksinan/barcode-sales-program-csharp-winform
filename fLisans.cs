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
    public partial class fLisans : Form
    {
        public fLisans()
        {
            InitializeComponent();
        }

        private void bTamam_Click(object sender, EventArgs e)
        {
            if (tLisansNo.Text != "")
            {
                Kontrol k = new Kontrol();
                k.Lisansla(tLisansNo.Text);
            }
        }
    }
}
