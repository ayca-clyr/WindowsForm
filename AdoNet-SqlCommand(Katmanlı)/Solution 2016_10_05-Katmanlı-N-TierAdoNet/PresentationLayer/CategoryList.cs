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
    public partial class CategoryList : Form
    {
        CategoryBLL _categoryBLL;
        public CategoryList()
        {
            InitializeComponent();
            _categoryBLL = new CategoryBLL();
        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            dtvCategories.DataSource = _categoryBLL.GetAll();
        }

        private void dtvCategories_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id =(int)dtvCategories.Rows[e.RowIndex].Cells[0].Value;

            CategoryEdit categoryEditForm = new CategoryEdit(id);
            categoryEditForm.MdiParent = this.MdiParent;
            categoryEditForm.Show();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dtvCategories.SelectedRows[0].Cells[0].Value;
            Category cat=_categoryBLL.Get(id);
            bool result = _categoryBLL.Delete(cat);
            if (result)
            {
                MessageBox.Show("İşlem gerçekleştirildi.");
                dtvCategories.DataSource = _categoryBLL.GetAll();
            }
            else
            {
                MessageBox.Show("İşlem gerçekleşmedi.");
            }
            

        }
    }
}
