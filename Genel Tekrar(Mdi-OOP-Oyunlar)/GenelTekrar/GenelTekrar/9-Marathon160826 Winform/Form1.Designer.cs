namespace _9_Marathon160826_Winform
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
            this.lblString = new System.Windows.Forms.Label();
            this.lblİnt = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblDecimal2Hane = new System.Windows.Forms.Label();
            this.lblDouble = new System.Windows.Forms.Label();
            this.btnString = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnDecimal2Hane = new System.Windows.Forms.Button();
            this.txtBxString = new System.Windows.Forms.TextBox();
            this.txtBxInt = new System.Windows.Forms.TextBox();
            this.txtBxDouble = new System.Windows.Forms.TextBox();
            this.txtBxDec2 = new System.Windows.Forms.TextBox();
            this.txtBxDate = new System.Windows.Forms.TextBox();
            this.txtBxDecimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(12, 9);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(86, 13);
            this.lblString.TabIndex = 3;
            this.lblString.Text = "String değer girin";
            // 
            // lblİnt
            // 
            this.lblİnt.AutoSize = true;
            this.lblİnt.Location = new System.Drawing.Point(12, 45);
            this.lblİnt.Name = "lblİnt";
            this.lblİnt.Size = new System.Drawing.Size(71, 13);
            this.lblİnt.TabIndex = 4;
            this.lblİnt.Text = "İnt değer girin";
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Location = new System.Drawing.Point(12, 95);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(97, 13);
            this.lblDecimal.TabIndex = 7;
            this.lblDecimal.Text = "Decimal değer girin";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(12, 138);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(105, 13);
            this.lblDateTime.TabIndex = 10;
            this.lblDateTime.Text = "DateTime değer girin";
            // 
            // lblDecimal2Hane
            // 
            this.lblDecimal2Hane.AutoSize = true;
            this.lblDecimal2Hane.Location = new System.Drawing.Point(12, 187);
            this.lblDecimal2Hane.Name = "lblDecimal2Hane";
            this.lblDecimal2Hane.Size = new System.Drawing.Size(215, 13);
            this.lblDecimal2Hane.TabIndex = 13;
            this.lblDecimal2Hane.Text = "Decimal değer girin(virgülden sonra 2 haneli)";
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Location = new System.Drawing.Point(12, 239);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(93, 13);
            this.lblDouble.TabIndex = 16;
            this.lblDouble.Text = "Double değer girin";
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(235, 7);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(75, 23);
            this.btnString.TabIndex = 17;
            this.btnString.Text = "String";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(235, 39);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(75, 23);
            this.btnInt.TabIndex = 18;
            this.btnInt.Text = "İnt";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(235, 90);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnDecimal.TabIndex = 19;
            this.btnDecimal.Text = "Decimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.Location = new System.Drawing.Point(235, 133);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(75, 23);
            this.btnDateTime.TabIndex = 20;
            this.btnDateTime.Text = "Datetime";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(235, 229);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(75, 23);
            this.btnDouble.TabIndex = 22;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnDecimal2Hane
            // 
            this.btnDecimal2Hane.Location = new System.Drawing.Point(374, 181);
            this.btnDecimal2Hane.Name = "btnDecimal2Hane";
            this.btnDecimal2Hane.Size = new System.Drawing.Size(75, 23);
            this.btnDecimal2Hane.TabIndex = 21;
            this.btnDecimal2Hane.Text = "Decimal";
            this.btnDecimal2Hane.UseVisualStyleBackColor = true;
            this.btnDecimal2Hane.Click += new System.EventHandler(this.btnDecimal2Hane_Click);
            // 
            // txtBxString
            // 
            this.txtBxString.Location = new System.Drawing.Point(121, 13);
            this.txtBxString.Name = "txtBxString";
            this.txtBxString.Size = new System.Drawing.Size(100, 20);
            this.txtBxString.TabIndex = 23;
            // 
            // txtBxInt
            // 
            this.txtBxInt.Location = new System.Drawing.Point(121, 45);
            this.txtBxInt.Name = "txtBxInt";
            this.txtBxInt.Size = new System.Drawing.Size(100, 20);
            this.txtBxInt.TabIndex = 24;
            // 
            // txtBxDouble
            // 
            this.txtBxDouble.Location = new System.Drawing.Point(123, 232);
            this.txtBxDouble.Name = "txtBxDouble";
            this.txtBxDouble.Size = new System.Drawing.Size(100, 20);
            this.txtBxDouble.TabIndex = 25;
            // 
            // txtBxDec2
            // 
            this.txtBxDec2.Location = new System.Drawing.Point(247, 181);
            this.txtBxDec2.Name = "txtBxDec2";
            this.txtBxDec2.Size = new System.Drawing.Size(100, 20);
            this.txtBxDec2.TabIndex = 26;
            // 
            // txtBxDate
            // 
            this.txtBxDate.Location = new System.Drawing.Point(123, 135);
            this.txtBxDate.Name = "txtBxDate";
            this.txtBxDate.Size = new System.Drawing.Size(100, 20);
            this.txtBxDate.TabIndex = 27;
            // 
            // txtBxDecimal
            // 
            this.txtBxDecimal.Location = new System.Drawing.Point(121, 95);
            this.txtBxDecimal.Name = "txtBxDecimal";
            this.txtBxDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtBxDecimal.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 466);
            this.Controls.Add(this.txtBxDecimal);
            this.Controls.Add(this.txtBxDate);
            this.Controls.Add(this.txtBxDec2);
            this.Controls.Add(this.txtBxDouble);
            this.Controls.Add(this.txtBxInt);
            this.Controls.Add(this.txtBxString);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnDecimal2Hane);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.lblDouble);
            this.Controls.Add(this.lblDecimal2Hane);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.lblİnt);
            this.Controls.Add(this.lblString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Label lblİnt;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblDecimal2Hane;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnDecimal2Hane;
        private System.Windows.Forms.TextBox txtBxString;
        private System.Windows.Forms.TextBox txtBxInt;
        private System.Windows.Forms.TextBox txtBxDouble;
        private System.Windows.Forms.TextBox txtBxDec2;
        private System.Windows.Forms.TextBox txtBxDate;
        private System.Windows.Forms.TextBox txtBxDecimal;
    }
}

