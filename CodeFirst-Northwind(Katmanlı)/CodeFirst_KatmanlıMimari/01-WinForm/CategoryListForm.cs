using _01_BusinessLayer;
using _01_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_WinForm
{
    public partial class CategoryListForm : Form
    {
        CategoryBLL _catBLL;
        Category cat = new Category();
        CategoryEditForm catEdit = new CategoryEditForm();
        public static int ID;
        public CategoryListForm()
        {
            InitializeComponent();
            _catBLL = new CategoryBLL();
        }

        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            dGVCategoryList.DataSource = _catBLL.GetAll();
        }

        public void GetCategory()
        {
            dGVCategoryList.DataSource = null;
            dGVCategoryList.DataSource = _catBLL.GetAll();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int id = (int)dGVCategoryList.SelectedRows[0].Cells[0].Value;
            Category cat = _catBLL.Get(id);
            bool result = _catBLL.Remove(cat);
            if (result)
            {
                MessageBox.Show("İşlem Gerçekleşti");
            }
            else
            {
                MessageBox.Show("İşlem Gerçekleşmedi");
            }
            GetCategory();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catEdit.btnAdd.Text = "Update";
            catEdit.isSave = false;
            cat.CategoryID = (int)dGVCategoryList.SelectedRows[0].Cells[0].Value;
            ID = cat.CategoryID;
            cat = _catBLL.Get(cat.CategoryID);

            catEdit.txtBxCategoryName.Text = cat.Name;
            catEdit.txtBxDescription.Text = cat.Description;


            catEdit.MdiParent = Form1.ActiveForm;
            catEdit.Show();

        }
    }
}
