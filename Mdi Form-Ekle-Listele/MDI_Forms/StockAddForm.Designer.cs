namespace MDI_Forms
{
    partial class StockAddForm
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
            this.lblStock = new System.Windows.Forms.Label();
            this.txtBxStockAdd = new System.Windows.Forms.TextBox();
            this.btnSaveStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(45, 92);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(88, 17);
            this.lblStock.TabIndex = 0;
            this.lblStock.Text = "Stock Miktarı";
            // 
            // txtBxStockAdd
            // 
            this.txtBxStockAdd.Location = new System.Drawing.Point(194, 87);
            this.txtBxStockAdd.Name = "txtBxStockAdd";
            this.txtBxStockAdd.Size = new System.Drawing.Size(100, 22);
            this.txtBxStockAdd.TabIndex = 1;
            // 
            // btnSaveStock
            // 
            this.btnSaveStock.Location = new System.Drawing.Point(143, 191);
            this.btnSaveStock.Name = "btnSaveStock";
            this.btnSaveStock.Size = new System.Drawing.Size(75, 23);
            this.btnSaveStock.TabIndex = 2;
            this.btnSaveStock.Text = "Kaydet";
            this.btnSaveStock.UseVisualStyleBackColor = true;
            this.btnSaveStock.Click += new System.EventHandler(this.btnSaveStock_Click);
            // 
            // StockAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 358);
            this.Controls.Add(this.btnSaveStock);
            this.Controls.Add(this.txtBxStockAdd);
            this.Controls.Add(this.lblStock);
            this.Name = "StockAddForm";
            this.Text = "StockAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtBxStockAdd;
        public System.Windows.Forms.Button btnSaveStock;
    }
}