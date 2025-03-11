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

namespace Proje21_MaliyetTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbMaliyetTest;Integrated Security=True;Encrypt=False");

        void MalzemeListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMalzemeler.DataSource = dt;
        }

        void UrunListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLURUNLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMalzemeler.DataSource = dt;
        }

        void Kasa()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLKASA", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMalzemeler.DataSource = dt;
        }

        //Ürünler listesini ComboBox'a Aktarma
        void Urunler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLURUNLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUrun.ValueMember = "URUNID";
            cmbUrun.DisplayMember = "AD";
            cmbUrun.DataSource = dt;
            baglanti.Close();
        }
        //Malzemeler listesini ComboBox'a Aktarma
        void Malzemeler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMalzeme.ValueMember = "MALZEMEID";
            cmbMalzeme.DisplayMember = "AD";
            cmbMalzeme.DataSource = dt;
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListesi();
            Urunler();
            Malzemeler();
        }

        private void btnUrunListesi_Click(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void btnMalzemeListesi_Click(object sender, EventArgs e)
        {
            MalzemeListesi();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            Kasa();
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMALZEMELER (AD,STOK,FIYAT,NOTLAR) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtMalzemeAd.Text);
            komut.Parameters.AddWithValue("@p2", decimal.Parse(txtMalzemeStok.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtMalzemeFiyat.Text));
            komut.Parameters.AddWithValue("@p4", txtMalzemeNotlar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MalzemeListesi();
            txtMalzemeID.Clear();
            txtMalzemeAd.Clear();
            txtMalzemeStok.Clear();
            txtMalzemeFiyat.Clear();
            txtMalzemeNotlar.Clear();
            txtMalzemeAd.Focus();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLURUNLER (AD) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListesi();
            txtUrunID.Clear();
            txtUrunAd.Clear();
            txtUrunAd.Focus();
        }

        private void btnUrunOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFIRIN (URUNID,MALZEMEID,MIKTAR,MALIYET) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtMiktar.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtMaliyet.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lstUrunler.Items.Add(cmbMalzeme.Text + " - " + txtMaliyet.Text);

            txtMiktar.Clear();
            txtMaliyet.Clear();
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;

            if (txtMiktar.Text == "")
            {
                txtMiktar.Text = "0";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLMALZEMELER where MALZEMEID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbMalzeme.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtMaliyet.Text = dr[3].ToString();
            }
            baglanti.Close();

            maliyet = Convert.ToDouble(txtMaliyet.Text) / 1000 * Convert.ToDouble(txtMiktar.Text);
            txtMaliyet.Text = maliyet.ToString();
        }

        private void cmbMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvMalzemeler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUrunID.Text = dgvMalzemeler.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUrunAd.Text = dgvMalzemeler.Rows[e.RowIndex].Cells[1].Value.ToString();

                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(MALIYET) from TBLFIRIN where URUNID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txtUrunID.Text);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    txtUrunMFiyat.Text = dr[0].ToString();
                }
                baglanti.Close();
            }
            catch (Exception)
            {

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLURUNLER set MFIYAT=@p1, SFIYAT=@p2, STOK=@p3 where URUNID=@p4", baglanti);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txtUrunMFiyat.Text));
            komut.Parameters.AddWithValue("@p2", decimal.Parse(txtUrunSFiyat.Text));
            komut.Parameters.AddWithValue("@p3", txtUrunStok.Text);
            komut.Parameters.AddWithValue("@p4", txtUrunID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListesi();
        }
    }
}
