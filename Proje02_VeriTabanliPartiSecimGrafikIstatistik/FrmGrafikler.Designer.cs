namespace Proje02_VeriTabanliPartiSecimGrafikIstatistik
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIlceSecin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prbAParti = new System.Windows.Forms.ProgressBar();
            this.prbBParti = new System.Windows.Forms.ProgressBar();
            this.prbCParti = new System.Windows.Forms.ProgressBar();
            this.prbDParti = new System.Windows.Forms.ProgressBar();
            this.prbEParti = new System.Windows.Forms.ProgressBar();
            this.lblAParti = new System.Windows.Forms.Label();
            this.lblBParti = new System.Windows.Forms.Label();
            this.lblCParti = new System.Windows.Forms.Label();
            this.lblDParti = new System.Windows.Forms.Label();
            this.lblEParti = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 24);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Partiler";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(920, 319);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEParti);
            this.groupBox2.Controls.Add(this.lblDParti);
            this.groupBox2.Controls.Add(this.lblCParti);
            this.groupBox2.Controls.Add(this.lblBParti);
            this.groupBox2.Controls.Add(this.lblAParti);
            this.groupBox2.Controls.Add(this.prbEParti);
            this.groupBox2.Controls.Add(this.prbDParti);
            this.groupBox2.Controls.Add(this.prbCParti);
            this.groupBox2.Controls.Add(this.prbBParti);
            this.groupBox2.Controls.Add(this.prbAParti);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbIlceSecin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(923, 358);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin:";
            // 
            // cmbIlceSecin
            // 
            this.cmbIlceSecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIlceSecin.FormattingEnabled = true;
            this.cmbIlceSecin.Location = new System.Drawing.Point(174, 46);
            this.cmbIlceSecin.Name = "cmbIlceSecin";
            this.cmbIlceSecin.Size = new System.Drawing.Size(243, 29);
            this.cmbIlceSecin.TabIndex = 1;
            this.cmbIlceSecin.SelectedIndexChanged += new System.EventHandler(this.cmbIlceSecin_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "B PARTİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "C PARTİ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "D PARTİ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "E PARTİ:";
            // 
            // prbAParti
            // 
            this.prbAParti.Location = new System.Drawing.Point(174, 110);
            this.prbAParti.Maximum = 200;
            this.prbAParti.Name = "prbAParti";
            this.prbAParti.Size = new System.Drawing.Size(522, 36);
            this.prbAParti.TabIndex = 11;
            // 
            // prbBParti
            // 
            this.prbBParti.Location = new System.Drawing.Point(174, 152);
            this.prbBParti.Maximum = 200;
            this.prbBParti.Name = "prbBParti";
            this.prbBParti.Size = new System.Drawing.Size(522, 36);
            this.prbBParti.TabIndex = 12;
            // 
            // prbCParti
            // 
            this.prbCParti.Location = new System.Drawing.Point(174, 194);
            this.prbCParti.Maximum = 200;
            this.prbCParti.Name = "prbCParti";
            this.prbCParti.Size = new System.Drawing.Size(522, 36);
            this.prbCParti.TabIndex = 13;
            // 
            // prbDParti
            // 
            this.prbDParti.Location = new System.Drawing.Point(174, 236);
            this.prbDParti.Maximum = 200;
            this.prbDParti.Name = "prbDParti";
            this.prbDParti.Size = new System.Drawing.Size(522, 36);
            this.prbDParti.TabIndex = 14;
            // 
            // prbEParti
            // 
            this.prbEParti.Location = new System.Drawing.Point(174, 278);
            this.prbEParti.Maximum = 200;
            this.prbEParti.Name = "prbEParti";
            this.prbEParti.Size = new System.Drawing.Size(522, 36);
            this.prbEParti.TabIndex = 15;
            // 
            // lblAParti
            // 
            this.lblAParti.AutoSize = true;
            this.lblAParti.Location = new System.Drawing.Point(702, 117);
            this.lblAParti.Name = "lblAParti";
            this.lblAParti.Size = new System.Drawing.Size(21, 21);
            this.lblAParti.TabIndex = 16;
            this.lblAParti.Text = "0";
            // 
            // lblBParti
            // 
            this.lblBParti.AutoSize = true;
            this.lblBParti.Location = new System.Drawing.Point(702, 160);
            this.lblBParti.Name = "lblBParti";
            this.lblBParti.Size = new System.Drawing.Size(21, 21);
            this.lblBParti.TabIndex = 17;
            this.lblBParti.Text = "0";
            // 
            // lblCParti
            // 
            this.lblCParti.AutoSize = true;
            this.lblCParti.Location = new System.Drawing.Point(702, 201);
            this.lblCParti.Name = "lblCParti";
            this.lblCParti.Size = new System.Drawing.Size(21, 21);
            this.lblCParti.TabIndex = 18;
            this.lblCParti.Text = "0";
            // 
            // lblDParti
            // 
            this.lblDParti.AutoSize = true;
            this.lblDParti.Location = new System.Drawing.Point(702, 244);
            this.lblDParti.Name = "lblDParti";
            this.lblDParti.Size = new System.Drawing.Size(21, 21);
            this.lblDParti.TabIndex = 19;
            this.lblDParti.Text = "0";
            // 
            // lblEParti
            // 
            this.lblEParti.AutoSize = true;
            this.lblEParti.Location = new System.Drawing.Point(702, 285);
            this.lblEParti.Name = "lblEParti";
            this.lblEParti.Size = new System.Drawing.Size(21, 21);
            this.lblEParti.TabIndex = 20;
            this.lblEParti.Text = "0";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(950, 735);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seçim İstatistik ve Grafik Sistemi";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbIlceSecin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar prbEParti;
        private System.Windows.Forms.ProgressBar prbDParti;
        private System.Windows.Forms.ProgressBar prbCParti;
        private System.Windows.Forms.ProgressBar prbBParti;
        private System.Windows.Forms.ProgressBar prbAParti;
        private System.Windows.Forms.Label lblEParti;
        private System.Windows.Forms.Label lblDParti;
        private System.Windows.Forms.Label lblCParti;
        private System.Windows.Forms.Label lblBParti;
        private System.Windows.Forms.Label lblAParti;
    }
}