namespace Part_1
{
    partial class StudentList
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
            this.lstBxStudentList = new System.Windows.Forms.ListBox();
            this.lblStudentCV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBxStudentList
            // 
            this.lstBxStudentList.FormattingEnabled = true;
            this.lstBxStudentList.Location = new System.Drawing.Point(12, 57);
            this.lstBxStudentList.Name = "lstBxStudentList";
            this.lstBxStudentList.Size = new System.Drawing.Size(271, 316);
            this.lstBxStudentList.TabIndex = 0;
            this.lstBxStudentList.SelectedIndexChanged += new System.EventHandler(this.lstBxStudentList_SelectedIndexChanged);
            // 
            // lblStudentCV
            // 
            this.lblStudentCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentCV.Location = new System.Drawing.Point(404, 71);
            this.lblStudentCV.Name = "lblStudentCV";
            this.lblStudentCV.Size = new System.Drawing.Size(430, 302);
            this.lblStudentCV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ÖĞRENCİ CV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğrenci Listesi";
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStudentCV);
            this.Controls.Add(this.lstBxStudentList);
            this.Name = "StudentList";
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.StudentList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxStudentList;
        private System.Windows.Forms.Label lblStudentCV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}