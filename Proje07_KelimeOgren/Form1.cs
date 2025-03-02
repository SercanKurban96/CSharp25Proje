using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proje07_KelimeOgren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=dbSozluk.mdb");
        Random rnd = new Random();
        int sure = 90;
        int kelime = 0;

        void getir()
        {
            int sayi;
            sayi = rnd.Next(1, 2490);

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtIngilizce.Text = dr[1].ToString();
                lblCevap.Text = dr[2].ToString(); //ürettiği sayıdaki ID'ye ait ingilize kelimenin türkçesini getirecektir.
                lblCevap.Text = lblCevap.Text.ToLower();
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            txtIngilizce.Text = "";
            txtTurkce.Focus();
            btnBaslat.Enabled = true;
            btnPas.Enabled = false;
            txtTurkce.Enabled = false;
            kelime = 0;
        }

        private void txtTurkce_TextChanged(object sender, EventArgs e)
        {
            if (txtTurkce.Text == lblCevap.Text)
            {
                kelime++;
                lblKelime.Text = kelime.ToString();
                getir();
                txtTurkce.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                txtTurkce.Enabled = false;
                timer1.Stop();
                btnBaslat.Enabled = true;
                btnPas.Enabled = false;
                kelime = 0;
            }
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            btnBaslat.Enabled = false;
            getir();
            txtTurkce.Clear();
            txtTurkce.Focus();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            kelime = 0;
            lblKelime.Text = kelime.ToString();
            sure = 90;
            getir();
            timer1.Start();
            txtTurkce.Clear();     
            btnBaslat.Enabled = false;
            btnPas.Enabled = true;
            txtTurkce.Enabled = true;
            txtTurkce.Focus();
        }
    }
}
