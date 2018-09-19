namespace Part1
{
    partial class SqlConnectionTestForm
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
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlantıAçKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarİşlemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.authorListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.yazarİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bağlantıAçKapatToolStripMenuItem,
            this.categoriKaydetToolStripMenuItem,
            this.categoriListeleToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.işlemlerToolStripMenuItem.Text = "Catrgory";
            // 
            // bağlantıAçKapatToolStripMenuItem
            // 
            this.bağlantıAçKapatToolStripMenuItem.Name = "bağlantıAçKapatToolStripMenuItem";
            this.bağlantıAçKapatToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.bağlantıAçKapatToolStripMenuItem.Text = "Connection Open-Close";
            this.bağlantıAçKapatToolStripMenuItem.Click += new System.EventHandler(this.bağlantıAçKapatToolStripMenuItem_Click);
            // 
            // categoriKaydetToolStripMenuItem
            // 
            this.categoriKaydetToolStripMenuItem.Name = "categoriKaydetToolStripMenuItem";
            this.categoriKaydetToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.categoriKaydetToolStripMenuItem.Text = "Category crod";
            this.categoriKaydetToolStripMenuItem.Click += new System.EventHandler(this.categoriKaydetToolStripMenuItem_Click);
            // 
            // categoriListeleToolStripMenuItem
            // 
            this.categoriListeleToolStripMenuItem.Name = "categoriListeleToolStripMenuItem";
            this.categoriListeleToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.categoriListeleToolStripMenuItem.Text = "Category List";
            this.categoriListeleToolStripMenuItem.Click += new System.EventHandler(this.categoriListeleToolStripMenuItem_Click);
            // 
            // yazarİşlemleriToolStripMenuItem
            // 
            this.yazarİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazarİşlemleriToolStripMenuItem1,
            this.authorListToolStripMenuItem});
            this.yazarİşlemleriToolStripMenuItem.Name = "yazarİşlemleriToolStripMenuItem";
            this.yazarİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yazarİşlemleriToolStripMenuItem.Text = "Author";
            // 
            // yazarİşlemleriToolStripMenuItem1
            // 
            this.yazarİşlemleriToolStripMenuItem1.Name = "yazarİşlemleriToolStripMenuItem1";
            this.yazarİşlemleriToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.yazarİşlemleriToolStripMenuItem1.Text = "Author crod";
            this.yazarİşlemleriToolStripMenuItem1.Click += new System.EventHandler(this.yazarİşlemleriToolStripMenuItem1_Click_1);
            // 
            // authorListToolStripMenuItem
            // 
            this.authorListToolStripMenuItem.Name = "authorListToolStripMenuItem";
            this.authorListToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.authorListToolStripMenuItem.Text = "Author List";
            this.authorListToolStripMenuItem.Click += new System.EventHandler(this.authorListToolStripMenuItem_Click);
            // 
            // SqlConnectionTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SqlConnectionTestForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlantıAçKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarİşlemleriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem authorListToolStripMenuItem;
    }
}

