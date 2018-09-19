namespace _15_XML_Serialization
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
            this.txtBxAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxSoyadı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numOkulNo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSingleSerialization = new System.Windows.Forms.Button();
            this.btnAllSerialization = new System.Windows.Forms.Button();
            this.lwOgrenciler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numOkulNo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı:";
            // 
            // txtBxAdı
            // 
            this.txtBxAdı.Location = new System.Drawing.Point(38, 42);
            this.txtBxAdı.Name = "txtBxAdı";
            this.txtBxAdı.Size = new System.Drawing.Size(200, 20);
            this.txtBxAdı.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyadı:";
            // 
            // txtBxSoyadı
            // 
            this.txtBxSoyadı.Location = new System.Drawing.Point(38, 94);
            this.txtBxSoyadı.Name = "txtBxSoyadı";
            this.txtBxSoyadı.Size = new System.Drawing.Size(200, 20);
            this.txtBxSoyadı.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Okul No:";
            // 
            // numOkulNo
            // 
            this.numOkulNo.Location = new System.Drawing.Point(38, 149);
            this.numOkulNo.Name = "numOkulNo";
            this.numOkulNo.Size = new System.Drawing.Size(200, 20);
            this.numOkulNo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(38, 206);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpDogumTarihi.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(284, 36);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(288, 78);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSingleSerialization
            // 
            this.btnSingleSerialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSingleSerialization.Location = new System.Drawing.Point(284, 133);
            this.btnSingleSerialization.Name = "btnSingleSerialization";
            this.btnSingleSerialization.Size = new System.Drawing.Size(288, 78);
            this.btnSingleSerialization.TabIndex = 15;
            this.btnSingleSerialization.Text = "Tek Öğrenci Serilize Et";
            this.btnSingleSerialization.UseVisualStyleBackColor = true;
            this.btnSingleSerialization.Click += new System.EventHandler(this.btnSingleSerialization_Click);
            // 
            // btnAllSerialization
            // 
            this.btnAllSerialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAllSerialization.Location = new System.Drawing.Point(284, 217);
            this.btnAllSerialization.Name = "btnAllSerialization";
            this.btnAllSerialization.Size = new System.Drawing.Size(288, 77);
            this.btnAllSerialization.TabIndex = 16;
            this.btnAllSerialization.Text = "Hepsini Serilize Et";
            this.btnAllSerialization.UseVisualStyleBackColor = true;
            this.btnAllSerialization.Click += new System.EventHandler(this.btnAllSerialization_Click);
            // 
            // lwOgrenciler
            // 
            this.lwOgrenciler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lwOgrenciler.Location = new System.Drawing.Point(38, 322);
            this.lwOgrenciler.Name = "lwOgrenciler";
            this.lwOgrenciler.Size = new System.Drawing.Size(534, 257);
            this.lwOgrenciler.TabIndex = 17;
            this.lwOgrenciler.UseCompatibleStateImageBehavior = false;
            this.lwOgrenciler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Okul No";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Doğum Tarihi";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yaş";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 572);
            this.Controls.Add(this.lwOgrenciler);
            this.Controls.Add(this.btnAllSerialization);
            this.Controls.Add(this.btnSingleSerialization);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numOkulNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxSoyadı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxAdı);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOkulNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxSoyadı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numOkulNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSingleSerialization;
        private System.Windows.Forms.Button btnAllSerialization;
        private System.Windows.Forms.ListView lwOgrenciler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

