namespace FileExplorer
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
            this.cmbDiskSec = new System.Windows.Forms.ComboBox();
            this.trvKlasorler = new System.Windows.Forms.TreeView();
            this.lstGoruntule = new System.Windows.Forms.ListView();
            this.DosyaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Boyut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OlusturulmaTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cntxDosyaIslemleri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Kopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.Yapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.Kes = new System.Windows.Forms.ToolStripMenuItem();
            this.Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.pnlFiltre = new System.Windows.Forms.Panel();
            this.stsBilgi = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.cntxDosyaIslemleri.SuspendLayout();
            this.pnlFiltre.SuspendLayout();
            this.stsBilgi.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDiskSec
            // 
            this.cmbDiskSec.FormattingEnabled = true;
            this.cmbDiskSec.Location = new System.Drawing.Point(2, 3);
            this.cmbDiskSec.Name = "cmbDiskSec";
            this.cmbDiskSec.Size = new System.Drawing.Size(232, 24);
            this.cmbDiskSec.TabIndex = 0;
            this.cmbDiskSec.SelectedIndexChanged += new System.EventHandler(this.cmbDiskSec_SelectedIndexChanged);
            // 
            // trvKlasorler
            // 
            this.trvKlasorler.Location = new System.Drawing.Point(2, 33);
            this.trvKlasorler.Name = "trvKlasorler";
            this.trvKlasorler.Size = new System.Drawing.Size(232, 385);
            this.trvKlasorler.TabIndex = 1;
            this.trvKlasorler.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvKlasorler_AfterExpand);
            this.trvKlasorler.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvKlasorler_AfterSelect);
            // 
            // lstGoruntule
            // 
            this.lstGoruntule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DosyaAdi,
            this.Boyut,
            this.OlusturulmaTarihi});
            this.lstGoruntule.ContextMenuStrip = this.cntxDosyaIslemleri;
            this.lstGoruntule.FullRowSelect = true;
            this.lstGoruntule.GridLines = true;
            this.lstGoruntule.Location = new System.Drawing.Point(237, 3);
            this.lstGoruntule.Name = "lstGoruntule";
            this.lstGoruntule.Size = new System.Drawing.Size(418, 382);
            this.lstGoruntule.TabIndex = 2;
            this.lstGoruntule.UseCompatibleStateImageBehavior = false;
            this.lstGoruntule.View = System.Windows.Forms.View.Details;
            this.lstGoruntule.DoubleClick += new System.EventHandler(this.lstGoruntule_DoubleClick);
            // 
            // DosyaAdi
            // 
            this.DosyaAdi.Text = "Dosya Adı";
            this.DosyaAdi.Width = 105;
            // 
            // Boyut
            // 
            this.Boyut.Text = "Boyut";
            this.Boyut.Width = 93;
            // 
            // OlusturulmaTarihi
            // 
            this.OlusturulmaTarihi.Text = "Oluşturulma Tarihi";
            this.OlusturulmaTarihi.Width = 159;
            // 
            // cntxDosyaIslemleri
            // 
            this.cntxDosyaIslemleri.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxDosyaIslemleri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Kopyala,
            this.Yapistir,
            this.Kes,
            this.Sil});
            this.cntxDosyaIslemleri.Name = "cntxDosyaIslemleri";
            this.cntxDosyaIslemleri.Size = new System.Drawing.Size(185, 108);
            // 
            // Kopyala
            // 
            this.Kopyala.Name = "Kopyala";
            this.Kopyala.Size = new System.Drawing.Size(184, 26);
            this.Kopyala.Text = "Kopyala Ctrl+C";
            this.Kopyala.Click += new System.EventHandler(this.Kopyala_Click);
            // 
            // Yapistir
            // 
            this.Yapistir.Name = "Yapistir";
            this.Yapistir.Size = new System.Drawing.Size(184, 26);
            this.Yapistir.Text = "Yapıştır Ctrl+V";
            this.Yapistir.Click += new System.EventHandler(this.Yapistir_Click);
            // 
            // Kes
            // 
            this.Kes.Name = "Kes";
            this.Kes.Size = new System.Drawing.Size(184, 26);
            this.Kes.Text = "Kes Ctrl+X";
            this.Kes.Click += new System.EventHandler(this.Kes_Click);
            // 
            // Sil
            // 
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(184, 26);
            this.Sil.Text = "Sil";
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.FormattingEnabled = true;
            this.cmbFiltre.Location = new System.Drawing.Point(3, 3);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(134, 24);
            this.cmbFiltre.TabIndex = 3;
            // 
            // btnFiltre
            // 
            this.btnFiltre.Location = new System.Drawing.Point(143, 3);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(79, 25);
            this.btnFiltre.TabIndex = 4;
            this.btnFiltre.Text = "Filtrele";
            this.btnFiltre.UseVisualStyleBackColor = true;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // pnlFiltre
            // 
            this.pnlFiltre.Controls.Add(this.cmbFiltre);
            this.pnlFiltre.Controls.Add(this.btnFiltre);
            this.pnlFiltre.Location = new System.Drawing.Point(237, 391);
            this.pnlFiltre.Name = "pnlFiltre";
            this.pnlFiltre.Size = new System.Drawing.Size(418, 40);
            this.pnlFiltre.TabIndex = 5;
            // 
            // stsBilgi
            // 
            this.stsBilgi.Dock = System.Windows.Forms.DockStyle.None;
            this.stsBilgi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsBilgi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.stsBilgi.Location = new System.Drawing.Point(0, 0);
            this.stsBilgi.Name = "stsBilgi";
            this.stsBilgi.Size = new System.Drawing.Size(899, 25);
            this.stsBilgi.TabIndex = 6;
            this.stsBilgi.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 19);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.stsBilgi);
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnlFiltre);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lstGoruntule);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.trvKlasorler);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cmbDiskSec);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(899, 676);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(899, 701);
            this.toolStripContainer1.TabIndex = 7;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 701);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cntxDosyaIslemleri.ResumeLayout(false);
            this.pnlFiltre.ResumeLayout(false);
            this.stsBilgi.ResumeLayout(false);
            this.stsBilgi.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDiskSec;
        private System.Windows.Forms.TreeView trvKlasorler;
        private System.Windows.Forms.ListView lstGoruntule;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.ColumnHeader DosyaAdi;
        private System.Windows.Forms.ColumnHeader Boyut;
        private System.Windows.Forms.ColumnHeader OlusturulmaTarihi;
        private System.Windows.Forms.Panel pnlFiltre;
        private System.Windows.Forms.ContextMenuStrip cntxDosyaIslemleri;
        private System.Windows.Forms.ToolStripMenuItem Kopyala;
        private System.Windows.Forms.ToolStripMenuItem Yapistir;
        private System.Windows.Forms.ToolStripMenuItem Kes;
        private System.Windows.Forms.ToolStripMenuItem Sil;
        private System.Windows.Forms.StatusStrip stsBilgi;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}

