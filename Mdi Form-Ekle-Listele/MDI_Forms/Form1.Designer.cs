namespace MDI_Forms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEmployeeList = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yatayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basamakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ikonlarıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hepsiniKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStock = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelYönetimiToolStripMenuItem,
            this.görünümToolStripMenuItem,
            this.stokYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelYönetimiToolStripMenuItem
            // 
            this.personelYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewEmployee,
            this.menuItemEmployeeList});
            this.personelYönetimiToolStripMenuItem.Name = "personelYönetimiToolStripMenuItem";
            this.personelYönetimiToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.personelYönetimiToolStripMenuItem.Text = "Personel Yönetimi";
            // 
            // menuItemNewEmployee
            // 
            this.menuItemNewEmployee.Name = "menuItemNewEmployee";
            this.menuItemNewEmployee.Size = new System.Drawing.Size(154, 22);
            this.menuItemNewEmployee.Text = "Yeni Personel";
            this.menuItemNewEmployee.Click += new System.EventHandler(this.menuItemNewEmployee_Click);
            // 
            // menuItemEmployeeList
            // 
            this.menuItemEmployeeList.Name = "menuItemEmployeeList";
            this.menuItemEmployeeList.Size = new System.Drawing.Size(154, 22);
            this.menuItemEmployeeList.Text = "Personel Listesi";
            this.menuItemEmployeeList.Click += new System.EventHandler(this.menuItemEmployeeList_Click);
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dikeyToolStripMenuItem,
            this.yatayToolStripMenuItem,
            this.basamakToolStripMenuItem,
            this.ikonlarıDüzenleToolStripMenuItem,
            this.hepsiniKapatToolStripMenuItem});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // dikeyToolStripMenuItem
            // 
            this.dikeyToolStripMenuItem.Name = "dikeyToolStripMenuItem";
            this.dikeyToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.dikeyToolStripMenuItem.Text = "Dikey";
            this.dikeyToolStripMenuItem.Click += new System.EventHandler(this.dikeyToolStripMenuItem_Click);
            // 
            // yatayToolStripMenuItem
            // 
            this.yatayToolStripMenuItem.Name = "yatayToolStripMenuItem";
            this.yatayToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yatayToolStripMenuItem.Text = "Yatay";
            this.yatayToolStripMenuItem.Click += new System.EventHandler(this.yatayToolStripMenuItem_Click);
            // 
            // basamakToolStripMenuItem
            // 
            this.basamakToolStripMenuItem.Name = "basamakToolStripMenuItem";
            this.basamakToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.basamakToolStripMenuItem.Text = "Basamak";
            this.basamakToolStripMenuItem.Click += new System.EventHandler(this.basamakToolStripMenuItem_Click);
            // 
            // ikonlarıDüzenleToolStripMenuItem
            // 
            this.ikonlarıDüzenleToolStripMenuItem.Name = "ikonlarıDüzenleToolStripMenuItem";
            this.ikonlarıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ikonlarıDüzenleToolStripMenuItem.Text = "İkonları Düzenle";
            this.ikonlarıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.ikonlarıDüzenleToolStripMenuItem_Click);
            // 
            // hepsiniKapatToolStripMenuItem
            // 
            this.hepsiniKapatToolStripMenuItem.Name = "hepsiniKapatToolStripMenuItem";
            this.hepsiniKapatToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.hepsiniKapatToolStripMenuItem.Text = "Hepsini Kapat";
            this.hepsiniKapatToolStripMenuItem.Click += new System.EventHandler(this.hepsiniKapatToolStripMenuItem_Click);
            // 
            // stokYönetimiToolStripMenuItem
            // 
            this.stokYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewProduct,
            this.menuItemStock});
            this.stokYönetimiToolStripMenuItem.Name = "stokYönetimiToolStripMenuItem";
            this.stokYönetimiToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.stokYönetimiToolStripMenuItem.Text = "Stok Yönetimi";
            // 
            // menuItemNewProduct
            // 
            this.menuItemNewProduct.Name = "menuItemNewProduct";
            this.menuItemNewProduct.Size = new System.Drawing.Size(152, 22);
            this.menuItemNewProduct.Text = "Yeni Ürün";
            // 
            // menuItemStock
            // 
            this.menuItemStock.Name = "menuItemStock";
            this.menuItemStock.Size = new System.Drawing.Size(152, 22);
            this.menuItemStock.Text = "Stok";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 430);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewEmployee;
        private System.Windows.Forms.ToolStripMenuItem menuItemEmployeeList;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yatayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basamakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ikonlarıDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hepsiniKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewProduct;
        private System.Windows.Forms.ToolStripMenuItem menuItemStock;
    }
}

