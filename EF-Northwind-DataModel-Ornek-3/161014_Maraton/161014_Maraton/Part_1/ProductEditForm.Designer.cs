namespace Part_1
{
    partial class ProductEditForm
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxProductID = new System.Windows.Forms.TextBox();
            this.txtBxProductName = new System.Windows.Forms.TextBox();
            this.txtBxStock = new System.Windows.Forms.TextBox();
            this.txtBxPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cBxCategoryID = new System.Windows.Forms.ComboBox();
            this.cBxSupplierID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductID";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(21, 86);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(94, 17);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "ProductName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // txtBxProductID
            // 
            this.txtBxProductID.Location = new System.Drawing.Point(151, 33);
            this.txtBxProductID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxProductID.Name = "txtBxProductID";
            this.txtBxProductID.Size = new System.Drawing.Size(191, 22);
            this.txtBxProductID.TabIndex = 6;
            // 
            // txtBxProductName
            // 
            this.txtBxProductName.Location = new System.Drawing.Point(151, 78);
            this.txtBxProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxProductName.Name = "txtBxProductName";
            this.txtBxProductName.Size = new System.Drawing.Size(191, 22);
            this.txtBxProductName.TabIndex = 6;
            // 
            // txtBxStock
            // 
            this.txtBxStock.Location = new System.Drawing.Point(151, 207);
            this.txtBxStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxStock.Name = "txtBxStock";
            this.txtBxStock.Size = new System.Drawing.Size(191, 22);
            this.txtBxStock.TabIndex = 6;
            // 
            // txtBxPrice
            // 
            this.txtBxPrice.Location = new System.Drawing.Point(151, 250);
            this.txtBxPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxPrice.Name = "txtBxPrice";
            this.txtBxPrice.Size = new System.Drawing.Size(191, 22);
            this.txtBxPrice.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(107, 340);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(257, 340);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cBxCategoryID
            // 
            this.cBxCategoryID.FormattingEnabled = true;
            this.cBxCategoryID.Location = new System.Drawing.Point(151, 126);
            this.cBxCategoryID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBxCategoryID.Name = "cBxCategoryID";
            this.cBxCategoryID.Size = new System.Drawing.Size(191, 24);
            this.cBxCategoryID.TabIndex = 8;
            // 
            // cBxSupplierID
            // 
            this.cBxSupplierID.FormattingEnabled = true;
            this.cBxSupplierID.Location = new System.Drawing.Point(151, 172);
            this.cBxSupplierID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBxSupplierID.Name = "cBxSupplierID";
            this.cBxSupplierID.Size = new System.Drawing.Size(191, 24);
            this.cBxSupplierID.TabIndex = 9;
            // 
            // ProductEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 446);
            this.Controls.Add(this.cBxSupplierID);
            this.Controls.Add(this.cBxCategoryID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBxPrice);
            this.Controls.Add(this.txtBxStock);
            this.Controls.Add(this.txtBxProductName);
            this.Controls.Add(this.txtBxProductID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductEditForm";
            this.Text = "ProductEditForm";
            this.Load += new System.EventHandler(this.ProductEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtBxProductID;
        public System.Windows.Forms.TextBox txtBxProductName;
        public System.Windows.Forms.TextBox txtBxStock;
        public System.Windows.Forms.TextBox txtBxPrice;
        public System.Windows.Forms.ComboBox cBxCategoryID;
        public System.Windows.Forms.ComboBox cBxSupplierID;
    }
}