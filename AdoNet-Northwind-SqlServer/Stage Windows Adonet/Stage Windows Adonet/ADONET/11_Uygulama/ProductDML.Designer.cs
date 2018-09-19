namespace _11_Uygulama
{
    partial class ProductDML
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnİnsert = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBxProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.txtBxUnitPrice = new System.Windows.Forms.TextBox();
            this.txtBxUnitsInStock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(22, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(419, 252);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnİnsert
            // 
            this.btnİnsert.Location = new System.Drawing.Point(242, 302);
            this.btnİnsert.Name = "btnİnsert";
            this.btnİnsert.Size = new System.Drawing.Size(75, 23);
            this.btnİnsert.TabIndex = 1;
            this.btnİnsert.Text = "Ekle";
            this.btnİnsert.UseVisualStyleBackColor = true;
            this.btnİnsert.Click += new System.EventHandler(this.btnİnsert_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(242, 343);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelle.TabIndex = 2;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(242, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProductName";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "QuantityPerUnit";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UnitPrice";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "UnitsInStock";
            this.columnHeader4.Width = 92;
            // 
            // txtBxProductName
            // 
            this.txtBxProductName.Location = new System.Drawing.Point(117, 305);
            this.txtBxProductName.Name = "txtBxProductName";
            this.txtBxProductName.Size = new System.Drawing.Size(100, 20);
            this.txtBxProductName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ProductName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "QuantityPerUnit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "UnitPrice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "UnitsInStock:";
            // 
            // txtBxQuantityPerUnit
            // 
            this.txtBxQuantityPerUnit.Location = new System.Drawing.Point(117, 333);
            this.txtBxQuantityPerUnit.Name = "txtBxQuantityPerUnit";
            this.txtBxQuantityPerUnit.Size = new System.Drawing.Size(100, 20);
            this.txtBxQuantityPerUnit.TabIndex = 4;
            // 
            // txtBxUnitPrice
            // 
            this.txtBxUnitPrice.Location = new System.Drawing.Point(117, 358);
            this.txtBxUnitPrice.Name = "txtBxUnitPrice";
            this.txtBxUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBxUnitPrice.TabIndex = 4;
            // 
            // txtBxUnitsInStock
            // 
            this.txtBxUnitsInStock.Location = new System.Drawing.Point(117, 384);
            this.txtBxUnitsInStock.Name = "txtBxUnitsInStock";
            this.txtBxUnitsInStock.Size = new System.Drawing.Size(100, 20);
            this.txtBxUnitsInStock.TabIndex = 4;
            // 
            // ProductDML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 536);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxUnitsInStock);
            this.Controls.Add(this.txtBxUnitPrice);
            this.Controls.Add(this.txtBxQuantityPerUnit);
            this.Controls.Add(this.txtBxProductName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnİnsert);
            this.Controls.Add(this.listView1);
            this.Name = "ProductDML";
            this.Text = "ProductDML";
            this.Load += new System.EventHandler(this.ProductDML_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnİnsert;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBxProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxQuantityPerUnit;
        private System.Windows.Forms.TextBox txtBxUnitPrice;
        private System.Windows.Forms.TextBox txtBxUnitsInStock;
    }
}