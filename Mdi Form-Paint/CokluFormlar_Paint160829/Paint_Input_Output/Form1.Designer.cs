namespace Paint_Input_Output
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
            this.pBxÇizimAlanı = new System.Windows.Forms.PictureBox();
            this.btnColorSelector = new System.Windows.Forms.Button();
            this.tbScroll = new System.Windows.Forms.TrackBar();
            this.lblColor = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contexMenuAc = new System.Windows.Forms.ToolStripMenuItem();
            this.contexMenuTemizle = new System.Windows.Forms.ToolStripMenuItem();
            this.contexMenuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.contexMenuKaydet2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contexMenuÇıkış = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pBxÇizimAlanı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScroll)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBxÇizimAlanı
            // 
            this.pBxÇizimAlanı.ContextMenuStrip = this.contextMenuStrip1;
            this.pBxÇizimAlanı.Location = new System.Drawing.Point(128, 12);
            this.pBxÇizimAlanı.Name = "pBxÇizimAlanı";
            this.pBxÇizimAlanı.Size = new System.Drawing.Size(747, 409);
            this.pBxÇizimAlanı.TabIndex = 0;
            this.pBxÇizimAlanı.TabStop = false;
            this.pBxÇizimAlanı.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBxÇizimAlanı_MouseDown);
            this.pBxÇizimAlanı.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBxÇizimAlanı_MouseMove);
            this.pBxÇizimAlanı.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBxÇizimAlanı_MouseUp);
            // 
            // btnColorSelector
            // 
            this.btnColorSelector.Location = new System.Drawing.Point(12, 12);
            this.btnColorSelector.Name = "btnColorSelector";
            this.btnColorSelector.Size = new System.Drawing.Size(95, 34);
            this.btnColorSelector.TabIndex = 1;
            this.btnColorSelector.Text = "Renk Seç";
            this.btnColorSelector.UseVisualStyleBackColor = true;
            this.btnColorSelector.Click += new System.EventHandler(this.btnColorSelector_Click);
            // 
            // tbScroll
            // 
            this.tbScroll.Location = new System.Drawing.Point(12, 121);
            this.tbScroll.Name = "tbScroll";
            this.tbScroll.Size = new System.Drawing.Size(95, 45);
            this.tbScroll.TabIndex = 2;
            this.tbScroll.Scroll += new System.EventHandler(this.tbScroll_Scroll);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(9, 49);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(25, 13);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "      ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contexMenuAc,
            this.contexMenuTemizle,
            this.contexMenuKaydet,
            this.contexMenuKaydet2,
            this.contexMenuÇıkış});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 136);
            // 
            // contexMenuAc
            // 
            this.contexMenuAc.Name = "contexMenuAc";
            this.contexMenuAc.Size = new System.Drawing.Size(156, 22);
            this.contexMenuAc.Text = "AÇ";
            this.contexMenuAc.Click += new System.EventHandler(this.contexMenuAc_Click);
            // 
            // contexMenuTemizle
            // 
            this.contexMenuTemizle.Name = "contexMenuTemizle";
            this.contexMenuTemizle.Size = new System.Drawing.Size(157, 22);
            this.contexMenuTemizle.Text = "TEMİZLE";
            this.contexMenuTemizle.Click += new System.EventHandler(this.contexMenuTemizle_Click);
            // 
            // contexMenuKaydet
            // 
            this.contexMenuKaydet.Name = "contexMenuKaydet";
            this.contexMenuKaydet.Size = new System.Drawing.Size(156, 22);
            this.contexMenuKaydet.Text = "KAYDET";
            this.contexMenuKaydet.Click += new System.EventHandler(this.contexMenuKaydet_Click);
            // 
            // contexMenuKaydet2
            // 
            this.contexMenuKaydet2.Name = "contexMenuKaydet2";
            this.contexMenuKaydet2.Size = new System.Drawing.Size(157, 22);
            this.contexMenuKaydet2.Text = "FARKLI KAYDET";
            this.contexMenuKaydet2.Click += new System.EventHandler(this.contexMenuKaydet2_Click);
            // 
            // contexMenuÇıkış
            // 
            this.contexMenuÇıkış.Name = "contexMenuÇıkış";
            this.contexMenuÇıkış.Size = new System.Drawing.Size(157, 22);
            this.contexMenuÇıkış.Text = "ÇIKIŞ";
            this.contexMenuÇıkış.Click += new System.EventHandler(this.contexMenuÇıkış_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 433);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.tbScroll);
            this.Controls.Add(this.btnColorSelector);
            this.Controls.Add(this.pBxÇizimAlanı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBxÇizimAlanı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScroll)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBxÇizimAlanı;
        private System.Windows.Forms.Button btnColorSelector;
        private System.Windows.Forms.TrackBar tbScroll;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contexMenuAc;
        private System.Windows.Forms.ToolStripMenuItem contexMenuTemizle;
        private System.Windows.Forms.ToolStripMenuItem contexMenuKaydet;
        private System.Windows.Forms.ToolStripMenuItem contexMenuKaydet2;
        private System.Windows.Forms.ToolStripMenuItem contexMenuÇıkış;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

