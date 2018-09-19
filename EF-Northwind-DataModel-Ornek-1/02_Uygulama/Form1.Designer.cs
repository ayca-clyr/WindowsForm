namespace _02_Uygulama
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
            this.lstconnected = new System.Windows.Forms.ListBox();
            this.lstDisconnected = new System.Windows.Forms.ListBox();
            this.lstEntity = new System.Windows.Forms.ListBox();
            this.lblConnected = new System.Windows.Forms.Label();
            this.lblDisconnected = new System.Windows.Forms.Label();
            this.lblEntity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnected
            // 
            this.btnConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnected.Location = new System.Drawing.Point(13, 13);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(82, 23);
            this.btnConnected.TabIndex = 0;
            this.btnConnected.Text = "Connected";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // btnDisconnected
            // 
            this.btnDisconnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDisconnected.Location = new System.Drawing.Point(174, 12);
            this.btnDisconnected.Name = "btnDisconnected";
            this.btnDisconnected.Size = new System.Drawing.Size(94, 23);
            this.btnDisconnected.TabIndex = 1;
            this.btnDisconnected.Text = "Disconnected";
            this.btnDisconnected.UseVisualStyleBackColor = true;
            this.btnDisconnected.Click += new System.EventHandler(this.btnDisconnected_Click);
            // 
            // btnEntityFramework
            // 
            this.btnEntityFramework.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEntityFramework.Location = new System.Drawing.Point(333, 12);
            this.btnEntityFramework.Name = "btnEntityFramework";
            this.btnEntityFramework.Size = new System.Drawing.Size(120, 23);
            this.btnEntityFramework.TabIndex = 2;
            this.btnEntityFramework.Text = "Entity Framework";
            this.btnEntityFramework.UseVisualStyleBackColor = true;
            this.btnEntityFramework.Click += new System.EventHandler(this.btnEntityFramework_Click);
            // 
            // lstconnected
            // 
            this.lstconnected.FormattingEnabled = true;
            this.lstconnected.Location = new System.Drawing.Point(13, 55);
            this.lstconnected.Name = "lstconnected";
            this.lstconnected.Size = new System.Drawing.Size(120, 251);
            this.lstconnected.TabIndex = 3;
            // 
            // lstDisconnected
            // 
            this.lstDisconnected.FormattingEnabled = true;
            this.lstDisconnected.Location = new System.Drawing.Point(174, 55);
            this.lstDisconnected.Name = "lstDisconnected";
            this.lstDisconnected.Size = new System.Drawing.Size(120, 251);
            this.lstDisconnected.TabIndex = 4;
            // 
            // lstEntity
            // 
            this.lstEntity.FormattingEnabled = true;
            this.lstEntity.Location = new System.Drawing.Point(333, 55);
            this.lstEntity.Name = "lstEntity";
            this.lstEntity.Size = new System.Drawing.Size(120, 251);
            this.lstEntity.TabIndex = 5;
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.Location = new System.Drawing.Point(12, 322);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(10, 13);
            this.lblConnected.TabIndex = 6;
            this.lblConnected.Text = "-";
            // 
            // lblDisconnected
            // 
            this.lblDisconnected.AutoSize = true;
            this.lblDisconnected.Location = new System.Drawing.Point(173, 322);
            this.lblDisconnected.Name = "lblDisconnected";
            this.lblDisconnected.Size = new System.Drawing.Size(10, 13);
            this.lblDisconnected.TabIndex = 7;
            this.lblDisconnected.Text = "-";
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(332, 331);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(10, 13);
            this.lblEntity.TabIndex = 8;
            this.lblEntity.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 370);
            this.Controls.Add(this.lblEntity);
            this.Controls.Add(this.lblDisconnected);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.lstEntity);
            this.Controls.Add(this.lstDisconnected);
            this.Controls.Add(this.lstconnected);
            this.Controls.Add(this.btnEntityFramework);
            this.Controls.Add(this.btnDisconnected);
            this.Controls.Add(this.btnConnected);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.Button btnDisconnected;
        private System.Windows.Forms.Button btnEntityFramework;
        private System.Windows.Forms.ListBox lstconnected;
        private System.Windows.Forms.ListBox lstDisconnected;
        private System.Windows.Forms.ListBox lstEntity;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Label lblDisconnected;
        private System.Windows.Forms.Label lblEntity;
    }
}

