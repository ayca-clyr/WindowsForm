namespace _2_ArabaYarısı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pctBxBirinci = new System.Windows.Forms.PictureBox();
            this.pctBxİkinci = new System.Windows.Forms.PictureBox();
            this.pctBxBitis = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxBirinci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxİkinci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxBitis)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBxBirinci
            // 
            this.pctBxBirinci.Image = ((System.Drawing.Image)(resources.GetObject("pctBxBirinci.Image")));
            this.pctBxBirinci.Location = new System.Drawing.Point(55, 82);
            this.pctBxBirinci.Name = "pctBxBirinci";
            this.pctBxBirinci.Size = new System.Drawing.Size(100, 50);
            this.pctBxBirinci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBxBirinci.TabIndex = 0;
            this.pctBxBirinci.TabStop = false;
            // 
            // pctBxİkinci
            // 
            this.pctBxİkinci.Image = ((System.Drawing.Image)(resources.GetObject("pctBxİkinci.Image")));
            this.pctBxİkinci.Location = new System.Drawing.Point(55, 206);
            this.pctBxİkinci.Name = "pctBxİkinci";
            this.pctBxİkinci.Size = new System.Drawing.Size(100, 50);
            this.pctBxİkinci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBxİkinci.TabIndex = 1;
            this.pctBxİkinci.TabStop = false;
            // 
            // pctBxBitis
            // 
            this.pctBxBitis.Image = global::_2_ArabaYarısı.Properties.Resources.bitisCizgisi;
            this.pctBxBitis.Location = new System.Drawing.Point(615, 12);
            this.pctBxBitis.Name = "pctBxBitis";
            this.pctBxBitis.Size = new System.Drawing.Size(100, 434);
            this.pctBxBitis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBxBitis.TabIndex = 2;
            this.pctBxBitis.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(55, 343);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(100, 23);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(200, 343);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(100, 23);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Yeniden Başla";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 488);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.pctBxBitis);
            this.Controls.Add(this.pctBxİkinci);
            this.Controls.Add(this.pctBxBirinci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBxBirinci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxİkinci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxBitis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBxBirinci;
        private System.Windows.Forms.PictureBox pctBxİkinci;
        private System.Windows.Forms.PictureBox pctBxBitis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnRestart;
    }
}

