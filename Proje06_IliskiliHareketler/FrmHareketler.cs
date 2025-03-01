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
    public partial class FrmHareketler : Form
    {
        public FrmHareketler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbIliskiliHareket;Integrated Security=True");

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT HAREKETID, TBLURUNLER.AD, ADSOYAD, TBLPERSONELLER.AD, FIYAT FROM TBLHAREKETLER INNER JOIN TBLURUNLER ON TBLURUNLER.ID = TBLHAREKETLER.URUN INNER JOIN TBLMUSTERILER ON TBLMUSTERILER.ID = TBLHAREKETLER.MUSTERI INNER JOIN TBLPERSONELLER ON TBLPERSONELLER.ID = TBLHAREKETLER.PERSONEL", baglanti);
            //SqlDataAdapter da = new SqlDataAdapter("Execute Proje6", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHareketler.DataSource = dt;
        }

        private void FrmHareketler_Load(object sender, EventArgs e)
        {
            Listele();

            //Ürünleri ComboBox'a Aktarma
            SqlCommand komut = new SqlCommand("select * from TBLURUNLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUrun.DisplayMember = "AD";
            cmbUrun.ValueMember = "ID";
            cmbUrun.DataSource = dt;

            //Müşterileri ComboBox'a Aktarma
            SqlCommand komut2 = new SqlCommand("select * from TBLMUSTERILER", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbMusteri.DisplayMember = "ADSOYAD";
            cmbMusteri.ValueMember = "ID";
            cmbMusteri.DataSource = dt2;

            //Personelleri ComboBox'a Aktarma
            SqlCommand komut3 = new SqlCommand("select * from TBLPERSONELLER", baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            cmbPersonel.DisplayMember = "AD";
            cmbPersonel.ValueMember = "ID";
            cmbPersonel.DataSource = dt3;
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLHAREKETLER (URUN,MUSTERI,PERSONEL,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", byte.Parse(cmbUrun.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@p2", byte.Parse(cmbMusteri.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@p3", byte.Parse(cmbPersonel.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@p4", short.Parse(txtFiyat.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış Başarıyla Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            txtHareketID.Clear();
            txtFiyat.Clear();
        }

        private void dgvHareketler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtHareketID.Text = dgvHareketler.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbUrun.Text = dgvHareketler.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbMusteri.Text = dgvHareketler.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbPersonel.Text = dgvHareketler.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtFiyat.Text = dgvHareketler.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
