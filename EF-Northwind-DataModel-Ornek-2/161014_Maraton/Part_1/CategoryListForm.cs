using Part_1.Data;
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
    public partial class CategoryListForm : Form
    {
        public CategoryListForm()
        {
            InitializeComponent(); 
           
        }
 NorthwindEntities db = new NorthwindEntities(); 
       
      CategoryEditForm editForm ;
        
      

        List<Category> category = new List<Category>();
        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            dGVCategory.DataSource = db.Categories.ToList();
        }

        private void Yenile(List<Category> name)
        {

            dGVCategory.DataSource = null;
            dGVCategory.DataSource = name;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.CategoryName = txtBxCategoryName.Text;

            List<Category> result = (
                from c in db.Categories
                where c.CategoryName.ToLower().Contains(cat.CategoryName)
                orderby c.CategoryName
                select c).ToList();
            Yenile(result);
        }
       public Category guncellenecek;
        private void txtBxCategoryName_TextChanged(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.CategoryName = txtBxCategoryName.Text;

            List<Category> result = (
                from c in db.Categories
                where c.CategoryName.ToLower().Contains(cat.CategoryName)
                orderby c.CategoryName
                select c).ToList();
            Yenile(result);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dGVCategory.SelectedRows.Count > 0)
            {
         

               int id = (int)dGVCategory.SelectedRows[0].Cells["CategoryID"].Value;
                Category cat = db.Categories
                    .Where(x => x.CategoryID == id)
                    .FirstOrDefault();

                db.Categories.Remove(cat);
            db.SaveChanges();
             }
            MessageBox.Show("Silme İşleminiz Gerçekleşti!");

            dGVCategory.DataSource = db.Categories.ToList();
        }
        
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            editForm = new CategoryEditForm();
      
            int id = (int)dGVCategory.SelectedRows[0].Cells["CategoryID"].Value;

            guncellenecek = db.Categories
                .Where(x => x.CategoryID == id)
                .FirstOrDefault();
            editForm.txtID.Text = guncellenecek.CategoryID.ToString();
            editForm.txtBxCategoryName.Text = guncellenecek.CategoryName;
            editForm.txtBxDescription.Text = guncellenecek.Description;
            editForm.btnAdd.Text = "Update";       
            editForm.MdiParent = Form1.ActiveForm;
            editForm.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
