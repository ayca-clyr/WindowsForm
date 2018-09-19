namespace Part1
{
    partial class CategoryListForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstCategoryList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(67, 207);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lstCategoryList
            // 
            this.lstCategoryList.FormattingEnabled = true;
            this.lstCategoryList.Location = new System.Drawing.Point(13, 13);
            this.lstCategoryList.Name = "lstCategoryList";
            this.lstCategoryList.Size = new System.Drawing.Size(212, 173);
            this.lstCategoryList.TabIndex = 2;
            this.lstCategoryList.SelectedIndexChanged += new System.EventHandler(this.lstCategoryList_SelectedIndexChanged);
            // 
            // CategoryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 308);
            this.Controls.Add(this.lstCategoryList);
            this.Controls.Add(this.btnUpdate);
            this.Name = "CategoryListForm";
            this.Text = "CategoryListForm";
            this.Load += new System.EventHandler(this.CategoryListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.ListBox lstCategoryList;
    }
}