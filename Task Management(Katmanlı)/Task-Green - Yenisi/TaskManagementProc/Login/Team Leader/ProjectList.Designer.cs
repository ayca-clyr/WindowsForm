namespace Login
{
    partial class TeamLeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamLeader));
            this.dGVProjectList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hataİstekEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleGeliştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dGVProjectList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGVProjectList.Name = "dGVProjectList";
            this.dGVProjectList.RowTemplate.Height = 24;
            this.dGVProjectList.Size = new System.Drawing.Size(869, 465);
            this.dGVProjectList.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hataİstekEkleToolStripMenuItem,
            this.güncelleGeliştirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // hataİstekEkleToolStripMenuItem
            // 
            this.hataİstekEkleToolStripMenuItem.Name = "hataİstekEkleToolStripMenuItem";
            this.hataİstekEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hataİstekEkleToolStripMenuItem.Text = "Hata/İstek Ekle";
            this.hataİstekEkleToolStripMenuItem.Click += new System.EventHandler(this.hataİstekEkleToolStripMenuItem_Click);
            // 
            // güncelleGeliştirToolStripMenuItem
            // 
            this.güncelleGeliştirToolStripMenuItem.Name = "güncelleGeliştirToolStripMenuItem";
            this.güncelleGeliştirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.güncelleGeliştirToolStripMenuItem.Text = "Geliştir/Test Et";
            this.güncelleGeliştirToolStripMenuItem.Click += new System.EventHandler(this.güncelleGeliştirToolStripMenuItem_Click);
            // 
            // TeamLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(869, 465);
            this.Controls.Add(this.dGVProjectList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeamLeader";
            this.Text = "Takım Lideri";
            this.Load += new System.EventHandler(this.TeamLeader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVProjectList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hataİstekEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleGeliştirToolStripMenuItem;
        public System.Windows.Forms.DataGridView dGVProjectList;
    }
}