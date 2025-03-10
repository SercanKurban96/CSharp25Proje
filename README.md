# <img height="50" src="https://user-images.githubusercontent.com/25181517/121405384-444d7300-c95d-11eb-959f-913020d3bf90.png"> ile 25 Derste 25 Uygulamalı Proje

👋 Merhabalar, oluşturmuş olduğum bu repo, Udemy'de Murat Yücedağ tarafından verilen C# ile 25 Derste 25 Uygulamalı Proje adlı kursta yapmış olduğum sorguları içermektedir. Bu eğitimde C#, MSSQL ve Access ile yapılan projeler içermektedir.
<br><hr>

# 🖥️ Proje 1 - Öğrenci Sınav Not Kayıt Sistemi
Bu projenin amacı; her öğrencinin kendi numarasıyla sisteme giriş yaptıktan sonra kendi notlarını görüntülediği, öğretmenin de öğrenci eklemeyi, öğrencilerin sınav notları üzerinde değişiklik yapabildiği, not ekleyebildiği gibi işlemlerini gerçekleştiren bir not kayıt sistemidir.<br><br>

![image](https://github.com/user-attachments/assets/f01590b6-013d-4fc4-bf19-76af18c6e64e)
<br>
Veri tabanımızın ismini DbNotKayit olarak belirliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/89a6e970-5fc3-45fb-9df5-1ee66c07fec3)
<br>
Tablomuzun ismini TBLDERS olarak belirliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/ee0ee229-3570-4573-a66e-d9cc1e8387c5)
<br>
TBLDERS tablosuna ait örnek veri girişlerimizi yaptık.<br><br>

![image](https://github.com/user-attachments/assets/b4cf5fb2-ea92-4a5a-b67c-2310b4436ae5)
<br>
İlk Windows Form projemizi oluşturuyoruz. İsmini Proje01_NotKayitSistemi olarak belirledik.<br><br>

### 📝 Projede yer alacak Formlar;
📌 Öğrenci Giriş<br>
📌 Öğretmen Giriş<br>
📌 Öğretmen Sayfası<br>
📌 Öğrenci Sayfası<br><br>

![image](https://github.com/user-attachments/assets/ea5a78a6-763d-49b9-911d-a29e4eb4851a)
<br>
Giriş formu bu şekildedir. Burada hem öğrenci hem de öğretmen numaralarıyla giriş yapabilecektir. Öğrenci numarasını girdikten sonra Öğrenci Sayfası formuna gidecektir. Bunun için yeni bir form oluşturuyoruz ve ismini FrmOgrenciDetay olarak belirliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/e9931c1c-908a-4556-b4ed-aca6276866ba)
<br>
FrmOgrenciDetay formu bu şekildedir. Öğrenci numarasını girdikten sonra kendisine ait olan sınav bilgilerini burada görüntüleyebilir.<br><br>

![image](https://github.com/user-attachments/assets/cff4e44e-621b-4ce1-afe2-8cb111a045f6)
<br>
FrmOgretmenDetay formu bu şekildedir. Öğretmen numarasını girdikten sonra öğrenci ekleme, notları güncelleme ve notları görüntüleme işlemlerini yapabilir.<br><br>

### 📝 Form işleri tamamlandıktan sonra yapmamız gerekenler;
👨‍🎓 <b>Öğrenci Girişi İçin:</b><br><br>
📍 İlk olarak FrmGiris formunda öğrencinin numarasını girdiğimiz zaman FrmOgrenciDetay formundaki öğrencinin bilgileri yer almalıdır. FrmOgrenciDetay formuna gidiyoruz.<br>

![image](https://github.com/user-attachments/assets/6d49efef-0719-4602-99ef-357b15e71480)
<br>
Formun Load kısmına bir tane değişken oluşturuyoruz. Bu değişkenin erişim belirleyicisini diğer formlardan ulaşmak için "public" olarak belirliyoruz. String türünden numara olarak belirledik ve formun Load kısmına label'e vermiş olduğumuz frmNumara ismini maskedTextBox'a ait özellik olan Text özelliğini kullanarak numara değişkenine atıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/067a293a-f44f-4fdf-974b-0649e3094b46)
<br>
Burada numara değişkeni FrmGiris formundan gelecektir. Burada FrmOgrenciDetay formunda fr isminde bir tane nesne türettiğimiz için fr aracılığıyla FrmOgrenciDetay formundaki özelliklere ve public olan komutlara ulaşabiliyoruz. Burada numara adlı değişkene maskedTextBox'tan gelen değere atıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/de52f313-7358-41de-a971-3f9a393849dd)
<br>
Projemizi çalıştırdıktan sonra örnek olarak 1234 numaralı öğrenciye giriş yaptıralım.<br><br>

![image](https://github.com/user-attachments/assets/9ffd8915-7d44-4525-a0be-ed7b5f918eae)
<br>
Numara girişi yaptıktan sonra öğrenciye ait numarayı burada göstermiş oldu.<br><br>

Projemize SQL bağlantısı ekliyoruz. SQL bağlantı ekleme işlemi CSharpEducation ve SQLEducation repolarında yer almaktadır.<br><br>

![image](https://github.com/user-attachments/assets/75ea9668-bdea-4c57-b92f-759b2c8006e7)
<br>
FrmOgrenciDetay formunda yer alan kodlar bu şekildedir. Program çalıştırıldığı zaman herhangi bir öğrencinin numarası girildiği zaman sınav bilgileri yer alacaktır.<br><br>

🗒️ FrmOgretmenDetay formunda yer alan kod örnekleri ve çıktıları;<br><br>

![image](https://github.com/user-attachments/assets/52dfada7-af1f-4fc2-81f2-64b58e573f3d)
<br>

![image](https://github.com/user-attachments/assets/75cee505-b51c-43f3-9513-86f62bd95aaa)
<br>

![image](https://github.com/user-attachments/assets/217c8895-156f-45e5-80c7-3b4a482aaf0e)
<br>

![image](https://github.com/user-attachments/assets/787841dc-502d-4328-90f2-0af32c8ccb2a)
<br>

![image](https://github.com/user-attachments/assets/c218f43d-29c3-413f-91f5-cb485057c51a)
<br>

<hr>

# 🖥️ Proje 2 - Seçim İstatistik ve Grafik Sistemi
Bu projenin amacı; İstanbul'daki 5 farklı ilçede 5 farklı partinin seçim sonuçlarını grafiklerle, progressbar (durum çubuğu) ve istatistik bazında C# formda listeleyip gösterdiğimiz bir uygulamadır. Örneğin; 1. parti hayvan haklarını koruma derneğini, çocuk haklarını koruma derneğini vs. başkan seçilme işlemi yapılacaktır.<br><br>

📍 Partiler: A-B-C-D-E<br>
📍 İl: İstanbul<br>
📍 İlçeler: Şişli, Kadıköy, Beşiktaş, Beyoğlu, Sarıyer<br><br>

![image](https://github.com/user-attachments/assets/97101051-77cd-4986-9f31-631ade2d04c9)
<br>
Veri tabanımızın ismini DbSecimProje olarak belirliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/8e1935e7-458d-475d-b789-23c244a3bf6c)
<br>
Tablomuzun ismini TBLILCE olarak belirledik.<br><br>

![image](https://github.com/user-attachments/assets/54b5388a-04af-4291-b841-e471bd994047)
<br>
Projemizin ismini Proje02_VeriTabanliPartiSecimGrafikIstatistik olarak belirledik.<br><br>

### 🗒️ Projeye ait ekran görüntüleri:

![image](https://github.com/user-attachments/assets/caca65a3-3347-4f08-b613-afe98b1acfd9)
<br>
Form1 ismini FrmOyGiris olarak değiştirdik ve tasarımı bu şekilde tasarladık.<br><br>

![image](https://github.com/user-attachments/assets/905068fe-ca7f-49cf-847d-a75397c7de9a)
<br>
FrmGrafikler formumuzu bu şekilde tasarladık. Burada partilerin yanlarına birer tane ProgressBar aracı ekledik. ProgressBar aracının özelliğinde yer alan Maximum kısmını 200 olarak belirledik.<br><br>

![image](https://github.com/user-attachments/assets/003050be-8d8c-4856-8002-a0c5e4564b34)
<br>

![image](https://github.com/user-attachments/assets/3f2f2624-37ab-4db3-bdfc-98cbe094ad6c)
<br>

![image](https://github.com/user-attachments/assets/4c9b6405-0d70-4c36-9983-2f2242641d10)
<br><br>

<hr>

# 🖥️ Proje 3 - Passaparola Oyunu
## 📌 Nasıl Oynanır?

📍 Alfabedeki harflerden A ya tıklanır. (Rastgele bir harften de başlayabilirsiniz.)<br>
📍 Yarışmacıdan, tıklanan sorunun cevabı yazılması beklenir. (Hangi harfe tıklamışsanız cevap o harfle başlar)<br>
📍 Sorunun cevabı alttaki alana yazılır ve cevaplanır.<br>
📍 Sorunun cevabını bilemediğinizde pas deyip başka soruyu cevaplanabilir. Pas geçilen soru daha sonra tekrar cevaplanabilir. Hatalı cevaplanan sorular tekrar cevaplanamaz.<br>
📍 İşlem tüm harfler için uygulanır. Sorular cevaplandıktan sonra isteğe bağlı olarak skor kaydedilir.<br><br>

### 🗒️ Projeye ait ekran görüntüleri:
![image](https://github.com/user-attachments/assets/ade16bac-0ea6-40a8-b3b8-8e93d1c7b714)
<br>

![image](https://github.com/user-attachments/assets/6e611bd3-681e-48b9-85d5-6f16c6774767)
<br>

![image](https://github.com/user-attachments/assets/0a90de0c-1da5-4823-b8ee-53768d7fe9e5)
<br>

![image](https://github.com/user-attachments/assets/e5827279-bbf8-4cf1-8831-58de58f2804e)
<br>

![image](https://github.com/user-attachments/assets/30172a54-3d7b-4dad-a8dd-4c52e28482c6)
<br>

![image](https://github.com/user-attachments/assets/eb967524-7b76-4dc0-985f-44034ab752cd)
<br>

![image](https://github.com/user-attachments/assets/1d1f5655-bbd6-4fca-8329-3b893c04939c)
<br><br>

<hr>

# 🖥️ Proje 4 - XML Kullanımı ve Döviz Ofisi Uygulaması
Bu projede döviz çekme işlemini gerçekleştireceğiz. Burada Merkez Bankası'nın Döviz Kurları sitesinden döviz kurlarını çekme işlemini yapıyoruz.<br><br>

Türkiye Cumhuriyeti Merkez Bankası Kurları: https://www.tcmb.gov.tr/kurlar/today.xml
<br><br>

![image](https://github.com/user-attachments/assets/cd2e8f32-39b3-4275-b4c2-b4474d73769f)
<br>

![image](https://github.com/user-attachments/assets/1d278ec8-a694-49dd-bed2-6cd249c5036e)
<br>
Buradaki verilere ait kodları görüntüleyebilmek için sağ tıklayıp "Sayfa Kaynağını Görüntüle" diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/0137e3a9-a967-474d-a6db-c8bddec231e2)
<br>

![image](https://github.com/user-attachments/assets/7016b0e8-be5f-43ef-aaae-cc08325d71d6)
<br>
Burada kullanacağımız verileri seçip ilgili kodlamamızı yapıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/e37ed137-06a6-4561-8ed6-75ffeddfc885)
<br>

![image](https://github.com/user-attachments/assets/2eff5d01-3674-4b81-a578-10cf9af14efe)
<br>

![image](https://github.com/user-attachments/assets/b8a6feb9-2b14-47c1-a345-7e13feadf565)
<br>

![image](https://github.com/user-attachments/assets/fe5ebdea-0f35-4ab3-a43c-e54958d3dd2a)
<br><br>

<hr>

# 🖥️ Proje 5 - Masaüstü Kişisel Film Arşiv ve İzleme Sistemi
Bu projede bir film fragman uygulamasını gerçekleştireceğiz. Amaç; YouTube'daki favorilediğimiz filmleri bir çatı altında toplamak ve film aramadan bir butonla izleyebilmemizi sağlamaktır.<br><br>

![image](https://github.com/user-attachments/assets/fc4fc6bd-d1c3-4447-8561-5bb8936437fe)
<br>
Veri tabanımızın ismini DbFilmArsivim olarak belirliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/28622f17-328e-4bdd-a077-ee7efea41157)
<br>
Burada ID değerini otomatik artan ve DURUM sütununda yer alan bit değerini varsayılan olarak 0 yapıyoruz ve ismini TBLFILMLER diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/57749172-ba4c-4090-b6c7-612b1c0e2d2a)
<br>

![image](https://github.com/user-attachments/assets/b1fd268e-b9fc-400e-8a61-733afda3b412)
<br><br>

<hr>

# 🖥️ Proje 6 - İlişkili Veri Tabanı Hareket Tablo ve Sorgulama Uygulaması
Burada ilişkiyi ve alt sorguları kullanarak bir uygulama geliştireceğiz.<br><br>

### 🗒️ Kullanacağımız tablolar
📍 Ürün<br>
📍 Müşteri<br>
📍 Satıcı<br>
📍 Hareket<br><br>

![image](https://github.com/user-attachments/assets/8b948965-b9ac-485c-9a27-fa2133e9df2b)
<br>
Veri tabanın ismini DbIliskiliHareket olarak belirliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/52d1bfd7-75a0-4b2c-b8cc-fa81befa54f0)
<br>

![image](https://github.com/user-attachments/assets/08a5bdde-c04b-45df-b9d8-aae03a6ef19a)
<br>

![image](https://github.com/user-attachments/assets/fa3136bb-310c-4094-b98d-ccb92b8830f4)
<br>

![image](https://github.com/user-attachments/assets/1942b295-fd28-4037-90b5-8a842aed1411)
<br>
Tablolarımız ve ilişkili diyagramımız bu şekilde olacaktır.<br><br>

![image](https://github.com/user-attachments/assets/a29c98b8-a41f-427e-964e-6dc17711034b)
<br>

![image](https://github.com/user-attachments/assets/084e895f-899a-4938-a4d7-7cd8c4c3ca0f)
<br>

![image](https://github.com/user-attachments/assets/d2ec69d7-cbe7-48c7-b49f-aa7ecd663054)
<br>

![image](https://github.com/user-attachments/assets/d96eecad-3e1d-4e88-b15d-aacb1f78422e)
<br>
Örnek veri girişlerimizi yaptık.<br><br>

![image](https://github.com/user-attachments/assets/eab57b38-c5a2-4a66-93e0-991ac7e88894)
<br>

![image](https://github.com/user-attachments/assets/8b3e5417-a6fa-4966-a39e-87ae712c6583)
<br>
Örnek sorgularla birleştirme işlemleri ve prosedür oluşturma işlemi bu şekildedir.<br><br>

![image](https://github.com/user-attachments/assets/ad8b5107-5140-4594-b999-43b093b5f1d3)
<br>

![image](https://github.com/user-attachments/assets/2ea4892e-0fda-4c5d-aa7c-39db1653754f)
<br><br>

<hr>

# 🖥️ Proje 7 - Kelime Öğren! Access Kelime İngilizce Kelime Öğrenme Uygulaması
Bu projede Access veri tabanını kullanarak bir Türkçe-İngilizce kelime öğrenme uygulaması geliştireceğiz. Amaç, 90 saniyede gelen ingilizce kelimeleri bilmeye çalışmaktır.<br><br>

![image](https://github.com/user-attachments/assets/e3c85459-253e-477b-8469-795f2b14a816)
<br>
Burada label4'ü eklememizin sebebi Türkçe'ye karşılık gelen textBox metninin eşleştirmesini sağlamaktır, ancak burada label4'ün özellik kısmının Visible özelliğin false olarak ayarladık.<br><br>

![image](https://github.com/user-attachments/assets/912bc37a-d517-4447-8071-e8597c288649)
<br>

![image](https://github.com/user-attachments/assets/98887174-ad7e-4476-a80f-807437ac43df)
<br><br>

<hr>

# 🖥️ Proje 8 - İki Boyutlu Nesneleri Form Üzerinde Koordinat ve Hareketleri
📍 Form arka plan rengi: Silver<br>
📍 Kullanılan Araçlar: Panel (bariyerler için arka plan rengi beyaz), PictureBox (nesneyi hareket ettirmek için GIF dosyası olarak kullanıldı.), Timer<br>
:warning: PictureBox konumlarına bakmak için PictureBox'a ait özellikler kısmından Location'a bakılır (x, y).<br><br>

![image](https://github.com/user-attachments/assets/beb50bd0-d7b3-463f-85c8-37a0933306e0)
<br>

![image](https://github.com/user-attachments/assets/142215b9-8d2a-4979-8050-e0074984f2d1)
<br>

![image](https://github.com/user-attachments/assets/c13e9995-a392-4fcd-8726-97426cef19c6)
<br><br>

<hr>

# 🖥️ Proje 9 - Veri Tabanı ile Mail ve Telefon Rehber Kayıt Modülü
Bu projede MSSQL kullanarak bir tane Rehber Kayıt Modülü geliştireceğiz. Veri tabanımızın ismini DbRehber olarak belirledik.<br><br>

![image](https://github.com/user-attachments/assets/cf26b135-49b1-4b84-a9f3-4fd3c05cc7bd)
<br>
Daha sonradan FOTOGRAF isminde bir sütun ekleyeceğiz ve veri tipini varchar(100) olarak belirleyeceğiz.<br><br>

![image](https://github.com/user-attachments/assets/5a8ac219-e2ab-4fc4-a019-6ab8f50e564d)
<br>

![image](https://github.com/user-attachments/assets/7e8eca82-eae3-4044-be3f-994fcdf78522)
<br>

![image](https://github.com/user-attachments/assets/480ce776-c4b4-4624-b50c-72e4e70112e0)
<br>

![image](https://github.com/user-attachments/assets/452f75d1-3e3a-463c-b49a-fccec6c6d4a1)
<br>

![image](https://github.com/user-attachments/assets/637b8b57-4ec4-47b3-a325-43c6986540e9)
<br><br>

<hr>

# 🖥️ Proje 10 - İlişkili Tablolar ile Birleştirme Uygulamaları
Bu projede MSSQL üzerinden ilerleyeceğiz ve yazdığımız sorgudan sonra C# üzerinden DataGridView üzerinden göstereceğiz.<br><br>

Bir tane veri tabanı oluşturuyoruz, burada DbProje10 ismini verdik. Siz istediğiniz ismi verebilirsiniz. Ardından tablolarımızı oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/276a9fec-03af-4098-9cd9-22d63c7289b6)
<br>

![image](https://github.com/user-attachments/assets/7776dc5b-014e-4790-b4b9-8a8e622b3040)
<br>

![image](https://github.com/user-attachments/assets/2363498a-6e32-4ff1-be82-41cfe6a11af9)
<br>

![image](https://github.com/user-attachments/assets/ebedecdc-2b1b-42fc-b8ea-4b10581574f9)
<br>

![image](https://github.com/user-attachments/assets/12f9e9f1-0621-407d-906c-58d689f83294)
<br>
Tablolarımızı ve diyagramımızı oluşturduk.<br><br>

![image](https://github.com/user-attachments/assets/fae9072e-49f2-494e-87ca-055789165b14)
<br>

![image](https://github.com/user-attachments/assets/d500e060-c013-4f22-90ee-68388d9aea6b)
<br>

![image](https://github.com/user-attachments/assets/e642038e-278b-45f6-ba36-29e7962bd918)
<br><br>

<hr>

# 🖥️ Proje 11 - Kullanıcılar Arası Veri Tabanı Bağlantısı ile Mesajlaşma Sistemi
Bir önceki projemizde oluşturduğumuz veri tabanı üzerinden devam ediyoruz. Burada 2 tane daha tablo ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/980c6adf-af9c-40af-a900-f52fe453a74e)
<br>

![image](https://github.com/user-attachments/assets/2adeff2f-6890-4323-875a-f653cbc13f02)
<br>
Tablolarımızı bu şekilde oluşturduk.<br><br>

![image](https://github.com/user-attachments/assets/687321fb-0332-4323-a358-3ec112f7ce32)
<br>

![image](https://github.com/user-attachments/assets/b58ca1bf-3f49-4a10-a99f-034e3bdf0452)
<br>

![image](https://github.com/user-attachments/assets/2e90d0b1-fabe-43bd-b115-506ccf9fa3fa)
<br>

![image](https://github.com/user-attachments/assets/44e8ab8e-6296-4364-b988-3ffebc2d9543)
<br>

![image](https://github.com/user-attachments/assets/a6db6f81-61e8-4925-a210-9de9302e8764)
<br>

![image](https://github.com/user-attachments/assets/1bcbb63c-1303-4631-af59-4ab069f66861)
<br>

![image](https://github.com/user-attachments/assets/14420d2c-03f0-403f-831b-8bee151a624a)
<br><br>

<hr>

# 🖥️ Proje 12 - Form Üzerinde SQL Sorguları Çalıştırma Uygulaması (Mini SQL Derleyicisi)
Burada veri tabanı ve o veri tabanına ait tabloları seçme işlemini uyguluyoruz.<br><br>

![image](https://github.com/user-attachments/assets/4ea91320-28bd-405b-88e4-f8764656f0cd)
<br>

![image](https://github.com/user-attachments/assets/b376bcf9-4958-4a69-9020-3d1f09457190)
<br>

![image](https://github.com/user-attachments/assets/1a9504d2-8f3c-4be4-a4ba-8dfda7be3009)
<br>

![image](https://github.com/user-attachments/assets/b80453da-8993-4eeb-b433-b63d89af520b)
<br>

![image](https://github.com/user-attachments/assets/5a210e6a-3654-4c38-9e57-92b6a816ad61)
<br>

![image](https://github.com/user-attachments/assets/7662eda1-7846-4cdb-b557-84adc397c1c9)
<br>

![image](https://github.com/user-attachments/assets/8ffb22ed-37fb-4009-816b-663bb1009eba)
<br>

![image](https://github.com/user-attachments/assets/4f2831d3-1086-4b8a-bbac-89a91befe349)
<br><br>

<hr>

# 🖥️ Proje 13 - Veri Tabanı Verileri Şifreleme ve Şifreli Verileri Çözme Uygulaması

![image](https://github.com/user-attachments/assets/ad7c859a-fad0-471b-a6db-a0040235b351)
<br>
Burada en son oluşturduğumuz Proje10 veri tabanı üzerinden devam ediyoruz.<br><br>

![image](https://github.com/user-attachments/assets/23b29a6b-317d-4efc-ae26-a79dbcfa56ce)
<br>
Tabloyu bu şekilde oluşturduk.<br><br>

![image](https://github.com/user-attachments/assets/a4e49319-54a7-43e7-bfd1-12d0b40fd3ce)
<br>
Formumuzun tasarımını bu şekilde oluşturduk. Yazacağımız verilerin şifreleme işlemini label6'da göstereceğiz.<br><br>

![image](https://github.com/user-attachments/assets/3224f5f5-dbac-4d42-aa70-db6c97cf4bb3)
<br>
Örnek şifreleme işleminin kodları bu şekildedir.<br><br>

![image](https://github.com/user-attachments/assets/4e974eef-53fd-40c6-8cdc-2aa548735bce)
<br>

![image](https://github.com/user-attachments/assets/ef63a4fc-bc74-49c7-b361-c92ae8d02b6f)
<br>

![image](https://github.com/user-attachments/assets/597d4cbb-d15f-4a96-8d0c-192995842af5)
<br><br>

<hr>

# 🖥️ Proje 14 - Bankamatik Simülasyonu

![image](https://github.com/user-attachments/assets/fbecf7ad-b182-43eb-8254-82bce0448114)
<br>

![image](https://github.com/user-attachments/assets/d33b31c5-25b9-49ff-8ee1-7fe618db0918)
<br>

![image](https://github.com/user-attachments/assets/a162a866-2fc0-48ad-8337-c275178280f4)
<br>
Bu tabloda otomatik artan işlemi kullanılmamıştır.<br><br>

![image](https://github.com/user-attachments/assets/aa13b36d-15cb-476d-8391-ce1fd718e1ed)
<br>
Tablolarımızı bu şekilde oluşturduk. Şimdi yeni bir form oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/65f1d18f-68d1-47bd-9179-a984f76191e5)
<br>
Giriş formumuzu bu şekilde oluşturduk.<br><br>

![image](https://github.com/user-attachments/assets/6814e73d-eb31-4343-835e-38b7982b2fb4)
<br>
Burada kullanıcının hesap bilgilerini görüntüleyebilme ve para gönderme işlemlerini yapıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/29ad85a0-c1b6-49c1-ab45-b762aa07cbd8)
<br>
Burada yeni bir hesap oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/ca3f4edd-e305-449e-abdc-9c4d7a1b8486)
<br>

![image](https://github.com/user-attachments/assets/978133b1-1919-4427-ac2e-346e56fa5737)
<br><br>

<hr>

# 🖥️ Proje 15 - Öğrenci Etüt & Ders Kayıt Sistemi

![image](https://github.com/user-attachments/assets/193abaf5-dd92-4ad8-920e-08f8347d2376)
<br>

![image](https://github.com/user-attachments/assets/8f0a069f-8a79-4a10-9cf9-8540bd57d7e3)
<br>

![image](https://github.com/user-attachments/assets/5722767a-5683-4fe7-8775-992f3a5bdd95)
<br>

![image](https://github.com/user-attachments/assets/0272fd60-111a-433f-bc3e-dbb0e8745e84)
<br>

![image](https://github.com/user-attachments/assets/99be94e7-00ed-4129-9d8a-c3d82351b5db)
<br>
TBLETUT tablosunda DURUM kısmı Default olarak 0 belirlenmiştir.<br><br>

![image](https://github.com/user-attachments/assets/e7bae896-1345-450d-a3f0-8aad0e583a64)
<br>

![image](https://github.com/user-attachments/assets/e1b5cbba-ad34-419b-b669-c27a1d7d2d4f)
<br>

![image](https://github.com/user-attachments/assets/4a85afa4-39a3-498c-8861-5fc97bafb367)
<br>

![image](https://github.com/user-attachments/assets/a8cb06ba-407b-485f-97d0-97102f86ecb2)
<br>

![image](https://github.com/user-attachments/assets/e0a22897-de16-4d90-adb5-1b8c65e05944)
<br><br>

<hr>

# 🖥️ Proje 16 - Trigger Kullanarak Veri Tabanı Yedek Tablosu Oluşturma
Bu projede isterseniz var olan veri tabanına ait tablo üzerinden de yapabilirsiniz. Biz burada daha önce oluşturduğumuz DbProje10 adlı veri tabanı üzerinden tablo oluşturacağız.<br><br>

![image](https://github.com/user-attachments/assets/6424f096-e66a-434e-8808-33e10ed4ef58)
<br>

![image](https://github.com/user-attachments/assets/cbf64e18-a6fe-48ad-abba-3ab753f0450d)
<br>
Bu tabloda otomatik artan uygulanmamıştır. Edit Top 200 Rows'a geldiğimizde başlangıç değerini 0 yapıyoruz.<br><br>

<b>Kitap adetini birer birer arttırmak için yazacağımız SQL sorgusu:</b><br><br>
CREATE TRIGGER ARTTIR<br>
ON TBLKITAPLAR<br>
AFTER INSERT<br>
AS<br>
UPDATE TBLSAYAC SET ADET=ADET+1<br><br>

![image](https://github.com/user-attachments/assets/46da8670-bca8-4dc0-97ff-350ffa8a6eee)
<br>
Oluşturduğumuz TBLKITAPLAR tablosunda yer alan sütunların aynısını yazıyoruz ve tablomuzun ismini TBLKITAPYEDEK olarak kaydediyoruz.<br><br>

![image](https://github.com/user-attachments/assets/d70cd0b5-0f2c-4180-a66b-a69b54a68dc7)
<br>

![image](https://github.com/user-attachments/assets/9f531113-e1d5-4e75-9302-30f854059f70)
<br>

![image](https://github.com/user-attachments/assets/81dd234f-3a80-4177-8507-46bbb293ee86)
<br><br>

<b>Kitap adetini birer birer azaltmak için yazacağımız SQL sorgusu:</b><br><br>
CREATE TRIGGER AZALT<br>
ON TBLKITAPLAR<br>
AFTER DELETE<br>
AS<br>
UPDATE TBLSAYAC SET ADET=ADET-1<br><br>

<b>Yedekleme İşlemi İçin TBLKITAPLAR tablosundan sildiğimiz veriyi TBLKITAPYEDEK tablosuna aktarma işlemi için yazacağımız SQL sorgusu:</b><br><br>
CREATE TRIGGER YEDEK<br>
ON TBLKITAPLAR<br>
AFTER DELETE<br>
AS<br>
DECLARE @kitapad varchar(50)<br>
DECLARE @kitapyazar varchar(50)<br>
SELECT @kitapad=AD, @kitapyazar=YAZAR from deleted<br>
INSERT INTO TBLKITAPYEDEK(AD,YAZAR) VALUES (@kitapad,@kitapyazar)<br><br>

![image](https://github.com/user-attachments/assets/a42f0760-4a76-4e36-9e4d-804065f9a91a)
<br>

![image](https://github.com/user-attachments/assets/f5c40a3c-0c50-4b2c-98e2-835b553a9649)
<br><br>

<hr>

# 🖥️ Proje 17 - Veri Tabanı ile Yolcu Bilet Rezervasyon & Kayıt Sistemi

![image](https://github.com/user-attachments/assets/ae064127-1beb-46b2-bd0c-3697dc458018)
<br>

![image](https://github.com/user-attachments/assets/c69a9766-9471-4634-b916-2ab4fbe40ee8)
<br>

![image](https://github.com/user-attachments/assets/d0575de8-ca5c-4363-b161-d4335631487d)
<br>

![image](https://github.com/user-attachments/assets/056dff89-55ab-4718-99d5-7a401bc6f9b3)
<br>

![image](https://github.com/user-attachments/assets/356aee24-924a-4b85-95e9-d06cbdac93ab)
<br>
TBLSEFERBILGI tablosunda yer alan ID sütununa geldiğimizde otomatik artan kısmında yer alan Identity Seed değerini 1000 yapıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/0ede62c0-af12-4c78-a906-cb157a3a49ae)
<br>

![image](https://github.com/user-attachments/assets/463209f2-6428-46e2-9577-2eab8c1551d8)
<br>
TBLSEFERBILGI tablosunda küçük bir değişiklik yapılmıştır. ID yerine SEFERNO ismi, TARIH char(5) yerine char(15) olarak değiştirilmiştir.<br><br>

![image](https://github.com/user-attachments/assets/7d9689ff-bfd8-4c9e-b625-5f7f1c692b29)
<br>
TBLSEFERDETAY tablosunda ise SEFERNO char(6) yerine int olarak değiştirilmiştir.<br><br>

![image](https://github.com/user-attachments/assets/80e94f4e-d845-45d3-8ada-8af66fe8a398)
<br>

![image](https://github.com/user-attachments/assets/193547df-e938-4f8e-8454-6c71e36e63fd)
<br>
TBLYOLCUBILGI tablosunda ise CINSIYET bit yerine char(5) olarak değiştirilmiştir.<br><br>

![image](https://github.com/user-attachments/assets/9050c881-83e7-49e0-afab-fa0839112f92)
<br><br>

<hr>

# 🖥️ Proje 18 - Petrol & Akaryakıt Stok Takip Sistemi

Bu projede Petrol Ofisi'ne benzer bir simülasyon geliştireceğiz.<br><br>

![image](https://github.com/user-attachments/assets/14a2686a-2329-4a06-9241-345ff6823a05)
<br>

![image](https://github.com/user-attachments/assets/6897e12a-9d03-41f3-a53e-6dcca279503b)
<br>

![image](https://github.com/user-attachments/assets/6b4931f3-f043-4bee-b867-8982f5a77129)
<br>
TBLKASA tablosunda otomatik artan uygulanmamıştır.<br><br>

![image](https://github.com/user-attachments/assets/d122bdc5-7674-4bdb-984e-f66d9b42c3e9)
<br>

![image](https://github.com/user-attachments/assets/6577fdc7-8094-4225-a5dc-7a4ea56661a8)
<br>

![image](https://github.com/user-attachments/assets/d3c4e1f8-be1a-4459-8454-63a8e907d15c)
<br>

![image](https://github.com/user-attachments/assets/fbfcce3e-a4eb-4b86-b2f6-66e087035f5a)
<br>

![image](https://github.com/user-attachments/assets/ca0be4a5-e71c-4230-a144-c15ae6e0840f)
<br>

![image](https://github.com/user-attachments/assets/47bdccc9-f35f-423b-877b-5ba5499355f3)
<br><br>

<hr>

# 🖥️ Proje 19 - Dosya İşlemleri ile Resim Üzerine Yazı Yazma Uygulaması

<b>Bu projede kullanacağımız araçlar:</b><br><br>
📌 4 Button<br>
📌 2 Label<br>
📌 2 TextBox<br>
📌 1 PictureBox<br>
📌 1 OpenFileDialog<br>
📌 1 SaveFileDialog<br>
📌 1 ColorDialog<br><br>

![image](https://github.com/user-attachments/assets/4873918f-a485-4348-b3c6-01d9b6085c77)
<br>

![image](https://github.com/user-attachments/assets/272e8924-6a2c-45d0-9e35-5d838ec40bd2)
<br>

![image](https://github.com/user-attachments/assets/34172e3a-7196-42cf-886e-380f9b143cb7)
<br>

![image](https://github.com/user-attachments/assets/d31b7d51-429a-4a27-a25c-500978630b1a)
<br>

![image](https://github.com/user-attachments/assets/df11cf70-d1c4-4bc2-86e6-452d465a7bf0)
<br>

![image](https://github.com/user-attachments/assets/941d0790-3e2a-42ae-8588-af4a25bb6176)
<br>

![image](https://github.com/user-attachments/assets/9b8e1426-7c67-4c43-a34d-d229f6c2a283)
<br>

![image](https://github.com/user-attachments/assets/f2b5e432-c0b1-4ded-b4ac-11f917d2b1b8)
<br>

![image](https://github.com/user-attachments/assets/80aebe42-bfa4-4601-a76e-8e68143bac41)
<br>

![image](https://github.com/user-attachments/assets/11199775-e83f-462b-850b-331be50da787)
<br><br>

<hr>








