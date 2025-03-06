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

namespace Proje13_SifreliVeriler
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
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLVERILER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvVeriler.DataSource = dt;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            byte[] addizi = ASCIIEncoding.ASCII.GetBytes(ad); //ASCII kodlarını kullanarak şifreleme işlemini Byte olarak değerini alacaktır.
            string adsifre = Convert.ToBase64String(addizi); //ToBase64 kullanılan şifreleme yöntemlerinden bir tanesidir.
            //label6.Text = adsifre; //Burada şifreleme işlemini label6'ya yazdırdık. Burada küçük bir deneme yapmış olduk.

            string soyad = txtSoyad.Text;
            byte[] soyaddizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadsifre = Convert.ToBase64String(soyaddizi);

            string mail = txtMail.Text;
            byte[] maildizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailsifre = Convert.ToBase64String(maildizi);

            string sifre = txtSifre.Text;
            byte[] sifredizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifresifre = Convert.ToBase64String(sifredizi);

            string hesapno = txtHesapNo.Text;
            byte[] hesapnodizi = ASCIIEncoding.ASCII.GetBytes(hesapno);
            string hesapnosifre = Convert.ToBase64String(hesapnodizi);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLVERILER (AD,SOYAD,MAIL,SIFRE,HESAPNO) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", adsifre);
            komut.Parameters.AddWithValue("@p2", soyadsifre);
            komut.Parameters.AddWithValue("@p3", mailsifre);
            komut.Parameters.AddWithValue("@p4", sifresifre);
            komut.Parameters.AddWithValue("@p5", hesapnosifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

            //string adcozum = txtAd.Text;
            //byte[] adcozumdizi = Convert.FromBase64String(adcozum);
            //string adverisi = ASCIIEncoding.ASCII.GetString(adcozumdizi);
            //label6.Text = adverisi;
        }

        private void btnSifreCoz_Click(object sender, EventArgs e)
        {
            //İsmi girilen veriyi label6'ya şifreyi çözmüş formatında yazdırma
            string adcozum = txtAd.Text;
            byte[] adcozumdizi = Convert.FromBase64String(adcozum);
            string adverisi = ASCIIEncoding.ASCII.GetString(adcozumdizi);
            label6.Text = adverisi;
        }

        private void dgvVeriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAd.Text = dgvVeriler.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoyad.Text = dgvVeriler.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMail.Text = dgvVeriler.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSifre.Text = dgvVeriler.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtHesapNo.Text = dgvVeriler.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {

            }   
        }
    }
}
