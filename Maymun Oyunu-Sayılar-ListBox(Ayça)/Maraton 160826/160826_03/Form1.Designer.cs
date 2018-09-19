namespace _160826_03
{
    partial class lblIsim
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
            this.cBxResimler = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.pBxResim = new System.Windows.Forms.PictureBox();
            this.txtBxIsim = new System.Windows.Forms.TextBox();
            this.txtBxUrl = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblResimler = new System.Windows.Forms.Label();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // cBxResimler
            // 
            this.cBxResimler.FormattingEnabled = true;
            this.cBxResimler.Location = new System.Drawing.Point(533, 43);
            this.cBxResimler.Name = "cBxResimler";
            this.cBxResimler.Size = new System.Drawing.Size(168, 21);
            this.cBxResimler.TabIndex = 0;
            this.cBxResimler.SelectedIndexChanged += new System.EventHandler(this.cBxResimler_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(591, 77);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pBxResim
            // 
            this.pBxResim.Location = new System.Drawing.Point(110, 174);
            this.pBxResim.Name = "pBxResim";
            this.pBxResim.Size = new System.Drawing.Size(598, 251);
            this.pBxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxResim.TabIndex = 2;
            this.pBxResim.TabStop = false;
            // 
            // txtBxIsim
            // 
            this.txtBxIsim.Location = new System.Drawing.Point(68, 43);
            this.txtBxIsim.Name = "txtBxIsim";
            this.txtBxIsim.Size = new System.Drawing.Size(181, 20);
            this.txtBxIsim.TabIndex = 3;
            // 
            // txtBxUrl
            // 
            this.txtBxUrl.Location = new System.Drawing.Point(68, 103);
            this.txtBxUrl.Name = "txtBxUrl";
            this.txtBxUrl.Size = new System.Drawing.Size(181, 20);
            this.txtBxUrl.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(110, 145);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "İSİM";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(133, 87);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 13);
            this.lblUrl.TabIndex = 7;
            this.lblUrl.Text = "URL";
            // 
            // lblResimler
            // 
            this.lblResimler.AutoSize = true;
            this.lblResimler.Location = new System.Drawing.Point(588, 27);
            this.lblResimler.Name = "lblResimler";
            this.lblResimler.Size = new System.Drawing.Size(62, 13);
            this.lblResimler.TabIndex = 8;
            this.lblResimler.Text = "RESİMLER";
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(12, 281);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(75, 23);
            this.btnSol.TabIndex = 9;
            this.btnSol.Text = "SOL";
            this.btnSol.UseVisualStyleBackColor = true;
            // 
            // btnSag
            // 
            this.btnSag.Location = new System.Drawing.Point(714, 266);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(75, 23);
            this.btnSag.TabIndex = 10;
            this.btnSag.Text = "SAĞ";
            this.btnSag.UseVisualStyleBackColor = true;
            // 
            // lblIsim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 437);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.lblResimler);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtBxUrl);
            this.Controls.Add(this.txtBxIsim);
            this.Controls.Add(this.pBxResim);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.cBxResimler);
            this.Name = "lblIsim";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.lblIsim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBxResimler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pBxResim;
        private System.Windows.Forms.TextBox txtBxIsim;
        private System.Windows.Forms.TextBox txtBxUrl;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblResimler;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnSag;
    }
}

