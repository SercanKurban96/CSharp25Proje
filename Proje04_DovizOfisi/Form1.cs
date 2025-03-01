using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proje04_DovizOfisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml"; //Bugünün kurları yer almaktadır.

            var xmldosya = new XmlDocument(); //Burada yeni bir XML dokuman nesnesi oluşturduk.
            xmldosya.Load(bugun); //Bugünden gelen değerleri XML dosyasına yükleyecektir.

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml; //Burada bugun değişkeninde yer alan XML sitesine sağ tıklayıp "Sayfa Kaynağını Görüntüle" dedikten sonra burada tüm veriler yer almaktadır. Buradan Tarih_Date, Currency, Kod ve BanknoteBuying olanları alıyoruz.
            lblDolarAlis.Text = dolaralis;

            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml; //Burada bugun değişkeninde yer alan XML sitesine sağ tıklayıp "Sayfa Kaynağını Görüntüle" dedikten sonra burada tüm veriler yer almaktadır. Buradan Tarih_Date, Currency, Kod ve BanknoteSelling olanları alıyoruz.
            lblDolarSatis.Text = dolarsatis;

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEuroAlis.Text = euroalis;

            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuroSatis.Text = eurosatis;
        }

        private void btnDolarAl_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarAlis.Text;
        }

        private void btnDolarSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarSatis.Text;
        }

        private void btnEuroAl_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroAlis.Text;
        }

        private void btnEuroSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroSatis.Text;
        }

        private void btnIslem1_Click(object sender, EventArgs e)
        {
            //Kur değeri ile miktar değerinin çarpımı tutara yansıtma işlemi
            double kur, miktar, tutar;
            kur = Convert.ToDouble(txtKur.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = kur * miktar;
            txtTutar.Text = tutar.ToString();
        }

        private void txtKur_TextChanged(object sender, EventArgs e)
        {     
            txtKur.Text = txtKur.Text.Replace(".", ","); //Buradaki amaç, kur ile miktar çarpımından sonra yapılan hesap değerini virgülle ayıramamaktadır. Buradaki yazacağımız kod, tutarı hesapladıktan sonra virgülle ayıracaktır. Örneğin dolar alış 36,3557 ile miktarın 100 ile çarpımından sonra çıkan sonuç 3635,57 olarak gözükecektir.
        }

        private void btnIslem2_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(txtKur.Text);
            int miktar = Convert.ToInt32(txtMiktar.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            txtTutar.Text = tutar.ToString();
            double kalan = miktar % kur;
            txtKalan.Text = kalan.ToString();
        }
    }
}
