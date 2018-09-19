namespace Tez2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYardim = new System.Windows.Forms.Button();
            this.btnHakkimizda = new System.Windows.Forms.Button();
            this.btnDevam = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Location = new System.Drawing.Point(115, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 296);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "OLASI TEHLİKELER";
            // 
            // btnYardim
            // 
            this.btnYardim.ForeColor = System.Drawing.Color.Black;
            this.btnYardim.Location = new System.Drawing.Point(544, 44);
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(105, 35);
            this.btnYardim.TabIndex = 2;
            this.btnYardim.Text = "YARDIM";
            this.btnYardim.UseVisualStyleBackColor = true;
            this.btnYardim.Click += new System.EventHandler(this.btnYardim_Click);
            // 
            // btnHakkimizda
            // 
            this.btnHakkimizda.Location = new System.Drawing.Point(35, 44);
            this.btnHakkimizda.Name = "btnHakkimizda";
            this.btnHakkimizda.Size = new System.Drawing.Size(154, 35);
            this.btnHakkimizda.TabIndex = 3;
            this.btnHakkimizda.Text = "HAKKIMIZDA";
            this.btnHakkimizda.UseVisualStyleBackColor = true;
            this.btnHakkimizda.Click += new System.EventHandler(this.btnHakkimizda_Click);
            // 
            // btnDevam
            // 
            this.btnDevam.Location = new System.Drawing.Point(308, 457);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(163, 35);
            this.btnDevam.TabIndex = 4;
            this.btnDevam.Text = "DEVAM";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Kayma,takılma vb. nedenlerle düşme",
            "Elektrikli aletler",
            "Yüksekten düşme",
            "Cisimlerin düşmesi",
            "Yangın,parlama ve patlama",
            "Hareketli erişim ekipmanları(Merdivenler,platformlar)",
            "Biyolojik ajanlar(Virüs,bakteri)",
            "Gürültü ve titreşim",
            "Radyasyon ve ultraviyole ışınlar",
            "Uygun olmayan duruş ve çalışma şekilleri"});
            this.checkedListBox1.Location = new System.Drawing.Point(20, 20);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(437, 259);
            this.checkedListBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 535);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.btnHakkimizda);
            this.Controls.Add(this.btnYardim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYardim;
        private System.Windows.Forms.Button btnHakkimizda;
        public System.Windows.Forms.Button btnDevam;
        public System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

