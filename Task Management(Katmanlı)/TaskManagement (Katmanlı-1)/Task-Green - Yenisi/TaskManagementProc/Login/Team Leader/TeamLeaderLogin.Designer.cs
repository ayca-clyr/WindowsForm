namespace Login
{
    partial class TeamLeaderLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamLeaderLogin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taskAddManagementToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.taskAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectListToolStripMenuItem1,
            this.taskAddManagementToolStripMenuItem2,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1046, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectListToolStripMenuItem1
            // 
            this.projectListToolStripMenuItem1.Name = "projectListToolStripMenuItem1";
            this.projectListToolStripMenuItem1.Size = new System.Drawing.Size(89, 24);
            this.projectListToolStripMenuItem1.Text = "ProjectList";
            this.projectListToolStripMenuItem1.Click += new System.EventHandler(this.projectListToolStripMenuItem1_Click);
            // 
            // taskAddManagementToolStripMenuItem2
            // 
            this.taskAddManagementToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskAddToolStripMenuItem});
            this.taskAddManagementToolStripMenuItem2.Name = "taskAddManagementToolStripMenuItem2";
            this.taskAddManagementToolStripMenuItem2.Size = new System.Drawing.Size(136, 24);
            this.taskAddManagementToolStripMenuItem2.Text = "TaskManagement";
            // 
            // taskAddToolStripMenuItem
            // 
            this.taskAddToolStripMenuItem.Name = "taskAddToolStripMenuItem";
            this.taskAddToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.taskAddToolStripMenuItem.Text = "TaskAdd";
            this.taskAddToolStripMenuItem.Click += new System.EventHandler(this.taskAddToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // TeamLeaderLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1046, 495);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeamLeaderLogin";
            this.Text = "Takım Lideri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem taskAddManagementToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem taskAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}