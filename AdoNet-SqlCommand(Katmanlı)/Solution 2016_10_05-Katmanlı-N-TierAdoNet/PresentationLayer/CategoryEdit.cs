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
    public partial class CategoryEdit : Form
    {
        CategoryBLL _categoryBLL;
        Category _cat;
        bool isSave=false;
        
        public CategoryEdit()
        {
            InitializeComponent();
            _categoryBLL = new CategoryBLL();
            _cat = new Category();
            isSave = true;
            btnSave.Text = "Kaydet";
          
        }
        public CategoryEdit(int id)
        {
            InitializeComponent();
            _categoryBLL = new CategoryBLL();
            _cat = _categoryBLL.Get(id);
            isSave = false;
            btnSave.Text = "Güncelle";
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _cat.CategoryName = txtBxCategory.Text;
            _cat.Description = txtBxDescription.Text;
            bool result;
            if (isSave)
            {
               
                result = _categoryBLL.Insert(_cat);
            }
            else
            {
                result = _categoryBLL.Update(_cat);
            }
            if (result)
            {
                MessageBox.Show("İşlem başarıyla gerçekleştirildi.");
            }
            else
            {
                MessageBox.Show("İşlem sırasında hata oluştu");
            }
        }

        private void CategoryEdit_Load(object sender, EventArgs e)
        {
            if (isSave == false)
            {
                txtBxDescription.Text = _cat.Description;
                txtBxCategory.Text = _cat.CategoryName;
            }
        }
    }
}
