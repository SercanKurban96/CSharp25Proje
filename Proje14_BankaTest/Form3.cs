using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje14_BankaTest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True;Encrypt=False");

        //Aynı Hesap Numarasının Kaydetmesini Engelleme
        bool durum;
        void AyniHesapNo()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLKISILER where HESAPNO=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", mskHesapNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AyniHesapNo();
            
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLKISILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", mskTC.Text);
                komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
                komut.Parameters.AddWithValue("@p5", mskHesapNo.Text);
                komut.Parameters.AddWithValue("@p6", txtSifre.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAd.Clear();
                txtSoyad.Clear();
                mskTC.Clear();
                mskTelefon.Clear();
                mskHesapNo.Clear();
                txtSifre.Clear();
                txtAd.Focus();
            }
            else
            {
                MessageBox.Show("Böyle bir Hesap No zaten var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnHesapNo_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int hesapNo = rnd.Next(100000, 1000000);
            mskHesapNo.Text = hesapNo.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtAd.Focus();
        }
    }
}
