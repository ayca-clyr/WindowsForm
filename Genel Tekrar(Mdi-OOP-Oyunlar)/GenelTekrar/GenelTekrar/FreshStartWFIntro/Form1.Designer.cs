namespace FreshStartWFIntro
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
            this.lblAdı = new System.Windows.Forms.Label();
            this.lblSıfre = new System.Windows.Forms.Label();
            this.txtBxAd = new System.Windows.Forms.TextBox();
            this.txtBxSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdı
            // 
            this.lblAdı.AutoSize = true;
            this.lblAdı.Location = new System.Drawing.Point(30, 23);
            this.lblAdı.Name = "lblAdı";
            this.lblAdı.Size = new System.Drawing.Size(64, 13);
            this.lblAdı.TabIndex = 0;
            this.lblAdı.Text = "Kullanıcı Adı";
            // 
            // lblSıfre
            // 
            this.lblSıfre.AutoSize = true;
            this.lblSıfre.Location = new System.Drawing.Point(30, 57);
            this.lblSıfre.Name = "lblSıfre";
            this.lblSıfre.Size = new System.Drawing.Size(28, 13);
            this.lblSıfre.TabIndex = 1;
            this.lblSıfre.Text = "Şifre";
            // 
            // txtBxAd
            // 
            this.txtBxAd.Location = new System.Drawing.Point(118, 15);
            this.txtBxAd.Name = "txtBxAd";
            this.txtBxAd.Size = new System.Drawing.Size(100, 20);
            this.txtBxAd.TabIndex = 2;
            // 
            // txtBxSifre
            // 
            this.txtBxSifre.Location = new System.Drawing.Point(118, 57);
            this.txtBxSifre.Name = "txtBxSifre";
            this.txtBxSifre.PasswordChar = '*';
            this.txtBxSifre.Size = new System.Drawing.Size(100, 20);
            this.txtBxSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(118, 99);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(100, 23);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtBxSifre);
            this.Controls.Add(this.txtBxAd);
            this.Controls.Add(this.lblSıfre);
            this.Controls.Add(this.lblAdı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdı;
        private System.Windows.Forms.Label lblSıfre;
        private System.Windows.Forms.TextBox txtBxAd;
        private System.Windows.Forms.TextBox txtBxSifre;
        private System.Windows.Forms.Button btnGiris;
    }
}

