namespace StudentManagement
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciYöntetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStudentList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciYöntetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciYöntetimiToolStripMenuItem
            // 
            this.öğrenciYöntetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewStudent,
            this.menuItemStudentList});
            this.öğrenciYöntetimiToolStripMenuItem.Name = "öğrenciYöntetimiToolStripMenuItem";
            this.öğrenciYöntetimiToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.öğrenciYöntetimiToolStripMenuItem.Text = "Öğrenci Yöntetimi";
            // 
            // menuItemNewStudent
            // 
            this.menuItemNewStudent.Name = "menuItemNewStudent";
            this.menuItemNewStudent.Size = new System.Drawing.Size(152, 22);
            this.menuItemNewStudent.Text = "Yeni Ekle";
            this.menuItemNewStudent.Click += new System.EventHandler(this.menuItemNewStudent_Click);
            // 
            // menuItemStudentList
            // 
            this.menuItemStudentList.Name = "menuItemStudentList";
            this.menuItemStudentList.Size = new System.Drawing.Size(152, 22);
            this.menuItemStudentList.Text = "Öğrenci Listesi";
            this.menuItemStudentList.Click += new System.EventHandler(this.menuItemStudentList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 372);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciYöntetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewStudent;
        private System.Windows.Forms.ToolStripMenuItem menuItemStudentList;
    }
}

