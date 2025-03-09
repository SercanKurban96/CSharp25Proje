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

namespace Proje17_TestSeferSeyahat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbTestYolcuBilet;Integrated Security=True;Encrypt=False");

        void seferlistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLSEFERBILGI", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSeferListesi.DataSource = dt;
        }

        void yolcusayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLYOLCUBILGI", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblYolcuSayisi.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        void sefersayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLSEFERBILGI", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblSeferSayisi.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLYOLCUBILGI (AD,SOYAD,TELEFON,TC,CINSIYET,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", mskTC.Text);
            komut.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yolcu Bilgileri Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKaptanKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKAPTAN (KAPTANNO,ADSOYAD,TELEFON) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKaptanNo.Text);
            komut.Parameters.AddWithValue("@p2", txtKaptanAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskKaptanTelefon.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaptan Bilgileri Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSeferOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLSEFERBILGI (KALKIS,VARIS,TARIH,SAAT,KAPTAN,FIYAT) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKalkis.Text);
            komut.Parameters.AddWithValue("@p2", txtVaris.Text);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.Parameters.AddWithValue("@p5", mskKaptan.Text);
            komut.Parameters.AddWithValue("@p6", txtFiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sefer Bilgileri Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            seferlistesi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seferlistesi();
            yolcusayisi();
            sefersayisi();
        }

        private void dgvSeferListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtRezervasyonSeferNo.Text = dgvSeferListesi.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "9";
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select TC from TBLYOLCUBILGI where TC=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",mskRezervasyonTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (mskRezervasyonTC.Text.Length == 11 && mskRezervasyonTC.Text != "")
                {
                    SqlCommand komut2 = new SqlCommand("insert into TBLSEFERDETAY (SEFERNO,YOLCUTC,KOLTUK) values (@p1,@p2,@p3)", baglanti);
                    komut2.Parameters.AddWithValue("@p1",txtRezervasyonSeferNo.Text);
                    komut2.Parameters.AddWithValue("@p2",mskRezervasyonTC.Text);
                    komut2.Parameters.AddWithValue("@p3",txtKoltukNo.Text);
                    komut2.ExecuteNonQuery();
                    MessageBox.Show("Rezervasyon Yapıldı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    seferlistesi();                 
                }
                else
                {
                    MessageBox.Show("Lütfen T.C. numaranızı 11 haneli olarak giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Böyle bir T.C. numara bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }
    }
}
