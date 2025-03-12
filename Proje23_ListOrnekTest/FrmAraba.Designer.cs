namespace Proje23_ListOrnekTest
{
    partial class FrmAraba
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
            this.lstListele = new System.Windows.Forms.ListBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListele
            // 
            this.lstListele.FormattingEnabled = true;
            this.lstListele.HorizontalScrollbar = true;
            this.lstListele.ItemHeight = 27;
            this.lstListele.Location = new System.Drawing.Point(265, 68);
            this.lstListele.Name = "lstListele";
            this.lstListele.Size = new System.Drawing.Size(302, 355);
            this.lstListele.TabIndex = 3;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(265, 429);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(302, 45);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // FrmAraba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(833, 542);
            this.Controls.Add(this.lstListele);
            this.Controls.Add(this.btnListele);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAraba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAraba";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstListele;
        private System.Windows.Forms.Button btnListele;
    }
}