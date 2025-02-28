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

namespace Proje01_NotKayitSistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.TBLDERS' table. You can move, or remove it, as needed.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);

            //YAPILACAKLAR
            //Geçen Sayısı ve Kalan Sayısını Bulma (FrmOgretmenDetay)
            //Öğrenci Numarası girildiğinde Durum kısmı True False yerine Geçti Kaldı yazan program (FrmOgrenciDetay)

            
            lblGecenSayisi.Text = dbNotKayitDataSet.TBLDERS.Count(x => x.DURUM == true).ToString();
            lblKalanSayisi.Text = dbNotKayitDataSet.TBLDERS.Count(x => x.DURUM == false).ToString();
            lblOrtalama.Text = dbNotKayitDataSet.TBLDERS.Sum(x => x.ORTALAMA / (Convert.ToInt16(lblGecenSayisi.Text) + Convert.ToInt16(lblKalanSayisi.Text))).ToString("0.00");
        }

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", mskNumara.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Başarılı Bir Şekilde Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);
            mskNumara.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Sınav Ortalamalarını Hesaplama
            double ortalama, s1, s2, s3;
            string durum;

            s1 = Convert.ToDouble(txtSinav1.Text);
            s2 = Convert.ToDouble(txtSinav2.Text);
            s3 = Convert.ToDouble(txtSinav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblOrtalama.Text = ortalama.ToString("0.00");

            //Sınav Notlarını Güncelleme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLDERS set OGRS1=@p1, OGRS2=@p2, OGRS3=@p3, ORTALAMA=@p4, DURUM=@p5 where OGRNUMARA=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txtSinav1.Text);
            komut.Parameters.AddWithValue("@p2", txtSinav2.Text);
            komut.Parameters.AddWithValue("@p3", txtSinav3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(lblOrtalama.Text));
            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", mskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrencinin Sınav Notları Başarılı Bir Şekilde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);
            txtSinav1.Clear();
            txtSinav2.Clear();
            txtSinav3.Clear();
        }

        private void dgvSinavNotlari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mskNumara.Text = dgvSinavNotlari.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAd.Text = dgvSinavNotlari.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoyad.Text = dgvSinavNotlari.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSinav1.Text = dgvSinavNotlari.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSinav2.Text = dgvSinavNotlari.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSinav3.Text = dgvSinavNotlari.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
