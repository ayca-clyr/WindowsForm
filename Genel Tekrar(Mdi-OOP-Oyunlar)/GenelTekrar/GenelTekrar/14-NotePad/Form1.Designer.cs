﻿namespace _14_NotePad
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
            this.rtxtBx = new System.Windows.Forms.RichTextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtBx
            // 
            this.rtxtBx.Location = new System.Drawing.Point(0, -2);
            this.rtxtBx.Name = "rtxtBx";
            this.rtxtBx.Size = new System.Drawing.Size(681, 384);
            this.rtxtBx.TabIndex = 1;
            this.rtxtBx.Text = "";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(0, 388);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(122, 73);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Oku";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(543, 382);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(138, 79);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "Yaz";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 480);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.rtxtBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtBx;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;

    }
}

