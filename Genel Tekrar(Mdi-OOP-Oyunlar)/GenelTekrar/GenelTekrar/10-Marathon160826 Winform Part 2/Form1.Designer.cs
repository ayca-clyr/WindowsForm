namespace _10_Marathon160826_Winform_Part_2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.dateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.txtBxSpecial = new System.Windows.Forms.TextBox();
            this.numShooting = new System.Windows.Forms.NumericUpDown();
            this.numPassing = new System.Windows.Forms.NumericUpDown();
            this.numDribbling = new System.Windows.Forms.NumericUpDown();
            this.lstKayıtlar = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numShooting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPassing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDribbling)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DateofBirth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Team";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "SpecialShot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shooting";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Passing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dribbling";
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(118, 10);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtBxFirstName.TabIndex = 8;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(118, 46);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(100, 20);
            this.txtBxLastName.TabIndex = 9;
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.Location = new System.Drawing.Point(118, 85);
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(173, 20);
            this.dateTimeBirth.TabIndex = 10;
            // 
            // cmbTeam
            // 
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Items.AddRange(new object[] {
            "Real Madrid",
            "Barcelona",
            "Ac Milan",
            "Juventus",
            "Chealsea",
            "Bayern Munich",
            "Boursia Dourtmund",
            "Galatasaray",
            "Benfica",
            "Porto",
            "Paris St Germain"});
            this.cmbTeam.Location = new System.Drawing.Point(118, 122);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(100, 21);
            this.cmbTeam.TabIndex = 11;
            // 
            // txtBxSpecial
            // 
            this.txtBxSpecial.Location = new System.Drawing.Point(118, 165);
            this.txtBxSpecial.Name = "txtBxSpecial";
            this.txtBxSpecial.Size = new System.Drawing.Size(100, 20);
            this.txtBxSpecial.TabIndex = 12;
            // 
            // numShooting
            // 
            this.numShooting.Location = new System.Drawing.Point(118, 201);
            this.numShooting.Name = "numShooting";
            this.numShooting.Size = new System.Drawing.Size(100, 20);
            this.numShooting.TabIndex = 13;
            // 
            // numPassing
            // 
            this.numPassing.Location = new System.Drawing.Point(118, 236);
            this.numPassing.Name = "numPassing";
            this.numPassing.Size = new System.Drawing.Size(100, 20);
            this.numPassing.TabIndex = 14;
            // 
            // numDribbling
            // 
            this.numDribbling.Location = new System.Drawing.Point(118, 273);
            this.numDribbling.Name = "numDribbling";
            this.numDribbling.Size = new System.Drawing.Size(100, 20);
            this.numDribbling.TabIndex = 15;
            // 
            // lstKayıtlar
            // 
            this.lstKayıtlar.FormattingEnabled = true;
            this.lstKayıtlar.Location = new System.Drawing.Point(367, 10);
            this.lstKayıtlar.Name = "lstKayıtlar";
            this.lstKayıtlar.Size = new System.Drawing.Size(271, 290);
            this.lstKayıtlar.TabIndex = 16;
            this.lstKayıtlar.SelectedIndexChanged += new System.EventHandler(this.lstKayıtlar_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(367, 307);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(467, 306);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(563, 305);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 25);
            this.btnGüncelle.TabIndex = 19;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 357);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstKayıtlar);
            this.Controls.Add(this.numDribbling);
            this.Controls.Add(this.numPassing);
            this.Controls.Add(this.numShooting);
            this.Controls.Add(this.txtBxSpecial);
            this.Controls.Add(this.cmbTeam);
            this.Controls.Add(this.dateTimeBirth);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numShooting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPassing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDribbling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.DateTimePicker dateTimeBirth;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.TextBox txtBxSpecial;
        private System.Windows.Forms.NumericUpDown numShooting;
        private System.Windows.Forms.NumericUpDown numPassing;
        private System.Windows.Forms.NumericUpDown numDribbling;
        private System.Windows.Forms.ListBox lstKayıtlar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
    }
}

