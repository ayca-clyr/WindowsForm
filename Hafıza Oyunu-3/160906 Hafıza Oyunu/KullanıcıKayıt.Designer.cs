namespace _160906_Hafıza_Oyunu
{
    partial class KullanıcıKayıt
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
            this.lblKayıtKullanıcıAdı = new System.Windows.Forms.Label();
            this.txtBxKayıtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.lblKayıtPuan = new System.Windows.Forms.Label();
            this.btnKullanıcıKaydet = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lstPuanTablosu = new System.Windows.Forms.ListView();
            this.KullanıcıAdı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Puan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblKullanıcıGösterilenPuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKayıtKullanıcıAdı
            // 
            this.lblKayıtKullanıcıAdı.AutoSize = true;
            this.lblKayıtKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayıtKullanıcıAdı.Location = new System.Drawing.Point(25, 16);
            this.lblKayıtKullanıcıAdı.Name = "lblKayıtKullanıcıAdı";
            this.lblKayıtKullanıcıAdı.Size = new System.Drawing.Size(97, 20);
            this.lblKayıtKullanıcıAdı.TabIndex = 0;
            this.lblKayıtKullanıcıAdı.Text = "Kullanıcı Adı:";
            // 
            // txtBxKayıtKullanıcıAdı
            // 
            this.txtBxKayıtKullanıcıAdı.Location = new System.Drawing.Point(128, 18);
            this.txtBxKayıtKullanıcıAdı.Name = "txtBxKayıtKullanıcıAdı";
            this.txtBxKayıtKullanıcıAdı.Size = new System.Drawing.Size(144, 20);
            this.txtBxKayıtKullanıcıAdı.TabIndex = 1;
            // 
            // lblKayıtPuan
            // 
            this.lblKayıtPuan.AutoSize = true;
            this.lblKayıtPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayıtPuan.Location = new System.Drawing.Point(72, 54);
            this.lblKayıtPuan.Name = "lblKayıtPuan";
            this.lblKayıtPuan.Size = new System.Drawing.Size(50, 20);
            this.lblKayıtPuan.TabIndex = 2;
            this.lblKayıtPuan.Text = "Puan:";
            // 
            // btnKullanıcıKaydet
            // 
            this.btnKullanıcıKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanıcıKaydet.Location = new System.Drawing.Point(128, 94);
            this.btnKullanıcıKaydet.Name = "btnKullanıcıKaydet";
            this.btnKullanıcıKaydet.Size = new System.Drawing.Size(144, 32);
            this.btnKullanıcıKaydet.TabIndex = 4;
            this.btnKullanıcıKaydet.Text = "Kaydet";
            this.btnKullanıcıKaydet.UseVisualStyleBackColor = true;
            this.btnKullanıcıKaydet.Click += new System.EventHandler(this.btnKullanıcıKaydet_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRestart.Location = new System.Drawing.Point(39, 202);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(233, 51);
            this.btnRestart.TabIndex = 11;
            this.btnRestart.Text = "Yeniden Oyna";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lstPuanTablosu
            // 
            this.lstPuanTablosu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KullanıcıAdı,
            this.Puan});
            this.lstPuanTablosu.Location = new System.Drawing.Point(349, 18);
            this.lstPuanTablosu.Name = "lstPuanTablosu";
            this.lstPuanTablosu.Size = new System.Drawing.Size(238, 390);
            this.lstPuanTablosu.TabIndex = 12;
            this.lstPuanTablosu.UseCompatibleStateImageBehavior = false;
            this.lstPuanTablosu.View = System.Windows.Forms.View.Details;
            // 
            // KullanıcıAdı
            // 
            this.KullanıcıAdı.Text = "Kullanıcı Adı";
            this.KullanıcıAdı.Width = 79;
            // 
            // Puan
            // 
            this.Puan.Text = "Puan";
            // 
            // lblKullanıcıGösterilenPuan
            // 
            this.lblKullanıcıGösterilenPuan.AutoSize = true;
            this.lblKullanıcıGösterilenPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcıGösterilenPuan.Location = new System.Drawing.Point(124, 54);
            this.lblKullanıcıGösterilenPuan.Name = "lblKullanıcıGösterilenPuan";
            this.lblKullanıcıGösterilenPuan.Size = new System.Drawing.Size(0, 20);
            this.lblKullanıcıGösterilenPuan.TabIndex = 3;
            // 
            // KullanıcıKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 405);
            this.Controls.Add(this.lstPuanTablosu);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnKullanıcıKaydet);
            this.Controls.Add(this.lblKullanıcıGösterilenPuan);
            this.Controls.Add(this.lblKayıtPuan);
            this.Controls.Add(this.txtBxKayıtKullanıcıAdı);
            this.Controls.Add(this.lblKayıtKullanıcıAdı);
            this.Name = "KullanıcıKayıt";
            this.Text = "KullanıcıKayıt";
            this.Load += new System.EventHandler(this.KullanıcıKayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblKayıtKullanıcıAdı;
        public System.Windows.Forms.TextBox txtBxKayıtKullanıcıAdı;
        public System.Windows.Forms.Label lblKayıtPuan;
        public System.Windows.Forms.Button btnKullanıcıKaydet;
        public System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ListView lstPuanTablosu;
        private System.Windows.Forms.ColumnHeader KullanıcıAdı;
        private System.Windows.Forms.ColumnHeader Puan;
        public System.Windows.Forms.Label lblKullanıcıGösterilenPuan;

    }
}