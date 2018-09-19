namespace _10_Uygulama_Disconnected_Baglanti_ListView
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
            this.lstCategori = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGetCategory = new System.Windows.Forms.Button();
            this.cmbEmploye = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCategori
            // 
            this.lstCategori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstCategori.Location = new System.Drawing.Point(27, 33);
            this.lstCategori.Name = "lstCategori";
            this.lstCategori.Size = new System.Drawing.Size(417, 257);
            this.lstCategori.TabIndex = 0;
            this.lstCategori.UseCompatibleStateImageBehavior = false;
            this.lstCategori.View = System.Windows.Forms.View.Details;
            this.lstCategori.SelectedIndexChanged += new System.EventHandler(this.lstCategori_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Category ID";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Category Name";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 129;
            // 
            // btnGetCategory
            // 
            this.btnGetCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetCategory.Location = new System.Drawing.Point(126, 309);
            this.btnGetCategory.Name = "btnGetCategory";
            this.btnGetCategory.Size = new System.Drawing.Size(200, 50);
            this.btnGetCategory.TabIndex = 1;
            this.btnGetCategory.Text = "Kategorileri Getir";
            this.btnGetCategory.UseVisualStyleBackColor = true;
            this.btnGetCategory.Click += new System.EventHandler(this.btnGetCategory_Click);
            // 
            // cmbEmploye
            // 
            this.cmbEmploye.FormattingEnabled = true;
            this.cmbEmploye.Location = new System.Drawing.Point(519, 49);
            this.cmbEmploye.Name = "cmbEmploye";
            this.cmbEmploye.Size = new System.Drawing.Size(121, 21);
            this.cmbEmploye.TabIndex = 2;
            this.cmbEmploye.SelectedIndexChanged += new System.EventHandler(this.cmbEmploye_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Çalışanlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmploye);
            this.Controls.Add(this.btnGetCategory);
            this.Controls.Add(this.lstCategori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstCategori;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnGetCategory;
        private System.Windows.Forms.ComboBox cmbEmploye;
        private System.Windows.Forms.Label label1;
    }
}

