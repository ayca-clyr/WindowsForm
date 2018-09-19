namespace _11_MultipleForms
{
    partial class StudentDeleteForm
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
            this.lblİsimGöster = new System.Windows.Forms.Label();
            this.btnTamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblİsimGöster
            // 
            this.lblİsimGöster.AutoSize = true;
            this.lblİsimGöster.Location = new System.Drawing.Point(89, 80);
            this.lblİsimGöster.Name = "lblİsimGöster";
            this.lblİsimGöster.Size = new System.Drawing.Size(35, 13);
            this.lblİsimGöster.TabIndex = 0;
            this.lblİsimGöster.Text = "label1";
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(137, 135);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 1;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // StudentDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.lblİsimGöster);
            this.Name = "StudentDeleteForm";
            this.Text = "StudentDeleteForm";
            this.Load += new System.EventHandler(this.StudentDeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblİsimGöster;
        private System.Windows.Forms.Button btnTamam;
    }
}