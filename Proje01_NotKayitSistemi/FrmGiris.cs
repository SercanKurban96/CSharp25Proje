﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje01_NotKayitSistemi
{
    public partial class FrmGiris: Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            FrmOgrenciDetay fr = new FrmOgrenciDetay();
            fr.numara = mskNumara.Text;
            fr.Show();
        }

        private void mskNumara_TextChanged(object sender, EventArgs e)
        {
            if (mskNumara.Text == "1111")
            {
                FrmOgretmenDetay fr = new FrmOgretmenDetay();
                fr.Show();
            }
        }
    }
}
