namespace _12_MDIForms
{
    partial class ProductForm
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
            this.lblProductÜrünAdı = new System.Windows.Forms.Label();
            this.lblProductStokSayı = new System.Windows.Forms.Label();
            this.txtBxProductÜrünAdı = new System.Windows.Forms.TextBox();
            this.txtBxProductStokSayı = new System.Windows.Forms.TextBox();
            this.btnProductKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductÜrünAdı
            // 
            this.lblProductÜrünAdı.AutoSize = true;
            this.lblProductÜrünAdı.Location = new System.Drawing.Point(13, 28);
            this.lblProductÜrünAdı.Name = "lblProductÜrünAdı";
            this.lblProductÜrünAdı.Size = new System.Drawing.Size(48, 13);
            this.lblProductÜrünAdı.TabIndex = 0;
            this.lblProductÜrünAdı.Text = "Ürün Adı";
            // 
            // lblProductStokSayı
            // 
            this.lblProductStokSayı.AutoSize = true;
            this.lblProductStokSayı.Location = new System.Drawing.Point(13, 107);
            this.lblProductStokSayı.Name = "lblProductStokSayı";
            this.lblProductStokSayı.Size = new System.Drawing.Size(102, 13);
            this.lblProductStokSayı.TabIndex = 1;
            this.lblProductStokSayı.Text = "Stoktaki Ürün Sayısı";
            // 
            // txtBxProductÜrünAdı
            // 
            this.txtBxProductÜrünAdı.Location = new System.Drawing.Point(16, 64);
            this.txtBxProductÜrünAdı.Name = "txtBxProductÜrünAdı";
            this.txtBxProductÜrünAdı.Size = new System.Drawing.Size(146, 20);
            this.txtBxProductÜrünAdı.TabIndex = 2;
            // 
            // txtBxProductStokSayı
            // 
            this.txtBxProductStokSayı.Location = new System.Drawing.Point(13, 138);
            this.txtBxProductStokSayı.Name = "txtBxProductStokSayı";
            this.txtBxProductStokSayı.Size = new System.Drawing.Size(149, 20);
            this.txtBxProductStokSayı.TabIndex = 3;
            // 
            // btnProductKaydet
            // 
            this.btnProductKaydet.Location = new System.Drawing.Point(64, 179);
            this.btnProductKaydet.Name = "btnProductKaydet";
            this.btnProductKaydet.Size = new System.Drawing.Size(98, 23);
            this.btnProductKaydet.TabIndex = 4;
            this.btnProductKaydet.Text = "Kaydet";
            this.btnProductKaydet.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 262);
            this.Controls.Add(this.btnProductKaydet);
            this.Controls.Add(this.txtBxProductStokSayı);
            this.Controls.Add(this.txtBxProductÜrünAdı);
            this.Controls.Add(this.lblProductStokSayı);
            this.Controls.Add(this.lblProductÜrünAdı);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductÜrünAdı;
        private System.Windows.Forms.Label lblProductStokSayı;
        private System.Windows.Forms.TextBox txtBxProductÜrünAdı;
        private System.Windows.Forms.TextBox txtBxProductStokSayı;
        public System.Windows.Forms.Button btnProductKaydet;
    }
}