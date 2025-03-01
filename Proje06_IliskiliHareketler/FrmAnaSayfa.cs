using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje06_IliskiliHareketler
{
    public partial class FrmAnaSayfa: Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            FrmUrunler fr = new FrmUrunler();
            fr.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void btnHareketlerTablosu_Click(object sender, EventArgs e)
        {
            FrmHareketlerTablosu fr = new FrmHareketlerTablosu();
            fr.Show();
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            FrmPersoneller fr = new FrmPersoneller();
            fr.Show();
        }

        private void btnHareketler_Click(object sender, EventArgs e)
        {
            FrmHareketler fr = new FrmHareketler();
            fr.Show();
        }
    }
}
