namespace Part_1
{
    partial class OrderListForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rBtnBetween = new System.Windows.Forms.RadioButton();
            this.rBtnLittle = new System.Windows.Forms.RadioButton();
            this.rBtnLarge = new System.Windows.Forms.RadioButton();
            this.dTPOrderDate2 = new System.Windows.Forms.DateTimePicker();
            this.dTPOrderDate1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBxCompany = new System.Windows.Forms.TextBox();
            this.cBxEmployeeName = new System.Windows.Forms.ComboBox();
            this.rBtnNotEqual = new System.Windows.Forms.RadioButton();
            this.rBtnEqual = new System.Windows.Forms.RadioButton();
            this.dGVOrders = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gBxDate = new System.Windows.Forms.GroupBox();
            this.btnDateActive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).BeginInit();
            this.gBxDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDateActive);
            this.splitContainer1.Panel1.Controls.Add(this.gBxDate);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtBxCompany);
            this.splitContainer1.Panel1.Controls.Add(this.cBxEmployeeName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dGVOrders);
            this.splitContainer1.Size = new System.Drawing.Size(1122, 663);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "CompanyName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "EmployeeName";
            // 
            // rBtnBetween
            // 
            this.rBtnBetween.AutoSize = true;
            this.rBtnBetween.Location = new System.Drawing.Point(28, 149);
            this.rBtnBetween.Name = "rBtnBetween";
            this.rBtnBetween.Size = new System.Drawing.Size(83, 21);
            this.rBtnBetween.TabIndex = 9;
            this.rBtnBetween.TabStop = true;
            this.rBtnBetween.Text = "Between";
            this.rBtnBetween.UseVisualStyleBackColor = true;
            this.rBtnBetween.CheckedChanged += new System.EventHandler(this.rBtnBetween_CheckedChanged);
            // 
            // rBtnLittle
            // 
            this.rBtnLittle.AutoSize = true;
            this.rBtnLittle.Location = new System.Drawing.Point(28, 117);
            this.rBtnLittle.Name = "rBtnLittle";
            this.rBtnLittle.Size = new System.Drawing.Size(59, 21);
            this.rBtnLittle.TabIndex = 8;
            this.rBtnLittle.TabStop = true;
            this.rBtnLittle.Text = "Little";
            this.rBtnLittle.UseVisualStyleBackColor = true;
            this.rBtnLittle.CheckedChanged += new System.EventHandler(this.rBtnLittle_CheckedChanged);
            // 
            // rBtnLarge
            // 
            this.rBtnLarge.AutoSize = true;
            this.rBtnLarge.Location = new System.Drawing.Point(28, 85);
            this.rBtnLarge.Name = "rBtnLarge";
            this.rBtnLarge.Size = new System.Drawing.Size(66, 21);
            this.rBtnLarge.TabIndex = 7;
            this.rBtnLarge.TabStop = true;
            this.rBtnLarge.Text = "Large";
            this.rBtnLarge.UseVisualStyleBackColor = true;
            this.rBtnLarge.CheckedChanged += new System.EventHandler(this.rBtnLarge_CheckedChanged);
            // 
            // dTPOrderDate2
            // 
            this.dTPOrderDate2.Location = new System.Drawing.Point(272, 105);
            this.dTPOrderDate2.Name = "dTPOrderDate2";
            this.dTPOrderDate2.Size = new System.Drawing.Size(200, 22);
            this.dTPOrderDate2.TabIndex = 6;
            this.dTPOrderDate2.Visible = false;
            // 
            // dTPOrderDate1
            // 
            this.dTPOrderDate1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dTPOrderDate1.Location = new System.Drawing.Point(272, 50);
            this.dTPOrderDate1.Name = "dTPOrderDate1";
            this.dTPOrderDate1.Size = new System.Drawing.Size(200, 22);
            this.dTPOrderDate1.TabIndex = 5;
            this.dTPOrderDate1.Value = new System.DateTime(2016, 10, 16, 0, 0, 0, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(196, 149);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBxCompany
            // 
            this.txtBxCompany.Location = new System.Drawing.Point(150, 36);
            this.txtBxCompany.Name = "txtBxCompany";
            this.txtBxCompany.Size = new System.Drawing.Size(121, 22);
            this.txtBxCompany.TabIndex = 3;
            // 
            // cBxEmployeeName
            // 
            this.cBxEmployeeName.FormattingEnabled = true;
            this.cBxEmployeeName.Location = new System.Drawing.Point(150, 100);
            this.cBxEmployeeName.Name = "cBxEmployeeName";
            this.cBxEmployeeName.Size = new System.Drawing.Size(121, 24);
            this.cBxEmployeeName.TabIndex = 2;
            this.cBxEmployeeName.SelectedIndexChanged += new System.EventHandler(this.cBxEmployeeName_SelectedIndexChanged);
            // 
            // rBtnNotEqual
            // 
            this.rBtnNotEqual.AutoSize = true;
            this.rBtnNotEqual.Location = new System.Drawing.Point(28, 53);
            this.rBtnNotEqual.Name = "rBtnNotEqual";
            this.rBtnNotEqual.Size = new System.Drawing.Size(87, 21);
            this.rBtnNotEqual.TabIndex = 1;
            this.rBtnNotEqual.TabStop = true;
            this.rBtnNotEqual.Text = "NotEqual";
            this.rBtnNotEqual.UseVisualStyleBackColor = true;
            this.rBtnNotEqual.CheckedChanged += new System.EventHandler(this.rBtnNotEqual_CheckedChanged);
            // 
            // rBtnEqual
            // 
            this.rBtnEqual.AutoSize = true;
            this.rBtnEqual.Location = new System.Drawing.Point(28, 21);
            this.rBtnEqual.Name = "rBtnEqual";
            this.rBtnEqual.Size = new System.Drawing.Size(65, 21);
            this.rBtnEqual.TabIndex = 0;
            this.rBtnEqual.TabStop = true;
            this.rBtnEqual.Text = "Equal";
            this.rBtnEqual.UseVisualStyleBackColor = true;
            this.rBtnEqual.CheckedChanged += new System.EventHandler(this.rBtnEqual_CheckedChanged);
            // 
            // dGVOrders
            // 
            this.dGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVOrders.Location = new System.Drawing.Point(0, 0);
            this.dGVOrders.Name = "dGVOrders";
            this.dGVOrders.RowTemplate.Height = 24;
            this.dGVOrders.Size = new System.Drawing.Size(1122, 461);
            this.dGVOrders.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "OrderDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "OrderDate";
            this.label4.Visible = false;
            // 
            // gBxDate
            // 
            this.gBxDate.Controls.Add(this.rBtnEqual);
            this.gBxDate.Controls.Add(this.label4);
            this.gBxDate.Controls.Add(this.rBtnNotEqual);
            this.gBxDate.Controls.Add(this.label3);
            this.gBxDate.Controls.Add(this.dTPOrderDate1);
            this.gBxDate.Controls.Add(this.dTPOrderDate2);
            this.gBxDate.Controls.Add(this.rBtnLarge);
            this.gBxDate.Controls.Add(this.rBtnBetween);
            this.gBxDate.Controls.Add(this.rBtnLittle);
            this.gBxDate.Location = new System.Drawing.Point(512, 12);
            this.gBxDate.Name = "gBxDate";
            this.gBxDate.Size = new System.Drawing.Size(535, 183);
            this.gBxDate.TabIndex = 14;
            this.gBxDate.TabStop = false;
            this.gBxDate.Text = "Date";
            // 
            // btnDateActive
            // 
            this.btnDateActive.Location = new System.Drawing.Point(342, 62);
            this.btnDateActive.Name = "btnDateActive";
            this.btnDateActive.Size = new System.Drawing.Size(114, 35);
            this.btnDateActive.TabIndex = 15;
            this.btnDateActive.Text = "Active Date";
            this.btnDateActive.UseVisualStyleBackColor = true;
            this.btnDateActive.Click += new System.EventHandler(this.btnDateActive_Click);
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 663);
            this.Controls.Add(this.splitContainer1);
            this.Name = "OrderListForm";
            this.Text = "OrderListForm";
            this.Load += new System.EventHandler(this.OrderListForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).EndInit();
            this.gBxDate.ResumeLayout(false);
            this.gBxDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton rBtnBetween;
        private System.Windows.Forms.RadioButton rBtnLittle;
        private System.Windows.Forms.RadioButton rBtnLarge;
        private System.Windows.Forms.DateTimePicker dTPOrderDate2;
        private System.Windows.Forms.DateTimePicker dTPOrderDate1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBxCompany;
        private System.Windows.Forms.ComboBox cBxEmployeeName;
        private System.Windows.Forms.RadioButton rBtnNotEqual;
        private System.Windows.Forms.RadioButton rBtnEqual;
        private System.Windows.Forms.DataGridView dGVOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDateActive;
        private System.Windows.Forms.GroupBox gBxDate;
    }
}