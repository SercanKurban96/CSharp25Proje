namespace Proje13_SifreliVeriler
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
            this.dgvVeriler = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSifreCoz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVeriler
            // 
            this.dgvVeriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeriler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVeriler.Location = new System.Drawing.Point(0, 238);
            this.dgvVeriler.Name = "dgvVeriler";
            this.dgvVeriler.RowHeadersWidth = 51;
            this.dgvVeriler.RowTemplate.Height = 24;
            this.dgvVeriler.Size = new System.Drawing.Size(1078, 234);
            this.dgvVeriler.TabIndex = 0;
            this.dgvVeriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeriler_CellClick);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(606, 112);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(158, 48);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(147, 37);
            this.txtAd.MaxLength = 100;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(248, 30);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(147, 73);
            this.txtSoyad.MaxLength = 100;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(248, 30);
            this.txtSoyad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(147, 109);
            this.txtMail.MaxLength = 100;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(248, 30);
            this.txtMail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mail:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(564, 37);
            this.txtSifre.MaxLength = 100;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(248, 30);
            this.txtSifre.TabIndex = 9;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifre:";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(564, 73);
            this.txtHesapNo.MaxLength = 100;
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(248, 30);
            this.txtHesapNo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hesap No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(840, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // btnSifreCoz
            // 
            this.btnSifreCoz.Location = new System.Drawing.Point(606, 166);
            this.btnSifreCoz.Name = "btnSifreCoz";
            this.btnSifreCoz.Size = new System.Drawing.Size(158, 48);
            this.btnSifreCoz.TabIndex = 13;
            this.btnSifreCoz.Text = "Şifre Çöz";
            this.btnSifreCoz.UseVisualStyleBackColor = true;
            this.btnSifreCoz.Click += new System.EventHandler(this.btnSifreCoz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1078, 472);
            this.Controls.Add(this.btnSifreCoz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgvVeriler);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifreli Veriler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVeriler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSifreCoz;
    }
}

