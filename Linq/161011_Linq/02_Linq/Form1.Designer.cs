namespace _02_Linq
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
            this.lstQuery = new System.Windows.Forms.ListBox();
            this.btnQuery1 = new System.Windows.Forms.Button();
            this.dGVQuery = new System.Windows.Forms.DataGridView();
            this.btnQuery2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBxCategory = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstQuery
            // 
            this.lstQuery.FormattingEnabled = true;
            this.lstQuery.Location = new System.Drawing.Point(12, 53);
            this.lstQuery.Name = "lstQuery";
            this.lstQuery.Size = new System.Drawing.Size(200, 394);
            this.lstQuery.TabIndex = 0;
            // 
            // btnQuery1
            // 
            this.btnQuery1.Location = new System.Drawing.Point(12, 12);
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(75, 23);
            this.btnQuery1.TabIndex = 1;
            this.btnQuery1.Text = "Query1";
            this.btnQuery1.UseVisualStyleBackColor = true;
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // dGVQuery
            // 
            this.dGVQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVQuery.Location = new System.Drawing.Point(218, 53);
            this.dGVQuery.Name = "dGVQuery";
            this.dGVQuery.Size = new System.Drawing.Size(200, 394);
            this.dGVQuery.TabIndex = 2;
            // 
            // btnQuery2
            // 
            this.btnQuery2.Location = new System.Drawing.Point(112, 11);
            this.btnQuery2.Name = "btnQuery2";
            this.btnQuery2.Size = new System.Drawing.Size(75, 23);
            this.btnQuery2.TabIndex = 4;
            this.btnQuery2.Text = "Query2";
            this.btnQuery2.UseVisualStyleBackColor = true;
            this.btnQuery2.Click += new System.EventHandler(this.btnQuery2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kategori Seçiniz :";
            // 
            // cmbBxCategory
            // 
            this.cmbBxCategory.FormattingEnabled = true;
            this.cmbBxCategory.Location = new System.Drawing.Point(337, 22);
            this.cmbBxCategory.Name = "cmbBxCategory";
            this.cmbBxCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbBxCategory.TabIndex = 7;
            this.cmbBxCategory.SelectedIndexChanged += new System.EventHandler(this.cmbBxCategory_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(424, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(222, 394);
            this.dataGridView1.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(652, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 394);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 473);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxCategory);
            this.Controls.Add(this.btnQuery2);
            this.Controls.Add(this.dGVQuery);
            this.Controls.Add(this.btnQuery1);
            this.Controls.Add(this.lstQuery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstQuery;
        private System.Windows.Forms.Button btnQuery1;
        private System.Windows.Forms.DataGridView dGVQuery;
        private System.Windows.Forms.Button btnQuery2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBxCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

