using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje03_Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCevapla.Enabled = false;
        }

        void Cevapla()
        {
            txtCevapla.Clear();
            txtCevapla.Enabled = false;
        }

        private void txtCevapla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (txtCevapla.Text.Equals("akdeniz", StringComparison.OrdinalIgnoreCase))
                        {
                            btnA.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnA.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 2:
                        if (txtCevapla.Text.Equals("bursa", StringComparison.OrdinalIgnoreCase))
                        {
                            btnB.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnB.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 3:
                        if (txtCevapla.Text.Equals("cuma", StringComparison.OrdinalIgnoreCase))
                        {
                            btnC.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnC.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 4:
                        if (txtCevapla.Text.Equals("diyarbakır", StringComparison.OrdinalIgnoreCase))
                        {
                            btnD.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnD.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 5:
                        if (txtCevapla.Text.Equals("eski", StringComparison.OrdinalIgnoreCase))
                        {
                            btnE.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnE.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 6:
                        if (txtCevapla.Text.Equals("ferman", StringComparison.OrdinalIgnoreCase))
                        {
                            btnF.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnF.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 7:
                        if (txtCevapla.Text.Equals("güneş", StringComparison.OrdinalIgnoreCase))
                        {
                            btnG.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnG.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 8:
                        if (txtCevapla.Text.Equals("halı", StringComparison.OrdinalIgnoreCase))
                        {
                            btnH.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnH.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 9:
                        if (txtCevapla.Text.Equals("ısparta", StringComparison.OrdinalIgnoreCase))
                        {
                            btnI.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnI.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 10:
                        if (txtCevapla.Text.Equals("içel", StringComparison.OrdinalIgnoreCase))
                        {
                            btnİ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnİ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 11:
                        if (txtCevapla.Text.Equals("jandarma", StringComparison.OrdinalIgnoreCase))
                        {
                            btnJ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnJ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 12:
                        if (txtCevapla.Text.Equals("kayısı", StringComparison.OrdinalIgnoreCase))
                        {
                            btnK.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnK.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 13:
                        if (txtCevapla.Text.Equals("lale", StringComparison.OrdinalIgnoreCase))
                        {
                            btnL.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnL.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 14:
                        if (txtCevapla.Text.Equals("mart", StringComparison.OrdinalIgnoreCase))
                        {
                            btnM.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnM.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 15:
                        if (txtCevapla.Text.Equals("ney", StringComparison.OrdinalIgnoreCase))
                        {
                            btnN.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnN.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 16:
                        if (txtCevapla.Text.Equals("ozan", StringComparison.OrdinalIgnoreCase))
                        {
                            btnO.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnO.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 17:
                        if (txtCevapla.Text.Equals("pırasa", StringComparison.OrdinalIgnoreCase))
                        {
                            btnP.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnP.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 18:
                        if (txtCevapla.Text.Equals("ramazan", StringComparison.OrdinalIgnoreCase))
                        {
                            btnR.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnR.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 19:
                        if (txtCevapla.Text.Equals("snake", StringComparison.OrdinalIgnoreCase))
                        {
                            btnS.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnS.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 20:
                        if (txtCevapla.Text.Equals("tarkan", StringComparison.OrdinalIgnoreCase))
                        {
                            btnT.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnT.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 21:
                        if (txtCevapla.Text.Equals("umut", StringComparison.OrdinalIgnoreCase))
                        {
                            btnU.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnU.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 22:
                        if (txtCevapla.Text.Equals("van", StringComparison.OrdinalIgnoreCase))
                        {
                            btnV.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnV.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 23:
                        if (txtCevapla.Text.Equals("yıldırım", StringComparison.OrdinalIgnoreCase))
                        {
                            btnY.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnY.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;

                    case 24:
                        if (txtCevapla.Text.Equals("zeytin", StringComparison.OrdinalIgnoreCase))
                        {
                            btnZ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            Cevapla();
                        }
                        else
                        {
                            btnZ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            Cevapla();
                        }
                        break;
                }
            }
        }

        private void lnkLblCevapla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtCevapla.Clear();
            txtCevapla.Focus();
            txtCevapla.Enabled = true;
            lnkLblCevapla.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                rchSoru.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                btnA.BackColor = Color.Yellow;
            }

            if (soruno == 2)
            {
                rchSoru.Text = "Yeşilliğiyle ünlü Marmara ilimiz?";
                btnB.BackColor = Color.Yellow;
            }

            if (soruno == 3)
            {
                rchSoru.Text = "Müslümanların kutsal günü?";
                btnC.BackColor = Color.Yellow;
            }

            if (soruno == 4)
            {
                rchSoru.Text = "Karpuzuyla ünlü ilimiz?";
                btnD.BackColor = Color.Yellow;
            }

            if (soruno == 5)
            {
                rchSoru.Text = "Yeni kelimesinin zıt anlamlısı?";
                btnE.BackColor = Color.Yellow;
            }

            if (soruno == 6)
            {
                rchSoru.Text = "Padişahın emirlerinin yazılı hali?";
                btnF.BackColor = Color.Yellow;
            }

            if (soruno == 7)
            {
                rchSoru.Text = "Dünyanın ısı kaynağı?";
                btnG.BackColor = Color.Yellow;
            }

            if (soruno == 8)
            {
                rchSoru.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne?";
                btnH.BackColor = Color.Yellow;
            }

            if (soruno == 9)
            {
                rchSoru.Text = "Gülüyle ünlü ilimiz?";
                btnI.BackColor = Color.Yellow;
            }

            if (soruno == 10)
            {
                rchSoru.Text = "Mersin'in diğer ismi?";
                btnİ.BackColor = Color.Yellow;
            }

            if (soruno == 11)
            {
                rchSoru.Text = "Askeri bir topluluk?";
                btnJ.BackColor = Color.Yellow;
            }

            if (soruno == 12)
            {
                rchSoru.Text = "Malatya'nın meşhur meyvesi?";
                btnK.BackColor = Color.Yellow;
            }

            if (soruno == 13)
            {
                rchSoru.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                btnL.BackColor = Color.Yellow;
            }

            if (soruno == 11)
            {
                rchSoru.Text = "Askeri bir topluluk?";
                btnJ.BackColor = Color.Yellow;
            }

            if (soruno == 12)
            {
                rchSoru.Text = "Malatya'nın meşhur meyvesi?";
                btnK.BackColor = Color.Yellow;
            }

            if (soruno == 13)
            {
                rchSoru.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                btnL.BackColor = Color.Yellow;
            }

            if (soruno == 14)
            {
                rchSoru.Text = "Yılın üçüncü ayı?";
                btnM.BackColor = Color.Yellow;
            }

            if (soruno == 15)
            {
                rchSoru.Text = "Üflemeli bir müzik aleti?";
                btnN.BackColor = Color.Yellow;
            }

            if (soruno == 16)
            {
                rchSoru.Text = "Halk şairi?";
                btnO.BackColor = Color.Yellow;
            }

            if (soruno == 17)
            {
                rchSoru.Text = "Çocukların pek sevmediği pirinç havuç gibi sebzeler ile yapılan yemek?";
                btnP.BackColor = Color.Yellow;
            }

            if (soruno == 18)
            {
                rchSoru.Text = "11 ayın sultanı?";
                btnR.BackColor = Color.Yellow;
            }

            if (soruno == 19)
            {
                rchSoru.Text = "İngilizce'de yılan?";
                btnS.BackColor = Color.Yellow;
            }

            if (soruno == 20)
            {
                rchSoru.Text = "Türkiye'nin Megastarı?";
                btnT.BackColor = Color.Yellow;
            }

            if (soruno == 21)
            {
                rchSoru.Text = "Ümit kelimesinin eş anlamlısı?";
                btnU.BackColor = Color.Yellow;
            }

            if (soruno == 22)
            {
                rchSoru.Text = "Kahvaltısı ile ünlü ilimiz?";
                btnV.BackColor = Color.Yellow;
            }

            if (soruno == 23)
            {
                rchSoru.Text = "Şimşek kelimesinin eş anlamlısı?";
                btnY.BackColor = Color.Yellow;
            }

            if (soruno == 24)
            {
                rchSoru.Text = "Ege Bölgesi'nin en çok ağacı bulunan yağı da yapılan bir kahvaltı besini?";
                btnZ.BackColor = Color.Yellow;
            }
        }
    }
}
