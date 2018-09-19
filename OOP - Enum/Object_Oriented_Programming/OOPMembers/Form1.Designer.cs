namespace OOPMembers
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
            this.txtBxIlkHali = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblSonHali = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBxIlkHali
            // 
            this.txtBxIlkHali.Location = new System.Drawing.Point(54, 64);
            this.txtBxIlkHali.Name = "txtBxIlkHali";
            this.txtBxIlkHali.Size = new System.Drawing.Size(100, 20);
            this.txtBxIlkHali.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(66, 168);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "DEĞİŞTİR";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblSonHali
            // 
            this.lblSonHali.AutoSize = true;
            this.lblSonHali.Location = new System.Drawing.Point(89, 114);
            this.lblSonHali.Name = "lblSonHali";
            this.lblSonHali.Size = new System.Drawing.Size(0, 13);
            this.lblSonHali.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 263);
            this.Controls.Add(this.lblSonHali);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtBxIlkHali);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxIlkHali;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblSonHali;
    }
}

