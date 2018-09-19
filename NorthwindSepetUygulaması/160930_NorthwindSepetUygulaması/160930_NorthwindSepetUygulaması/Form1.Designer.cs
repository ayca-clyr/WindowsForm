namespace _160930_NorthwindSepetUygulaması
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
            this.components = new System.ComponentModel.Container();
            this.cBoxEmplyee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxCustemer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxShippers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrderNow = new System.Windows.Forms.Button();
            this.lViewProduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sEPETEEKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.grpBasket = new System.Windows.Forms.GroupBox();
            this.pnlBasket = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOrderSave = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.grpProduct.SuspendLayout();
            this.grpBasket.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxEmplyee
            // 
            this.cBoxEmplyee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxEmplyee.FormattingEnabled = true;
            this.cBoxEmplyee.Location = new System.Drawing.Point(16, 32);
            this.cBoxEmplyee.MaxDropDownItems = 5;
            this.cBoxEmplyee.Name = "cBoxEmplyee";
            this.cBoxEmplyee.Size = new System.Drawing.Size(207, 28);
            this.cBoxEmplyee.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel";
            // 
            // cBoxCustemer
            // 
            this.cBoxCustemer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxCustemer.FormattingEnabled = true;
            this.cBoxCustemer.Location = new System.Drawing.Point(233, 32);
            this.cBoxCustemer.MaxDropDownItems = 5;
            this.cBoxCustemer.Name = "cBoxCustemer";
            this.cBoxCustemer.Size = new System.Drawing.Size(207, 28);
            this.cBoxCustemer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(229, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteriler";
            // 
            // cBoxShippers
            // 
            this.cBoxShippers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxShippers.FormattingEnabled = true;
            this.cBoxShippers.Location = new System.Drawing.Point(447, 32);
            this.cBoxShippers.Name = "cBoxShippers";
            this.cBoxShippers.Size = new System.Drawing.Size(207, 28);
            this.cBoxShippers.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(443, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kargo Şirketi";
            // 
            // btnOrderNow
            // 
            this.btnOrderNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrderNow.Location = new System.Drawing.Point(664, 9);
            this.btnOrderNow.Name = "btnOrderNow";
            this.btnOrderNow.Size = new System.Drawing.Size(204, 51);
            this.btnOrderNow.TabIndex = 2;
            this.btnOrderNow.Text = "Sipariş Geç";
            this.btnOrderNow.UseVisualStyleBackColor = true;
            this.btnOrderNow.Click += new System.EventHandler(this.btnOrderNow_Click);
            // 
            // lViewProduct
            // 
            this.lViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lViewProduct.ContextMenuStrip = this.contextMenuStrip1;
            this.lViewProduct.FullRowSelect = true;
            this.lViewProduct.Location = new System.Drawing.Point(6, 19);
            this.lViewProduct.Name = "lViewProduct";
            this.lViewProduct.Size = new System.Drawing.Size(405, 412);
            this.lViewProduct.TabIndex = 3;
            this.lViewProduct.UseCompatibleStateImageBehavior = false;
            this.lViewProduct.View = System.Windows.Forms.View.Details;
            this.lViewProduct.DoubleClick += new System.EventHandler(this.lViewProduct_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Kategorisi";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Birim Miktarı";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Birim Fiyatı";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Stok";
            this.columnHeader5.Width = 89;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sEPETEEKLEToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 26);
            // 
            // sEPETEEKLEToolStripMenuItem
            // 
            this.sEPETEEKLEToolStripMenuItem.Name = "sEPETEEKLEToolStripMenuItem";
            this.sEPETEEKLEToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.sEPETEEKLEToolStripMenuItem.Text = "SEPETE EKLE";
            this.sEPETEEKLEToolStripMenuItem.Click += new System.EventHandler(this.sEPETEEKLEToolStripMenuItem_Click);
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.lViewProduct);
            this.grpProduct.Location = new System.Drawing.Point(16, 85);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(424, 442);
            this.grpProduct.TabIndex = 4;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Ürün Bilgileri";
            this.grpProduct.Visible = false;
            // 
            // grpBasket
            // 
            this.grpBasket.Controls.Add(this.label8);
            this.grpBasket.Controls.Add(this.label7);
            this.grpBasket.Controls.Add(this.pnlBasket);
            this.grpBasket.Controls.Add(this.label6);
            this.grpBasket.Controls.Add(this.label4);
            this.grpBasket.Controls.Add(this.label5);
            this.grpBasket.Controls.Add(this.btnOrderSave);
            this.grpBasket.Controls.Add(this.lblTotalPrice);
            this.grpBasket.Location = new System.Drawing.Point(447, 85);
            this.grpBasket.Name = "grpBasket";
            this.grpBasket.Size = new System.Drawing.Size(424, 442);
            this.grpBasket.TabIndex = 5;
            this.grpBasket.TabStop = false;
            this.grpBasket.Text = "Sepet Bilgileri";
            this.grpBasket.Visible = false;
            // 
            // pnlBasket
            // 
            this.pnlBasket.AutoScroll = true;
            this.pnlBasket.Location = new System.Drawing.Point(7, 48);
            this.pnlBasket.Name = "pnlBasket";
            this.pnlBasket.Size = new System.Drawing.Size(411, 339);
            this.pnlBasket.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(320, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tutar : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(235, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Adet :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(140, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Birim Fiyatı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Toplam Tutar :";
            // 
            // btnOrderSave
            // 
            this.btnOrderSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrderSave.Location = new System.Drawing.Point(254, 393);
            this.btnOrderSave.Name = "btnOrderSave";
            this.btnOrderSave.Size = new System.Drawing.Size(164, 46);
            this.btnOrderSave.TabIndex = 2;
            this.btnOrderSave.Text = "Sipariş Kaydet";
            this.btnOrderSave.UseVisualStyleBackColor = true;
            this.btnOrderSave.Click += new System.EventHandler(this.btnOrderSave_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotalPrice.Location = new System.Drawing.Point(136, 405);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(112, 34);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "0 $";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 547);
            this.Controls.Add(this.grpBasket);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.btnOrderNow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxShippers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxCustemer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxEmplyee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpProduct.ResumeLayout(false);
            this.grpBasket.ResumeLayout(false);
            this.grpBasket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxEmplyee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxCustemer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxShippers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrderNow;
        private System.Windows.Forms.ListView lViewProduct;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.GroupBox grpBasket;
        private System.Windows.Forms.Panel pnlBasket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOrderSave;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sEPETEEKLEToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

