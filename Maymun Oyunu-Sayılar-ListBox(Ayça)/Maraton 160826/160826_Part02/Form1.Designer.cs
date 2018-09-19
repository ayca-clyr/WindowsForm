namespace _160826_Part02
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
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.lstBxFutbolcuKayitlari = new System.Windows.Forms.ListBox();
            this.btnKaydetme = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.btnGuncelleme = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblShooting = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.txtBxSpecialShooting = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cBxTeam = new System.Windows.Forms.ComboBox();
            this.numericShooting = new System.Windows.Forms.NumericUpDown();
            this.numericPassing = new System.Windows.Forms.NumericUpDown();
            this.numericDribbling = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericShooting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDribbling)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(149, 27);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtBxFirstName.TabIndex = 0;
            this.txtBxFirstName.TextChanged += new System.EventHandler(this.txtBxFutbolcular_TextChanged);
            // 
            // lstBxFutbolcuKayitlari
            // 
            this.lstBxFutbolcuKayitlari.FormattingEnabled = true;
            this.lstBxFutbolcuKayitlari.Location = new System.Drawing.Point(389, 27);
            this.lstBxFutbolcuKayitlari.Name = "lstBxFutbolcuKayitlari";
            this.lstBxFutbolcuKayitlari.Size = new System.Drawing.Size(120, 212);
            this.lstBxFutbolcuKayitlari.TabIndex = 1;
            this.lstBxFutbolcuKayitlari.SelectedIndexChanged += new System.EventHandler(this.lstBxFutbolcuKayitlari_SelectedIndexChanged);
            // 
            // btnKaydetme
            // 
            this.btnKaydetme.Location = new System.Drawing.Point(91, 300);
            this.btnKaydetme.Name = "btnKaydetme";
            this.btnKaydetme.Size = new System.Drawing.Size(75, 23);
            this.btnKaydetme.TabIndex = 2;
            this.btnKaydetme.Text = "Kaydetme";
            this.btnKaydetme.UseVisualStyleBackColor = true;
            this.btnKaydetme.Click += new System.EventHandler(this.btnKaydetme_Click);
            // 
            // btnSilme
            // 
            this.btnSilme.Location = new System.Drawing.Point(418, 300);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(75, 23);
            this.btnSilme.TabIndex = 3;
            this.btnSilme.Text = "Silme";
            this.btnSilme.UseVisualStyleBackColor = true;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // btnGuncelleme
            // 
            this.btnGuncelleme.Location = new System.Drawing.Point(248, 300);
            this.btnGuncelleme.Name = "btnGuncelleme";
            this.btnGuncelleme.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelleme.TabIndex = 4;
            this.btnGuncelleme.Text = "Güncelleme";
            this.btnGuncelleme.UseVisualStyleBackColor = true;
            this.btnGuncelleme.Click += new System.EventHandler(this.btnGuncelleme_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(11, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(63, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "FirstName   ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(11, 60);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(55, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "LastName";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(11, 86);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(65, 13);
            this.lblDateOfBirth.TabIndex = 8;
            this.lblDateOfBirth.Text = "DateOfBirth ";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(11, 113);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(34, 13);
            this.lblTeam.TabIndex = 9;
            this.lblTeam.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "SpecialShooting";
            // 
            // lblShooting
            // 
            this.lblShooting.AutoSize = true;
            this.lblShooting.Location = new System.Drawing.Point(11, 165);
            this.lblShooting.Name = "lblShooting";
            this.lblShooting.Size = new System.Drawing.Size(70, 13);
            this.lblShooting.TabIndex = 11;
            this.lblShooting.Text = "Shooting       ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Passing         ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Dribbling      ";
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(149, 53);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(100, 20);
            this.txtBxLastName.TabIndex = 18;
            // 
            // txtBxSpecialShooting
            // 
            this.txtBxSpecialShooting.Location = new System.Drawing.Point(149, 132);
            this.txtBxSpecialShooting.Name = "txtBxSpecialShooting";
            this.txtBxSpecialShooting.Size = new System.Drawing.Size(100, 20);
            this.txtBxSpecialShooting.TabIndex = 20;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(149, 79);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(173, 20);
            this.dtpDogumTarihi.TabIndex = 22;
            // 
            // cBxTeam
            // 
            this.cBxTeam.FormattingEnabled = true;
            this.cBxTeam.Items.AddRange(new object[] {
            "GALATASAYAR",
            "Beşiktaş",
            "Fenerbahçe",
            "Bursaspor",
            "Trabzonspor",
            "Osmanlıspor"});
            this.cBxTeam.Location = new System.Drawing.Point(149, 105);
            this.cBxTeam.Name = "cBxTeam";
            this.cBxTeam.Size = new System.Drawing.Size(100, 21);
            this.cBxTeam.TabIndex = 23;
            this.cBxTeam.SelectedIndexChanged += new System.EventHandler(this.cBxTeam_SelectedIndexChanged);
            // 
            // numericShooting
            // 
            this.numericShooting.Location = new System.Drawing.Point(149, 165);
            this.numericShooting.Name = "numericShooting";
            this.numericShooting.Size = new System.Drawing.Size(120, 20);
            this.numericShooting.TabIndex = 24;
            // 
            // numericPassing
            // 
            this.numericPassing.Location = new System.Drawing.Point(149, 191);
            this.numericPassing.Name = "numericPassing";
            this.numericPassing.Size = new System.Drawing.Size(120, 20);
            this.numericPassing.TabIndex = 25;
            // 
            // numericDribbling
            // 
            this.numericDribbling.Location = new System.Drawing.Point(149, 217);
            this.numericDribbling.Name = "numericDribbling";
            this.numericDribbling.Size = new System.Drawing.Size(120, 20);
            this.numericDribbling.TabIndex = 26;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 441);
            this.Controls.Add(this.numericDribbling);
            this.Controls.Add(this.numericPassing);
            this.Controls.Add(this.numericShooting);
            this.Controls.Add(this.cBxTeam);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtBxSpecialShooting);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblShooting);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnGuncelleme);
            this.Controls.Add(this.btnSilme);
            this.Controls.Add(this.btnKaydetme);
            this.Controls.Add(this.lstBxFutbolcuKayitlari);
            this.Controls.Add(this.txtBxFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericShooting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDribbling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.ListBox lstBxFutbolcuKayitlari;
        private System.Windows.Forms.Button btnKaydetme;
        private System.Windows.Forms.Button btnSilme;
        private System.Windows.Forms.Button btnGuncelleme;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblShooting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxSpecialShooting;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.ComboBox cBxTeam;
        private System.Windows.Forms.NumericUpDown numericShooting;
        private System.Windows.Forms.NumericUpDown numericPassing;
        private System.Windows.Forms.NumericUpDown numericDribbling;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

