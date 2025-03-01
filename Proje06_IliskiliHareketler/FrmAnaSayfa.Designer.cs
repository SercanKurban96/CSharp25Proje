namespace Proje06_IliskiliHareketler
{
    partial class FrmAnaSayfa
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
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnHareketlerTablosu = new System.Windows.Forms.Button();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnHareketler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUrunler
            // 
            this.btnUrunler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunler.Location = new System.Drawing.Point(12, 12);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(201, 117);
            this.btnUrunler.TabIndex = 0;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriler.Location = new System.Drawing.Point(412, 12);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(201, 117);
            this.btnMusteriler.TabIndex = 1;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = true;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnHareketlerTablosu
            // 
            this.btnHareketlerTablosu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHareketlerTablosu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHareketlerTablosu.Location = new System.Drawing.Point(213, 133);
            this.btnHareketlerTablosu.Name = "btnHareketlerTablosu";
            this.btnHareketlerTablosu.Size = new System.Drawing.Size(201, 117);
            this.btnHareketlerTablosu.TabIndex = 2;
            this.btnHareketlerTablosu.Text = "Hareketler Tablosu";
            this.btnHareketlerTablosu.UseVisualStyleBackColor = true;
            this.btnHareketlerTablosu.Click += new System.EventHandler(this.btnHareketlerTablosu_Click);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersoneller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersoneller.Location = new System.Drawing.Point(12, 254);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(201, 117);
            this.btnPersoneller.TabIndex = 3;
            this.btnPersoneller.Text = "Personeller";
            this.btnPersoneller.UseVisualStyleBackColor = true;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnHareketler
            // 
            this.btnHareketler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHareketler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHareketler.Location = new System.Drawing.Point(412, 254);
            this.btnHareketler.Name = "btnHareketler";
            this.btnHareketler.Size = new System.Drawing.Size(201, 117);
            this.btnHareketler.TabIndex = 4;
            this.btnHareketler.Text = "Hareketler";
            this.btnHareketler.UseVisualStyleBackColor = true;
            this.btnHareketler.Click += new System.EventHandler(this.btnHareketler_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(625, 383);
            this.Controls.Add(this.btnHareketler);
            this.Controls.Add(this.btnPersoneller);
            this.Controls.Add(this.btnHareketlerTablosu);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.btnUrunler);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnHareketlerTablosu;
        private System.Windows.Forms.Button btnPersoneller;
        private System.Windows.Forms.Button btnHareketler;
    }
}