namespace ValueType_Vs_Reference
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
            this.lblStudentObjectOfClassAfterCopy = new System.Windows.Forms.Label();
            this.lblStudentObjectOfClass = new System.Windows.Forms.Label();
            this.btnCreateObjectByClass = new System.Windows.Forms.Button();
            this.btnCopyObjectOfClass = new System.Windows.Forms.Button();
            this.lblFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudentObjectOfClassAfterCopy
            // 
            this.lblStudentObjectOfClassAfterCopy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentObjectOfClassAfterCopy.Location = new System.Drawing.Point(341, 167);
            this.lblStudentObjectOfClassAfterCopy.Name = "lblStudentObjectOfClassAfterCopy";
            this.lblStudentObjectOfClassAfterCopy.Size = new System.Drawing.Size(172, 85);
            this.lblStudentObjectOfClassAfterCopy.TabIndex = 0;
            // 
            // lblStudentObjectOfClass
            // 
            this.lblStudentObjectOfClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentObjectOfClass.Location = new System.Drawing.Point(12, 167);
            this.lblStudentObjectOfClass.Name = "lblStudentObjectOfClass";
            this.lblStudentObjectOfClass.Size = new System.Drawing.Size(161, 85);
            this.lblStudentObjectOfClass.TabIndex = 1;
            // 
            // btnCreateObjectByClass
            // 
            this.btnCreateObjectByClass.Location = new System.Drawing.Point(46, 62);
            this.btnCreateObjectByClass.Name = "btnCreateObjectByClass";
            this.btnCreateObjectByClass.Size = new System.Drawing.Size(75, 66);
            this.btnCreateObjectByClass.TabIndex = 2;
            this.btnCreateObjectByClass.Text = "Create Object By Class";
            this.btnCreateObjectByClass.UseVisualStyleBackColor = true;
            this.btnCreateObjectByClass.Click += new System.EventHandler(this.btnCreateObjectByClass_Click);
            // 
            // btnCopyObjectOfClass
            // 
            this.btnCopyObjectOfClass.Location = new System.Drawing.Point(388, 51);
            this.btnCopyObjectOfClass.Name = "btnCopyObjectOfClass";
            this.btnCopyObjectOfClass.Size = new System.Drawing.Size(75, 67);
            this.btnCopyObjectOfClass.TabIndex = 3;
            this.btnCopyObjectOfClass.Text = "Copy Object Of Class";
            this.btnCopyObjectOfClass.UseVisualStyleBackColor = true;
            this.btnCopyObjectOfClass.Click += new System.EventHandler(this.btnCopyObjectOfClass_Click);
            // 
            // lblFinal
            // 
            this.lblFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinal.Location = new System.Drawing.Point(338, 272);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(175, 82);
            this.lblFinal.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 381);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.btnCopyObjectOfClass);
            this.Controls.Add(this.btnCreateObjectByClass);
            this.Controls.Add(this.lblStudentObjectOfClass);
            this.Controls.Add(this.lblStudentObjectOfClassAfterCopy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStudentObjectOfClassAfterCopy;
        private System.Windows.Forms.Label lblStudentObjectOfClass;
        private System.Windows.Forms.Button btnCreateObjectByClass;
        private System.Windows.Forms.Button btnCopyObjectOfClass;
        private System.Windows.Forms.Label lblFinal;
    }
}

