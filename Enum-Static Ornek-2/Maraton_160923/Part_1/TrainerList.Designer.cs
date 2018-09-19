namespace Part_1
{
    partial class TrainerList
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTrainerCV = new System.Windows.Forms.Label();
            this.lstBxTrainerList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Eğitmen Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "EĞİTMEN CV";
            // 
            // lblTrainerCV
            // 
            this.lblTrainerCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTrainerCV.Location = new System.Drawing.Point(418, 105);
            this.lblTrainerCV.Name = "lblTrainerCV";
            this.lblTrainerCV.Size = new System.Drawing.Size(430, 302);
            this.lblTrainerCV.TabIndex = 5;
            // 
            // lstBxTrainerList
            // 
            this.lstBxTrainerList.FormattingEnabled = true;
            this.lstBxTrainerList.Location = new System.Drawing.Point(26, 91);
            this.lstBxTrainerList.Name = "lstBxTrainerList";
            this.lstBxTrainerList.Size = new System.Drawing.Size(271, 316);
            this.lstBxTrainerList.TabIndex = 4;
            // 
            // TrainerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTrainerCV);
            this.Controls.Add(this.lstBxTrainerList);
            this.Name = "TrainerList";
            this.Text = "TrainerList";
            this.Load += new System.EventHandler(this.TrainerList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTrainerCV;
        private System.Windows.Forms.ListBox lstBxTrainerList;

    }
}