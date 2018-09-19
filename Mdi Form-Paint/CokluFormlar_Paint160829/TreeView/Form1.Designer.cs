namespace TreeView
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
            this.cBxDrivers = new System.Windows.Forms.ComboBox();
            this.lstBxRightSide = new System.Windows.Forms.ListBox();
            this.tvLeftSide = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // cBxDrivers
            // 
            this.cBxDrivers.FormattingEnabled = true;
            this.cBxDrivers.Location = new System.Drawing.Point(12, 12);
            this.cBxDrivers.Name = "cBxDrivers";
            this.cBxDrivers.Size = new System.Drawing.Size(121, 21);
            this.cBxDrivers.TabIndex = 0;
            // 
            // lstBxRightSide
            // 
            this.lstBxRightSide.FormattingEnabled = true;
            this.lstBxRightSide.Location = new System.Drawing.Point(164, 12);
            this.lstBxRightSide.Name = "lstBxRightSide";
            this.lstBxRightSide.Size = new System.Drawing.Size(553, 433);
            this.lstBxRightSide.TabIndex = 1;
            // 
            // tvLeftSide
            // 
            this.tvLeftSide.Location = new System.Drawing.Point(13, 40);
            this.tvLeftSide.Name = "tvLeftSide";
            this.tvLeftSide.Size = new System.Drawing.Size(121, 405);
            this.tvLeftSide.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 452);
            this.Controls.Add(this.tvLeftSide);
            this.Controls.Add(this.lstBxRightSide);
            this.Controls.Add(this.cBxDrivers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cBxDrivers;
        private System.Windows.Forms.ListBox lstBxRightSide;
        private System.Windows.Forms.TreeView tvLeftSide;
    }
}

