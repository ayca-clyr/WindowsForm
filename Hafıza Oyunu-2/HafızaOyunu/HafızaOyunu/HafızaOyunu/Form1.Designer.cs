namespace HafızaOyunu
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
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmBoxZorluk = new System.Windows.Forms.ComboBox();
            this.lstVw = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerZaman = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 0;
            // 
            // cmBoxZorluk
            // 
            this.cmBoxZorluk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxZorluk.FormattingEnabled = true;
            this.cmBoxZorluk.Items.AddRange(new object[] {
            "Antreman Modu",
            "Kolay Mod",
            "Orta Mod",
            "Zor Mod"});
            this.cmBoxZorluk.Location = new System.Drawing.Point(121, 100);
            this.cmBoxZorluk.Name = "cmBoxZorluk";
            this.cmBoxZorluk.Size = new System.Drawing.Size(121, 21);
            this.cmBoxZorluk.TabIndex = 1;
            // 
            // lstVw
            // 
            this.lstVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstVw.Location = new System.Drawing.Point(26, 185);
            this.lstVw.Name = "lstVw";
            this.lstVw.Size = new System.Drawing.Size(216, 209);
            this.lstVw.TabIndex = 2;
            this.lstVw.UseCompatibleStateImageBehavior = false;
            this.lstVw.View = System.Windows.Forms.View.Details;
            this.lstVw.SelectedIndexChanged += new System.EventHandler(this.lstVw_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Puan";
            this.columnHeader2.Width = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı Gir :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zorluk Seviyesi :";
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.DimGray;
            this.btnBasla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBasla.Location = new System.Drawing.Point(165, 137);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(77, 32);
            this.btnBasla.TabIndex = 5;
            this.btnBasla.Text = "Oyuna Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerZaman
            // 
            this.timerZaman.Tick += new System.EventHandler(this.timerZaman_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(269, 406);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstVw);
            this.Controls.Add(this.cmBoxZorluk);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstVw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBasla;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.ComboBox cmBoxZorluk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerZaman;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

