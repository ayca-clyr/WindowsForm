namespace _4_YönTusları
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
            this.btnX = new System.Windows.Forms.Button();
            this.btnKuzeyBatı = new System.Windows.Forms.Button();
            this.btnKuzey = new System.Windows.Forms.Button();
            this.btnKuzeyDogu = new System.Windows.Forms.Button();
            this.btnBatı = new System.Windows.Forms.Button();
            this.btnDogu = new System.Windows.Forms.Button();
            this.btnGuneyBatı = new System.Windows.Forms.Button();
            this.btnGuney = new System.Windows.Forms.Button();
            this.btnGuneyDogu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Lime;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnX.Location = new System.Drawing.Point(26, 23);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(111, 77);
            this.btnX.TabIndex = 0;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            this.btnX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnX_KeyDown);
            // 
            // btnKuzeyBatı
            // 
            this.btnKuzeyBatı.Location = new System.Drawing.Point(394, 180);
            this.btnKuzeyBatı.Name = "btnKuzeyBatı";
            this.btnKuzeyBatı.Size = new System.Drawing.Size(75, 23);
            this.btnKuzeyBatı.TabIndex = 1;
            this.btnKuzeyBatı.Text = "Kuzey Batı";
            this.btnKuzeyBatı.UseVisualStyleBackColor = true;
            this.btnKuzeyBatı.Click += new System.EventHandler(this.btnKuzeyBatı_Click);
            // 
            // btnKuzey
            // 
            this.btnKuzey.Location = new System.Drawing.Point(530, 180);
            this.btnKuzey.Name = "btnKuzey";
            this.btnKuzey.Size = new System.Drawing.Size(75, 23);
            this.btnKuzey.TabIndex = 2;
            this.btnKuzey.Text = "Kuzey";
            this.btnKuzey.UseVisualStyleBackColor = true;
            this.btnKuzey.Click += new System.EventHandler(this.btnKuzey_Click);
            // 
            // btnKuzeyDogu
            // 
            this.btnKuzeyDogu.Location = new System.Drawing.Point(662, 180);
            this.btnKuzeyDogu.Name = "btnKuzeyDogu";
            this.btnKuzeyDogu.Size = new System.Drawing.Size(75, 23);
            this.btnKuzeyDogu.TabIndex = 3;
            this.btnKuzeyDogu.Text = "Kuzey Doğu";
            this.btnKuzeyDogu.UseVisualStyleBackColor = true;
            this.btnKuzeyDogu.Click += new System.EventHandler(this.btnKuzeyDogu_Click);
            // 
            // btnBatı
            // 
            this.btnBatı.Location = new System.Drawing.Point(394, 247);
            this.btnBatı.Name = "btnBatı";
            this.btnBatı.Size = new System.Drawing.Size(75, 23);
            this.btnBatı.TabIndex = 4;
            this.btnBatı.Text = "Batı";
            this.btnBatı.UseVisualStyleBackColor = true;
            this.btnBatı.Click += new System.EventHandler(this.btnBatı_Click);
            // 
            // btnDogu
            // 
            this.btnDogu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDogu.Location = new System.Drawing.Point(662, 247);
            this.btnDogu.Name = "btnDogu";
            this.btnDogu.Size = new System.Drawing.Size(75, 23);
            this.btnDogu.TabIndex = 5;
            this.btnDogu.Text = "Doğu";
            this.btnDogu.UseVisualStyleBackColor = true;
            this.btnDogu.Click += new System.EventHandler(this.btnDogu_Click);
            // 
            // btnGuneyBatı
            // 
            this.btnGuneyBatı.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnGuneyBatı.Location = new System.Drawing.Point(394, 306);
            this.btnGuneyBatı.Name = "btnGuneyBatı";
            this.btnGuneyBatı.Size = new System.Drawing.Size(75, 23);
            this.btnGuneyBatı.TabIndex = 6;
            this.btnGuneyBatı.Text = "Güney Batı";
            this.btnGuneyBatı.UseVisualStyleBackColor = true;
            this.btnGuneyBatı.Click += new System.EventHandler(this.btnGuneyBatı_Click);
            // 
            // btnGuney
            // 
            this.btnGuney.Location = new System.Drawing.Point(530, 306);
            this.btnGuney.Name = "btnGuney";
            this.btnGuney.Size = new System.Drawing.Size(75, 23);
            this.btnGuney.TabIndex = 7;
            this.btnGuney.Text = "Güney";
            this.btnGuney.UseVisualStyleBackColor = true;
            this.btnGuney.Click += new System.EventHandler(this.btnGuney_Click);
            // 
            // btnGuneyDogu
            // 
            this.btnGuneyDogu.Location = new System.Drawing.Point(662, 306);
            this.btnGuneyDogu.Name = "btnGuneyDogu";
            this.btnGuneyDogu.Size = new System.Drawing.Size(75, 23);
            this.btnGuneyDogu.TabIndex = 8;
            this.btnGuneyDogu.Text = "Güney Doğu";
            this.btnGuneyDogu.UseVisualStyleBackColor = true;
            this.btnGuneyDogu.Click += new System.EventHandler(this.btnGuneyDogu_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 474);
            this.Controls.Add(this.btnGuneyDogu);
            this.Controls.Add(this.btnGuney);
            this.Controls.Add(this.btnGuneyBatı);
            this.Controls.Add(this.btnDogu);
            this.Controls.Add(this.btnBatı);
            this.Controls.Add(this.btnKuzeyDogu);
            this.Controls.Add(this.btnKuzey);
            this.Controls.Add(this.btnKuzeyBatı);
            this.Controls.Add(this.btnX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnKuzeyBatı;
        private System.Windows.Forms.Button btnKuzey;
        private System.Windows.Forms.Button btnKuzeyDogu;
        private System.Windows.Forms.Button btnBatı;
        private System.Windows.Forms.Button btnDogu;
        private System.Windows.Forms.Button btnGuneyBatı;
        private System.Windows.Forms.Button btnGuney;
        private System.Windows.Forms.Button btnGuneyDogu;
        private System.Windows.Forms.Timer timer1;
    }
}

