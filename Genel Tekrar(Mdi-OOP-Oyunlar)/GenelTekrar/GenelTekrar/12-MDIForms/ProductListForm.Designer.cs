namespace _12_MDIForms
{
    partial class ProductListForm
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
            this.lstProductListForm = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstProductListForm
            // 
            this.lstProductListForm.FormattingEnabled = true;
            this.lstProductListForm.Location = new System.Drawing.Point(0, 0);
            this.lstProductListForm.Name = "lstProductListForm";
            this.lstProductListForm.Size = new System.Drawing.Size(363, 381);
            this.lstProductListForm.TabIndex = 0;
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 376);
            this.Controls.Add(this.lstProductListForm);
            this.Name = "ProductListForm";
            this.Text = "ProductListForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lstProductListForm;


    }
}