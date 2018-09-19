namespace _4__OOP_ValueType_vs_ReferenceType
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
            this.lblStudentObjectOfClassCreate = new System.Windows.Forms.Label();
            this.lblStudentObjectOfClassAfterCopy = new System.Windows.Forms.Label();
            this.btnCreateObjectByClass = new System.Windows.Forms.Button();
            this.btnCopyObjectOfClass = new System.Windows.Forms.Button();
            this.lblFinalClass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFinalStruct = new System.Windows.Forms.Label();
            this.btnCopyObjectByStruct = new System.Windows.Forms.Button();
            this.btnCreateObjectByStruct = new System.Windows.Forms.Button();
            this.lblStudentObjectOfStructAfterCopy = new System.Windows.Forms.Label();
            this.lblStudentObjectOfStruct = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudentObjectOfClassCreate
            // 
            this.lblStudentObjectOfClassCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentObjectOfClassCreate.Location = new System.Drawing.Point(68, 176);
            this.lblStudentObjectOfClassCreate.Name = "lblStudentObjectOfClassCreate";
            this.lblStudentObjectOfClassCreate.Size = new System.Drawing.Size(221, 145);
            this.lblStudentObjectOfClassCreate.TabIndex = 0;
            // 
            // lblStudentObjectOfClassAfterCopy
            // 
            this.lblStudentObjectOfClassAfterCopy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentObjectOfClassAfterCopy.Location = new System.Drawing.Point(321, 176);
            this.lblStudentObjectOfClassAfterCopy.Name = "lblStudentObjectOfClassAfterCopy";
            this.lblStudentObjectOfClassAfterCopy.Size = new System.Drawing.Size(228, 145);
            this.lblStudentObjectOfClassAfterCopy.TabIndex = 1;
            // 
            // btnCreateObjectByClass
            // 
            this.btnCreateObjectByClass.Location = new System.Drawing.Point(112, 80);
            this.btnCreateObjectByClass.Name = "btnCreateObjectByClass";
            this.btnCreateObjectByClass.Size = new System.Drawing.Size(123, 83);
            this.btnCreateObjectByClass.TabIndex = 2;
            this.btnCreateObjectByClass.Text = "Create Object By Class";
            this.btnCreateObjectByClass.UseVisualStyleBackColor = true;
            this.btnCreateObjectByClass.Click += new System.EventHandler(this.btnCreateObjectByClass_Click);
            // 
            // btnCopyObjectOfClass
            // 
            this.btnCopyObjectOfClass.Location = new System.Drawing.Point(371, 80);
            this.btnCopyObjectOfClass.Name = "btnCopyObjectOfClass";
            this.btnCopyObjectOfClass.Size = new System.Drawing.Size(132, 83);
            this.btnCopyObjectOfClass.TabIndex = 3;
            this.btnCopyObjectOfClass.Text = "Copy Object Of Class";
            this.btnCopyObjectOfClass.UseVisualStyleBackColor = true;
            this.btnCopyObjectOfClass.Click += new System.EventHandler(this.btnCopyObjectOfClass_Click);
            // 
            // lblFinalClass
            // 
            this.lblFinalClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinalClass.Location = new System.Drawing.Point(198, 363);
            this.lblFinalClass.Name = "lblFinalClass";
            this.lblFinalClass.Size = new System.Drawing.Size(221, 145);
            this.lblFinalClass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Finally";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Class İle Yapım";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(850, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Finally";
            // 
            // lblFinalStruct
            // 
            this.lblFinalStruct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinalStruct.Location = new System.Drawing.Point(763, 352);
            this.lblFinalStruct.Name = "lblFinalStruct";
            this.lblFinalStruct.Size = new System.Drawing.Size(221, 145);
            this.lblFinalStruct.TabIndex = 11;
            // 
            // btnCopyObjectByStruct
            // 
            this.btnCopyObjectByStruct.Location = new System.Drawing.Point(936, 69);
            this.btnCopyObjectByStruct.Name = "btnCopyObjectByStruct";
            this.btnCopyObjectByStruct.Size = new System.Drawing.Size(132, 83);
            this.btnCopyObjectByStruct.TabIndex = 10;
            this.btnCopyObjectByStruct.Text = "Copy Object Of Struct";
            this.btnCopyObjectByStruct.UseVisualStyleBackColor = true;
            this.btnCopyObjectByStruct.Click += new System.EventHandler(this.btnCopyObjectByStruct_Click);
            // 
            // btnCreateObjectByStruct
            // 
            this.btnCreateObjectByStruct.Location = new System.Drawing.Point(677, 69);
            this.btnCreateObjectByStruct.Name = "btnCreateObjectByStruct";
            this.btnCreateObjectByStruct.Size = new System.Drawing.Size(123, 83);
            this.btnCreateObjectByStruct.TabIndex = 9;
            this.btnCreateObjectByStruct.Text = "Create Object By Struct";
            this.btnCreateObjectByStruct.UseVisualStyleBackColor = true;
            this.btnCreateObjectByStruct.Click += new System.EventHandler(this.btnCreateObjectByStruct_Click);
            // 
            // lblStudentObjectOfStructAfterCopy
            // 
            this.lblStudentObjectOfStructAfterCopy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentObjectOfStructAfterCopy.Location = new System.Drawing.Point(886, 165);
            this.lblStudentObjectOfStructAfterCopy.Name = "lblStudentObjectOfStructAfterCopy";
            this.lblStudentObjectOfStructAfterCopy.Size = new System.Drawing.Size(228, 145);
            this.lblStudentObjectOfStructAfterCopy.TabIndex = 8;
            // 
            // lblStudentObjectOfStruct
            // 
            this.lblStudentObjectOfStruct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentObjectOfStruct.Location = new System.Drawing.Point(633, 165);
            this.lblStudentObjectOfStruct.Name = "lblStudentObjectOfStruct";
            this.lblStudentObjectOfStruct.Size = new System.Drawing.Size(221, 145);
            this.lblStudentObjectOfStruct.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(866, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Struct ile Yapım";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 543);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFinalStruct);
            this.Controls.Add(this.btnCopyObjectByStruct);
            this.Controls.Add(this.btnCreateObjectByStruct);
            this.Controls.Add(this.lblStudentObjectOfStructAfterCopy);
            this.Controls.Add(this.lblStudentObjectOfStruct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFinalClass);
            this.Controls.Add(this.btnCopyObjectOfClass);
            this.Controls.Add(this.btnCreateObjectByClass);
            this.Controls.Add(this.lblStudentObjectOfClassAfterCopy);
            this.Controls.Add(this.lblStudentObjectOfClassCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentObjectOfClassCreate;
        private System.Windows.Forms.Label lblStudentObjectOfClassAfterCopy;
        private System.Windows.Forms.Button btnCreateObjectByClass;
        private System.Windows.Forms.Button btnCopyObjectOfClass;
        private System.Windows.Forms.Label lblFinalClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFinalStruct;
        private System.Windows.Forms.Button btnCopyObjectByStruct;
        private System.Windows.Forms.Button btnCreateObjectByStruct;
        private System.Windows.Forms.Label lblStudentObjectOfStructAfterCopy;
        private System.Windows.Forms.Label lblStudentObjectOfStruct;
        private System.Windows.Forms.Label label7;
    }
}

