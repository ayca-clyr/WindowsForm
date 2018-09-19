namespace Circus_Oyunu
{
    partial class CircusStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircusStart));
            this.pBxCircus = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.pBxBlock = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.lblPoint = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBxCircus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // pBxCircus
            // 
            this.pBxCircus.Image = ((System.Drawing.Image)(resources.GetObject("pBxCircus.Image")));
            this.pBxCircus.Location = new System.Drawing.Point(12, 256);
            this.pBxCircus.Name = "pBxCircus";
            this.pBxCircus.Size = new System.Drawing.Size(50, 67);
            this.pBxCircus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxCircus.TabIndex = 1;
            this.pBxCircus.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(266, 371);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 54);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pBxBlock
            // 
            this.pBxBlock.Image = ((System.Drawing.Image)(resources.GetObject("pBxBlock.Image")));
            this.pBxBlock.Location = new System.Drawing.Point(804, 80);
            this.pBxBlock.Name = "pBxBlock";
            this.pBxBlock.Size = new System.Drawing.Size(101, 231);
            this.pBxBlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxBlock.TabIndex = 4;
            this.pBxBlock.TabStop = false;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(15, 23);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(58, 17);
            this.lblPoint.TabIndex = 7;
            this.lblPoint.Text = "PUAN : ";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(443, 371);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(110, 54);
            this.btnPause.TabIndex = 8;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(626, 371);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 54);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CircusStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1079, 520);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.pBxBlock);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pBxCircus);
            this.KeyPreview = true;
            this.Name = "CircusStart";
            this.Load += new System.EventHandler(this.CircusStart_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CircusStart_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pBxCircus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBxCircus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pBxBlock;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnClose;
    }
}