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

namespace Proje09_Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbRehber;Integrated Security=True;Encrypt=False");

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLKISILER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRehber.DataSource = dt;
        }

        void Temizle()
        {
            txtID.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtMail.Clear();
            mskTelefon.Clear();
            txtFotografYolu.Clear();
            pctFotograf.ImageLocation = null;
            txtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKISILER (AD,SOYAD,TELEFON,MAIL,FOTOGRAF) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtMail.Text);
            komut.Parameters.AddWithValue("@p5", txtFotografYolu.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Rehbere Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Lütfen rehberden bir kişi seçiniz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Seçtiğiniz kaydı silmek ister misiniz?","Uyarı",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from TBLKISILER where ID=" + txtID.Text, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kişi Rehberden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    Temizle();
                }        
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLKISILER set AD=@p1,SOYAD=@p2,TELEFON=@p3,MAIL=@p4, FOTOGRAF=@p5 where ID=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtMail.Text);
            komut.Parameters.AddWithValue("@p5", txtFotografYolu.Text);
            komut.Parameters.AddWithValue("@p6", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Rehberde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dgvRehber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dgvRehber.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAd.Text = dgvRehber.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoyad.Text = dgvRehber.Rows[e.RowIndex].Cells[2].Value.ToString();
                mskTelefon.Text = dgvRehber.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMail.Text = dgvRehber.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtFotografYolu.Text = dgvRehber.Rows[e.RowIndex].Cells[5].Value.ToString();
                pctFotograf.ImageLocation = dgvRehber.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnFotografYolu_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pctFotograf.ImageLocation = openFileDialog1.FileName;
            txtFotografYolu.Text = openFileDialog1.FileName;
        }
    }
}
