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

namespace Proje14_BankaTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string hesapNo;
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True;Encrypt=False");

        private void Form2_Load(object sender, EventArgs e)
        {
            lblHesapNo.Text = hesapNo;

            //Hesap No'ya Göre Kullanıcının Bilgilerini Taşıma
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLKISILER where HESAPNO=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", hesapNo);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
                lblTC.Text = dr[3].ToString();
                lblTelefon.Text = dr[4].ToString();
            }
            baglanti.Close();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            //Gönderilen Hesabın Para Artışı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE+@p1 where HESAPNO=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txtTutar.Text));
            komut.Parameters.AddWithValue("@p2", mskHesapNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            //Gönderilen Hesabın Para Azalışı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE-@k1 where HESAPNO=@k2", baglanti);
            komut2.Parameters.AddWithValue("@k1", decimal.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@k2", hesapNo);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //
        }
    }
}
