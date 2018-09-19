namespace _160906_Hafıza_Oyunu
{
    partial class OyunEkranı
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
            this.btnPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.rdBtnAntreman = new System.Windows.Forms.RadioButton();
            this.rdBtnKolay = new System.Windows.Forms.RadioButton();
            this.rdBtnOrta = new System.Windows.Forms.RadioButton();
            this.rdBtnZor = new System.Windows.Forms.RadioButton();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblGösterilenPuan = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.lblKalanZaman = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPanel
            // 
            this.btnPanel.Location = new System.Drawing.Point(29, 131);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(618, 438);
            this.btnPanel.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // rdBtnAntreman
            // 
            this.rdBtnAntreman.AutoSize = true;
            this.rdBtnAntreman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnAntreman.Location = new System.Drawing.Point(41, 38);
            this.rdBtnAntreman.Name = "rdBtnAntreman";
            this.rdBtnAntreman.Size = new System.Drawing.Size(97, 24);
            this.rdBtnAntreman.TabIndex = 1;
            this.rdBtnAntreman.Text = "Antreman";
            this.rdBtnAntreman.UseVisualStyleBackColor = true;
            this.rdBtnAntreman.CheckedChanged += new System.EventHandler(this.rdBtnAntreman_CheckedChanged);
            // 
            // rdBtnKolay
            // 
            this.rdBtnKolay.AutoSize = true;
            this.rdBtnKolay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnKolay.Location = new System.Drawing.Point(189, 38);
            this.rdBtnKolay.Name = "rdBtnKolay";
            this.rdBtnKolay.Size = new System.Drawing.Size(65, 24);
            this.rdBtnKolay.TabIndex = 2;
            this.rdBtnKolay.Text = "Kolay";
            this.rdBtnKolay.UseVisualStyleBackColor = true;
            this.rdBtnKolay.CheckedChanged += new System.EventHandler(this.rdBtnKolay_CheckedChanged);
            // 
            // rdBtnOrta
            // 
            this.rdBtnOrta.AutoSize = true;
            this.rdBtnOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnOrta.Location = new System.Drawing.Point(319, 38);
            this.rdBtnOrta.Name = "rdBtnOrta";
            this.rdBtnOrta.Size = new System.Drawing.Size(58, 24);
            this.rdBtnOrta.TabIndex = 3;
            this.rdBtnOrta.Text = "Orta";
            this.rdBtnOrta.UseVisualStyleBackColor = true;
            this.rdBtnOrta.CheckedChanged += new System.EventHandler(this.rdBtnOrta_CheckedChanged);
            // 
            // rdBtnZor
            // 
            this.rdBtnZor.AutoSize = true;
            this.rdBtnZor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnZor.Location = new System.Drawing.Point(455, 38);
            this.rdBtnZor.Name = "rdBtnZor";
            this.rdBtnZor.Size = new System.Drawing.Size(51, 24);
            this.rdBtnZor.TabIndex = 4;
            this.rdBtnZor.Text = "Zor";
            this.rdBtnZor.UseVisualStyleBackColor = true;
            this.rdBtnZor.CheckedChanged += new System.EventHandler(this.rdBtnZor_CheckedChanged);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(542, 33);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(105, 34);
            this.btnBaslat.TabIndex = 5;
            this.btnBaslat.TabStop = false;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(37, 75);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(50, 20);
            this.lblPuan.TabIndex = 6;
            this.lblPuan.Text = "Puan:";
            // 
            // lblGösterilenPuan
            // 
            this.lblGösterilenPuan.AutoSize = true;
            this.lblGösterilenPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGösterilenPuan.Location = new System.Drawing.Point(93, 75);
            this.lblGösterilenPuan.Name = "lblGösterilenPuan";
            this.lblGösterilenPuan.Size = new System.Drawing.Size(0, 20);
            this.lblGösterilenPuan.TabIndex = 7;
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(493, 82);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(63, 20);
            this.lblZaman.TabIndex = 8;
            this.lblZaman.Text = "Zaman:";
            // 
            // lblKalanZaman
            // 
            this.lblKalanZaman.AutoSize = true;
            this.lblKalanZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanZaman.Location = new System.Drawing.Point(562, 82);
            this.lblKalanZaman.Name = "lblKalanZaman";
            this.lblKalanZaman.Size = new System.Drawing.Size(0, 20);
            this.lblKalanZaman.TabIndex = 9;
            // 
            // OyunEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 643);
            this.Controls.Add(this.lblKalanZaman);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblGösterilenPuan);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.rdBtnZor);
            this.Controls.Add(this.rdBtnOrta);
            this.Controls.Add(this.rdBtnKolay);
            this.Controls.Add(this.rdBtnAntreman);
            this.Controls.Add(this.btnPanel);
            this.Name = "OyunEkranı";
            this.Text = "OyunEkranı";
            this.Load += new System.EventHandler(this.OyunEkranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel btnPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton rdBtnAntreman;
        private System.Windows.Forms.RadioButton rdBtnKolay;
        private System.Windows.Forms.RadioButton rdBtnOrta;
        private System.Windows.Forms.RadioButton rdBtnZor;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Label lblKalanZaman;
        public System.Windows.Forms.Label lblPuan;
        public System.Windows.Forms.Label lblGösterilenPuan;
    }
}