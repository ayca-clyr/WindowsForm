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
    public partial class CategoryEditForm : Form
    {
        CategoryBLL _catBLL;
        public Category _cat;
        public bool isSave = false;
        public CategoryEditForm()
        {
            InitializeComponent();
            _catBLL = new CategoryBLL();
            _cat = new Category();
            isSave = true;
            btnAdd.Text = "Add";
        }
        public void Clear()
        {
            txtBxCategoryName.Text = "";
            txtBxDescription.Text = "";
        }
        public CategoryEditForm(int id)
        {
            InitializeComponent();
            _catBLL = new CategoryBLL();
            _cat = _catBLL.Get(id);
            isSave = false;
            btnAdd.Text = "Update";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool result;

            _cat.Name = txtBxCategoryName.Text;
            _cat.Description = txtBxDescription.Text;

            if (isSave)
            {
                result = _catBLL.Add(_cat);
                Clear();

                if (result)
                {
                    MessageBox.Show("Ekleme İşleminiz Başarıyla Gerçekleşti");

                }
                else
                {
                    MessageBox.Show("Ekleme İşleminiz Başarısız");
                }
            }
            else
            {
                _cat.CategoryID = CategoryListForm.ID;
                result = _catBLL.Update(_cat);
                if (result)
                {
                    MessageBox.Show("Güncelleme İşleminiz Başarıyla Gerçekleşti");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Güncelleme İşleminiz Başarısız");
                }


            }

        }

    }
}
