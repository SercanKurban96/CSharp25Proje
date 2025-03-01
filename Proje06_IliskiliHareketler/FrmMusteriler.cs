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

namespace Proje06_IliskiliHareketler
{
    public partial class FrmMusteriler: Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbIliskiliHareket;Integrated Security=True");

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLMUSTERILER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMusteriler.DataSource = dt;
            txtMusteriAdSoyad.Focus();
        }

        void Temizle()
        {
            txtMusteriID.Clear();
            txtMusteriAdSoyad.Clear();
            txtMusteriAdSoyad.Focus();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            Listele();
            txtMusteriAdSoyad.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMUSTERILER (ADSOYAD) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtMusteriAdSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from TBLMUSTERILER where ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", byte.Parse(txtMusteriID.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLMUSTERILER set ADSOYAD=@p1 where ID=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtMusteriAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", byte.Parse(txtMusteriID.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMusteriID.Text = dgvMusteriler.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMusteriAdSoyad.Text = dgvMusteriler.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
