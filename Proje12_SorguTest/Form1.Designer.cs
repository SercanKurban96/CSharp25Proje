namespace Proje12_SorguTest
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
            this.dgvSorgu = new System.Windows.Forms.DataGridView();
            this.rchSorgu = new System.Windows.Forms.RichTextBox();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.btnEkleSilGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVeriTabani = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTablolar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorgu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSorgu
            // 
            this.dgvSorgu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSorgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSorgu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSorgu.Location = new System.Drawing.Point(0, 394);
            this.dgvSorgu.Name = "dgvSorgu";
            this.dgvSorgu.RowHeadersWidth = 51;
            this.dgvSorgu.RowTemplate.Height = 24;
            this.dgvSorgu.Size = new System.Drawing.Size(1225, 274);
            this.dgvSorgu.TabIndex = 0;
            // 
            // rchSorgu
            // 
            this.rchSorgu.Location = new System.Drawing.Point(0, 195);
            this.rchSorgu.Name = "rchSorgu";
            this.rchSorgu.Size = new System.Drawing.Size(967, 186);
            this.rchSorgu.TabIndex = 1;
            this.rchSorgu.Text = "";
            // 
            // btnCalistir
            // 
            this.btnCalistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalistir.Location = new System.Drawing.Point(994, 199);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(205, 73);
            this.btnCalistir.TabIndex = 2;
            this.btnCalistir.Text = "ÇALIŞTIR";
            this.btnCalistir.UseVisualStyleBackColor = false;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // btnEkleSilGuncelle
            // 
            this.btnEkleSilGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnEkleSilGuncelle.Location = new System.Drawing.Point(994, 290);
            this.btnEkleSilGuncelle.Name = "btnEkleSilGuncelle";
            this.btnEkleSilGuncelle.Size = new System.Drawing.Size(205, 73);
            this.btnEkleSilGuncelle.TabIndex = 3;
            this.btnEkleSilGuncelle.Text = "Ekle - Sil - Güncelle";
            this.btnEkleSilGuncelle.UseVisualStyleBackColor = false;
            this.btnEkleSilGuncelle.Click += new System.EventHandler(this.btnEkleSilGuncelle_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Chiller", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1199, 103);
            this.label1.TabIndex = 4;
            this.label1.Text = "SQL SORGU TEST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbVeriTabani
            // 
            this.cmbVeriTabani.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeriTabani.FormattingEnabled = true;
            this.cmbVeriTabani.Location = new System.Drawing.Point(158, 128);
            this.cmbVeriTabani.Name = "cmbVeriTabani";
            this.cmbVeriTabani.Size = new System.Drawing.Size(211, 32);
            this.cmbVeriTabani.TabIndex = 5;
            this.cmbVeriTabani.SelectedIndexChanged += new System.EventHandler(this.cmbVeriTabani_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Veri Tabanı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tablolar:";
            // 
            // cmbTablolar
            // 
            this.cmbTablolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablolar.FormattingEnabled = true;
            this.cmbTablolar.Location = new System.Drawing.Point(582, 128);
            this.cmbTablolar.Name = "cmbTablolar";
            this.cmbTablolar.Size = new System.Drawing.Size(211, 32);
            this.cmbTablolar.TabIndex = 7;
            this.cmbTablolar.SelectedIndexChanged += new System.EventHandler(this.cmbTablolar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1225, 668);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTablolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVeriTabani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkleSilGuncelle);
            this.Controls.Add(this.btnCalistir);
            this.Controls.Add(this.rchSorgu);
            this.Controls.Add(this.dgvSorgu);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL SORGU TEST";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorgu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSorgu;
        private System.Windows.Forms.RichTextBox rchSorgu;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.Button btnEkleSilGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVeriTabani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTablolar;
    }
}

