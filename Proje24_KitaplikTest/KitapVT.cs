using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Proje24_KitaplikTest
{
    class KitapVT
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=Kitaplik.mdb");

        //Listeleme İşlemi
        public List<Kitap> Liste() //Burada erişimi public olarak belirleyip List türünden Kitap sınıfını alıyoruz ve ismini Liste olarak belirliyoruz.
        {
            List<Kitap> ktp = new List<Kitap>(); //Burada List türünden Kitap sınıfını alıp ktp adlı değişkenimizi oluşturuyoruz.
            baglanti.Open(); //Bağlantıyı açıyoruz.
            OleDbCommand komut = new OleDbCommand("select * from Kitaplar", baglanti); //Kitaplar tablosundaki verileri çağırmak için ilgili sorgumuzu yazıyoruz.
            OleDbDataReader dr = komut.ExecuteReader(); //Verileri okuma işlemi yapıyoruz.
            while (dr.Read()) //Buradaki verileri okuduğu sürece...
            {
                Kitap k = new Kitap(); //Kitap sınıfından k adlı bir değişken üretiyoruz.
                k.ID = Convert.ToInt16(dr[0].ToString()); //İlk sütun olan ID'yi ekliyoruz.
                k.ADI = dr[1].ToString(); //İkinci sütun olan ADI ekliyoruz.
                k.YAZARI = dr[2].ToString(); //Üçüncü ve son sütun olan YAZARI ekliyoruz.

                ktp.Add(k); //Burada ktp değişkeninden gelen değeri k nesnesinden gelen değerine ekliyoruz.
            }
            baglanti.Close(); //Bağlantıyı kapatıyoruz.
            return ktp; //Programın hata vermemesi için return komutunu kullanarak geriye değer döndürme işlemini uyguluyoruz. Burada ktp değerini döndürüyoruz.
        }

        //Ekleme İşlemi
        public void KitapEkle(Kitap kt)
        {
            baglanti.Open(); //Bağlantıyı açıyoruz.
            OleDbCommand komut = new OleDbCommand("insert into Kitaplar (KitapAd,Yazar) values (@p1,@p2)", baglanti); //Kitaplar tablosundaki verileri eklemek için ilgili sorgumuzu yazıyoruz. Burada @p1, @p2 parametreleri Kitaplar tablosunda yer alan sütunlara karşılık gelmektedir.
            komut.Parameters.AddWithValue("@p1", kt.ADI); //@p1 parametresi KitapAd sütununa karşılık gelen değer
            komut.Parameters.AddWithValue("@p2", kt.YAZARI); //@p2 parametresi Yazar sütununa karşılık gelen değer
            komut.ExecuteNonQuery(); //Değişiklikleri kaydetmek için kullandığımız komuttur.
            baglanti.Close(); //Bağlantıyı kapatıyoruz.
        }
    }
}
