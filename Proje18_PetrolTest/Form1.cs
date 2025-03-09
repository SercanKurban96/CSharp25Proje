using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje18_PetrolTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbBenzinTest;Integrated Security=True;Encrypt=False");

        void listele()
        {
            //Kurşunsuz 95
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLBENZIN where PETROLTUR='Kurşunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblKursunsuz95.Text = dr[3].ToString();
                pbKursunsuz95.Value = int.Parse(dr[4].ToString());
                lblKursunsuz95Litre.Text = dr[4].ToString();
            }
            baglanti.Close();

            //Kurşunsuz 97
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from TBLBENZIN where PETROLTUR='Kurşunsuz97'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblKursunsuz97.Text = dr2[3].ToString();
                pbKursunsuz97.Value = int.Parse(dr2[4].ToString());
                lblKursunsuz97Litre.Text = dr2[4].ToString();
            }
            baglanti.Close();

            //Euro Dizel10
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from TBLBENZIN where PETROLTUR='EuroDizel10'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblEuroDizel10.Text = dr3[3].ToString();
                pbEuroDizel10.Value = int.Parse(dr3[4].ToString());
                lblEuroDizel10Litre.Text = dr3[4].ToString();
            }
            baglanti.Close();

            //Yeni Pro Dizel
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from TBLBENZIN where PETROLTUR='YeniProDizel'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblYeniProDizel.Text = dr4[3].ToString();
                pbYeniProDizel.Value = int.Parse(dr4[4].ToString());
                lblYeniProDizelLitre.Text = dr4[4].ToString();
            }
            baglanti.Close();

            //Gaz
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from TBLBENZIN where PETROLTUR='Gaz'", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblGaz.Text = dr5[3].ToString();
                pbGaz.Value = int.Parse(dr5[4].ToString());
                lblGazLitre.Text = dr5[4].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from TBLKASA", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblKasa.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }

        void temizle()
        {
            numKursunsuz95.Value = 0;
            numKursunsuz97.Value = 0;
            numEuroDizel10.Value = 0;
            numYeniProDizel.Value = 0;
            numGaz.Value = 0;
            txtKursunsuz95Fiyat.Text = "";
            txtKursunsuz97Fiyat.Text = "";
            txtEuroDizel10Fiyat.Text = "";
            txtYeniProDizelFiyat.Text = "";
            txtGazFiyat.Text = "";
            txtLitre.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void numKursunsuz95_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(lblKursunsuz95.Text);
            litre = Convert.ToDouble(numKursunsuz95.Value);
            tutar = kursunsuz95 * litre;
            txtKursunsuz95Fiyat.Text = tutar.ToString();
        }

        private void numKursunsuz97_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;
            kursunsuz97 = Convert.ToDouble(lblKursunsuz97.Text);
            litre = Convert.ToDouble(numKursunsuz97.Value);
            tutar = kursunsuz97 * litre;
            txtKursunsuz97Fiyat.Text = tutar.ToString();
        }

        private void numEuroDizel10_ValueChanged(object sender, EventArgs e)
        {
            double euroDizel10, litre, tutar;
            euroDizel10 = Convert.ToDouble(lblEuroDizel10.Text);
            litre = Convert.ToDouble(numEuroDizel10.Value);
            tutar = euroDizel10 * litre;
            txtEuroDizel10Fiyat.Text = tutar.ToString();
        }

        private void numYeniProDizel_ValueChanged(object sender, EventArgs e)
        {
            double yeniProDizel10, litre, tutar;
            yeniProDizel10 = Convert.ToDouble(lblYeniProDizel.Text);
            litre = Convert.ToDouble(numYeniProDizel.Value);
            tutar = yeniProDizel10 * litre;
            txtYeniProDizelFiyat.Text = tutar.ToString();
        }

        private void numGaz_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(lblGaz.Text);
            litre = Convert.ToDouble(numGaz.Value);
            tutar = gaz * litre;
            txtGazFiyat.Text = tutar.ToString();
        }

        private void btnDepoDoldur_Click(object sender, EventArgs e)
        {
            //Kurşunsuz 95
            if (numKursunsuz95.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Kurşunsuz95");
                komut.Parameters.AddWithValue("@p3", lblKursunsuz95Litre.Text);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtKursunsuz95Fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtKursunsuz95Fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='Kurşunsuz95'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numKursunsuz95.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Satış Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numKursunsuz95.Value = 0;
                txtKursunsuz95Fiyat.Clear();
                listele();
            }

            //Kurşunsuz 97
            if (numKursunsuz97.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Kurşunsuz97");
                komut.Parameters.AddWithValue("@p3", lblKursunsuz97Litre.Text);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtKursunsuz97Fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtKursunsuz97Fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='Kurşunsuz97'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numKursunsuz97.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numKursunsuz97.Value = 0;
                txtKursunsuz97Fiyat.Clear();
                listele();
            }

            //Euro Dizel10
            if (numEuroDizel10.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "EuroDizel10");
                komut.Parameters.AddWithValue("@p3", lblEuroDizel10Litre.Text);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtEuroDizel10Fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtEuroDizel10Fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='EuroDizel10'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numEuroDizel10.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numEuroDizel10.Value = 0;
                txtEuroDizel10Fiyat.Clear();
                listele();
            }

            //Yeni Pro Dizel
            if (numYeniProDizel.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "YeniProDizel");
                komut.Parameters.AddWithValue("@p3", lblYeniProDizelLitre.Text);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtYeniProDizelFiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtYeniProDizelFiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='YeniProDizel'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numYeniProDizel.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numYeniProDizel.Value = 0;
                txtYeniProDizelFiyat.Clear();
                listele();
            }

            //Gaz
            if (numGaz.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Gaz");
                komut.Parameters.AddWithValue("@p3", lblGazLitre.Text);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtGazFiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtGazFiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='Gaz'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numGaz.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numGaz.Value = 0;
                txtGazFiyat.Clear();
                listele();
            }
        }

        private void btnKursunsuz95Ekle_Click(object sender, EventArgs e)
        {
            if (lblKursunsuz95Litre.Text != "10000")
            {
                decimal tutar = (decimal)(double.Parse(txtLitre.Text) * 43.26);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", tutar);
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLBENZIN set STOK=STOK+@p1 where PETROLTUR='Kurşunsuz95'", baglanti);
                komut2.Parameters.AddWithValue("@p1", int.Parse(txtLitre.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut3.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut3.Parameters.AddWithValue("@p2", "Kurşunsuz95");
                komut3.Parameters.AddWithValue("@p3", int.Parse(txtLitre.Text));
                komut3.Parameters.AddWithValue("@p4", tutar);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Alış Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Depo zaten dolu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKursunsuz97Ekle_Click(object sender, EventArgs e)
        {
            if (lblKursunsuz97Litre.Text != "10000")
            {
                decimal tutar = (decimal)(double.Parse(txtLitre.Text) * 43.50);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", tutar);
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLBENZIN set STOK=STOK+@p1 where PETROLTUR='Kurşunsuz97'", baglanti);
                komut2.Parameters.AddWithValue("@p1", int.Parse(txtLitre.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut3.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut3.Parameters.AddWithValue("@p2", "Kurşunsuz97");
                komut3.Parameters.AddWithValue("@p3", int.Parse(txtLitre.Text));
                komut3.Parameters.AddWithValue("@p4", tutar);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Alış Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Depo zaten dolu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEuroDizel10Ekle_Click(object sender, EventArgs e)
        {
            if (lblEuroDizel10.Text != "10000")
            {
                decimal tutar = (decimal)(double.Parse(txtLitre.Text) * 43.50);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", tutar);
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLBENZIN set STOK=STOK+@p1 where PETROLTUR='EuroDizel10'", baglanti);
                komut2.Parameters.AddWithValue("@p1", int.Parse(txtLitre.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut3.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut3.Parameters.AddWithValue("@p2", "EuroDizel10");
                komut3.Parameters.AddWithValue("@p3", int.Parse(txtLitre.Text));
                komut3.Parameters.AddWithValue("@p4", tutar);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Alış Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Depo zaten dolu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYeniProDizelEkle_Click(object sender, EventArgs e)
        {
            if (lblYeniProDizel.Text != "10000")
            {
                decimal tutar = (decimal)(double.Parse(txtLitre.Text) * 43.50);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", tutar);
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLBENZIN set STOK=STOK+@p1 where PETROLTUR='YeniProDizel'", baglanti);
                komut2.Parameters.AddWithValue("@p1", int.Parse(txtLitre.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut3.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut3.Parameters.AddWithValue("@p2", "YeniProDizel");
                komut3.Parameters.AddWithValue("@p3", int.Parse(txtLitre.Text));
                komut3.Parameters.AddWithValue("@p4", tutar);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Alış Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Depo zaten dolu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGazEkle_Click(object sender, EventArgs e)
        {
            if (lblGaz.Text != "10000")
            {
                decimal tutar = (decimal)(double.Parse(txtLitre.Text) * 43.50);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", tutar);
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLBENZIN set STOK=STOK+@p1 where PETROLTUR='Gaz'", baglanti);
                komut2.Parameters.AddWithValue("@p1", int.Parse(txtLitre.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut3.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut3.Parameters.AddWithValue("@p2", "Gaz");
                komut3.Parameters.AddWithValue("@p3", int.Parse(txtLitre.Text));
                komut3.Parameters.AddWithValue("@p4", tutar);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Alış Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Depo zaten dolu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
