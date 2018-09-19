namespace VPaint
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
            this.renklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnCember = new System.Windows.Forms.Button();
            this.btnDoldur = new System.Windows.Forms.Button();
            this.btnDikdörtgen = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renklerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // renklerToolStripMenuItem
            // 
            this.renklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemColor});
            this.renklerToolStripMenuItem.Name = "renklerToolStripMenuItem";
            this.renklerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.renklerToolStripMenuItem.Text = "Renkler";
            this.renklerToolStripMenuItem.Click += new System.EventHandler(this.renklerToolStripMenuItem_Click);
            // 
            // menuItemColor
            // 
            this.menuItemColor.Name = "menuItemColor";
            this.menuItemColor.Size = new System.Drawing.Size(121, 22);
            this.menuItemColor.Text = "Renk Seç";
            this.menuItemColor.Click += new System.EventHandler(this.menuItemColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(83, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 370);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(0, 25);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(78, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 85);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 19);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(0, 145);
            this.btnLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(56, 19);
            this.btnLine.TabIndex = 4;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnCember
            // 
            this.btnCember.Location = new System.Drawing.Point(0, 228);
            this.btnCember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCember.Name = "btnCember";
            this.btnCember.Size = new System.Drawing.Size(56, 19);
            this.btnCember.TabIndex = 5;
            this.btnCember.Text = "Çember";
            this.btnCember.UseVisualStyleBackColor = true;
            this.btnCember.Click += new System.EventHandler(this.btnCember_Click);
            // 
            // btnDoldur
            // 
            this.btnDoldur.Location = new System.Drawing.Point(0, 263);
            this.btnDoldur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDoldur.Name = "btnDoldur";
            this.btnDoldur.Size = new System.Drawing.Size(56, 19);
            this.btnDoldur.TabIndex = 6;
            this.btnDoldur.Text = "Doldur";
            this.btnDoldur.UseVisualStyleBackColor = true;
            this.btnDoldur.Click += new System.EventHandler(this.btnDoldur_Click);
            // 
            // btnDikdörtgen
            // 
            this.btnDikdörtgen.Location = new System.Drawing.Point(0, 188);
            this.btnDikdörtgen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDikdörtgen.Name = "btnDikdörtgen";
            this.btnDikdörtgen.Size = new System.Drawing.Size(56, 19);
            this.btnDikdörtgen.TabIndex = 7;
            this.btnDikdörtgen.Text = "Dikdörtgen";
            this.btnDikdörtgen.UseVisualStyleBackColor = true;
            this.btnDikdörtgen.Click += new System.EventHandler(this.btnDikdörtgen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 472);
            this.Controls.Add(this.btnDikdörtgen);
            this.Controls.Add(this.btnDoldur);
            this.Controls.Add(this.btnCember);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemColor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnCember;
        private System.Windows.Forms.Button btnDoldur;
        private System.Windows.Forms.Button btnDikdörtgen;
    }
}

