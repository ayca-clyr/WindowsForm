namespace _12_MDIForms
{
    partial class EmployeeForm
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
            this.lblEmployeeAdı = new System.Windows.Forms.Label();
            this.lblEmployeeSoyadı = new System.Windows.Forms.Label();
            this.txtBxEmployeeAdı = new System.Windows.Forms.TextBox();
            this.txtBxEmployeeSoyadı = new System.Windows.Forms.TextBox();
            this.btnEmployeeKaydet = new System.Windows.Forms.Button();
            this.lblEmployeeDogumTarihi = new System.Windows.Forms.Label();
            this.dtmEmployeeDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblEmployeeAdı
            // 
            this.lblEmployeeAdı.AutoSize = true;
            this.lblEmployeeAdı.Location = new System.Drawing.Point(34, 34);
            this.lblEmployeeAdı.Name = "lblEmployeeAdı";
            this.lblEmployeeAdı.Size = new System.Drawing.Size(22, 13);
            this.lblEmployeeAdı.TabIndex = 0;
            this.lblEmployeeAdı.Text = "Adı";
            // 
            // lblEmployeeSoyadı
            // 
            this.lblEmployeeSoyadı.AutoSize = true;
            this.lblEmployeeSoyadı.Location = new System.Drawing.Point(34, 92);
            this.lblEmployeeSoyadı.Name = "lblEmployeeSoyadı";
            this.lblEmployeeSoyadı.Size = new System.Drawing.Size(39, 13);
            this.lblEmployeeSoyadı.TabIndex = 1;
            this.lblEmployeeSoyadı.Text = "Soyadı";
            // 
            // txtBxEmployeeAdı
            // 
            this.txtBxEmployeeAdı.Location = new System.Drawing.Point(37, 61);
            this.txtBxEmployeeAdı.Name = "txtBxEmployeeAdı";
            this.txtBxEmployeeAdı.Size = new System.Drawing.Size(166, 20);
            this.txtBxEmployeeAdı.TabIndex = 2;
            // 
            // txtBxEmployeeSoyadı
            // 
            this.txtBxEmployeeSoyadı.Location = new System.Drawing.Point(37, 133);
            this.txtBxEmployeeSoyadı.Name = "txtBxEmployeeSoyadı";
            this.txtBxEmployeeSoyadı.Size = new System.Drawing.Size(166, 20);
            this.txtBxEmployeeSoyadı.TabIndex = 3;
            // 
            // btnEmployeeKaydet
            // 
            this.btnEmployeeKaydet.Location = new System.Drawing.Point(128, 247);
            this.btnEmployeeKaydet.Name = "btnEmployeeKaydet";
            this.btnEmployeeKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeKaydet.TabIndex = 4;
            this.btnEmployeeKaydet.Text = "Kaydet";
            this.btnEmployeeKaydet.UseVisualStyleBackColor = true;
            this.btnEmployeeKaydet.Click += new System.EventHandler(this.btnEmployeeKaydet_Click);
            // 
            // lblEmployeeDogumTarihi
            // 
            this.lblEmployeeDogumTarihi.AutoSize = true;
            this.lblEmployeeDogumTarihi.Location = new System.Drawing.Point(34, 170);
            this.lblEmployeeDogumTarihi.Name = "lblEmployeeDogumTarihi";
            this.lblEmployeeDogumTarihi.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeDogumTarihi.TabIndex = 5;
            this.lblEmployeeDogumTarihi.Text = "Doğum Tarihi";
            // 
            // dtmEmployeeDogumTarihi
            // 
            this.dtmEmployeeDogumTarihi.Location = new System.Drawing.Point(37, 200);
            this.dtmEmployeeDogumTarihi.Name = "dtmEmployeeDogumTarihi";
            this.dtmEmployeeDogumTarihi.Size = new System.Drawing.Size(162, 20);
            this.dtmEmployeeDogumTarihi.TabIndex = 6;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 331);
            this.Controls.Add(this.dtmEmployeeDogumTarihi);
            this.Controls.Add(this.lblEmployeeDogumTarihi);
            this.Controls.Add(this.btnEmployeeKaydet);
            this.Controls.Add(this.txtBxEmployeeSoyadı);
            this.Controls.Add(this.txtBxEmployeeAdı);
            this.Controls.Add(this.lblEmployeeSoyadı);
            this.Controls.Add(this.lblEmployeeAdı);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeAdı;
        private System.Windows.Forms.Label lblEmployeeSoyadı;
        private System.Windows.Forms.TextBox txtBxEmployeeAdı;
        private System.Windows.Forms.TextBox txtBxEmployeeSoyadı;
        private System.Windows.Forms.Label lblEmployeeDogumTarihi;
        private System.Windows.Forms.DateTimePicker dtmEmployeeDogumTarihi;
        public System.Windows.Forms.Button btnEmployeeKaydet;
    }
}