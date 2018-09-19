namespace _7__Abstraction
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
            this.lblTruckDetails = new System.Windows.Forms.Label();
            this.btnCreateTruck = new System.Windows.Forms.Button();
            this.btnCarStart = new System.Windows.Forms.Button();
            this.lblCarSound = new System.Windows.Forms.Label();
            this.btnTruckStart = new System.Windows.Forms.Button();
            this.lblSoundTruck = new System.Windows.Forms.Label();
            this.btnCarHorn = new System.Windows.Forms.Button();
            this.btnTruckHorn = new System.Windows.Forms.Button();
            this.lblCarHorn = new System.Windows.Forms.Label();
            this.lblTruckHorn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Location = new System.Drawing.Point(37, 37);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(180, 34);
            this.btnCreateCar.TabIndex = 0;
            this.btnCreateCar.Text = "Araba Oluştur";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // lblCarDetails
            // 
            this.lblCarDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarDetails.Location = new System.Drawing.Point(34, 88);
            this.lblCarDetails.Name = "lblCarDetails";
            this.lblCarDetails.Size = new System.Drawing.Size(183, 162);
            this.lblCarDetails.TabIndex = 1;
            // 
            // lblTruckDetails
            // 
            this.lblTruckDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTruckDetails.Location = new System.Drawing.Point(270, 88);
            this.lblTruckDetails.Name = "lblTruckDetails";
            this.lblTruckDetails.Size = new System.Drawing.Size(183, 162);
            this.lblTruckDetails.TabIndex = 3;
            // 
            // btnCreateTruck
            // 
            this.btnCreateTruck.Location = new System.Drawing.Point(273, 37);
            this.btnCreateTruck.Name = "btnCreateTruck";
            this.btnCreateTruck.Size = new System.Drawing.Size(180, 34);
            this.btnCreateTruck.TabIndex = 2;
            this.btnCreateTruck.Text = "Kamyon  Oluştur";
            this.btnCreateTruck.UseVisualStyleBackColor = true;
            this.btnCreateTruck.Click += new System.EventHandler(this.btnCreateTruck_Click);
            // 
            // btnCarStart
            // 
            this.btnCarStart.Location = new System.Drawing.Point(34, 276);
            this.btnCarStart.Name = "btnCarStart";
            this.btnCarStart.Size = new System.Drawing.Size(183, 26);
            this.btnCarStart.TabIndex = 4;
            this.btnCarStart.Text = "Araba Çalıştır";
            this.btnCarStart.UseVisualStyleBackColor = true;
            this.btnCarStart.Click += new System.EventHandler(this.btnCarStart_Click);
            // 
            // lblCarSound
            // 
            this.lblCarSound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarSound.Location = new System.Drawing.Point(34, 318);
            this.lblCarSound.Name = "lblCarSound";
            this.lblCarSound.Size = new System.Drawing.Size(183, 23);
            this.lblCarSound.TabIndex = 5;
            // 
            // btnTruckStart
            // 
            this.btnTruckStart.Location = new System.Drawing.Point(273, 276);
            this.btnTruckStart.Name = "btnTruckStart";
            this.btnTruckStart.Size = new System.Drawing.Size(180, 23);
            this.btnTruckStart.TabIndex = 6;
            this.btnTruckStart.Text = "Kamyon Çalıştır";
            this.btnTruckStart.UseVisualStyleBackColor = true;
            this.btnTruckStart.Click += new System.EventHandler(this.btnTruckStart_Click);
            // 
            // lblSoundTruck
            // 
            this.lblSoundTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoundTruck.Location = new System.Drawing.Point(273, 319);
            this.lblSoundTruck.Name = "lblSoundTruck";
            this.lblSoundTruck.Size = new System.Drawing.Size(180, 22);
            this.lblSoundTruck.TabIndex = 7;
            // 
            // btnCarHorn
            // 
            this.btnCarHorn.Location = new System.Drawing.Point(34, 362);
            this.btnCarHorn.Name = "btnCarHorn";
            this.btnCarHorn.Size = new System.Drawing.Size(183, 23);
            this.btnCarHorn.TabIndex = 8;
            this.btnCarHorn.Text = "Araba Korna Çal";
            this.btnCarHorn.UseVisualStyleBackColor = true;
            this.btnCarHorn.Click += new System.EventHandler(this.btnCarHorn_Click);
            // 
            // btnTruckHorn
            // 
            this.btnTruckHorn.Location = new System.Drawing.Point(273, 362);
            this.btnTruckHorn.Name = "btnTruckHorn";
            this.btnTruckHorn.Size = new System.Drawing.Size(180, 23);
            this.btnTruckHorn.TabIndex = 9;
            this.btnTruckHorn.Text = "Kamyon Korna Çal";
            this.btnTruckHorn.UseVisualStyleBackColor = true;
            this.btnTruckHorn.Click += new System.EventHandler(this.btnTruckHorn_Click);
            // 
            // lblCarHorn
            // 
            this.lblCarHorn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarHorn.Location = new System.Drawing.Point(34, 406);
            this.lblCarHorn.Name = "lblCarHorn";
            this.lblCarHorn.Size = new System.Drawing.Size(183, 23);
            this.lblCarHorn.TabIndex = 10;
            // 
            // lblTruckHorn
            // 
            this.lblTruckHorn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTruckHorn.Location = new System.Drawing.Point(273, 406);
            this.lblTruckHorn.Name = "lblTruckHorn";
            this.lblTruckHorn.Size = new System.Drawing.Size(180, 22);
            this.lblTruckHorn.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 456);
            this.Controls.Add(this.lblTruckHorn);
            this.Controls.Add(this.lblCarHorn);
            this.Controls.Add(this.btnTruckHorn);
            this.Controls.Add(this.btnCarHorn);
            this.Controls.Add(this.lblSoundTruck);
            this.Controls.Add(this.btnTruckStart);
            this.Controls.Add(this.lblCarSound);
            this.Controls.Add(this.btnCarStart);
            this.Controls.Add(this.lblTruckDetails);
            this.Controls.Add(this.btnCreateTruck);
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
        private System.Windows.Forms.Label lblTruckDetails;
        private System.Windows.Forms.Button btnCreateTruck;
        private System.Windows.Forms.Button btnCarStart;
        private System.Windows.Forms.Label lblCarSound;
        private System.Windows.Forms.Button btnTruckStart;
        private System.Windows.Forms.Label lblSoundTruck;
        private System.Windows.Forms.Button btnCarHorn;
        private System.Windows.Forms.Button btnTruckHorn;
        private System.Windows.Forms.Label lblCarHorn;
        private System.Windows.Forms.Label lblTruckHorn;
    }
}

