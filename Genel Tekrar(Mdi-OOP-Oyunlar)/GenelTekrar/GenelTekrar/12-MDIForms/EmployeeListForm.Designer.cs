namespace _12_MDIForms
{
    partial class EmployeeListForm
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
            this.LstEmployeeListForm = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstEmployeeListForm
            // 
            this.LstEmployeeListForm.FormattingEnabled = true;
            this.LstEmployeeListForm.Location = new System.Drawing.Point(12, 12);
            this.LstEmployeeListForm.Name = "LstEmployeeListForm";
            this.LstEmployeeListForm.Size = new System.Drawing.Size(260, 394);
            this.LstEmployeeListForm.TabIndex = 0;
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 410);
            this.Controls.Add(this.LstEmployeeListForm);
            this.Name = "EmployeeListForm";
            this.Text = "EmployeeListForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox LstEmployeeListForm;

    }
}