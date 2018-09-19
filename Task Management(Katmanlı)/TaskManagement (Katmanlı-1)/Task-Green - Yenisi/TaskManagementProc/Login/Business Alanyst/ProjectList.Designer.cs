namespace Login
{
    partial class BusinessAnalyst
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessAnalyst));
            this.dGVProjectList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hataİstekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geliştirilecekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProjectList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVProjectList
            // 
            this.dGVProjectList.BackgroundColor = System.Drawing.Color.Silver;
            this.dGVProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProjectList.ContextMenuStrip = this.contextMenuStrip1;
            this.dGVProjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVProjectList.Location = new System.Drawing.Point(0, 0);
            this.dGVProjectList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVProjectList.Name = "dGVProjectList";
            this.dGVProjectList.RowTemplate.Height = 24;
            this.dGVProjectList.Size = new System.Drawing.Size(1200, 576);
            this.dGVProjectList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hataİstekToolStripMenuItem,
            this.geliştirilecekToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 56);
            // 
            // hataİstekToolStripMenuItem
            // 
            this.hataİstekToolStripMenuItem.Name = "hataİstekToolStripMenuItem";
            this.hataİstekToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.hataİstekToolStripMenuItem.Text = "Hata/İstek";
            this.hataİstekToolStripMenuItem.Click += new System.EventHandler(this.hataİstekToolStripMenuItem_Click);
            // 
            // geliştirilecekToolStripMenuItem
            // 
            this.geliştirilecekToolStripMenuItem.Name = "geliştirilecekToolStripMenuItem";
            this.geliştirilecekToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.geliştirilecekToolStripMenuItem.Text = "Geliştirilecek";
            this.geliştirilecekToolStripMenuItem.Click += new System.EventHandler(this.geliştirilecekToolStripMenuItem_Click);
            // 
            // BusinessAnalyst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 576);
            this.Controls.Add(this.dGVProjectList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BusinessAnalyst";
            this.Text = "Projeler";
            this.Load += new System.EventHandler(this.BusinessAnalyst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVProjectList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hataİstekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geliştirilecekToolStripMenuItem;
        public System.Windows.Forms.DataGridView dGVProjectList;
    }
}