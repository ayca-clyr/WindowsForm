namespace Uygulama_05
{
    partial class Add
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
            this.txtBxProductName = new System.Windows.Forms.TextBox();
            this.txtBxUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtBxUnitPrice = new System.Windows.Forms.TextBox();
            this.cBxDiscontinued = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxProductName
            // 
            this.txtBxProductName.Location = new System.Drawing.Point(140, 29);
            this.txtBxProductName.Name = "txtBxProductName";
            this.txtBxProductName.Size = new System.Drawing.Size(100, 20);
            this.txtBxProductName.TabIndex = 0;
            // 
            // txtBxUnitsInStock
            // 
            this.txtBxUnitsInStock.Location = new System.Drawing.Point(140, 75);
            this.txtBxUnitsInStock.Name = "txtBxUnitsInStock";
            this.txtBxUnitsInStock.Size = new System.Drawing.Size(100, 20);
            this.txtBxUnitsInStock.TabIndex = 0;
            // 
            // txtBxUnitPrice
            // 
            this.txtBxUnitPrice.Location = new System.Drawing.Point(140, 127);
            this.txtBxUnitPrice.Name = "txtBxUnitPrice";
            this.txtBxUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBxUnitPrice.TabIndex = 0;
            // 
            // cBxDiscontinued
            // 
            this.cBxDiscontinued.FormattingEnabled = true;
            this.cBxDiscontinued.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cBxDiscontinued.Location = new System.Drawing.Point(140, 175);
            this.cBxDiscontinued.Name = "cBxDiscontinued";
            this.cBxDiscontinued.Size = new System.Drawing.Size(100, 21);
            this.cBxDiscontinued.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok Miktarı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fiyatı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Durum :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(184, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Ekle";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 354);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBxDiscontinued);
            this.Controls.Add(this.txtBxUnitPrice);
            this.Controls.Add(this.txtBxUnitsInStock);
            this.Controls.Add(this.txtBxProductName);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxProductName;
        private System.Windows.Forms.TextBox txtBxUnitsInStock;
        private System.Windows.Forms.TextBox txtBxUnitPrice;
        private System.Windows.Forms.ComboBox cBxDiscontinued;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
    }
}