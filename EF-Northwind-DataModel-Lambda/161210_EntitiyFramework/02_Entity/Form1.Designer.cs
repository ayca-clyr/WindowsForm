namespace _02_Entity
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
            this.btnConnected = new System.Windows.Forms.Button();
            this.btnDisconnected = new System.Windows.Forms.Button();
            this.btnEntityFramework = new System.Windows.Forms.Button();
            this.lstConnected = new System.Windows.Forms.ListBox();
            this.lstDisconnected = new System.Windows.Forms.ListBox();
            this.lstEntity = new System.Windows.Forms.ListBox();
            this.lblConnected = new System.Windows.Forms.Label();
            this.lblDisconnected = new System.Windows.Forms.Label();
            this.lblEntityFramework = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnected
            // 
            this.btnConnected.Location = new System.Drawing.Point(38, 31);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(75, 23);
            this.btnConnected.TabIndex = 0;
            this.btnConnected.Text = "Connected";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // btnDisconnected
            // 
            this.btnDisconnected.Location = new System.Drawing.Point(183, 31);
            this.btnDisconnected.Name = "btnDisconnected";
            this.btnDisconnected.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnected.TabIndex = 0;
            this.btnDisconnected.Text = "Disconned";
            this.btnDisconnected.UseVisualStyleBackColor = true;
            this.btnDisconnected.Click += new System.EventHandler(this.btnDisconnected_Click);
            // 
            // btnEntityFramework
            // 
            this.btnEntityFramework.Location = new System.Drawing.Point(334, 31);
            this.btnEntityFramework.Name = "btnEntityFramework";
            this.btnEntityFramework.Size = new System.Drawing.Size(99, 23);
            this.btnEntityFramework.TabIndex = 0;
            this.btnEntityFramework.Text = "Entity Framework";
            this.btnEntityFramework.UseVisualStyleBackColor = true;
            this.btnEntityFramework.Click += new System.EventHandler(this.btnEntityFramework_Click);
            // 
            // lstConnected
            // 
            this.lstConnected.FormattingEnabled = true;
            this.lstConnected.Location = new System.Drawing.Point(24, 74);
            this.lstConnected.Name = "lstConnected";
            this.lstConnected.Size = new System.Drawing.Size(120, 277);
            this.lstConnected.TabIndex = 1;
            // 
            // lstDisconnected
            // 
            this.lstDisconnected.FormattingEnabled = true;
            this.lstDisconnected.Location = new System.Drawing.Point(167, 74);
            this.lstDisconnected.Name = "lstDisconnected";
            this.lstDisconnected.Size = new System.Drawing.Size(120, 277);
            this.lstDisconnected.TabIndex = 1;
            // 
            // lstEntity
            // 
            this.lstEntity.FormattingEnabled = true;
            this.lstEntity.Location = new System.Drawing.Point(321, 74);
            this.lstEntity.Name = "lstEntity";
            this.lstEntity.Size = new System.Drawing.Size(127, 277);
            this.lstEntity.TabIndex = 1;
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.Location = new System.Drawing.Point(56, 371);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(10, 13);
            this.lblConnected.TabIndex = 2;
            this.lblConnected.Text = "-";
            // 
            // lblDisconnected
            // 
            this.lblDisconnected.AutoSize = true;
            this.lblDisconnected.Location = new System.Drawing.Point(207, 371);
            this.lblDisconnected.Name = "lblDisconnected";
            this.lblDisconnected.Size = new System.Drawing.Size(10, 13);
            this.lblDisconnected.TabIndex = 2;
            this.lblDisconnected.Text = "-";
            // 
            // lblEntityFramework
            // 
            this.lblEntityFramework.AutoSize = true;
            this.lblEntityFramework.Location = new System.Drawing.Point(363, 371);
            this.lblEntityFramework.Name = "lblEntityFramework";
            this.lblEntityFramework.Size = new System.Drawing.Size(10, 13);
            this.lblEntityFramework.TabIndex = 2;
            this.lblEntityFramework.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 440);
            this.Controls.Add(this.lblEntityFramework);
            this.Controls.Add(this.lblDisconnected);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.lstEntity);
            this.Controls.Add(this.lstDisconnected);
            this.Controls.Add(this.lstConnected);
            this.Controls.Add(this.btnEntityFramework);
            this.Controls.Add(this.btnDisconnected);
            this.Controls.Add(this.btnConnected);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.Button btnDisconnected;
        private System.Windows.Forms.Button btnEntityFramework;
        private System.Windows.Forms.ListBox lstConnected;
        private System.Windows.Forms.ListBox lstDisconnected;
        private System.Windows.Forms.ListBox lstEntity;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Label lblDisconnected;
        private System.Windows.Forms.Label lblEntityFramework;
    }
}

