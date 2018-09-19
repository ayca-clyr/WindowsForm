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
            this.lVSepetim = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShow = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBxProducts
            // 
            this.cBxProducts.FormattingEnabled = true;
            this.cBxProducts.Location = new System.Drawing.Point(47, 43);
            this.cBxProducts.Margin = new System.Windows.Forms.Padding(4);
            this.cBxProducts.Name = "cBxProducts";
            this.cBxProducts.Size = new System.Drawing.Size(167, 24);
            this.cBxProducts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürünler";
            // 
            // txtBxProductCount
            // 
            this.txtBxProductCount.Location = new System.Drawing.Point(304, 52);
            this.txtBxProductCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxProductCount.Name = "txtBxProductCount";
            this.txtBxProductCount.Size = new System.Drawing.Size(183, 22);
            this.txtBxProductCount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Miktarı";
            // 
            // btnNewAdd
            // 
            this.btnNewAdd.Location = new System.Drawing.Point(568, 37);
            this.btnNewAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewAdd.Name = "btnNewAdd";
            this.btnNewAdd.Size = new System.Drawing.Size(93, 37);
            this.btnNewAdd.TabIndex = 4;
            this.btnNewAdd.Text = "Yeni Ekle";
            this.btnNewAdd.UseVisualStyleBackColor = true;
            this.btnNewAdd.Click += new System.EventHandler(this.btnNewAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lVSepetim);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.lblStock);
            this.panel1.Controls.Add(this.cBxProducts);
            this.panel1.Controls.Add(this.btnNewAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBxProductCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 543);
            this.panel1.TabIndex = 5;
            // 
            // lVSepetim
            // 
            this.lVSepetim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lVSepetim.Location = new System.Drawing.Point(686, 108);
            this.lVSepetim.Name = "lVSepetim";
            this.lVSepetim.Size = new System.Drawing.Size(617, 359);
            this.lVSepetim.TabIndex = 7;
            this.lVSepetim.UseCompatibleStateImageBehavior = false;
            this.lVSepetim.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "OrderID";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ProductID";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Discount";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "UnitPrice";
            this.columnHeader5.Width = 90;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(892, 36);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(146, 37);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Sepetteki Ürünlerim";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(514, 57);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 17);
            this.lblStock.TabIndex = 5;
            // 
            // YeniEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 543);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YeniEkle";
            this.Text = "YeniEkle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.YeniEkle_Load);
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
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnShow;
        public System.Windows.Forms.ListView lVSepetim;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}