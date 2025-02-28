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
