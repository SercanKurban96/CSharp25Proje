# <img height="50" src="https://user-images.githubusercontent.com/25181517/121405384-444d7300-c95d-11eb-959f-913020d3bf90.png"> ile 25 Derste 25 Uygulamalı Proje

👋 Merhabalar, oluşturmuş olduğum bu repo, Udemy'de Murat Yücedağ tarafından verilen C# ile 25 Derste 25 Uygulamalı Proje adlı kursta yapmış olduğum sorguları içermektedir. Bu eğitimde C# ve MSSQL ile yapılan projeler anlatılmaktadır.
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




