namespace _11_MultipleForms
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
            this.btnYeniEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSilDialog = new System.Windows.Forms.Button();
            this.lstKayıt = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.Location = new System.Drawing.Point(1, 3);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYeniEkle.TabIndex = 0;
            this.btnYeniEkle.Text = "Yeni Ekle";
            this.btnYeniEkle.UseVisualStyleBackColor = true;
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(102, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSilDialog
            // 
            this.btnSilDialog.Location = new System.Drawing.Point(222, 3);
            this.btnSilDialog.Name = "btnSilDialog";
            this.btnSilDialog.Size = new System.Drawing.Size(75, 23);
            this.btnSilDialog.TabIndex = 2;
            this.btnSilDialog.Text = "SilDialog";
            this.btnSilDialog.UseVisualStyleBackColor = true;
            this.btnSilDialog.Click += new System.EventHandler(this.btnSilDialog_Click);
            // 
            // lstKayıt
            // 
            this.lstKayıt.FormattingEnabled = true;
            this.lstKayıt.Location = new System.Drawing.Point(1, 52);
            this.lstKayıt.Name = "lstKayıt";
            this.lstKayıt.Size = new System.Drawing.Size(308, 212);
            this.lstKayıt.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 262);
            this.Controls.Add(this.lstKayıt);
            this.Controls.Add(this.btnSilDialog);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeniEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSilDialog;
        public System.Windows.Forms.ListBox lstKayıt;
    }
}

