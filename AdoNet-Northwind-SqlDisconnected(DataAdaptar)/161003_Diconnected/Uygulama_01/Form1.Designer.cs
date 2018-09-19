namespace Uygulama_01
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
            this.dGVCategories = new System.Windows.Forms.DataGridView();
            this.btnGetCategories = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVCategories
            // 
            this.dGVCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCategories.Location = new System.Drawing.Point(12, 12);
            this.dGVCategories.Name = "dGVCategories";
            this.dGVCategories.Size = new System.Drawing.Size(565, 181);
            this.dGVCategories.TabIndex = 0;
            // 
            // btnGetCategories
            // 
            this.btnGetCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetCategories.Location = new System.Drawing.Point(178, 215);
            this.btnGetCategories.Name = "btnGetCategories";
            this.btnGetCategories.Size = new System.Drawing.Size(197, 38);
            this.btnGetCategories.TabIndex = 1;
            this.btnGetCategories.Text = "Kategorileri Getir";
            this.btnGetCategories.UseVisualStyleBackColor = true;
            this.btnGetCategories.Click += new System.EventHandler(this.btnGetCategories_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 281);
            this.Controls.Add(this.btnGetCategories);
            this.Controls.Add(this.dGVCategories);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGVCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVCategories;
        private System.Windows.Forms.Button btnGetCategories;
    }
}

