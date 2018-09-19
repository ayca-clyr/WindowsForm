namespace _9._2___Static_Continue__StudentManagement
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
            this.öğrenciYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStudentList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciYönetimiToolStripMenuItem
            // 
            this.öğrenciYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNewStudent,
            this.MenuItemStudentList});
            this.öğrenciYönetimiToolStripMenuItem.Name = "öğrenciYönetimiToolStripMenuItem";
            this.öğrenciYönetimiToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.öğrenciYönetimiToolStripMenuItem.Text = "Öğrenci Yönetimi";
            // 
            // MenuItemNewStudent
            // 
            this.MenuItemNewStudent.Name = "MenuItemNewStudent";
            this.MenuItemNewStudent.Size = new System.Drawing.Size(152, 22);
            this.MenuItemNewStudent.Text = "Yeni Ekle";
            this.MenuItemNewStudent.Click += new System.EventHandler(this.MenuItemNewStudent_Click);
            // 
            // MenuItemStudentList
            // 
            this.MenuItemStudentList.Name = "MenuItemStudentList";
            this.MenuItemStudentList.Size = new System.Drawing.Size(152, 22);
            this.MenuItemStudentList.Text = "Öğrenci Listesi";
            this.MenuItemStudentList.Click += new System.EventHandler(this.MenuItemStudentList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 486);
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
        private System.Windows.Forms.ToolStripMenuItem öğrenciYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNewStudent;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStudentList;
    }
}

