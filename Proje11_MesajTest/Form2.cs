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

namespace Proje11_MesajTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbProje10;Integrated Security=True;Encrypt=False");

        void gelenkutusu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MESAJID, (AD + ' ' + SOYAD) AS GONDEREN, BASLIK, ICERIK from TBLMESAJLAR INNER JOIN TBLKISILER ON TBLKISILER.NUMARA = TBLMESAJLAR.GONDEREN where ALICI=" + numara, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGelenKutusu.DataSource = dt;
        }

        void gidenkutusu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MESAJID, (AD + ' ' + SOYAD) AS ALICI, BASLIK, ICERIK from TBLMESAJLAR INNER JOIN TBLKISILER ON TBLKISILER.NUMARA = TBLMESAJLAR.ALICI where GONDEREN=" + numara, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGidenKutusu.DataSource = dt;
        }

        void temizle()
        {
            txtBaslik.Clear();
            mskAlici.Clear();
            rchMesaj.Clear();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            gelenkutusu();
            gidenkutusu();

            //Adı Soyadı Çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select AD,SOYAD from TBLKISILER where NUMARA=" + numara, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            baglanti.Close();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            komut.Parameters.AddWithValue("@p2", mskAlici.Text);
            komut.Parameters.AddWithValue("@p3", txtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", rchMesaj.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız İletildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gidenkutusu();
            temizle();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
