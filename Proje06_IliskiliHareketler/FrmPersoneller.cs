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
    public partial class FrmPersoneller: Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbIliskiliHareket;Integrated Security=True");

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLPERSONELLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPersoneller.DataSource = dt;
            txtPersonelAdSoyad.Focus();
        }

        void Temizle()
        {
            txtPersonelID.Clear();
            txtPersonelAdSoyad.Clear();
            txtPersonelAdSoyad.Focus();
        }

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            Listele();
            txtPersonelAdSoyad.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLPERSONELLER (AD) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtPersonelAdSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from TBLPERSONELLER where ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", byte.Parse(txtPersonelID.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLPERSONELLER set AD=@p1 where ID=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtPersonelAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", byte.Parse(txtPersonelID.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void dgvPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtPersonelID.Text = dgvPersoneller.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPersonelAdSoyad.Text = dgvPersoneller.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
