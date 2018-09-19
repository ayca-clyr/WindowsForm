namespace Login
{
    partial class ProjectManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManagement));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projeAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniProjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projeAçToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.çalToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1053, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projeAçToolStripMenuItem
            // 
            this.projeAçToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniProjeToolStripMenuItem,
            this.projeListesiToolStripMenuItem});
            this.projeAçToolStripMenuItem.Name = "projeAçToolStripMenuItem";
            this.projeAçToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.projeAçToolStripMenuItem.Text = "Proje Yönetimi";
            // 
            // yeniProjeToolStripMenuItem
            // 
            this.yeniProjeToolStripMenuItem.Name = "yeniProjeToolStripMenuItem";
            this.yeniProjeToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.yeniProjeToolStripMenuItem.Text = "Yeni Proje";
            this.yeniProjeToolStripMenuItem.Click += new System.EventHandler(this.yeniProjeToolStripMenuItem_Click);
            // 
            // projeListesiToolStripMenuItem
            // 
            this.projeListesiToolStripMenuItem.Name = "projeListesiToolStripMenuItem";
            this.projeListesiToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.projeListesiToolStripMenuItem.Text = "Proje Listesi";
            this.projeListesiToolStripMenuItem.Click += new System.EventHandler(this.projeListesiToolStripMenuItem_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri İşlemleri";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // çalToolStripMenuItem
            // 
            this.çalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanEkleToolStripMenuItem});
            this.çalToolStripMenuItem.Name = "çalToolStripMenuItem";
            this.çalToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.çalToolStripMenuItem.Text = "Çalışanlar";
            // 
            // çalışanEkleToolStripMenuItem
            // 
            this.çalışanEkleToolStripMenuItem.Name = "çalışanEkleToolStripMenuItem";
            this.çalışanEkleToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.çalışanEkleToolStripMenuItem.Text = "Çalışan İşlemleri";
            this.çalışanEkleToolStripMenuItem.Click += new System.EventHandler(this.çalışanEkleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // ProjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 498);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProjectManagement";
            this.Text = "Proje Yöneticisi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projeAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniProjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}