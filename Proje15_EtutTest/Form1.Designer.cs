namespace Proje15_EtutTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.cmbOgretmen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEtutOlustur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEtutVer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvEtutListesi = new System.Windows.Forms.DataGridView();
            this.txtOgrenciID = new System.Windows.Forms.TextBox();
            this.txtEtutID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnFotografYukle = new System.Windows.Forms.Button();
            this.pctFotograf = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnOgretmenEkle = new System.Windows.Forms.Button();
            this.txtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOgretmenAd = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbOgretmenDers = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtutListesi)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotograf)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEtutOlustur);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mskSaat);
            this.groupBox1.Controls.Add(this.mskTarih);
            this.groupBox1.Controls.Add(this.cmbOgretmen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // cmbDers
            // 
            this.cmbDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(120, 33);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(288, 32);
            this.cmbDers.TabIndex = 1;
            this.cmbDers.SelectedIndexChanged += new System.EventHandler(this.cmbDers_SelectedIndexChanged);
            // 
            // cmbOgretmen
            // 
            this.cmbOgretmen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgretmen.FormattingEnabled = true;
            this.cmbOgretmen.Location = new System.Drawing.Point(120, 82);
            this.cmbOgretmen.Name = "cmbOgretmen";
            this.cmbOgretmen.Size = new System.Drawing.Size(288, 32);
            this.cmbOgretmen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğretmen:";
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(120, 132);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(288, 30);
            this.mskTarih.TabIndex = 4;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(120, 179);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(288, 30);
            this.mskSaat.TabIndex = 5;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tarih:";
            // 
            // btnEtutOlustur
            // 
            this.btnEtutOlustur.Location = new System.Drawing.Point(120, 224);
            this.btnEtutOlustur.Name = "btnEtutOlustur";
            this.btnEtutOlustur.Size = new System.Drawing.Size(288, 42);
            this.btnEtutOlustur.TabIndex = 8;
            this.btnEtutOlustur.Text = "Etüt Oluştur";
            this.btnEtutOlustur.UseVisualStyleBackColor = true;
            this.btnEtutOlustur.Click += new System.EventHandler(this.btnEtutOlustur_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEtutID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtOgrenciID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnEtutVer);
            this.groupBox2.Location = new System.Drawing.Point(461, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnEtutVer
            // 
            this.btnEtutVer.BackColor = System.Drawing.Color.Aqua;
            this.btnEtutVer.Location = new System.Drawing.Point(110, 107);
            this.btnEtutVer.Name = "btnEtutVer";
            this.btnEtutVer.Size = new System.Drawing.Size(269, 42);
            this.btnEtutVer.TabIndex = 8;
            this.btnEtutVer.Text = "Etüt Ver";
            this.btnEtutVer.UseVisualStyleBackColor = false;
            this.btnEtutVer.Click += new System.EventHandler(this.btnEtutVer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Öğrenci:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvEtutListesi);
            this.groupBox3.Location = new System.Drawing.Point(21, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1193, 289);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dgvEtutListesi
            // 
            this.dgvEtutListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEtutListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtutListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEtutListesi.Location = new System.Drawing.Point(3, 26);
            this.dgvEtutListesi.Name = "dgvEtutListesi";
            this.dgvEtutListesi.RowHeadersWidth = 51;
            this.dgvEtutListesi.RowTemplate.Height = 24;
            this.dgvEtutListesi.Size = new System.Drawing.Size(1187, 260);
            this.dgvEtutListesi.TabIndex = 0;
            this.dgvEtutListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtutListesi_CellClick);
            // 
            // txtOgrenciID
            // 
            this.txtOgrenciID.Location = new System.Drawing.Point(110, 71);
            this.txtOgrenciID.Name = "txtOgrenciID";
            this.txtOgrenciID.Size = new System.Drawing.Size(269, 30);
            this.txtOgrenciID.TabIndex = 15;
            // 
            // txtEtutID
            // 
            this.txtEtutID.Enabled = false;
            this.txtEtutID.Location = new System.Drawing.Point(110, 35);
            this.txtEtutID.Name = "txtEtutID";
            this.txtEtutID.Size = new System.Drawing.Size(269, 30);
            this.txtEtutID.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Etüt ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDersAdi);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.btnDersEkle);
            this.groupBox4.Location = new System.Drawing.Point(461, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 121);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnOgrenciEkle);
            this.groupBox5.Controls.Add(this.mskTelefon);
            this.groupBox5.Controls.Add(this.txtMail);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtSinif);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtOgrenciSoyad);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtOgrenciAd);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(901, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(313, 288);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(101, 29);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(192, 30);
            this.txtOgrenciAd.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(52, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ad:";
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(101, 65);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(192, 30);
            this.txtOgrenciSoyad.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Soyad:";
            // 
            // txtSinif
            // 
            this.txtSinif.Location = new System.Drawing.Point(101, 101);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(192, 30);
            this.txtSinif.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(36, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sınıf:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "Telefon:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(101, 173);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(192, 30);
            this.txtMail.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(36, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "Mail:";
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(101, 137);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(192, 30);
            this.mskTelefon.TabIndex = 26;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackColor = System.Drawing.Color.Aqua;
            this.btnOgrenciEkle.Location = new System.Drawing.Point(24, 223);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(269, 42);
            this.btnOgrenciEkle.TabIndex = 27;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = false;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(121, 29);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(269, 30);
            this.txtDersAdi.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(20, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "Ders Adı:";
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.BackColor = System.Drawing.Color.Aqua;
            this.btnDersEkle.Location = new System.Drawing.Point(121, 65);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(269, 42);
            this.btnDersEkle.TabIndex = 16;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = false;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pctFotograf);
            this.groupBox6.Controls.Add(this.btnFotografYukle);
            this.groupBox6.Location = new System.Drawing.Point(1220, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(313, 288);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // btnFotografYukle
            // 
            this.btnFotografYukle.BackColor = System.Drawing.Color.Aqua;
            this.btnFotografYukle.Location = new System.Drawing.Point(24, 223);
            this.btnFotografYukle.Name = "btnFotografYukle";
            this.btnFotografYukle.Size = new System.Drawing.Size(269, 42);
            this.btnFotografYukle.TabIndex = 27;
            this.btnFotografYukle.Text = "Fotoğraf Yükle";
            this.btnFotografYukle.UseVisualStyleBackColor = false;
            this.btnFotografYukle.Click += new System.EventHandler(this.btnFotografYukle_Click);
            // 
            // pctFotograf
            // 
            this.pctFotograf.Location = new System.Drawing.Point(6, 22);
            this.pctFotograf.Name = "pctFotograf";
            this.pctFotograf.Size = new System.Drawing.Size(301, 186);
            this.pctFotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFotograf.TabIndex = 28;
            this.pctFotograf.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbOgretmenDers);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.btnOgretmenEkle);
            this.groupBox7.Controls.Add(this.txtOgretmenSoyad);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.txtOgretmenAd);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Location = new System.Drawing.Point(1220, 311);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(313, 288);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // btnOgretmenEkle
            // 
            this.btnOgretmenEkle.BackColor = System.Drawing.Color.Aqua;
            this.btnOgretmenEkle.Location = new System.Drawing.Point(24, 179);
            this.btnOgretmenEkle.Name = "btnOgretmenEkle";
            this.btnOgretmenEkle.Size = new System.Drawing.Size(269, 42);
            this.btnOgretmenEkle.TabIndex = 27;
            this.btnOgretmenEkle.Text = "Öğretmen Ekle";
            this.btnOgretmenEkle.UseVisualStyleBackColor = false;
            this.btnOgretmenEkle.Click += new System.EventHandler(this.btnOgretmenEkle_Click);
            // 
            // txtOgretmenSoyad
            // 
            this.txtOgretmenSoyad.Location = new System.Drawing.Point(101, 65);
            this.txtOgretmenSoyad.Name = "txtOgretmenSoyad";
            this.txtOgretmenSoyad.Size = new System.Drawing.Size(192, 30);
            this.txtOgretmenSoyad.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(30, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 24);
            this.label16.TabIndex = 18;
            this.label16.Text = "Soyad:";
            // 
            // txtOgretmenAd
            // 
            this.txtOgretmenAd.Location = new System.Drawing.Point(101, 29);
            this.txtOgretmenAd.Name = "txtOgretmenAd";
            this.txtOgretmenAd.Size = new System.Drawing.Size(192, 30);
            this.txtOgretmenAd.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(54, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 24);
            this.label17.TabIndex = 16;
            this.label17.Text = "Ad:";
            // 
            // cmbOgretmenDers
            // 
            this.cmbOgretmenDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgretmenDers.FormattingEnabled = true;
            this.cmbOgretmenDers.Location = new System.Drawing.Point(101, 101);
            this.cmbOgretmenDers.Name = "cmbOgretmenDers";
            this.cmbOgretmenDers.Size = new System.Drawing.Size(192, 32);
            this.cmbOgretmenDers.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(40, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 24);
            this.label13.TabIndex = 28;
            this.label13.Text = "Ders:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1539, 611);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etüt Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtutListesi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctFotograf)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.Button btnEtutOlustur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.ComboBox cmbOgretmen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEtutVer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvEtutListesi;
        private System.Windows.Forms.TextBox txtOgrenciID;
        private System.Windows.Forms.TextBox txtEtutID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pctFotograf;
        private System.Windows.Forms.Button btnFotografYukle;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cmbOgretmenDers;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnOgretmenEkle;
        private System.Windows.Forms.TextBox txtOgretmenSoyad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtOgretmenAd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

