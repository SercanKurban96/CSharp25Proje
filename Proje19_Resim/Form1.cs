using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje19_Resim
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resim; //Burada hem resim seçme içerisinde hem de yazdırmanın içinde tanımlanacağı için global alana yazılmıştır.
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); //Açılan Gözat penceresini gösterir.
            resim = openFileDialog1.FileName; //"resim" değişkenine dosyanın ismini atama işlemini yapar.
        }

        Color renk; //Birden fazla alanda tanımladığımız için global alana yazılmıştır.
        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }

        Bitmap bmp; //Bitmap: Üzerinde değişiklik yapacağımız dosyalar için kullanılan uzantıdır.
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(resim); //openFileDialog'tan seçmiş olduğumuz dosyayı bmp Bitmap aracılığıyla işliyoruz.

            Graphics gr = Graphics.FromImage(bmp); //Grafik sınıfına resim üzerinden işlem yapmaktadır.

            gr.DrawString(txtMetin.Text, new Font("Segoe UI", Convert.ToInt16(txtBoyut.Text), FontStyle.Bold), new SolidBrush(renk), 20, 30);
            //1. String formatta txtMetin.Text üzerine işlemektedir.
            //2. Ardından yeni bir yazı font oluşturup ismini belirledikten sonra gireceğimiz boyutu txtBoyut.Text olarak belirliyoruz.
            //3. Font stilini belirliyoruz.
            //4. Fırça stilini belirleyip renk değerine aktarıyoruz.
            //5. Soldan ve yukarıdan uzaklık değerlerini belirliyoruz.

            pictureBox1.Image = bmp;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Resim|.jpg"; //Resmi .jpg formatında kaydeder.
            saveFileDialog1.ShowDialog(); //Dosya kayıtları için kullanılan openFileDialog penceresidir.
            bmp.Save(saveFileDialog1.FileName); //Düzenlemiş olduğumuz resmi kaydetmektedir.
        }
    }
}
