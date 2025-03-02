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

namespace Proje12_SorguTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //veri tabanlarını çekme
        void databases()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Encrypt=False");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select name from sys.databases", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbVeriTabani.Items.Add(dr[0].ToString());
            }
            baglanti.Close();
        }

        //veri tabanlarına ait tabloları çekme
        void tables()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=" + cmbVeriTabani.Text + ";Integrated Security=True;Encrypt=False");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from sys.tables", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbTablolar.Items.Add(dr[0].ToString());
            }
            baglanti.Close();
        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=" + cmbVeriTabani.Text + ";Integrated Security=True;Encrypt=False");
            string sorgu = rchSorgu.Text; //Burada kendimiz SQL sorgularını richTextBox üzerinden yazıyoruz.

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSorgu.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorgunuzu kontrol edin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkleSilGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=" + cmbVeriTabani.Text + ";Integrated Security=True;Encrypt=False");
            string sorgu = rchSorgu.Text;

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                SqlDataAdapter da = new SqlDataAdapter("select * from TBLMATEMATIK", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSorgu.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorgunuzu kontrol edin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            databases();
            SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=" + cmbVeriTabani.Text + ";Integrated Security=True;Encrypt=False");
        }

        private void cmbVeriTabani_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTablolar.Items.Clear();
            tables();
        }

        private void cmbTablolar_SelectedIndexChanged(object sender, EventArgs e)
        {
            rchSorgu.Text = "select * from " + " " + cmbTablolar.Text;
        }
    }
}
