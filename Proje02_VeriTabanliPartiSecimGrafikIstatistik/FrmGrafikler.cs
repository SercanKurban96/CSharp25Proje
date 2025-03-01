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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //İlçe Adlarını ComboBox'a Çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ILCEAD from TBLILCE", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlceSecin.Items.Add(dr[0]);
            }
            baglanti.Close();

            //Grafiğe Toplam Sonuçları Getirme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(APARTI),sum(BPARTI),sum(CPARTI),sum(DPARTI),sum(EPARTI) from TBLILCE", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", dr2[4]);
            }
            baglanti.Close();
        }

        private void cmbIlceSecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLILCE where ILCEAD=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbIlceSecin.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                prbAParti.Value = int.Parse(dr[2].ToString());
                prbBParti.Value = int.Parse(dr[3].ToString());
                prbCParti.Value = int.Parse(dr[4].ToString());
                prbDParti.Value = int.Parse(dr[5].ToString());
                prbEParti.Value = int.Parse(dr[6].ToString());

                lblAParti.Text = dr[2].ToString();
                lblBParti.Text = dr[3].ToString();
                lblCParti.Text = dr[4].ToString();
                lblDParti.Text = dr[5].ToString();
                lblEParti.Text = dr[6].ToString();
            }
            baglanti.Close();
        }
    }
}
