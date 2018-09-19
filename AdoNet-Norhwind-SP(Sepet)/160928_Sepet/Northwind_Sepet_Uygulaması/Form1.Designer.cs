namespace Northwind_Sepet_Uygulaması
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
            this.cBxEmployees = new System.Windows.Forms.ComboBox();
            this.cBxCustomers = new System.Windows.Forms.ComboBox();
            this.cBxShipVia = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBxEmployees
            // 
            this.cBxEmployees.FormattingEnabled = true;
            this.cBxEmployees.Location = new System.Drawing.Point(32, 82);
            this.cBxEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.cBxEmployees.Name = "cBxEmployees";
            this.cBxEmployees.Size = new System.Drawing.Size(160, 24);
            this.cBxEmployees.TabIndex = 0;
            this.cBxEmployees.SelectedIndexChanged += new System.EventHandler(this.cBxEmployees_SelectedIndexChanged);
            // 
            // cBxCustomers
            // 
            this.cBxCustomers.FormattingEnabled = true;
            this.cBxCustomers.Location = new System.Drawing.Point(255, 84);
            this.cBxCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.cBxCustomers.Name = "cBxCustomers";
            this.cBxCustomers.Size = new System.Drawing.Size(160, 24);
            this.cBxCustomers.TabIndex = 1;
            this.cBxCustomers.SelectedIndexChanged += new System.EventHandler(this.cBxCustomers_SelectedIndexChanged);
            // 
            // cBxShipVia
            // 
            this.cBxShipVia.FormattingEnabled = true;
            this.cBxShipVia.Location = new System.Drawing.Point(481, 84);
            this.cBxShipVia.Margin = new System.Windows.Forms.Padding(4);
            this.cBxShipVia.Name = "cBxShipVia";
            this.cBxShipVia.Size = new System.Drawing.Size(160, 24);
            this.cBxShipVia.TabIndex = 2;
            this.cBxShipVia.SelectedIndexChanged += new System.EventHandler(this.cBxShipVia_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(707, 81);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 27);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Sipariş Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Çalışanlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Müşteriler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kargo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 446);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cBxShipVia);
            this.Controls.Add(this.cBxCustomers);
            this.Controls.Add(this.cBxEmployees);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cBxEmployees;
        public System.Windows.Forms.ComboBox cBxCustomers;
        public System.Windows.Forms.ComboBox cBxShipVia;
    }
}

