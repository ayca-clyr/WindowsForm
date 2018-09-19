namespace Login
{
    partial class SoftwareDeveloper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareDeveloper));
            this.dGVTaskList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testEdilecekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBxEmployeeID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTaskList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVTaskList
            // 
            this.dGVTaskList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTaskList.ContextMenuStrip = this.contextMenuStrip1;
            this.dGVTaskList.Location = new System.Drawing.Point(0, 0);
            this.dGVTaskList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVTaskList.Name = "dGVTaskList";
            this.dGVTaskList.RowTemplate.Height = 24;
            this.dGVTaskList.Size = new System.Drawing.Size(944, 528);
            this.dGVTaskList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testEdilecekToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 30);
            // 
            // testEdilecekToolStripMenuItem
            // 
            this.testEdilecekToolStripMenuItem.Name = "testEdilecekToolStripMenuItem";
            this.testEdilecekToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.testEdilecekToolStripMenuItem.Text = "Test Edilecek";
            this.testEdilecekToolStripMenuItem.Click += new System.EventHandler(this.testEdilecekToolStripMenuItem_Click);
            // 
            // cBxEmployeeID
            // 
            this.cBxEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxEmployeeID.FormattingEnabled = true;
            this.cBxEmployeeID.Location = new System.Drawing.Point(1006, 162);
            this.cBxEmployeeID.Name = "cBxEmployeeID";
            this.cBxEmployeeID.Size = new System.Drawing.Size(163, 24);
            this.cBxEmployeeID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(950, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gönderilecek Test Uzmanını Seçiniz";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1038, 38);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SoftwareDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1231, 578);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBxEmployeeID);
            this.Controls.Add(this.dGVTaskList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SoftwareDeveloper";
            this.Text = "Yazılım Geliştirici";
            this.Load += new System.EventHandler(this.SoftwareDeveloper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTaskList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVTaskList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testEdilecekToolStripMenuItem;
        private System.Windows.Forms.ComboBox cBxEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}