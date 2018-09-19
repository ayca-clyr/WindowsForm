namespace Part_1
{
    partial class StudentForm
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
            this.groupWorkDetails = new System.Windows.Forms.GroupBox();
            this.dTPStudentWorkEndDate = new System.Windows.Forms.DateTimePicker();
            this.dTPStudentWorkStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtBxStudentWorkName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupSchoolDetails = new System.Windows.Forms.GroupBox();
            this.lblStudentSchoolBranch = new System.Windows.Forms.Label();
            this.cBxStudentSchoolBranch = new System.Windows.Forms.ComboBox();
            this.dTPStudentSchoolEndDate = new System.Windows.Forms.DateTimePicker();
            this.dTPStudentSchoolStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtBxStudentSchoolName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupStudents = new System.Windows.Forms.GroupBox();
            this.btnStudensSave = new System.Windows.Forms.Button();
            this.cBxStudentGender = new System.Windows.Forms.ComboBox();
            this.dTPStudentDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtBxStudentLastName = new System.Windows.Forms.TextBox();
            this.txtBxStudentFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupWorkDetails.SuspendLayout();
            this.groupSchoolDetails.SuspendLayout();
            this.groupStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupWorkDetails
            // 
            this.groupWorkDetails.Controls.Add(this.dTPStudentWorkEndDate);
            this.groupWorkDetails.Controls.Add(this.dTPStudentWorkStartDate);
            this.groupWorkDetails.Controls.Add(this.txtBxStudentWorkName);
            this.groupWorkDetails.Controls.Add(this.label10);
            this.groupWorkDetails.Controls.Add(this.label11);
            this.groupWorkDetails.Controls.Add(this.label12);
            this.groupWorkDetails.Location = new System.Drawing.Point(19, 299);
            this.groupWorkDetails.Name = "groupWorkDetails";
            this.groupWorkDetails.Size = new System.Drawing.Size(331, 274);
            this.groupWorkDetails.TabIndex = 6;
            this.groupWorkDetails.TabStop = false;
            this.groupWorkDetails.Text = "Öğrenci Şirket Bilgileri";
            // 
            // dTPStudentWorkEndDate
            // 
            this.dTPStudentWorkEndDate.Location = new System.Drawing.Point(100, 94);
            this.dTPStudentWorkEndDate.Name = "dTPStudentWorkEndDate";
            this.dTPStudentWorkEndDate.Size = new System.Drawing.Size(172, 20);
            this.dTPStudentWorkEndDate.TabIndex = 11;
            // 
            // dTPStudentWorkStartDate
            // 
            this.dTPStudentWorkStartDate.Location = new System.Drawing.Point(100, 58);
            this.dTPStudentWorkStartDate.Name = "dTPStudentWorkStartDate";
            this.dTPStudentWorkStartDate.Size = new System.Drawing.Size(172, 20);
            this.dTPStudentWorkStartDate.TabIndex = 10;
            // 
            // txtBxStudentWorkName
            // 
            this.txtBxStudentWorkName.Location = new System.Drawing.Point(100, 27);
            this.txtBxStudentWorkName.Name = "txtBxStudentWorkName";
            this.txtBxStudentWorkName.Size = new System.Drawing.Size(172, 20);
            this.txtBxStudentWorkName.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Çıkış Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Başlama Tarihi :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Şirket Adı :";
            // 
            // groupSchoolDetails
            // 
            this.groupSchoolDetails.Controls.Add(this.lblStudentSchoolBranch);
            this.groupSchoolDetails.Controls.Add(this.cBxStudentSchoolBranch);
            this.groupSchoolDetails.Controls.Add(this.dTPStudentSchoolEndDate);
            this.groupSchoolDetails.Controls.Add(this.dTPStudentSchoolStartDate);
            this.groupSchoolDetails.Controls.Add(this.txtBxStudentSchoolName);
            this.groupSchoolDetails.Controls.Add(this.label9);
            this.groupSchoolDetails.Controls.Add(this.label8);
            this.groupSchoolDetails.Controls.Add(this.label7);
            this.groupSchoolDetails.Location = new System.Drawing.Point(19, 12);
            this.groupSchoolDetails.Name = "groupSchoolDetails";
            this.groupSchoolDetails.Size = new System.Drawing.Size(331, 267);
            this.groupSchoolDetails.TabIndex = 5;
            this.groupSchoolDetails.TabStop = false;
            this.groupSchoolDetails.Text = "Öğrenci Okul Bilgileri";
            // 
            // lblStudentSchoolBranch
            // 
            this.lblStudentSchoolBranch.AutoSize = true;
            this.lblStudentSchoolBranch.Location = new System.Drawing.Point(8, 143);
            this.lblStudentSchoolBranch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentSchoolBranch.Name = "lblStudentSchoolBranch";
            this.lblStudentSchoolBranch.Size = new System.Drawing.Size(73, 13);
            this.lblStudentSchoolBranch.TabIndex = 9;
            this.lblStudentSchoolBranch.Text = "Okul Bölümü :";
            // 
            // cBxStudentSchoolBranch
            // 
            this.cBxStudentSchoolBranch.FormattingEnabled = true;
            this.cBxStudentSchoolBranch.Location = new System.Drawing.Point(100, 136);
            this.cBxStudentSchoolBranch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBxStudentSchoolBranch.Name = "cBxStudentSchoolBranch";
            this.cBxStudentSchoolBranch.Size = new System.Drawing.Size(158, 21);
            this.cBxStudentSchoolBranch.TabIndex = 8;
            // 
            // dTPStudentSchoolEndDate
            // 
            this.dTPStudentSchoolEndDate.Location = new System.Drawing.Point(100, 99);
            this.dTPStudentSchoolEndDate.Name = "dTPStudentSchoolEndDate";
            this.dTPStudentSchoolEndDate.Size = new System.Drawing.Size(158, 20);
            this.dTPStudentSchoolEndDate.TabIndex = 5;
            // 
            // dTPStudentSchoolStartDate
            // 
            this.dTPStudentSchoolStartDate.Location = new System.Drawing.Point(100, 69);
            this.dTPStudentSchoolStartDate.Name = "dTPStudentSchoolStartDate";
            this.dTPStudentSchoolStartDate.Size = new System.Drawing.Size(158, 20);
            this.dTPStudentSchoolStartDate.TabIndex = 4;
            // 
            // txtBxStudentSchoolName
            // 
            this.txtBxStudentSchoolName.Location = new System.Drawing.Point(100, 32);
            this.txtBxStudentSchoolName.Name = "txtBxStudentSchoolName";
            this.txtBxStudentSchoolName.Size = new System.Drawing.Size(158, 20);
            this.txtBxStudentSchoolName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Bitiş Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Başlama Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Okul Adı :";
            // 
            // groupStudents
            // 
            this.groupStudents.Controls.Add(this.btnStudensSave);
            this.groupStudents.Controls.Add(this.cBxStudentGender);
            this.groupStudents.Controls.Add(this.dTPStudentDateOfBirth);
            this.groupStudents.Controls.Add(this.txtBxStudentLastName);
            this.groupStudents.Controls.Add(this.txtBxStudentFirstName);
            this.groupStudents.Controls.Add(this.label4);
            this.groupStudents.Controls.Add(this.label3);
            this.groupStudents.Controls.Add(this.label2);
            this.groupStudents.Controls.Add(this.label1);
            this.groupStudents.Location = new System.Drawing.Point(356, 12);
            this.groupStudents.Name = "groupStudents";
            this.groupStudents.Size = new System.Drawing.Size(440, 573);
            this.groupStudents.TabIndex = 4;
            this.groupStudents.TabStop = false;
            this.groupStudents.Text = "Öğrenciler";
            // 
            // btnStudensSave
            // 
            this.btnStudensSave.Location = new System.Drawing.Point(243, 176);
            this.btnStudensSave.Name = "btnStudensSave";
            this.btnStudensSave.Size = new System.Drawing.Size(103, 34);
            this.btnStudensSave.TabIndex = 15;
            this.btnStudensSave.Text = "Ekle";
            this.btnStudensSave.UseVisualStyleBackColor = true;
            this.btnStudensSave.Click += new System.EventHandler(this.btnStudensSave_Click);
            // 
            // cBxStudentGender
            // 
            this.cBxStudentGender.FormattingEnabled = true;
            this.cBxStudentGender.Location = new System.Drawing.Point(93, 97);
            this.cBxStudentGender.Name = "cBxStudentGender";
            this.cBxStudentGender.Size = new System.Drawing.Size(121, 21);
            this.cBxStudentGender.TabIndex = 12;
            // 
            // dTPStudentDateOfBirth
            // 
            this.dTPStudentDateOfBirth.Location = new System.Drawing.Point(93, 140);
            this.dTPStudentDateOfBirth.Name = "dTPStudentDateOfBirth";
            this.dTPStudentDateOfBirth.Size = new System.Drawing.Size(121, 20);
            this.dTPStudentDateOfBirth.TabIndex = 11;
            // 
            // txtBxStudentLastName
            // 
            this.txtBxStudentLastName.Location = new System.Drawing.Point(93, 63);
            this.txtBxStudentLastName.Name = "txtBxStudentLastName";
            this.txtBxStudentLastName.Size = new System.Drawing.Size(121, 20);
            this.txtBxStudentLastName.TabIndex = 8;
            // 
            // txtBxStudentFirstName
            // 
            this.txtBxStudentFirstName.Location = new System.Drawing.Point(93, 28);
            this.txtBxStudentFirstName.Name = "txtBxStudentFirstName";
            this.txtBxStudentFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtBxStudentFirstName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyeti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 597);
            this.Controls.Add(this.groupWorkDetails);
            this.Controls.Add(this.groupSchoolDetails);
            this.Controls.Add(this.groupStudents);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.groupWorkDetails.ResumeLayout(false);
            this.groupWorkDetails.PerformLayout();
            this.groupSchoolDetails.ResumeLayout(false);
            this.groupSchoolDetails.PerformLayout();
            this.groupStudents.ResumeLayout(false);
            this.groupStudents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupWorkDetails;
        private System.Windows.Forms.DateTimePicker dTPStudentWorkEndDate;
        private System.Windows.Forms.DateTimePicker dTPStudentWorkStartDate;
        private System.Windows.Forms.TextBox txtBxStudentWorkName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupSchoolDetails;
        private System.Windows.Forms.DateTimePicker dTPStudentSchoolEndDate;
        private System.Windows.Forms.DateTimePicker dTPStudentSchoolStartDate;
        private System.Windows.Forms.TextBox txtBxStudentSchoolName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupStudents;
        private System.Windows.Forms.Button btnStudensSave;
        private System.Windows.Forms.ComboBox cBxStudentGender;
        private System.Windows.Forms.DateTimePicker dTPStudentDateOfBirth;
        private System.Windows.Forms.TextBox txtBxStudentLastName;
        private System.Windows.Forms.TextBox txtBxStudentFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentSchoolBranch;
        private System.Windows.Forms.ComboBox cBxStudentSchoolBranch;
    }
}