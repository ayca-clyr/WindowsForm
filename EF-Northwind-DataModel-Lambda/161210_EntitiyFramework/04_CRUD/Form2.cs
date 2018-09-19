using _04_CRUD.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_CRUD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();
        private void Form2_Load(object sender, EventArgs e)
        {
            cmBxCategoryName.DataSource = (from c in db.Categories select c.CategoryName).ToList();
            dataGridView1.DataSource = db.Products.ToList();                                   
           
        }

        Product guncellenecek;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Ekle")
            {
                db.Products.Add(new Product { ProductName = txtBxProductName.Text, CategoryID = cmBxCategoryName.SelectedIndex });
                db.SaveChanges();
                MessageBox.Show("Ürün Eklenmiştir!");
                btnAdd.Text = "Güncelle";
            }
            else if (btnAdd.Text == "Güncelle")
            {
                if (cmBxCategoryName.SelectedIndex > -1)
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells["ProductID"].Value;
                    guncellenecek = db.Products
                                       .Where(x => x.ProductID == id)
                                       .FirstOrDefault();
                    txtBxProductName.Text = guncellenecek.ProductName;
                    cmBxCategoryName.SelectedItem = guncellenecek.CategoryID;


                }
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             if (cmBxCategoryName.SelectedIndex > -1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["CategoryID"].Value;
                Product pro = db.Products
                                  .Where(x => x.ProductID == id)
                                  .FirstOrDefault();
                db.Products.Remove(pro);
                db.SaveChanges();
                MessageBox.Show("Ürün Silinnmiştir!");
        }
    }
}
