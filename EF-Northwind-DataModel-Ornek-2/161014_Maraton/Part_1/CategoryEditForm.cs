using Part_1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1
{
    public partial class CategoryEditForm : Form
    {
        public CategoryEditForm()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();
        CategoryListForm catListForm;
        
        private void Clear()
        {
            txtBxCategoryName.Text = "";
            txtBxDescription.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

    
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (btnAdd.Text == "Add")
            {
                catListForm.MdiParent = Form1.ActiveForm;
                db.Database.ExecuteSqlCommand("insert into Categories (CategoryName, Description) values(@ad,@desc)", new SqlParameter("@ad", txtBxCategoryName.Text), new SqlParameter("@desc", txtBxDescription.Text));
                MessageBox.Show("Kategori Eklenmiştir!");                
           catListForm.dGVCategory.DataSource = db.Categories.ToList();
           Clear();
            }
            else if (btnAdd.Text == "Update")
            {

                int id = int.Parse(txtID.Text);

                Category guncellenecek = db.Categories
                     .Where(x => x.CategoryID == id)
                     .FirstOrDefault();
                guncellenecek.CategoryName = txtBxCategoryName.Text;
                guncellenecek.Description = txtBxDescription.Text;
                db.SaveChanges();

                catListForm = new CategoryListForm();
                
                catListForm.dGVCategory.DataSource = db.Categories.ToList();
                MessageBox.Show("Güncelleme İşleminiz Gerçekleşmiştir.");
                this.Hide();
               
               
            
                catListForm.MdiParent = Form1.ActiveForm; 
                Clear();
            }
           
        }

        private void CategoryEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}