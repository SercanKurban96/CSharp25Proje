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

namespace Proje16_TriggerTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbProje10;Integrated Security=True;Encrypt=False");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLKITAPLAR", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKitaplar.DataSource = dt;
        }

        void temizle()
        {
            txtID.Clear();
            txtAd.Clear();
            txtYazar.Clear();
            txtSayfa.Clear();
            txtYayinevi.Clear();
            txtTur.Clear();
        }

        void sayac()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLSAYAC", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblKitapAdet.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKITAPLAR (AD,YAZAR,SAYFA,YAYINEVI,TUR) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", txtSayfa.Text);
            komut.Parameters.AddWithValue("@p4", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@p5", txtTur.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
            sayac();
            txtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            txtAd.Focus();
            sayac();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from TBLKITAPLAR where ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
            sayac();
            txtAd.Focus();
        }

        private void dgvKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dgvKitaplar.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAd.Text = dgvKitaplar.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtYazar.Text = dgvKitaplar.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSayfa.Text = dgvKitaplar.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtYayinevi.Text = dgvKitaplar.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTur.Text = dgvKitaplar.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
