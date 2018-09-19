namespace xml
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.numericSchoolNo = new System.Windows.Forms.NumericUpDown();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTekOgrenciKaydet = new System.Windows.Forms.Button();
            this.btnTumOgrenciler = new System.Windows.Forms.Button();
            this.lVOgrenci = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numericSchoolNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(40, 34);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(31, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Adı : ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(40, 74);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(45, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Soyadı :";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(40, 116);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(52, 13);
            this.lblStudentNo.TabIndex = 1;
            this.lblStudentNo.Text = "Okul No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doğum Tarihi : ";
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(129, 34);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtBxFirstName.TabIndex = 2;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(129, 67);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(200, 20);
            this.txtBxLastName.TabIndex = 3;
            // 
            // numericSchoolNo
            // 
            this.numericSchoolNo.Location = new System.Drawing.Point(129, 109);
            this.numericSchoolNo.Name = "numericSchoolNo";
            this.numericSchoolNo.Size = new System.Drawing.Size(200, 20);
            this.numericSchoolNo.TabIndex = 6;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(129, 153);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(413, 34);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(256, 34);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTekOgrenciKaydet
            // 
            this.btnTekOgrenciKaydet.Location = new System.Drawing.Point(413, 81);
            this.btnTekOgrenciKaydet.Name = "btnTekOgrenciKaydet";
            this.btnTekOgrenciKaydet.Size = new System.Drawing.Size(256, 34);
            this.btnTekOgrenciKaydet.TabIndex = 9;
            this.btnTekOgrenciKaydet.Text = "Tek Öğrenci Serilize Et";
            this.btnTekOgrenciKaydet.UseVisualStyleBackColor = true;
            this.btnTekOgrenciKaydet.Click += new System.EventHandler(this.btnTekOgrenciKaydet_Click);
            // 
            // btnTumOgrenciler
            // 
            this.btnTumOgrenciler.Location = new System.Drawing.Point(413, 142);
            this.btnTumOgrenciler.Name = "btnTumOgrenciler";
            this.btnTumOgrenciler.Size = new System.Drawing.Size(256, 31);
            this.btnTumOgrenciler.TabIndex = 10;
            this.btnTumOgrenciler.Text = "Hepsini Serilize Et";
            this.btnTumOgrenciler.UseVisualStyleBackColor = true;
            this.btnTumOgrenciler.Click += new System.EventHandler(this.btnTumOgrenciler_Click);
            // 
            // lVOgrenci
            // 
            this.lVOgrenci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lVOgrenci.Location = new System.Drawing.Point(55, 210);
            this.lVOgrenci.Name = "lVOgrenci";
            this.lVOgrenci.Size = new System.Drawing.Size(614, 208);
            this.lVOgrenci.TabIndex = 11;
            this.lVOgrenci.UseCompatibleStateImageBehavior = false;
            this.lVOgrenci.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Okul No";
            this.columnHeader3.Width = 136;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Doğum Tarihi";
            this.columnHeader4.Width = 158;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yaş";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 451);
            this.Controls.Add(this.lVOgrenci);
            this.Controls.Add(this.btnTumOgrenciler);
            this.Controls.Add(this.btnTekOgrenciKaydet);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.numericSchoolNo);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericSchoolNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.NumericUpDown numericSchoolNo;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTekOgrenciKaydet;
        private System.Windows.Forms.Button btnTumOgrenciler;
        private System.Windows.Forms.ListView lVOgrenci;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

