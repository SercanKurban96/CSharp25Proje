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

namespace Proje05_FilmArsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbFilmArsivim;Integrated Security=True");

        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLFILMLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvFilmListesi.DataSource = dt;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFILMLER (AD,KATEGORI,LINK) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtFilmAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKategori.Text);
            komut.Parameters.AddWithValue("@p3", txtLink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film Listenize Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void btnTamEkran_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvFilmListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvFilmListesi.SelectedCells[0].RowIndex;
            string link = dgvFilmListesi.Rows[secilen].Cells[3].Value.ToString();
            webBrowser1.Navigate(link);
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Sercan KURBAN tarafından 1 Mart 2025 tarihinde kodlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Color[] renkler = { Color.Blue, Color.Yellow, Color.Black, Color.Red, Color.Gray, Color.Green, Color.Purple, Color.Pink, Color.Orange, Color.Navy };
            int sayi = rnd.Next(1, 10);

            this.BackColor = renkler[sayi];
        }
    }
}
