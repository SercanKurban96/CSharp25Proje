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
using System.IO;

namespace Proje15_EtutTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbEtutTest;Integrated Security=True;Encrypt=False");

        void derslistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLDERSLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.ValueMember = "DERSID";
            cmbDers.DisplayMember = "DERSAD";
            cmbDers.DataSource = dt;
        }

        void ogretmenderslistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLDERSLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbOgretmenDers.ValueMember = "DERSID";
            cmbOgretmenDers.DisplayMember = "DERSAD";
            cmbOgretmenDers.DataSource = dt;
        }

        void etutlistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("execute ETUT", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEtutListesi.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            derslistesi();
            etutlistesi();
            ogretmenderslistesi();
        }

        void temizle()
        {
            mskSaat.Clear();
            mskTarih.Clear();
        }

        bool durum;
        void ayniDersVarMi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLDERSLER where DERSAD=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtDersAdi.Text);
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

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Derslere Göre Öğretmenin Adını ve Soyadını ComboBox'a Aktarma
            SqlDataAdapter da = new SqlDataAdapter("select OGRTID,(AD +' '+SOYAD) AS 'Ogretmen' from TBLOGRETMEN where BRANSID=" + cmbDers.SelectedValue, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbOgretmen.ValueMember = "OGRTID";
            cmbOgretmen.DisplayMember = "Ogretmen";
            cmbOgretmen.DataSource = dt;
        }

        private void btnEtutOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            etutlistesi();
            temizle();
        }

        private void dgvEtutListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtEtutID.Text = dgvEtutListesi.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnEtutVer_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLETUT set OGRENCIID=@p1, DURUM=@p2 where ID=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", txtOgrenciID.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", txtEtutID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Öğrenciye Verildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFotografYukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pctFotograf.ImageLocation = openFileDialog1.FileName;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            if (txtOgrenciAd.Text == "" || txtOgrenciSoyad.Text == "" || pctFotograf.ImageLocation == null || txtSinif.Text == "" || mskTelefon.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("Lütfen alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtOgrenciAd.Text);
                komut.Parameters.AddWithValue("@p2", txtOgrenciSoyad.Text);
                komut.Parameters.AddWithValue("@p3", pctFotograf.ImageLocation);
                komut.Parameters.AddWithValue("@p4", txtSinif.Text);
                komut.Parameters.AddWithValue("@p5", mskTelefon.Text);
                komut.Parameters.AddWithValue("@p6", txtMail.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOgrenciAd.Clear();
                txtOgrenciSoyad.Clear();
                pctFotograf.ImageLocation = null;
                txtSinif.Clear();
                mskTelefon.Clear();
                txtMail.Clear();
            }
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            if (txtDersAdi.Text == "")
            {
                MessageBox.Show("Lütfen ders adını boş bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (durum == true)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into TBLDERSLER (DERSAD) values (@p1)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtDersAdi.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Ders Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDersAdi.Clear();
                }
                else
                {
                    MessageBox.Show("Böyle bir ders adı zaten var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnOgretmenEkle_Click(object sender, EventArgs e)
        {
            if (txtOgretmenAd.Text == "" || txtOgretmenSoyad.Text == "")
            {
                MessageBox.Show("Lütfen alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLOGRETMEN (AD,SOYAD,BRANSID) values (@p1,@p2,@p3)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtOgretmenAd.Text);
                komut.Parameters.AddWithValue("@p2", txtOgretmenSoyad.Text);
                komut.Parameters.AddWithValue("@p3", cmbOgretmenDers.SelectedValue);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğretmen Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOgretmenAd.Clear();
                txtOgretmenSoyad.Clear();
            }
        }
    }
}
