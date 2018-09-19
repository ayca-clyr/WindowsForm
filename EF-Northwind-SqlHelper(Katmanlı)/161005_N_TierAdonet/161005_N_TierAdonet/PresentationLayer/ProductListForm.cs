using BusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
            _proBLL = new ProductBLL();

        }
        ProductBLL _proBLL;
        private void dGVProductList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dGVProductList.Rows[e.RowIndex].Cells[0].Value;

            ProductEditForm frm = new ProductEditForm(id);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            dGVProductList.DataSource = _proBLL.GetAll();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dGVProductList.SelectedRows[0].Cells[0].Value;
            Product cat = _proBLL.Get(id);
            bool result = _proBLL.Delete(cat);
            if (result)
            {
                MessageBox.Show("İşlem Gerçekleşti");
            }
            else
            {
                MessageBox.Show("İşlem Gerçekleşmedi");
            }
            dGVProductList.DataSource = _proBLL.GetAll();
        }
    }
}
