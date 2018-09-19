namespace ChangeOffice
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
            this.btnKur = new System.Windows.Forms.Button();
            this.lstKurBilgileri = new System.Windows.Forms.ListBox();
            this.lblKurAdı = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSatışFiyatı = new System.Windows.Forms.Label();
            this.lblAlışFiyatı = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numerikMiktar = new System.Windows.Forms.NumericUpDown();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numerikMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKur
            // 
            this.btnKur.Location = new System.Drawing.Point(13, 44);
            this.btnKur.Name = "btnKur";
            this.btnKur.Size = new System.Drawing.Size(124, 39);
            this.btnKur.TabIndex = 0;
            this.btnKur.Text = "Kur Bilgilerini Çek";
            this.btnKur.UseVisualStyleBackColor = true;
            this.btnKur.Click += new System.EventHandler(this.btnKur_Click);
            // 
            // lstKurBilgileri
            // 
            this.lstKurBilgileri.FormattingEnabled = true;
            this.lstKurBilgileri.Location = new System.Drawing.Point(13, 100);
            this.lstKurBilgileri.Name = "lstKurBilgileri";
            this.lstKurBilgileri.Size = new System.Drawing.Size(120, 290);
            this.lstKurBilgileri.TabIndex = 1;
            // 
            // lblKurAdı
            // 
            this.lblKurAdı.AutoSize = true;
            this.lblKurAdı.Location = new System.Drawing.Point(303, 70);
            this.lblKurAdı.Name = "lblKurAdı";
            this.lblKurAdı.Size = new System.Drawing.Size(92, 13);
            this.lblKurAdı.TabIndex = 2;
            this.lblKurAdı.Text = "(Henüz Seçilmedi)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Birim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alış Fiyatı";
            // 
            // lblSatışFiyatı
            // 
            this.lblSatışFiyatı.AutoSize = true;
            this.lblSatışFiyatı.Location = new System.Drawing.Point(416, 213);
            this.lblSatışFiyatı.Name = "lblSatışFiyatı";
            this.lblSatışFiyatı.Size = new System.Drawing.Size(13, 13);
            this.lblSatışFiyatı.TabIndex = 3;
            this.lblSatışFiyatı.Text = "0";
            // 
            // lblAlışFiyatı
            // 
            this.lblAlışFiyatı.AutoSize = true;
            this.lblAlışFiyatı.Location = new System.Drawing.Point(416, 166);
            this.lblAlışFiyatı.Name = "lblAlışFiyatı";
            this.lblAlışFiyatı.Size = new System.Drawing.Size(13, 13);
            this.lblAlışFiyatı.TabIndex = 3;
            this.lblAlışFiyatı.Text = "0";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(416, 115);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(13, 13);
            this.lblBirim.TabIndex = 3;
            this.lblBirim.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Satış Fiyatı";
            // 
            // numerikMiktar
            // 
            this.numerikMiktar.Location = new System.Drawing.Point(286, 249);
            this.numerikMiktar.Name = "numerikMiktar";
            this.numerikMiktar.Size = new System.Drawing.Size(143, 20);
            this.numerikMiktar.TabIndex = 4;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(416, 353);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(13, 13);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "0";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(286, 295);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(143, 31);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 415);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.numerikMiktar);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.lblAlışFiyatı);
            this.Controls.Add(this.lblSatışFiyatı);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKurAdı);
            this.Controls.Add(this.lstKurBilgileri);
            this.Controls.Add(this.btnKur);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numerikMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKur;
        private System.Windows.Forms.ListBox lstKurBilgileri;
        private System.Windows.Forms.Label lblKurAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSatışFiyatı;
        private System.Windows.Forms.Label lblAlışFiyatı;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numerikMiktar;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnHesapla;
    }
}

