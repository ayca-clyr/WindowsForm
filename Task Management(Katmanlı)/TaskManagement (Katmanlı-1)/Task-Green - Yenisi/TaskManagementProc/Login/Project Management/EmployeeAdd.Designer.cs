namespace Login
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBxAccountID = new System.Windows.Forms.ComboBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dGVEmployeeList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mBxPhone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployeeList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(248, 294);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Çalışan Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "EMail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-52, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ad";
            // 
            // cBxAccountID
            // 
            this.cBxAccountID.BackColor = System.Drawing.SystemColors.Menu;
            this.cBxAccountID.FormattingEnabled = true;
            this.cBxAccountID.Location = new System.Drawing.Point(147, 249);
            this.cBxAccountID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBxAccountID.Name = "cBxAccountID";
            this.cBxAccountID.Size = new System.Drawing.Size(203, 24);
            this.cBxAccountID.TabIndex = 5;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBxLastName.Location = new System.Drawing.Point(147, 82);
            this.txtBxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(203, 22);
            this.txtBxLastName.TabIndex = 1;
            this.txtBxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxLastName_KeyPress);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBxPassword.Location = new System.Drawing.Point(147, 167);
            this.txtBxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '*';
            this.txtBxPassword.Size = new System.Drawing.Size(203, 22);
            this.txtBxPassword.TabIndex = 3;
            this.txtBxPassword.UseSystemPasswordChar = true;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBxEmail.Location = new System.Drawing.Point(147, 128);
            this.txtBxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(203, 22);
            this.txtBxEmail.TabIndex = 2;
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBxFirstName.Location = new System.Drawing.Point(147, 34);
            this.txtBxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(203, 22);
            this.txtBxFirstName.TabIndex = 0;
            this.txtBxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxFirstName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ad";
            // 
            // dGVEmployeeList
            // 
            this.dGVEmployeeList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEmployeeList.ContextMenuStrip = this.contextMenuStrip1;
            this.dGVEmployeeList.Location = new System.Drawing.Point(400, 34);
            this.dGVEmployeeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVEmployeeList.Name = "dGVEmployeeList";
            this.dGVEmployeeList.RowTemplate.Height = 24;
            this.dGVEmployeeList.Size = new System.Drawing.Size(844, 450);
            this.dGVEmployeeList.TabIndex = 25;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 56);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // mBxPhone
            // 
            this.mBxPhone.BackColor = System.Drawing.SystemColors.Menu;
            this.mBxPhone.Location = new System.Drawing.Point(147, 210);
            this.mBxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mBxPhone.Mask = "(999) 000-0000";
            this.mBxPhone.Name = "mBxPhone";
            this.mBxPhone.Size = new System.Drawing.Size(203, 22);
            this.mBxPhone.TabIndex = 4;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1256, 514);
            this.Controls.Add(this.mBxPhone);
            this.Controls.Add(this.dGVEmployeeList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBxAccountID);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.txtBxFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeForm";
            this.Text = "Çalışan Kayıt";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployeeList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBxAccountID;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dGVEmployeeList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox mBxPhone;
    }
}