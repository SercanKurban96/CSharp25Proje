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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele1_Click(object sender, EventArgs e)
        {
            lstListele1.Items.Clear();
            List<string> karakterler = new List<string>();
            karakterler.Add("Mazhar");
            karakterler.Add("Ruhsar");
            karakterler.Add("Menkıbe");
            karakterler.Add("Müfit");
            karakterler.Add("Reyhan");
            karakterler.Add("Firdevs");

            karakterler.Remove("Müfit");

            foreach (string k in karakterler)
            {
                lstListele1.Items.Add(k);
            }
        }

        private void btnListele2_Click(object sender, EventArgs e)
        {
            lstListele2.Items.Clear();
            List<int> sayilar = new List<int>();
            sayilar.Add(45);
            sayilar.Add(74);
            sayilar.Add(25);
            sayilar.Add(33);
            sayilar.Add(22);
            sayilar.Add(15);
            sayilar.Add(14);
            foreach (int s in sayilar)
            {
                if (s % 5 == 0)
                {
                    lstListele2.Items.Add(s);
                }
            }

            if (sayilar.Contains(74))
            {
                MessageBox.Show("Bu Sayı Var");
            }
            else
            {
                MessageBox.Show("Bu Sayı Yok");
            }
        }

        private void btnListele3_Click(object sender, EventArgs e)
        {
            lstListele3.Items.Clear();
            List<Kisiler> kisi = new List<Kisiler>();

            kisi.Add(new Kisiler()
            {
                ADI = "Sercan",
                SOYADI = "Kurban",
                MESLEKI = "Yazılımcı"
            });

            foreach (Kisiler k in kisi)
            {
                lstListele3.Items.Add(k.ADI + " " + k.SOYADI + " " + k.MESLEKI);
            }
        }
    }
}
