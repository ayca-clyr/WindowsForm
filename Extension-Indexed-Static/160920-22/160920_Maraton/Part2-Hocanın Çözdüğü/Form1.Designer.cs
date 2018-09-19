namespace Part2_Hocanın_Çözdüğü
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
            this.gBxDriverPanel = new System.Windows.Forms.GroupBox();
            this.gBxVehiclePanel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.cBxLicenseType = new System.Windows.Forms.ComboBox();
            this.btnSaveDriver = new System.Windows.Forms.Button();
            this.lstBxDrivers = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxMake = new System.Windows.Forms.TextBox();
            this.txtBxModel = new System.Windows.Forms.TextBox();
            this.cBxVehicleType = new System.Windows.Forms.ComboBox();
            this.btnSaveVehicle = new System.Windows.Forms.Button();
            this.lstBxVehicle = new System.Windows.Forms.ListBox();
            this.gBxSimulationPanel = new System.Windows.Forms.GroupBox();
            this.cBxVehicles = new System.Windows.Forms.ComboBox();
            this.cBxDrivers = new System.Windows.Forms.ComboBox();
            this.btnGetIn = new System.Windows.Forms.Button();
            this.btnGetOff = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.btnBrake = new System.Windows.Forms.Button();
            this.lblVehicleStatus = new System.Windows.Forms.Label();
            this.lblVehicleSpeed = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.gBxDriverPanel.SuspendLayout();
            this.gBxVehiclePanel.SuspendLayout();
            this.gBxSimulationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBxDriverPanel
            // 
            this.gBxDriverPanel.Controls.Add(this.lstBxDrivers);
            this.gBxDriverPanel.Controls.Add(this.btnSaveDriver);
            this.gBxDriverPanel.Controls.Add(this.cBxLicenseType);
            this.gBxDriverPanel.Controls.Add(this.txtBxLastName);
            this.gBxDriverPanel.Controls.Add(this.txtBxFirstName);
            this.gBxDriverPanel.Controls.Add(this.label3);
            this.gBxDriverPanel.Controls.Add(this.label2);
            this.gBxDriverPanel.Controls.Add(this.label1);
            this.gBxDriverPanel.Location = new System.Drawing.Point(12, 21);
            this.gBxDriverPanel.Name = "gBxDriverPanel";
            this.gBxDriverPanel.Size = new System.Drawing.Size(302, 410);
            this.gBxDriverPanel.TabIndex = 0;
            this.gBxDriverPanel.TabStop = false;
            this.gBxDriverPanel.Text = "Sürücü Paneli";
            // 
            // gBxVehiclePanel
            // 
            this.gBxVehiclePanel.Controls.Add(this.lstBxVehicle);
            this.gBxVehiclePanel.Controls.Add(this.btnSaveVehicle);
            this.gBxVehiclePanel.Controls.Add(this.cBxVehicleType);
            this.gBxVehiclePanel.Controls.Add(this.txtBxModel);
            this.gBxVehiclePanel.Controls.Add(this.txtBxMake);
            this.gBxVehiclePanel.Controls.Add(this.label6);
            this.gBxVehiclePanel.Controls.Add(this.label5);
            this.gBxVehiclePanel.Controls.Add(this.label4);
            this.gBxVehiclePanel.Location = new System.Drawing.Point(320, 21);
            this.gBxVehiclePanel.Name = "gBxVehiclePanel";
            this.gBxVehiclePanel.Size = new System.Drawing.Size(269, 410);
            this.gBxVehiclePanel.TabIndex = 0;
            this.gBxVehiclePanel.TabStop = false;
            this.gBxVehiclePanel.Text = "Araç Detayları";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sürücü Belgesi : ";
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(104, 42);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtBxFirstName.TabIndex = 1;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(104, 76);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(100, 20);
            this.txtBxLastName.TabIndex = 2;
            // 
            // cBxLicenseType
            // 
            this.cBxLicenseType.FormattingEnabled = true;
            this.cBxLicenseType.Location = new System.Drawing.Point(104, 109);
            this.cBxLicenseType.Name = "cBxLicenseType";
            this.cBxLicenseType.Size = new System.Drawing.Size(100, 21);
            this.cBxLicenseType.TabIndex = 3;
            // 
            // btnSaveDriver
            // 
            this.btnSaveDriver.Location = new System.Drawing.Point(129, 150);
            this.btnSaveDriver.Name = "btnSaveDriver";
            this.btnSaveDriver.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDriver.TabIndex = 4;
            this.btnSaveDriver.Text = "Kaydet";
            this.btnSaveDriver.UseVisualStyleBackColor = true;
            this.btnSaveDriver.Click += new System.EventHandler(this.btnSaveDriver_Click);
            // 
            // lstBxDrivers
            // 
            this.lstBxDrivers.FormattingEnabled = true;
            this.lstBxDrivers.Location = new System.Drawing.Point(9, 241);
            this.lstBxDrivers.Name = "lstBxDrivers";
            this.lstBxDrivers.Size = new System.Drawing.Size(195, 147);
            this.lstBxDrivers.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Marka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Araç Tipi";
            // 
            // txtBxMake
            // 
            this.txtBxMake.Location = new System.Drawing.Point(127, 35);
            this.txtBxMake.Name = "txtBxMake";
            this.txtBxMake.Size = new System.Drawing.Size(100, 20);
            this.txtBxMake.TabIndex = 3;
            // 
            // txtBxModel
            // 
            this.txtBxModel.Location = new System.Drawing.Point(127, 69);
            this.txtBxModel.Name = "txtBxModel";
            this.txtBxModel.Size = new System.Drawing.Size(100, 20);
            this.txtBxModel.TabIndex = 4;
            // 
            // cBxVehicleType
            // 
            this.cBxVehicleType.FormattingEnabled = true;
            this.cBxVehicleType.Location = new System.Drawing.Point(127, 101);
            this.cBxVehicleType.Name = "cBxVehicleType";
            this.cBxVehicleType.Size = new System.Drawing.Size(100, 21);
            this.cBxVehicleType.TabIndex = 5;
            // 
            // btnSaveVehicle
            // 
            this.btnSaveVehicle.Location = new System.Drawing.Point(152, 150);
            this.btnSaveVehicle.Name = "btnSaveVehicle";
            this.btnSaveVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnSaveVehicle.TabIndex = 6;
            this.btnSaveVehicle.Text = "Kaydet";
            this.btnSaveVehicle.UseVisualStyleBackColor = true;
            this.btnSaveVehicle.Click += new System.EventHandler(this.btnSaveVehicle_Click);
            // 
            // lstBxVehicle
            // 
            this.lstBxVehicle.FormattingEnabled = true;
            this.lstBxVehicle.Location = new System.Drawing.Point(33, 241);
            this.lstBxVehicle.Name = "lstBxVehicle";
            this.lstBxVehicle.Size = new System.Drawing.Size(194, 147);
            this.lstBxVehicle.TabIndex = 7;
            // 
            // gBxSimulationPanel
            // 
            this.gBxSimulationPanel.Controls.Add(this.lblDriver);
            this.gBxSimulationPanel.Controls.Add(this.lblVehicleSpeed);
            this.gBxSimulationPanel.Controls.Add(this.lblVehicleStatus);
            this.gBxSimulationPanel.Controls.Add(this.btnBrake);
            this.gBxSimulationPanel.Controls.Add(this.btnAccelerate);
            this.gBxSimulationPanel.Controls.Add(this.btnStop);
            this.gBxSimulationPanel.Controls.Add(this.btnStart);
            this.gBxSimulationPanel.Controls.Add(this.btnGetOff);
            this.gBxSimulationPanel.Controls.Add(this.btnGetIn);
            this.gBxSimulationPanel.Controls.Add(this.cBxDrivers);
            this.gBxSimulationPanel.Controls.Add(this.cBxVehicles);
            this.gBxSimulationPanel.Location = new System.Drawing.Point(595, 21);
            this.gBxSimulationPanel.Name = "gBxSimulationPanel";
            this.gBxSimulationPanel.Size = new System.Drawing.Size(241, 403);
            this.gBxSimulationPanel.TabIndex = 1;
            this.gBxSimulationPanel.TabStop = false;
            this.gBxSimulationPanel.Text = "Simulasyon ";
            // 
            // cBxVehicles
            // 
            this.cBxVehicles.FormattingEnabled = true;
            this.cBxVehicles.Location = new System.Drawing.Point(22, 34);
            this.cBxVehicles.Name = "cBxVehicles";
            this.cBxVehicles.Size = new System.Drawing.Size(121, 21);
            this.cBxVehicles.TabIndex = 0;
            // 
            // cBxDrivers
            // 
            this.cBxDrivers.FormattingEnabled = true;
            this.cBxDrivers.Location = new System.Drawing.Point(22, 69);
            this.cBxDrivers.Name = "cBxDrivers";
            this.cBxDrivers.Size = new System.Drawing.Size(121, 21);
            this.cBxDrivers.TabIndex = 1;
            // 
            // btnGetIn
            // 
            this.btnGetIn.Location = new System.Drawing.Point(22, 132);
            this.btnGetIn.Name = "btnGetIn";
            this.btnGetIn.Size = new System.Drawing.Size(75, 23);
            this.btnGetIn.TabIndex = 2;
            this.btnGetIn.Text = "Bin";
            this.btnGetIn.UseVisualStyleBackColor = true;
            this.btnGetIn.Click += new System.EventHandler(this.btnGetIn_Click);
            // 
            // btnGetOff
            // 
            this.btnGetOff.Location = new System.Drawing.Point(115, 132);
            this.btnGetOff.Name = "btnGetOff";
            this.btnGetOff.Size = new System.Drawing.Size(75, 23);
            this.btnGetOff.TabIndex = 3;
            this.btnGetOff.Text = "In";
            this.btnGetOff.UseVisualStyleBackColor = true;
            this.btnGetOff.Click += new System.EventHandler(this.btnGetOff_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 180);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Çalıştır";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(115, 180);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Durdur";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Location = new System.Drawing.Point(22, 225);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(75, 23);
            this.btnAccelerate.TabIndex = 6;
            this.btnAccelerate.Text = "Gazla";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // btnBrake
            // 
            this.btnBrake.Location = new System.Drawing.Point(115, 225);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(75, 23);
            this.btnBrake.TabIndex = 7;
            this.btnBrake.Text = "Yavaşla";
            this.btnBrake.UseVisualStyleBackColor = true;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            // 
            // lblVehicleStatus
            // 
            this.lblVehicleStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleStatus.Location = new System.Drawing.Point(21, 322);
            this.lblVehicleStatus.Name = "lblVehicleStatus";
            this.lblVehicleStatus.Size = new System.Drawing.Size(100, 24);
            this.lblVehicleStatus.TabIndex = 8;
            // 
            // lblVehicleSpeed
            // 
            this.lblVehicleSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSpeed.Location = new System.Drawing.Point(21, 360);
            this.lblVehicleSpeed.Name = "lblVehicleSpeed";
            this.lblVehicleSpeed.Size = new System.Drawing.Size(100, 21);
            this.lblVehicleSpeed.TabIndex = 8;
            // 
            // lblDriver
            // 
            this.lblDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDriver.Location = new System.Drawing.Point(21, 282);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(100, 26);
            this.lblDriver.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 436);
            this.Controls.Add(this.gBxSimulationPanel);
            this.Controls.Add(this.gBxVehiclePanel);
            this.Controls.Add(this.gBxDriverPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBxDriverPanel.ResumeLayout(false);
            this.gBxDriverPanel.PerformLayout();
            this.gBxVehiclePanel.ResumeLayout(false);
            this.gBxVehiclePanel.PerformLayout();
            this.gBxSimulationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBxDriverPanel;
        private System.Windows.Forms.ListBox lstBxDrivers;
        private System.Windows.Forms.Button btnSaveDriver;
        private System.Windows.Forms.ComboBox cBxLicenseType;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBxVehiclePanel;
        private System.Windows.Forms.ListBox lstBxVehicle;
        private System.Windows.Forms.Button btnSaveVehicle;
        private System.Windows.Forms.ComboBox cBxVehicleType;
        private System.Windows.Forms.TextBox txtBxModel;
        private System.Windows.Forms.TextBox txtBxMake;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gBxSimulationPanel;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblVehicleSpeed;
        private System.Windows.Forms.Label lblVehicleStatus;
        private System.Windows.Forms.Button btnBrake;
        private System.Windows.Forms.Button btnAccelerate;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGetOff;
        private System.Windows.Forms.Button btnGetIn;
        private System.Windows.Forms.ComboBox cBxDrivers;
        private System.Windows.Forms.ComboBox cBxVehicles;
    }
}

