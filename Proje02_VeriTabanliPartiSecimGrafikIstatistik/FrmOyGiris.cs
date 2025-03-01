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

namespace Proje02_VeriTabanliPartiSecimGrafikIstatistik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOyGirisiYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtIlceAd.Text);
            komut.Parameters.AddWithValue("@p2", txtAParti.Text);
            komut.Parameters.AddWithValue("@p3", txtBParti.Text);
            komut.Parameters.AddWithValue("@p4", txtCParti.Text);
            komut.Parameters.AddWithValue("@p5", txtDParti.Text);
            komut.Parameters.AddWithValue("@p6", txtEParti.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtIlceAd.Clear();
            txtAParti.Clear();
            txtBParti.Clear();
            txtCParti.Clear();
            txtDParti.Clear();
            txtEParti.Clear();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
