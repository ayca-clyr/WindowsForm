namespace Login
{
    partial class UpdateProjectError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProjectError));
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRequestDesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rBtnNothing = new System.Windows.Forms.RadioButton();
            this.rBtnImproved = new System.Windows.Forms.RadioButton();
            this.rBtnError = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBxProjectName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProjectDesc = new System.Windows.Forms.TextBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbEmploye = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpProjectGeneration = new System.Windows.Forms.DateTimePicker();
            this.dtpProjectDeadLine = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpCustomer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomer.Controls.Add(this.label7);
            this.grpCustomer.Controls.Add(this.txtRequestDesc);
            this.grpCustomer.Controls.Add(this.label10);
            this.grpCustomer.Controls.Add(this.rBtnNothing);
            this.grpCustomer.Controls.Add(this.rBtnImproved);
            this.grpCustomer.Controls.Add(this.rBtnError);
            this.grpCustomer.Location = new System.Drawing.Point(464, 181);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCustomer.Size = new System.Drawing.Size(503, 289);
            this.grpCustomer.TabIndex = 54;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Müşteri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Açıklama";
            // 
            // txtRequestDesc
            // 
            this.txtRequestDesc.Location = new System.Drawing.Point(165, 119);
            this.txtRequestDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRequestDesc.Multiline = true;
            this.txtRequestDesc.Name = "txtRequestDesc";
            this.txtRequestDesc.Size = new System.Drawing.Size(224, 144);
            this.txtRequestDesc.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Müşteri Hata/İstek";
            // 
            // rBtnNothing
            // 
            this.rBtnNothing.AutoSize = true;
            this.rBtnNothing.Location = new System.Drawing.Point(319, 57);
            this.rBtnNothing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnNothing.Name = "rBtnNothing";
            this.rBtnNothing.Size = new System.Drawing.Size(68, 21);
            this.rBtnNothing.TabIndex = 49;
            this.rBtnNothing.TabStop = true;
            this.rBtnNothing.Text = "Hiçbiri";
            this.rBtnNothing.UseVisualStyleBackColor = true;
            // 
            // rBtnImproved
            // 
            this.rBtnImproved.AutoSize = true;
            this.rBtnImproved.Checked = true;
            this.rBtnImproved.Location = new System.Drawing.Point(165, 57);
            this.rBtnImproved.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnImproved.Name = "rBtnImproved";
            this.rBtnImproved.Size = new System.Drawing.Size(58, 21);
            this.rBtnImproved.TabIndex = 47;
            this.rBtnImproved.TabStop = true;
            this.rBtnImproved.Text = "İstek";
            this.rBtnImproved.UseVisualStyleBackColor = true;
            // 
            // rBtnError
            // 
            this.rBtnError.AutoSize = true;
            this.rBtnError.Location = new System.Drawing.Point(244, 57);
            this.rBtnError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnError.Name = "rBtnError";
            this.rBtnError.Size = new System.Drawing.Size(59, 21);
            this.rBtnError.TabIndex = 48;
            this.rBtnError.Text = "Hata";
            this.rBtnError.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Red;
            this.btnUpdate.Location = new System.Drawing.Point(867, 491);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cBxProjectName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtProjectDesc);
            this.groupBox2.Controls.Add(this.cmbCustomer);
            this.groupBox2.Controls.Add(this.cmbEmploye);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(411, 441);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proje";
            // 
            // cBxProjectName
            // 
            this.cBxProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxProjectName.FormattingEnabled = true;
            this.cBxProjectName.Location = new System.Drawing.Point(153, 31);
            this.cBxProjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBxProjectName.Name = "cBxProjectName";
            this.cBxProjectName.Size = new System.Drawing.Size(224, 24);
            this.cBxProjectName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proje Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Müşteriler";
            // 
            // txtProjectDesc
            // 
            this.txtProjectDesc.Location = new System.Drawing.Point(153, 70);
            this.txtProjectDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProjectDesc.Multiline = true;
            this.txtProjectDesc.Name = "txtProjectDesc";
            this.txtProjectDesc.Size = new System.Drawing.Size(224, 144);
            this.txtProjectDesc.TabIndex = 4;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(153, 282);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(224, 24);
            this.cmbCustomer.TabIndex = 6;
            // 
            // cmbEmploye
            // 
            this.cmbEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmploye.FormattingEnabled = true;
            this.cmbEmploye.Location = new System.Drawing.Point(153, 230);
            this.cmbEmploye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEmploye.Name = "cmbEmploye";
            this.cmbEmploye.Size = new System.Drawing.Size(224, 24);
            this.cmbEmploye.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "İş Atanacak Kişi";
            // 
            // dtpProjectGeneration
            // 
            this.dtpProjectGeneration.Location = new System.Drawing.Point(213, 33);
            this.dtpProjectGeneration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpProjectGeneration.Name = "dtpProjectGeneration";
            this.dtpProjectGeneration.Size = new System.Drawing.Size(265, 22);
            this.dtpProjectGeneration.TabIndex = 16;
            // 
            // dtpProjectDeadLine
            // 
            this.dtpProjectDeadLine.Location = new System.Drawing.Point(213, 80);
            this.dtpProjectDeadLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpProjectDeadLine.Name = "dtpProjectDeadLine";
            this.dtpProjectDeadLine.Size = new System.Drawing.Size(265, 22);
            this.dtpProjectDeadLine.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proje Oluşturma Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Proje Teslim Tarihi";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtpProjectGeneration);
            this.groupBox1.Controls.Add(this.dtpProjectDeadLine);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(464, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(503, 128);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proje Detayları";
            // 
            // UpdateProjectError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1007, 535);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateProjectError";
            this.Text = "Müşteri Talep Ekle";
            this.Load += new System.EventHandler(this.UpdateProjectTeam_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtProjectDesc;
        public System.Windows.Forms.ComboBox cmbCustomer;
        public System.Windows.Forms.ComboBox cmbEmploye;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpProjectGeneration;
        public System.Windows.Forms.DateTimePicker dtpProjectDeadLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cBxProjectName;
        public System.Windows.Forms.RadioButton rBtnNothing;
        public System.Windows.Forms.RadioButton rBtnImproved;
        public System.Windows.Forms.RadioButton rBtnError;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtRequestDesc;
    }
}