﻿namespace Proje01_NotKayitSistemi
{
    partial class FrmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.mskNumara = new System.Windows.Forms.MaskedTextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRENCİ NUMARA:";
            // 
            // mskNumara
            // 
            this.mskNumara.Location = new System.Drawing.Point(367, 128);
            this.mskNumara.Mask = "0000";
            this.mskNumara.Name = "mskNumara";
            this.mskNumara.Size = new System.Drawing.Size(155, 30);
            this.mskNumara.TabIndex = 1;
            this.mskNumara.ValidatingType = typeof(int);
            this.mskNumara.TextChanged += new System.EventHandler(this.mskNumara_TextChanged);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(367, 176);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(155, 37);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(81, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 61);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğrenci Not Kayıt Sistemi";
            // 
            // FrmGiris
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(705, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.mskNumara);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Not Kayıt Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskNumara;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label label2;
    }
}

