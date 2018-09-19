namespace Abstraction
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
            this.btnCreateCar = new System.Windows.Forms.Button();
            this.lblCarDetails = new System.Windows.Forms.Label();
            this.btnStartCar = new System.Windows.Forms.Button();
            this.lblCarSound = new System.Windows.Forms.Label();
            this.btnCreateTruct = new System.Windows.Forms.Button();
            this.lblTructDetails = new System.Windows.Forms.Label();
            this.btnStartTruct = new System.Windows.Forms.Button();
            this.lblTructSound = new System.Windows.Forms.Label();
            this.btnCarHorn = new System.Windows.Forms.Button();
            this.lblCarHorn = new System.Windows.Forms.Label();
            this.btnTructHorn = new System.Windows.Forms.Button();
            this.lblTructHorn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Location = new System.Drawing.Point(12, 25);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(87, 23);
            this.btnCreateCar.TabIndex = 0;
            this.btnCreateCar.Text = "Araba Oluştur";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // lblCarDetails
            // 
            this.lblCarDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarDetails.Location = new System.Drawing.Point(13, 73);
            this.lblCarDetails.Name = "lblCarDetails";
            this.lblCarDetails.Size = new System.Drawing.Size(110, 98);
            this.lblCarDetails.TabIndex = 1;
            // 
            // btnStartCar
            // 
            this.btnStartCar.Location = new System.Drawing.Point(13, 223);
            this.btnStartCar.Name = "btnStartCar";
            this.btnStartCar.Size = new System.Drawing.Size(86, 23);
            this.btnStartCar.TabIndex = 2;
            this.btnStartCar.Text = "Arabayı Çalıştır";
            this.btnStartCar.UseVisualStyleBackColor = true;
            this.btnStartCar.Click += new System.EventHandler(this.btnStartCar_Click);
            // 
            // lblCarSound
            // 
            this.lblCarSound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarSound.Location = new System.Drawing.Point(13, 270);
            this.lblCarSound.Name = "lblCarSound";
            this.lblCarSound.Size = new System.Drawing.Size(100, 40);
            this.lblCarSound.TabIndex = 3;
            // 
            // btnCreateTruct
            // 
            this.btnCreateTruct.Location = new System.Drawing.Point(335, 25);
            this.btnCreateTruct.Name = "btnCreateTruct";
            this.btnCreateTruct.Size = new System.Drawing.Size(101, 23);
            this.btnCreateTruct.TabIndex = 4;
            this.btnCreateTruct.Text = "Kamyon Oluştur";
            this.btnCreateTruct.UseVisualStyleBackColor = true;
            this.btnCreateTruct.Click += new System.EventHandler(this.btnCreateTruct_Click);
            // 
            // lblTructDetails
            // 
            this.lblTructDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTructDetails.Location = new System.Drawing.Point(335, 73);
            this.lblTructDetails.Name = "lblTructDetails";
            this.lblTructDetails.Size = new System.Drawing.Size(128, 98);
            this.lblTructDetails.TabIndex = 5;
            // 
            // btnStartTruct
            // 
            this.btnStartTruct.Location = new System.Drawing.Point(335, 223);
            this.btnStartTruct.Name = "btnStartTruct";
            this.btnStartTruct.Size = new System.Drawing.Size(101, 23);
            this.btnStartTruct.TabIndex = 6;
            this.btnStartTruct.Text = "Kamyonu Çalıştır";
            this.btnStartTruct.UseVisualStyleBackColor = true;
            this.btnStartTruct.Click += new System.EventHandler(this.btnStartTruct_Click);
            // 
            // lblTructSound
            // 
            this.lblTructSound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTructSound.Location = new System.Drawing.Point(335, 270);
            this.lblTructSound.Name = "lblTructSound";
            this.lblTructSound.Size = new System.Drawing.Size(100, 40);
            this.lblTructSound.TabIndex = 7;
            // 
            // btnCarHorn
            // 
            this.btnCarHorn.Location = new System.Drawing.Point(12, 329);
            this.btnCarHorn.Name = "btnCarHorn";
            this.btnCarHorn.Size = new System.Drawing.Size(86, 23);
            this.btnCarHorn.TabIndex = 2;
            this.btnCarHorn.Text = "Karno Çal";
            this.btnCarHorn.UseVisualStyleBackColor = true;
            this.btnCarHorn.Click += new System.EventHandler(this.btnCarHorn_Click);
            // 
            // lblCarHorn
            // 
            this.lblCarHorn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarHorn.Location = new System.Drawing.Point(12, 376);
            this.lblCarHorn.Name = "lblCarHorn";
            this.lblCarHorn.Size = new System.Drawing.Size(100, 40);
            this.lblCarHorn.TabIndex = 3;
            // 
            // btnTructHorn
            // 
            this.btnTructHorn.Location = new System.Drawing.Point(334, 329);
            this.btnTructHorn.Name = "btnTructHorn";
            this.btnTructHorn.Size = new System.Drawing.Size(101, 23);
            this.btnTructHorn.TabIndex = 6;
            this.btnTructHorn.Text = "Korno Çal";
            this.btnTructHorn.UseVisualStyleBackColor = true;
            this.btnTructHorn.Click += new System.EventHandler(this.btnTructHorn_Click);
            // 
            // lblTructHorn
            // 
            this.lblTructHorn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTructHorn.Location = new System.Drawing.Point(334, 376);
            this.lblTructHorn.Name = "lblTructHorn";
            this.lblTructHorn.Size = new System.Drawing.Size(100, 40);
            this.lblTructHorn.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 469);
            this.Controls.Add(this.lblTructHorn);
            this.Controls.Add(this.lblTructSound);
            this.Controls.Add(this.btnTructHorn);
            this.Controls.Add(this.btnStartTruct);
            this.Controls.Add(this.lblTructDetails);
            this.Controls.Add(this.btnCreateTruct);
            this.Controls.Add(this.lblCarHorn);
            this.Controls.Add(this.lblCarSound);
            this.Controls.Add(this.btnCarHorn);
            this.Controls.Add(this.btnStartCar);
            this.Controls.Add(this.lblCarDetails);
            this.Controls.Add(this.btnCreateCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCar;
        private System.Windows.Forms.Label lblCarDetails;
        private System.Windows.Forms.Button btnStartCar;
        private System.Windows.Forms.Label lblCarSound;
        private System.Windows.Forms.Button btnCreateTruct;
        private System.Windows.Forms.Label lblTructDetails;
        private System.Windows.Forms.Button btnStartTruct;
        private System.Windows.Forms.Label lblTructSound;
        private System.Windows.Forms.Button btnCarHorn;
        private System.Windows.Forms.Label lblCarHorn;
        private System.Windows.Forms.Button btnTructHorn;
        private System.Windows.Forms.Label lblTructHorn;
    }
}

