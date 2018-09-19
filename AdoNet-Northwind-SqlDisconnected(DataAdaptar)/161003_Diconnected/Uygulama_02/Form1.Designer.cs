namespace Uygulama_02
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
            this.lVCategories = new System.Windows.Forms.ListView();
            this.btnGetCategories = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cBxCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lVCategories
            // 
            this.lVCategories.BackColor = System.Drawing.Color.White;
            this.lVCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lVCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lVCategories.ForeColor = System.Drawing.Color.Fuchsia;
            this.lVCategories.FullRowSelect = true;
            this.lVCategories.Location = new System.Drawing.Point(13, 13);
            this.lVCategories.Name = "lVCategories";
            this.lVCategories.Size = new System.Drawing.Size(482, 305);
            this.lVCategories.TabIndex = 0;
            this.lVCategories.UseCompatibleStateImageBehavior = false;
            this.lVCategories.View = System.Windows.Forms.View.Details;
            // 
            // btnGetCategories
            // 
            this.btnGetCategories.Location = new System.Drawing.Point(70, 363);
            this.btnGetCategories.Name = "btnGetCategories";
            this.btnGetCategories.Size = new System.Drawing.Size(142, 37);
            this.btnGetCategories.TabIndex = 1;
            this.btnGetCategories.Text = "Kategorileri Getir";
            this.btnGetCategories.UseVisualStyleBackColor = true;
            this.btnGetCategories.Click += new System.EventHandler(this.btnGetCategories_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CategoryID";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CategoryName";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 76;
            // 
            // cBxCategories
            // 
            this.cBxCategories.FormattingEnabled = true;
            this.cBxCategories.Location = new System.Drawing.Point(570, 44);
            this.cBxCategories.Name = "cBxCategories";
            this.cBxCategories.Size = new System.Drawing.Size(121, 21);
            this.cBxCategories.TabIndex = 2;
            this.cBxCategories.SelectedIndexChanged += new System.EventHandler(this.cBxCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategoriler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(728, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBxCategories);
            this.Controls.Add(this.btnGetCategories);
            this.Controls.Add(this.lVCategories);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lVCategories;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnGetCategories;
        private System.Windows.Forms.ComboBox cBxCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

