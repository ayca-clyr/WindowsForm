namespace Northwind_Sepet_Uygulaması
{
    partial class YeniEkle
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
            this.cBxProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxProductCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBxProducts
            // 
            this.cBxProducts.FormattingEnabled = true;
            this.cBxProducts.Location = new System.Drawing.Point(28, 35);
            this.cBxProducts.Name = "cBxProducts";
            this.cBxProducts.Size = new System.Drawing.Size(106, 21);
            this.cBxProducts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürünler";
            // 
            // txtBxProductCount
            // 
            this.txtBxProductCount.Location = new System.Drawing.Point(171, 35);
            this.txtBxProductCount.Name = "txtBxProductCount";
            this.txtBxProductCount.Size = new System.Drawing.Size(106, 20);
            this.txtBxProductCount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Miktarı";
            // 
            // btnNewAdd
            // 
            this.btnNewAdd.Location = new System.Drawing.Point(330, 26);
            this.btnNewAdd.Name = "btnNewAdd";
            this.btnNewAdd.Size = new System.Drawing.Size(70, 30);
            this.btnNewAdd.TabIndex = 4;
            this.btnNewAdd.Text = "Yeni Ekle";
            this.btnNewAdd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cBxProducts);
            this.panel1.Controls.Add(this.btnNewAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBxProductCount);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 218);
            this.panel1.TabIndex = 5;
            // 
            // YeniEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 261);
            this.Controls.Add(this.panel1);
            this.Name = "YeniEkle";
            this.Text = "YeniEkle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cBxProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxProductCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewAdd;
        private System.Windows.Forms.Panel panel1;

    }
}