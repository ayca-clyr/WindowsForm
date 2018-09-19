namespace MDI_Forms
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
            this.lstBxEmployees = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBxEmployees
            // 
            this.lstBxEmployees.ForeColor = System.Drawing.Color.Black;
            this.lstBxEmployees.FormattingEnabled = true;
            this.lstBxEmployees.Location = new System.Drawing.Point(41, 44);
            this.lstBxEmployees.Name = "lstBxEmployees";
            this.lstBxEmployees.Size = new System.Drawing.Size(143, 173);
            this.lstBxEmployees.TabIndex = 0;
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 279);
            this.Controls.Add(this.lstBxEmployees);
            this.Name = "EmployeeListForm";
            this.Text = "EmployeeListForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lstBxEmployees;


    }
}