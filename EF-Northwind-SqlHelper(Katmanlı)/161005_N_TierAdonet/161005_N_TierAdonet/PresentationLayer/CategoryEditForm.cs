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
    public partial class CategoryEditForm : Form
    {
        CategoryBLL _categoryBLL;
        Category cat;
        bool isSave = false;

        public CategoryEditForm()
        {
            InitializeComponent();
            _categoryBLL = new CategoryBLL();
            cat = new Category();
            isSave = true;
            btnSave.Text = "Kaydet";

        }
        public CategoryEditForm(int id)
        {
            InitializeComponent();
            _categoryBLL = new CategoryBLL();
            cat = _categoryBLL.Get(id);
            isSave = false;
            btnSave.Text = "Güncelle";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            bool result;

            cat.CategoryName = txtBxCategory.Text;
            cat.Description = txtBxDesc.Text;

            if (isSave)
            {
                result = _categoryBLL.Insert(cat);
            }
            else
            {
                result = _categoryBLL.Update(cat);
            }
            if (result)
            {
                MessageBox.Show("İşlem Başarıyla Gerçekleşti!");
            }
            else
            {
                MessageBox.Show("İşlem Başarısız!");
            }
        }

        private void CategoryEditForm_Load(object sender, EventArgs e)
        {
            if (isSave == false)
            {
                txtBxCategory.Text = cat.CategoryName;
                txtBxDesc.Text = cat.Description;

            }
        }
    }
}
