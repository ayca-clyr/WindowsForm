namespace Part1
{
    partial class Conneciton
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
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDurum
            // 
            this.lblDurum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(97, 34);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(311, 50);
            this.lblDurum.TabIndex = 10;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(167, 132);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(147, 45);
            this.btnConnection.TabIndex = 9;
            this.btnConnection.Text = "Bağlantıyı Aç";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // Conneciton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 261);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnConnection);
            this.Name = "Conneciton";
            this.Text = "Conneciton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnConnection;

    }
}