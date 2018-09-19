namespace Part1
{
    partial class AuthorListForm
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
            this.btnChange = new System.Windows.Forms.Button();
            this.lstBxAuthorList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(208, 267);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lstBxAuthorList
            // 
            this.lstBxAuthorList.FormattingEnabled = true;
            this.lstBxAuthorList.Location = new System.Drawing.Point(32, 25);
            this.lstBxAuthorList.Name = "lstBxAuthorList";
            this.lstBxAuthorList.Size = new System.Drawing.Size(481, 186);
            this.lstBxAuthorList.TabIndex = 12;
            // 
            // AuthorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 377);
            this.Controls.Add(this.lstBxAuthorList);
            this.Controls.Add(this.btnChange);
            this.Name = "AuthorListForm";
            this.Text = "AuthorListForm";
            this.Load += new System.EventHandler(this.AuthorListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ListBox lstBxAuthorList;
    }
}