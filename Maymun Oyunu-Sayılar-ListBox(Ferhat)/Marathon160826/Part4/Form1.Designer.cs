namespace Part4
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
            this.radioButton3X3 = new System.Windows.Forms.RadioButton();
            this.radioButton4X4 = new System.Windows.Forms.RadioButton();
            this.radioButton5X5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1DK = new System.Windows.Forms.RadioButton();
            this.radioButton3DK = new System.Windows.Forms.RadioButton();
            this.radioButton2DK = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonKolay = new System.Windows.Forms.RadioButton();
            this.radioButtonZor = new System.Windows.Forms.RadioButton();
            this.radioButtonOrta = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonSerbest = new System.Windows.Forms.RadioButton();
            this.radioButtonAntreman = new System.Windows.Forms.RadioButton();
            this.radioButtonZamanaKarsi = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonBestScore = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBasarili = new System.Windows.Forms.Label();
            this.lblBasarisiz = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblSecond = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton3X3
            // 
            this.radioButton3X3.AutoSize = true;
            this.radioButton3X3.Location = new System.Drawing.Point(6, 19);
            this.radioButton3X3.Name = "radioButton3X3";
            this.radioButton3X3.Size = new System.Drawing.Size(50, 17);
            this.radioButton3X3.TabIndex = 0;
            this.radioButton3X3.Text = "3 X 3";
            this.radioButton3X3.UseVisualStyleBackColor = true;
            this.radioButton3X3.CheckedChanged += new System.EventHandler(this.radioButton3X3_CheckedChanged);
            // 
            // radioButton4X4
            // 
            this.radioButton4X4.AutoSize = true;
            this.radioButton4X4.Location = new System.Drawing.Point(6, 52);
            this.radioButton4X4.Name = "radioButton4X4";
            this.radioButton4X4.Size = new System.Drawing.Size(50, 17);
            this.radioButton4X4.TabIndex = 0;
            this.radioButton4X4.Text = "4 X 4";
            this.radioButton4X4.UseVisualStyleBackColor = true;
            this.radioButton4X4.CheckedChanged += new System.EventHandler(this.radioButton4X4_CheckedChanged);
            // 
            // radioButton5X5
            // 
            this.radioButton5X5.AutoSize = true;
            this.radioButton5X5.Location = new System.Drawing.Point(6, 85);
            this.radioButton5X5.Name = "radioButton5X5";
            this.radioButton5X5.Size = new System.Drawing.Size(50, 17);
            this.radioButton5X5.TabIndex = 0;
            this.radioButton5X5.Text = "5 X 5";
            this.radioButton5X5.UseVisualStyleBackColor = true;
            this.radioButton5X5.CheckedChanged += new System.EventHandler(this.radioButton5X5_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3X3);
            this.groupBox1.Controls.Add(this.radioButton5X5);
            this.groupBox1.Controls.Add(this.radioButton4X4);
            this.groupBox1.Location = new System.Drawing.Point(125, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(70, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DESEN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1DK);
            this.groupBox2.Controls.Add(this.radioButton3DK);
            this.groupBox2.Controls.Add(this.radioButton2DK);
            this.groupBox2.Location = new System.Drawing.Point(201, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(74, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SÜRE";
            // 
            // radioButton1DK
            // 
            this.radioButton1DK.AutoSize = true;
            this.radioButton1DK.Location = new System.Drawing.Point(6, 19);
            this.radioButton1DK.Name = "radioButton1DK";
            this.radioButton1DK.Size = new System.Drawing.Size(49, 17);
            this.radioButton1DK.TabIndex = 0;
            this.radioButton1DK.Text = "1 DK";
            this.radioButton1DK.UseVisualStyleBackColor = true;
            this.radioButton1DK.CheckedChanged += new System.EventHandler(this.radioButton1DK_CheckedChanged);
            // 
            // radioButton3DK
            // 
            this.radioButton3DK.AutoSize = true;
            this.radioButton3DK.Location = new System.Drawing.Point(6, 85);
            this.radioButton3DK.Name = "radioButton3DK";
            this.radioButton3DK.Size = new System.Drawing.Size(49, 17);
            this.radioButton3DK.TabIndex = 0;
            this.radioButton3DK.Text = "3 DK";
            this.radioButton3DK.UseVisualStyleBackColor = true;
            this.radioButton3DK.CheckedChanged += new System.EventHandler(this.radioButton3DK_CheckedChanged);
            // 
            // radioButton2DK
            // 
            this.radioButton2DK.AutoSize = true;
            this.radioButton2DK.Location = new System.Drawing.Point(6, 52);
            this.radioButton2DK.Name = "radioButton2DK";
            this.radioButton2DK.Size = new System.Drawing.Size(49, 17);
            this.radioButton2DK.TabIndex = 0;
            this.radioButton2DK.Text = "2 DK";
            this.radioButton2DK.UseVisualStyleBackColor = true;
            this.radioButton2DK.CheckedChanged += new System.EventHandler(this.radioButton2DK_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonKolay);
            this.groupBox3.Controls.Add(this.radioButtonZor);
            this.groupBox3.Controls.Add(this.radioButtonOrta);
            this.groupBox3.Location = new System.Drawing.Point(281, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(74, 121);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SEVİYE";
            // 
            // radioButtonKolay
            // 
            this.radioButtonKolay.AutoSize = true;
            this.radioButtonKolay.Location = new System.Drawing.Point(6, 19);
            this.radioButtonKolay.Name = "radioButtonKolay";
            this.radioButtonKolay.Size = new System.Drawing.Size(51, 17);
            this.radioButtonKolay.TabIndex = 0;
            this.radioButtonKolay.Text = "Kolay";
            this.radioButtonKolay.UseVisualStyleBackColor = true;
            this.radioButtonKolay.CheckedChanged += new System.EventHandler(this.radioButtonKolay_CheckedChanged);
            // 
            // radioButtonZor
            // 
            this.radioButtonZor.AutoSize = true;
            this.radioButtonZor.Location = new System.Drawing.Point(6, 85);
            this.radioButtonZor.Name = "radioButtonZor";
            this.radioButtonZor.Size = new System.Drawing.Size(41, 17);
            this.radioButtonZor.TabIndex = 0;
            this.radioButtonZor.Text = "Zor";
            this.radioButtonZor.UseVisualStyleBackColor = true;
            this.radioButtonZor.CheckedChanged += new System.EventHandler(this.radioButtonZor_CheckedChanged);
            // 
            // radioButtonOrta
            // 
            this.radioButtonOrta.AutoSize = true;
            this.radioButtonOrta.Location = new System.Drawing.Point(6, 52);
            this.radioButtonOrta.Name = "radioButtonOrta";
            this.radioButtonOrta.Size = new System.Drawing.Size(45, 17);
            this.radioButtonOrta.TabIndex = 0;
            this.radioButtonOrta.Text = "Orta";
            this.radioButtonOrta.UseVisualStyleBackColor = true;
            this.radioButtonOrta.CheckedChanged += new System.EventHandler(this.radioButtonOrta_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonSerbest);
            this.groupBox4.Controls.Add(this.radioButtonAntreman);
            this.groupBox4.Controls.Add(this.radioButtonZamanaKarsi);
            this.groupBox4.Location = new System.Drawing.Point(12, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(107, 121);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Oyun Modu";
            // 
            // radioButtonSerbest
            // 
            this.radioButtonSerbest.AutoSize = true;
            this.radioButtonSerbest.Location = new System.Drawing.Point(6, 19);
            this.radioButtonSerbest.Name = "radioButtonSerbest";
            this.radioButtonSerbest.Size = new System.Drawing.Size(61, 17);
            this.radioButtonSerbest.TabIndex = 0;
            this.radioButtonSerbest.Text = "Serbest";
            this.radioButtonSerbest.UseVisualStyleBackColor = true;
            // 
            // radioButtonAntreman
            // 
            this.radioButtonAntreman.AutoSize = true;
            this.radioButtonAntreman.Location = new System.Drawing.Point(6, 85);
            this.radioButtonAntreman.Name = "radioButtonAntreman";
            this.radioButtonAntreman.Size = new System.Drawing.Size(70, 17);
            this.radioButtonAntreman.TabIndex = 0;
            this.radioButtonAntreman.Text = "Antreman";
            this.radioButtonAntreman.UseVisualStyleBackColor = true;
            // 
            // radioButtonZamanaKarsi
            // 
            this.radioButtonZamanaKarsi.AutoSize = true;
            this.radioButtonZamanaKarsi.Location = new System.Drawing.Point(6, 52);
            this.radioButtonZamanaKarsi.Name = "radioButtonZamanaKarsi";
            this.radioButtonZamanaKarsi.Size = new System.Drawing.Size(90, 17);
            this.radioButtonZamanaKarsi.TabIndex = 0;
            this.radioButtonZamanaKarsi.Text = "Zamana Karşı";
            this.radioButtonZamanaKarsi.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(73, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(361, 21);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(152, 36);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Başlat";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonBestScore
            // 
            this.buttonBestScore.Location = new System.Drawing.Point(361, 105);
            this.buttonBestScore.Name = "buttonBestScore";
            this.buttonBestScore.Size = new System.Drawing.Size(152, 36);
            this.buttonBestScore.TabIndex = 3;
            this.buttonBestScore.Text = "En İyi Skorlar";
            this.buttonBestScore.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Duraklat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblBasarisiz);
            this.groupBox5.Controls.Add(this.lblBasarili);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(0, 43);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 78);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Skor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BAŞARILI : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "BAŞARISIZ : ";
            // 
            // lblBasarili
            // 
            this.lblBasarili.AutoSize = true;
            this.lblBasarili.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBasarili.ForeColor = System.Drawing.Color.Green;
            this.lblBasarili.Location = new System.Drawing.Point(87, 20);
            this.lblBasarili.Name = "lblBasarili";
            this.lblBasarili.Size = new System.Drawing.Size(14, 13);
            this.lblBasarili.TabIndex = 0;
            this.lblBasarili.Text = "0";
            this.lblBasarili.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBasarisiz
            // 
            this.lblBasarisiz.AutoSize = true;
            this.lblBasarisiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBasarisiz.ForeColor = System.Drawing.Color.Red;
            this.lblBasarisiz.Location = new System.Drawing.Point(87, 46);
            this.lblBasarisiz.Name = "lblBasarisiz";
            this.lblBasarisiz.Size = new System.Drawing.Size(14, 13);
            this.lblBasarisiz.TabIndex = 0;
            this.lblBasarisiz.Text = "0";
            this.lblBasarisiz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.lblSecond);
            this.groupBox6.Location = new System.Drawing.Point(519, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(136, 121);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kalan Zaman";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecond.ForeColor = System.Drawing.Color.Black;
            this.lblSecond.Location = new System.Drawing.Point(61, 19);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(29, 20);
            this.lblSecond.TabIndex = 0;
            this.lblSecond.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(659, 661);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonBestScore);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton3X3;
        private System.Windows.Forms.RadioButton radioButton4X4;
        private System.Windows.Forms.RadioButton radioButton5X5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1DK;
        private System.Windows.Forms.RadioButton radioButton3DK;
        private System.Windows.Forms.RadioButton radioButton2DK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonKolay;
        private System.Windows.Forms.RadioButton radioButtonZor;
        private System.Windows.Forms.RadioButton radioButtonOrta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonSerbest;
        private System.Windows.Forms.RadioButton radioButtonAntreman;
        private System.Windows.Forms.RadioButton radioButtonZamanaKarsi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonBestScore;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblBasarisiz;
        private System.Windows.Forms.Label lblBasarili;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblSecond;
    }
}

