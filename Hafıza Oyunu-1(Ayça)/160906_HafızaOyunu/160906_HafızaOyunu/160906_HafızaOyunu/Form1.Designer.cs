namespace _160906_HafızaOyunu
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
            this.components = new System.ComponentModel.Container();
            this.lblOyuncuBilgileri = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblDogruSayisi = new System.Windows.Forms.Label();
            this.txtBxKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnKolay = new System.Windows.Forms.Button();
            this.btnZor = new System.Windows.Forms.Button();
            this.btnOrta = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnYeniden = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.lblMod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lstBxIsımler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYanlisSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOyuncuBilgileri
            // 
            this.lblOyuncuBilgileri.AutoSize = true;
            this.lblOyuncuBilgileri.Location = new System.Drawing.Point(10, 9);
            this.lblOyuncuBilgileri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOyuncuBilgileri.Name = "lblOyuncuBilgileri";
            this.lblOyuncuBilgileri.Size = new System.Drawing.Size(106, 17);
            this.lblOyuncuBilgileri.TabIndex = 5;
            this.lblOyuncuBilgileri.Text = "Oyuncu Bilgileri";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(13, 41);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(92, 17);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "Kullanıcı Adı :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(10, 104);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 17);
            this.label.TabIndex = 8;
            this.label.Text = "Doğru Sayısı";
            // 
            // lblDogruSayisi
            // 
            this.lblDogruSayisi.AutoSize = true;
            this.lblDogruSayisi.Location = new System.Drawing.Point(109, 104);
            this.lblDogruSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDogruSayisi.Name = "lblDogruSayisi";
            this.lblDogruSayisi.Size = new System.Drawing.Size(16, 17);
            this.lblDogruSayisi.TabIndex = 9;
            this.lblDogruSayisi.Text = "0";
            // 
            // txtBxKullanıcıAdı
            // 
            this.txtBxKullanıcıAdı.Location = new System.Drawing.Point(112, 41);
            this.txtBxKullanıcıAdı.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxKullanıcıAdı.Name = "txtBxKullanıcıAdı";
            this.txtBxKullanıcıAdı.Size = new System.Drawing.Size(132, 22);
            this.txtBxKullanıcıAdı.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 170);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 451);
            this.panel1.TabIndex = 12;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnKolay
            // 
            this.btnKolay.Location = new System.Drawing.Point(286, 30);
            this.btnKolay.Margin = new System.Windows.Forms.Padding(4);
            this.btnKolay.Name = "btnKolay";
            this.btnKolay.Size = new System.Drawing.Size(130, 28);
            this.btnKolay.TabIndex = 2;
            this.btnKolay.Text = "KOLAY MOD";
            this.btnKolay.UseVisualStyleBackColor = true;
            this.btnKolay.Click += new System.EventHandler(this.btnKolay_Click);
            // 
            // btnZor
            // 
            this.btnZor.Location = new System.Drawing.Point(288, 104);
            this.btnZor.Margin = new System.Windows.Forms.Padding(4);
            this.btnZor.Name = "btnZor";
            this.btnZor.Size = new System.Drawing.Size(128, 28);
            this.btnZor.TabIndex = 4;
            this.btnZor.Text = "ZOR MOD";
            this.btnZor.UseVisualStyleBackColor = true;
            this.btnZor.Click += new System.EventHandler(this.btnZor_Click_1);
            // 
            // btnOrta
            // 
            this.btnOrta.Location = new System.Drawing.Point(286, 68);
            this.btnOrta.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrta.Name = "btnOrta";
            this.btnOrta.Size = new System.Drawing.Size(130, 28);
            this.btnOrta.TabIndex = 3;
            this.btnOrta.Text = "ORTA MOD";
            this.btnOrta.UseVisualStyleBackColor = true;
            this.btnOrta.Click += new System.EventHandler(this.btnOrta_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(652, 30);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 23);
            this.btnKapat.TabIndex = 13;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnYeniden
            // 
            this.btnYeniden.Location = new System.Drawing.Point(652, 62);
            this.btnYeniden.Name = "btnYeniden";
            this.btnYeniden.Size = new System.Drawing.Size(100, 23);
            this.btnYeniden.TabIndex = 14;
            this.btnYeniden.Text = "YENİDEN";
            this.btnYeniden.UseVisualStyleBackColor = true;
            this.btnYeniden.Click += new System.EventHandler(this.btnYeniden_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(652, 91);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(100, 23);
            this.btnDurdur.TabIndex = 15;
            this.btnDurdur.Text = "DURDUR";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Location = new System.Drawing.Point(226, 138);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(0, 17);
            this.lblMod.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Süre :";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(80, 138);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(0, 17);
            this.lblSure.TabIndex = 18;
            // 
            // lstBxIsımler
            // 
            this.lstBxIsımler.FormattingEnabled = true;
            this.lstBxIsımler.ItemHeight = 16;
            this.lstBxIsımler.Location = new System.Drawing.Point(647, 138);
            this.lstBxIsımler.Name = "lstBxIsımler";
            this.lstBxIsımler.Size = new System.Drawing.Size(120, 484);
            this.lstBxIsımler.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yanlış Sayısı";
            // 
            // lblYanlisSayisi
            // 
            this.lblYanlisSayisi.AutoSize = true;
            this.lblYanlisSayisi.Location = new System.Drawing.Point(233, 104);
            this.lblYanlisSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYanlisSayisi.Name = "lblYanlisSayisi";
            this.lblYanlisSayisi.Size = new System.Drawing.Size(16, 17);
            this.lblYanlisSayisi.TabIndex = 9;
            this.lblYanlisSayisi.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 624);
            this.Controls.Add(this.lstBxIsımler);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnYeniden);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBxKullanıcıAdı);
            this.Controls.Add(this.lblYanlisSayisi);
            this.Controls.Add(this.lblDogruSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblOyuncuBilgileri);
            this.Controls.Add(this.btnZor);
            this.Controls.Add(this.btnOrta);
            this.Controls.Add(this.btnKolay);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOyuncuBilgileri;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblDogruSayisi;
        private System.Windows.Forms.TextBox txtBxKullanıcıAdı;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnKolay;
        private System.Windows.Forms.Button btnZor;
        private System.Windows.Forms.Button btnOrta;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnYeniden;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.ListBox lstBxIsımler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYanlisSayisi;
    }
}

