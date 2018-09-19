﻿using Part_1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1
{
    public partial class NorthwindMainForm : Form
    {
        public NorthwindMainForm()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void categoryListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryListForm catListForm = new CategoryListForm();
            catListForm.MdiParent = this;
            catListForm.Show();
        }

        private void categoryCRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryEditForm catEditForm = new CategoryEditForm();
            catEditForm.MdiParent = this;
            catEditForm.Show();

        }

        private void productCRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductEditForm proEditForm = new ProductEditForm();
            proEditForm.MdiParent = this;
            proEditForm.Show();
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductListForm proListForm = new ProductListForm();
            proListForm.MdiParent = this;
            proListForm.Show();
        }

        private void orderCRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderEditForm orderEdit = new OrderEditForm();
            orderEdit.MdiParent = this;
            orderEdit.Show();
        }

        private void orderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderListForm orderList = new OrderListForm();
            orderList.MdiParent = this;
            orderList.Show();
        }
    }
}