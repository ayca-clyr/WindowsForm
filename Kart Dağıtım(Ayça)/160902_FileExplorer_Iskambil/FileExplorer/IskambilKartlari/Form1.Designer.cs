namespace IskambilKartlari
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
            this.lblIsımler = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            this.txtBxPlayer1 = new System.Windows.Forms.TextBox();
            this.txtBxPlayer2 = new System.Windows.Forms.TextBox();
            this.txtBxPlayer3 = new System.Windows.Forms.TextBox();
            this.txtBxPlayer4 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIsımler
            // 
            this.lblIsımler.AutoSize = true;
            this.lblIsımler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsımler.Location = new System.Drawing.Point(341, 60);
            this.lblIsımler.Name = "lblIsımler";
            this.lblIsımler.Size = new System.Drawing.Size(393, 25);
            this.lblIsımler.TabIndex = 0;
            this.lblIsımler.Text = "LÜTFEN OYUNCU İSİMLERİNİ GİRİNİZ";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayer1.Location = new System.Drawing.Point(414, 151);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(92, 17);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "1. OYUNCU";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayer2.Location = new System.Drawing.Point(414, 189);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(92, 17);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "2. OYUNCU";
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayer3.Location = new System.Drawing.Point(414, 229);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(92, 17);
            this.lblPlayer3.TabIndex = 1;
            this.lblPlayer3.Text = "3. OYUNCU";
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.AutoSize = true;
            this.lblPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayer4.Location = new System.Drawing.Point(414, 268);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(92, 17);
            this.lblPlayer4.TabIndex = 1;
            this.lblPlayer4.Text = "4. OYUNCU";
            // 
            // txtBxPlayer1
            // 
            this.txtBxPlayer1.Location = new System.Drawing.Point(531, 151);
            this.txtBxPlayer1.Name = "txtBxPlayer1";
            this.txtBxPlayer1.Size = new System.Drawing.Size(112, 22);
            this.txtBxPlayer1.TabIndex = 2;
            // 
            // txtBxPlayer2
            // 
            this.txtBxPlayer2.Location = new System.Drawing.Point(531, 189);
            this.txtBxPlayer2.Name = "txtBxPlayer2";
            this.txtBxPlayer2.Size = new System.Drawing.Size(112, 22);
            this.txtBxPlayer2.TabIndex = 2;
            // 
            // txtBxPlayer3
            // 
            this.txtBxPlayer3.Location = new System.Drawing.Point(531, 229);
            this.txtBxPlayer3.Name = "txtBxPlayer3";
            this.txtBxPlayer3.Size = new System.Drawing.Size(112, 22);
            this.txtBxPlayer3.TabIndex = 2;
            // 
            // txtBxPlayer4
            // 
            this.txtBxPlayer4.Location = new System.Drawing.Point(531, 265);
            this.txtBxPlayer4.Name = "txtBxPlayer4";
            this.txtBxPlayer4.Size = new System.Drawing.Size(112, 22);
            this.txtBxPlayer4.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(418, 372);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(225, 73);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "BAŞLA";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 529);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBxPlayer4);
            this.Controls.Add(this.txtBxPlayer3);
            this.Controls.Add(this.txtBxPlayer2);
            this.Controls.Add(this.txtBxPlayer1);
            this.Controls.Add(this.lblPlayer4);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblIsımler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIsımler;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.Label lblPlayer4;
        private System.Windows.Forms.TextBox txtBxPlayer1;
        private System.Windows.Forms.TextBox txtBxPlayer2;
        private System.Windows.Forms.TextBox txtBxPlayer3;
        private System.Windows.Forms.TextBox txtBxPlayer4;
        private System.Windows.Forms.Button btnStart;
    }
}

