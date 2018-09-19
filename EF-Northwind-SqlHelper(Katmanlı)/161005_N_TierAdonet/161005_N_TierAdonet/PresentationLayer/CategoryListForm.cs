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
    public partial class CategoryListForm : Form
    {
        public CategoryListForm()
        {
            InitializeComponent();
            _categoryBLL = new CategoryBLL();
        }

        CategoryBLL _categoryBLL;
        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            dGVCategories.DataSource = _categoryBLL.GetAll();
        }

        private void dGVCategories_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dGVCategories.Rows[e.RowIndex].Cells[0].Value;

            CategoryEditForm frm = new CategoryEditForm(id);
            frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dGVCategories.SelectedRows[0].Cells[0].Value;
            Category cat = _categoryBLL.Get(id);
            bool result = _categoryBLL.Delete(cat);
            if (result)
            {
                MessageBox.Show("İşlem Gerçekleşti");
            }
            else
            {
                MessageBox.Show("İşlem Gerçekleşmedi");       
            }
            dGVCategories.DataSource = _categoryBLL.GetAll();
        }

   
        
    }
}
