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

namespace Proje06_IliskiliHareketler
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbIliskiliHareket;Integrated Security=True");

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLURUNLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUrunler.DataSource = dt;
            txtUrunAd.Focus();
        }

        void Temizle()
        {
            txtUrunID.Clear();
            txtUrunAd.Clear();
            txtStok.Clear();
            txtAlisFiyat.Clear();
            txtSatisFiyat.Clear();
            txtUrunAd.Focus();
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            Listele();
            txtUrunAd.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLURUNLER (AD,STOK,ALISFIYAT,SATISFIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komut.Parameters.AddWithValue("@p2", byte.Parse(txtStok.Text));
            komut.Parameters.AddWithValue("@p3", short.Parse(txtAlisFiyat.Text));
            komut.Parameters.AddWithValue("@p4", short.Parse(txtSatisFiyat.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from TBLURUNLER where ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", byte.Parse(txtUrunID.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLURUNLER set AD=@p1,STOK=@p2,ALISFIYAT=@p3,SATISFIYAT=@p4 where ID=@p5", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komut.Parameters.AddWithValue("@p2", byte.Parse(txtStok.Text));
            komut.Parameters.AddWithValue("@p3", short.Parse(txtAlisFiyat.Text));
            komut.Parameters.AddWithValue("@p4", short.Parse(txtSatisFiyat.Text));
            komut.Parameters.AddWithValue("@p5", byte.Parse(txtUrunID.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUrunID.Text = dgvUrunler.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUrunAd.Text = dgvUrunler.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtStok.Text = dgvUrunler.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAlisFiyat.Text = dgvUrunler.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSatisFiyat.Text = dgvUrunler.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
