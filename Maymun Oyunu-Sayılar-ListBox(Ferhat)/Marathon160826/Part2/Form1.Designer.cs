namespace Part2
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lBoxPlayer = new System.Windows.Forms.ListBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtPickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cBoxTeam = new System.Windows.Forms.ComboBox();
            this.txtSpecialShoot = new System.Windows.Forms.TextBox();
            this.numericUpDownShooting = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPassing = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDribbling = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShooting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDribbling)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lBoxPlayer
            // 
            this.lBoxPlayer.FormattingEnabled = true;
            this.lBoxPlayer.Location = new System.Drawing.Point(277, 10);
            this.lBoxPlayer.Name = "lBoxPlayer";
            this.lBoxPlayer.Size = new System.Drawing.Size(152, 212);
            this.lBoxPlayer.TabIndex = 1;
            this.lBoxPlayer.SelectedIndexChanged += new System.EventHandler(this.lBoxPlayer_SelectedIndexChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(113, 10);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(149, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Team";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Special Shoot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Shooting ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Passing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Dribbling";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(113, 37);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(149, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // dtPickerDateOfBirth
            // 
            this.dtPickerDateOfBirth.Location = new System.Drawing.Point(113, 64);
            this.dtPickerDateOfBirth.Name = "dtPickerDateOfBirth";
            this.dtPickerDateOfBirth.Size = new System.Drawing.Size(149, 20);
            this.dtPickerDateOfBirth.TabIndex = 4;
            // 
            // cBoxTeam
            // 
            this.cBoxTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTeam.FormattingEnabled = true;
            this.cBoxTeam.Items.AddRange(new object[] {
            "GALATSARAY",
            "FENERBAHÇE",
            "BEŞİKTAŞ"});
            this.cBoxTeam.Location = new System.Drawing.Point(113, 91);
            this.cBoxTeam.Name = "cBoxTeam";
            this.cBoxTeam.Size = new System.Drawing.Size(149, 21);
            this.cBoxTeam.TabIndex = 5;
            // 
            // txtSpecialShoot
            // 
            this.txtSpecialShoot.Location = new System.Drawing.Point(113, 119);
            this.txtSpecialShoot.Name = "txtSpecialShoot";
            this.txtSpecialShoot.Size = new System.Drawing.Size(149, 20);
            this.txtSpecialShoot.TabIndex = 2;
            // 
            // numericUpDownShooting
            // 
            this.numericUpDownShooting.Location = new System.Drawing.Point(113, 146);
            this.numericUpDownShooting.Name = "numericUpDownShooting";
            this.numericUpDownShooting.Size = new System.Drawing.Size(149, 20);
            this.numericUpDownShooting.TabIndex = 6;
            // 
            // numericUpDownPassing
            // 
            this.numericUpDownPassing.Location = new System.Drawing.Point(113, 173);
            this.numericUpDownPassing.Name = "numericUpDownPassing";
            this.numericUpDownPassing.Size = new System.Drawing.Size(149, 20);
            this.numericUpDownPassing.TabIndex = 6;
            // 
            // numericUpDownDribbling
            // 
            this.numericUpDownDribbling.Location = new System.Drawing.Point(113, 200);
            this.numericUpDownDribbling.Name = "numericUpDownDribbling";
            this.numericUpDownDribbling.Size = new System.Drawing.Size(149, 20);
            this.numericUpDownDribbling.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(97, 241);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 276);
            this.Controls.Add(this.numericUpDownDribbling);
            this.Controls.Add(this.numericUpDownPassing);
            this.Controls.Add(this.numericUpDownShooting);
            this.Controls.Add(this.cBoxTeam);
            this.Controls.Add(this.dtPickerDateOfBirth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSpecialShoot);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lBoxPlayer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShooting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDribbling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lBoxPlayer;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtPickerDateOfBirth;
        private System.Windows.Forms.ComboBox cBoxTeam;
        private System.Windows.Forms.TextBox txtSpecialShoot;
        private System.Windows.Forms.NumericUpDown numericUpDownShooting;
        private System.Windows.Forms.NumericUpDown numericUpDownPassing;
        private System.Windows.Forms.NumericUpDown numericUpDownDribbling;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}

