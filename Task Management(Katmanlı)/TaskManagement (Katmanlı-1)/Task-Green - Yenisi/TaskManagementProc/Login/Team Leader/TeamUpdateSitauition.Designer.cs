namespace Login.Team_Leader
{
    partial class TeamUpdateSitauition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamUpdateSitauition));
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.rbDevelopment = new System.Windows.Forms.RadioButton();
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomer.Controls.Add(this.btnSave);
            this.grpCustomer.Controls.Add(this.label1);
            this.grpCustomer.Controls.Add(this.rbUpdate);
            this.grpCustomer.Controls.Add(this.rbDevelopment);
            this.grpCustomer.Location = new System.Drawing.Point(16, 15);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCustomer.Size = new System.Drawing.Size(564, 169);
            this.grpCustomer.TabIndex = 55;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Proje Durum";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.Red;
            this.btnSave.Location = new System.Drawing.Point(347, 105);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Güncelle";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Proje Durumu";
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Location = new System.Drawing.Point(269, 63);
            this.rbUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(114, 21);
            this.rbUpdate.TabIndex = 49;
            this.rbUpdate.TabStop = true;
            this.rbUpdate.Text = "Test Edilecek";
            this.rbUpdate.UseVisualStyleBackColor = true;
            // 
            // rbDevelopment
            // 
            this.rbDevelopment.AutoSize = true;
            this.rbDevelopment.Location = new System.Drawing.Point(103, 63);
            this.rbDevelopment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDevelopment.Name = "rbDevelopment";
            this.rbDevelopment.Size = new System.Drawing.Size(109, 21);
            this.rbDevelopment.TabIndex = 48;
            this.rbDevelopment.Text = "Geliştirilecek";
            this.rbDevelopment.UseVisualStyleBackColor = true;
            // 
            // TeamUpdateSitauition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(611, 198);
            this.Controls.Add(this.grpCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeamUpdateSitauition";
            this.Text = "Görev Durum Güncelleme";
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grpCustomer;
        public System.Windows.Forms.RadioButton rbUpdate;
        public System.Windows.Forms.RadioButton rbDevelopment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}