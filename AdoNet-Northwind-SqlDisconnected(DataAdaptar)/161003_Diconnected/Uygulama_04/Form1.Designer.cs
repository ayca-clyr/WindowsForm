namespace Uygulama_04
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
            this.dGVProductsList = new System.Windows.Forms.DataGridView();
            this.btnGetCategoriesID = new System.Windows.Forms.Button();
            this.txtBxCategoryID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxCategoryName = new System.Windows.Forms.TextBox();
            this.btnGetCategoriesName = new System.Windows.Forms.Button();
            this.lVCategoryName = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dGVProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVProductsList
            // 
            this.dGVProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProductsList.Location = new System.Drawing.Point(38, 146);
            this.dGVProductsList.Name = "dGVProductsList";
            this.dGVProductsList.Size = new System.Drawing.Size(240, 210);
            this.dGVProductsList.TabIndex = 0;
            // 
            // btnGetCategoriesID
            // 
            this.btnGetCategoriesID.Location = new System.Drawing.Point(38, 83);
            this.btnGetCategoriesID.Name = "btnGetCategoriesID";
            this.btnGetCategoriesID.Size = new System.Drawing.Size(100, 37);
            this.btnGetCategoriesID.TabIndex = 1;
            this.btnGetCategoriesID.Text = "Ürünü Getir ID";
            this.btnGetCategoriesID.UseVisualStyleBackColor = true;
            this.btnGetCategoriesID.Click += new System.EventHandler(this.btnGetCategories_Click);
            // 
            // txtBxCategoryID
            // 
            this.txtBxCategoryID.Location = new System.Drawing.Point(38, 45);
            this.txtBxCategoryID.Name = "txtBxCategoryID";
            this.txtBxCategoryID.Size = new System.Drawing.Size(100, 20);
            this.txtBxCategoryID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori Adı";
            // 
            // txtBxCategoryName
            // 
            this.txtBxCategoryName.Location = new System.Drawing.Point(357, 45);
            this.txtBxCategoryName.Name = "txtBxCategoryName";
            this.txtBxCategoryName.Size = new System.Drawing.Size(158, 20);
            this.txtBxCategoryName.TabIndex = 2;
            // 
            // btnGetCategoriesName
            // 
            this.btnGetCategoriesName.Location = new System.Drawing.Point(383, 83);
            this.btnGetCategoriesName.Name = "btnGetCategoriesName";
            this.btnGetCategoriesName.Size = new System.Drawing.Size(100, 37);
            this.btnGetCategoriesName.TabIndex = 1;
            this.btnGetCategoriesName.Text = "Ürünü Getir Name";
            this.btnGetCategoriesName.UseVisualStyleBackColor = true;
            this.btnGetCategoriesName.Click += new System.EventHandler(this.btnGetCategoriesName_Click);
            // 
            // lVCategoryName
            // 
            this.lVCategoryName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lVCategoryName.Location = new System.Drawing.Point(319, 146);
            this.lVCategoryName.Name = "lVCategoryName";
            this.lVCategoryName.Size = new System.Drawing.Size(236, 184);
            this.lVCategoryName.TabIndex = 4;
            this.lVCategoryName.UseCompatibleStateImageBehavior = false;
            this.lVCategoryName.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stock";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 384);
            this.Controls.Add(this.lVCategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxCategoryName);
            this.Controls.Add(this.txtBxCategoryID);
            this.Controls.Add(this.btnGetCategoriesName);
            this.Controls.Add(this.btnGetCategoriesID);
            this.Controls.Add(this.dGVProductsList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGVProductsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVProductsList;
        private System.Windows.Forms.Button btnGetCategoriesID;
        private System.Windows.Forms.TextBox txtBxCategoryID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxCategoryName;
        private System.Windows.Forms.Button btnGetCategoriesName;
        private System.Windows.Forms.ListView lVCategoryName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

