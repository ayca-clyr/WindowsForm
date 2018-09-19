namespace Part_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.btnVehicleGet = new System.Windows.Forms.Button();
            this.btnVehicleOf = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFaster = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBxVehicleType = new System.Windows.Forms.ComboBox();
            this.cBxDLicensType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dTPDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad : ";
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(118, 26);
            this.txtBxFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(76, 20);
            this.txtBxFirstName.TabIndex = 3;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(118, 58);
            this.txtBxLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(76, 20);
            this.txtBxLastName.TabIndex = 3;
            // 
            // btnVehicleGet
            // 
            this.btnVehicleGet.Location = new System.Drawing.Point(139, 283);
            this.btnVehicleGet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVehicleGet.Name = "btnVehicleGet";
            this.btnVehicleGet.Size = new System.Drawing.Size(89, 24);
            this.btnVehicleGet.TabIndex = 4;
            this.btnVehicleGet.Text = "Araca Bin";
            this.btnVehicleGet.UseVisualStyleBackColor = true;
            this.btnVehicleGet.Click += new System.EventHandler(this.btnVehicleGet_Click);
            // 
            // btnVehicleOf
            // 
            this.btnVehicleOf.Location = new System.Drawing.Point(241, 283);
            this.btnVehicleOf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVehicleOf.Name = "btnVehicleOf";
            this.btnVehicleOf.Size = new System.Drawing.Size(88, 24);
            this.btnVehicleOf.TabIndex = 5;
            this.btnVehicleOf.Text = "Araçtan In";
            this.btnVehicleOf.UseVisualStyleBackColor = true;
            this.btnVehicleOf.Click += new System.EventHandler(this.btnVehicleOf_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(354, 283);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(82, 24);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Çalıştır";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(450, 283);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(72, 24);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Durdur";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFaster
            // 
            this.btnFaster.Location = new System.Drawing.Point(543, 283);
            this.btnFaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFaster.Name = "btnFaster";
            this.btnFaster.Size = new System.Drawing.Size(75, 24);
            this.btnFaster.TabIndex = 8;
            this.btnFaster.Text = "Hızlan";
            this.btnFaster.UseVisualStyleBackColor = true;
            this.btnFaster.Click += new System.EventHandler(this.btnFaster_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.Location = new System.Drawing.Point(632, 283);
            this.btnSlow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(78, 24);
            this.btnSlow.TabIndex = 9;
            this.btnSlow.Text = "Yavaşla";
            this.btnSlow.UseVisualStyleBackColor = true;
            // 
            // lblDetails
            // 
            this.lblDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDetails.Location = new System.Drawing.Point(594, 76);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(224, 133);
            this.lblDetails.TabIndex = 10;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(387, 131);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(90, 32);
            this.btnDetails.TabIndex = 11;
            this.btnDetails.Text = "Kaydet";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bilgiler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Araç Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sürücü Belgesi Tipi";
            // 
            // cBxVehicleType
            // 
            this.cBxVehicleType.FormattingEnabled = true;
            this.cBxVehicleType.Location = new System.Drawing.Point(118, 138);
            this.cBxVehicleType.Name = "cBxVehicleType";
            this.cBxVehicleType.Size = new System.Drawing.Size(121, 21);
            this.cBxVehicleType.TabIndex = 17;
            // 
            // cBxDLicensType
            // 
            this.cBxDLicensType.FormattingEnabled = true;
            this.cBxDLicensType.Location = new System.Drawing.Point(116, 178);
            this.cBxDLicensType.Name = "cBxDLicensType";
            this.cBxDLicensType.Size = new System.Drawing.Size(121, 21);
            this.cBxDLicensType.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Doğum Tarihi";
            // 
            // dTPDateOfBirth
            // 
            this.dTPDateOfBirth.Location = new System.Drawing.Point(118, 96);
            this.dTPDateOfBirth.Name = "dTPDateOfBirth";
            this.dTPDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dTPDateOfBirth.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 348);
            this.Controls.Add(this.dTPDateOfBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBxDLicensType);
            this.Controls.Add(this.cBxVehicleType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnSlow);
            this.Controls.Add(this.btnFaster);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnVehicleOf);
            this.Controls.Add(this.btnVehicleGet);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.Button btnVehicleGet;
        private System.Windows.Forms.Button btnVehicleOf;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnFaster;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBxVehicleType;
        private System.Windows.Forms.ComboBox cBxDLicensType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTPDateOfBirth;
    }
}

