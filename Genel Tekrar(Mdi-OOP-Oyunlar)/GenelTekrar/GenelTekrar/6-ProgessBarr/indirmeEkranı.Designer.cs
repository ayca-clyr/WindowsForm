namespace _6_ProgessBarr
{
    partial class indirmeEkranı
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
            this.lblİndirme = new System.Windows.Forms.Label();
            this.lblSuanZaman = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnDownloadIptal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBackHomePage = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblİndirme
            // 
            this.lblİndirme.AutoSize = true;
            this.lblİndirme.Location = new System.Drawing.Point(28, 50);
            this.lblİndirme.Name = "lblİndirme";
            this.lblİndirme.Size = new System.Drawing.Size(81, 13);
            this.lblİndirme.TabIndex = 0;
            this.lblİndirme.Text = "İndirme Yüzdesi";
            // 
            // lblSuanZaman
            // 
            this.lblSuanZaman.AutoSize = true;
            this.lblSuanZaman.Location = new System.Drawing.Point(27, 286);
            this.lblSuanZaman.Name = "lblSuanZaman";
            this.lblSuanZaman.Size = new System.Drawing.Size(76, 13);
            this.lblSuanZaman.TabIndex = 1;
            this.lblSuanZaman.Text = "Şuanki Zaman";
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Location = new System.Drawing.Point(28, 312);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(40, 13);
            this.lblZaman.TabIndex = 2;
            this.lblZaman.Text = "Zaman";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 109);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(679, 47);
            this.progressBar1.TabIndex = 3;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(30, 177);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(114, 57);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "İndirmeyi Duraklat";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnDownloadIptal
            // 
            this.btnDownloadIptal.Location = new System.Drawing.Point(216, 177);
            this.btnDownloadIptal.Name = "btnDownloadIptal";
            this.btnDownloadIptal.Size = new System.Drawing.Size(114, 57);
            this.btnDownloadIptal.TabIndex = 5;
            this.btnDownloadIptal.Text = "İndirmeyi İptal Et";
            this.btnDownloadIptal.UseVisualStyleBackColor = true;
            this.btnDownloadIptal.Click += new System.EventHandler(this.btnDownloadIptal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(405, 177);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 57);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Uygulamayı Kapat";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBackHomePage
            // 
            this.btnBackHomePage.Location = new System.Drawing.Point(595, 177);
            this.btnBackHomePage.Name = "btnBackHomePage";
            this.btnBackHomePage.Size = new System.Drawing.Size(114, 57);
            this.btnBackHomePage.TabIndex = 7;
            this.btnBackHomePage.Text = "Anasayfaya Dön";
            this.btnBackHomePage.UseVisualStyleBackColor = true;
            this.btnBackHomePage.Click += new System.EventHandler(this.btnBackHomePage_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // indirmeEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 340);
            this.Controls.Add(this.btnBackHomePage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDownloadIptal);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblSuanZaman);
            this.Controls.Add(this.lblİndirme);
            this.Name = "indirmeEkranı";
            this.Text = "İndirme";
            this.Load += new System.EventHandler(this.indirmeEkranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblİndirme;
        private System.Windows.Forms.Label lblSuanZaman;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnDownloadIptal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBackHomePage;
        private System.Windows.Forms.Timer timer1;
    }
}