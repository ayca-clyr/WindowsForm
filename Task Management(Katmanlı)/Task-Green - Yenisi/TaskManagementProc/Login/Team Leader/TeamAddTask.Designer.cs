namespace Login
{
    partial class TaskManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnError = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVCustomerRequestList = new System.Windows.Forms.DataGridView();
            this.dGVTaskList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBxManagerID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dTPEndTime = new System.Windows.Forms.DateTimePicker();
            this.dTPStartTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cBxSituation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxTaskName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxDescription = new System.Windows.Forms.TextBox();
            this.cBxEmployeeID = new System.Windows.Forms.ComboBox();
            this.cBxProjectName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaskSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCustomerRequestList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTaskList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btnError);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dGVCustomerRequestList);
            this.groupBox1.Controls.Add(this.dGVTaskList);
            this.groupBox1.Controls.Add(this.cBxManagerID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dTPEndTime);
            this.groupBox1.Controls.Add(this.dTPStartTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cBxSituation);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBxTaskName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBxDescription);
            this.groupBox1.Controls.Add(this.cBxEmployeeID);
            this.groupBox1.Controls.Add(this.cBxProjectName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTaskSave);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1397, 623);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Görev Atama Ekranı";
            // 
            // btnError
            // 
            this.btnError.BackColor = System.Drawing.Color.Red;
            this.btnError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnError.ForeColor = System.Drawing.SystemColors.Control;
            this.btnError.Location = new System.Drawing.Point(136, 564);
            this.btnError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(112, 28);
            this.btnError.TabIndex = 45;
            this.btnError.Tag = "";
            this.btnError.Text = "Geriye Dön";
            this.btnError.UseVisualStyleBackColor = false;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(833, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Görev Atanmış Projeler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(848, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Talep ve İstek Projeleri";
            // 
            // dGVCustomerRequestList
            // 
            this.dGVCustomerRequestList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVCustomerRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCustomerRequestList.Location = new System.Drawing.Point(412, 295);
            this.dGVCustomerRequestList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVCustomerRequestList.Name = "dGVCustomerRequestList";
            this.dGVCustomerRequestList.RowTemplate.Height = 24;
            this.dGVCustomerRequestList.Size = new System.Drawing.Size(963, 276);
            this.dGVCustomerRequestList.TabIndex = 38;
            // 
            // dGVTaskList
            // 
            this.dGVTaskList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTaskList.ContextMenuStrip = this.contextMenuStrip1;
            this.dGVTaskList.Location = new System.Drawing.Point(412, 37);
            this.dGVTaskList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVTaskList.Name = "dGVTaskList";
            this.dGVTaskList.RowTemplate.Height = 24;
            this.dGVTaskList.Size = new System.Drawing.Size(963, 235);
            this.dGVTaskList.TabIndex = 37;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 56);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // cBxManagerID
            // 
            this.cBxManagerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxManagerID.FormattingEnabled = true;
            this.cBxManagerID.Location = new System.Drawing.Point(169, 254);
            this.cBxManagerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBxManagerID.Name = "cBxManagerID";
            this.cBxManagerID.Size = new System.Drawing.Size(207, 24);
            this.cBxManagerID.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(12, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Yetkili Kişi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(12, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Proje Bitiş Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Proje Başlama Tarihi";
            // 
            // dTPEndTime
            // 
            this.dTPEndTime.Location = new System.Drawing.Point(169, 354);
            this.dTPEndTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPEndTime.Name = "dTPEndTime";
            this.dTPEndTime.Size = new System.Drawing.Size(208, 22);
            this.dTPEndTime.TabIndex = 32;
            // 
            // dTPStartTime
            // 
            this.dTPStartTime.Location = new System.Drawing.Point(169, 306);
            this.dTPStartTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPStartTime.Name = "dTPStartTime";
            this.dTPStartTime.Size = new System.Drawing.Size(208, 22);
            this.dTPStartTime.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Proje Durumu";
            // 
            // cBxSituation
            // 
            this.cBxSituation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxSituation.FormattingEnabled = true;
            this.cBxSituation.Location = new System.Drawing.Point(169, 148);
            this.cBxSituation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBxSituation.Name = "cBxSituation";
            this.cBxSituation.Size = new System.Drawing.Size(207, 24);
            this.cBxSituation.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Görev Adı ";
            // 
            // txtBxTaskName
            // 
            this.txtBxTaskName.Location = new System.Drawing.Point(169, 37);
            this.txtBxTaskName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxTaskName.Name = "txtBxTaskName";
            this.txtBxTaskName.Size = new System.Drawing.Size(208, 22);
            this.txtBxTaskName.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 406);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Açıklama";
            // 
            // txtBxDescription
            // 
            this.txtBxDescription.Location = new System.Drawing.Point(169, 406);
            this.txtBxDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxDescription.Multiline = true;
            this.txtBxDescription.Name = "txtBxDescription";
            this.txtBxDescription.Size = new System.Drawing.Size(215, 133);
            this.txtBxDescription.TabIndex = 23;
            // 
            // cBxEmployeeID
            // 
            this.cBxEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxEmployeeID.FormattingEnabled = true;
            this.cBxEmployeeID.Location = new System.Drawing.Point(169, 202);
            this.cBxEmployeeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBxEmployeeID.Name = "cBxEmployeeID";
            this.cBxEmployeeID.Size = new System.Drawing.Size(207, 24);
            this.cBxEmployeeID.TabIndex = 22;
            // 
            // cBxProjectName
            // 
            this.cBxProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxProjectName.FormattingEnabled = true;
            this.cBxProjectName.Location = new System.Drawing.Point(169, 91);
            this.cBxProjectName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBxProjectName.Name = "cBxProjectName";
            this.cBxProjectName.Size = new System.Drawing.Size(207, 24);
            this.cBxProjectName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Görev Atanacak Kişi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Proje Adı";
            // 
            // btnTaskSave
            // 
            this.btnTaskSave.BackColor = System.Drawing.Color.Green;
            this.btnTaskSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaskSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTaskSave.Location = new System.Drawing.Point(268, 564);
            this.btnTaskSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTaskSave.Name = "btnTaskSave";
            this.btnTaskSave.Size = new System.Drawing.Size(109, 28);
            this.btnTaskSave.TabIndex = 7;
            this.btnTaskSave.Text = "Görevi Ata";
            this.btnTaskSave.UseVisualStyleBackColor = false;
            this.btnTaskSave.Click += new System.EventHandler(this.btnTaskSave_Click);
            // 
            // TaskManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1363, 652);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TaskManagement";
            this.Text = "Görev Ekle";
            this.Load += new System.EventHandler(this.TaskManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCustomerRequestList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTaskList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnTaskSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cBxManagerID;
        public System.Windows.Forms.DateTimePicker dTPEndTime;
        public System.Windows.Forms.DateTimePicker dTPStartTime;
        public System.Windows.Forms.ComboBox cBxSituation;
        public System.Windows.Forms.TextBox txtBxTaskName;
        public System.Windows.Forms.TextBox txtBxDescription;
        public System.Windows.Forms.ComboBox cBxEmployeeID;
        public System.Windows.Forms.ComboBox cBxProjectName;
        private System.Windows.Forms.DataGridView dGVTaskList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGVCustomerRequestList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnError;
    }
}