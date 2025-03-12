using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje23_ListOrnekTest
{
    public partial class FrmAraba : Form
    {
        public FrmAraba()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lstListele.Items.Clear();
            List<Araba> araba = new List<Araba>();

            araba.Add(new Araba()
            {
                Marka = "McLaren",
                Model = "F1",
                Yil = 1995,
                Renk = "Siyah",
                VitesTuru = "Otomatik",
                YakitTuru = "Dizel",
                MotorHacmi = 2.5,
                BeygirGucu = 380,
                MaksimumHiz = 386
            });

            foreach (Araba arabalar in araba)
            {
                lstListele.Items.Add(arabalar.Marka + " - " + arabalar.Model + " - " + arabalar.Yil + " - " + arabalar.Renk + " - " + arabalar.VitesTuru + " - " + arabalar.YakitTuru + " - " + arabalar.MotorHacmi + " - " + arabalar.BeygirGucu + " - " + arabalar.MaksimumHiz);
            }
        }
    }
}
