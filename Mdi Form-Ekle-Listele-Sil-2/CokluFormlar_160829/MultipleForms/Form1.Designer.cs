namespace MultipleForms
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
            this.lstBxStudent = new System.Windows.Forms.ListBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnDeteleteDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBxStudent
            // 
            this.lstBxStudent.FormattingEnabled = true;
            this.lstBxStudent.Location = new System.Drawing.Point(22, 86);
            this.lstBxStudent.Name = "lstBxStudent";
            this.lstBxStudent.Size = new System.Drawing.Size(398, 290);
            this.lstBxStudent.TabIndex = 0;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(22, 37);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Yeni Ekle";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(144, 36);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(80, 24);
            this.btnDeleteStudent.TabIndex = 2;
            this.btnDeleteStudent.Text = "Sil";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnDeteleteDialog
            // 
            this.btnDeteleteDialog.Location = new System.Drawing.Point(324, 36);
            this.btnDeteleteDialog.Name = "btnDeteleteDialog";
            this.btnDeteleteDialog.Size = new System.Drawing.Size(96, 23);
            this.btnDeteleteDialog.TabIndex = 3;
            this.btnDeteleteDialog.Text = "Sil (Dialog)";
            this.btnDeteleteDialog.UseVisualStyleBackColor = true;
            this.btnDeteleteDialog.Click += new System.EventHandler(this.btnDeteleteDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 409);
            this.Controls.Add(this.btnDeteleteDialog);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lstBxStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnDeteleteDialog;
    }
}

