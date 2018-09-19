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
using System.Data.SqlClient;

namespace _04_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void Form1_Load(object sender, EventArgs e)
        {


            //dGVCategories.DataSource = (from c in db.Categories
            //                            select c).ToList();
            dGVCategories.DataSource = db.Categories.ToList();
        }

        private void GetCategories()
        {

            dGVCategories.DataSource = db.Categories.ToList();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 1.Yöntem Instance alarak Ekleme
            Category cat = new Category();
            cat.CategoryName = txtBxCategoryName.Text;
            cat.Description = txtBxDescription.Text;

            // db.Categories.Add(cat);
            db.SaveChanges();
            //MessageBox.Show("Ürün Instance alarak Eklenmiştir!");
            Temizle();
            GetCategories();
            #endregion

            #region 2.Yöntem Tek Satırda Ekleme
            // db.Categories.Add(new Category { CategoryName = txtBxCategoryName.Text, Description = txtBxDescription.Text });
            db.SaveChanges();
            Temizle();
           // MessageBox.Show("Ürün Tek Satırda Eklenmiştir!");
            GetCategories();
            #endregion

            #region 3.Yöntem Sorgu ile Ekleme
            //db.Database.ExecuteSqlCommand("insert into Categories(CategoryName,Description) values (@ad,@desc)", new SqlParameter("@ad",txtBxCategoryName.Text), new SqlParameter("@desc",txtBxDescription.Text));
            Temizle();
           // MessageBox.Show("Ürün Sorgu ile Eklenmiştir!");
            #endregion

            #region 4.Yöntem SP ile Ekleme

           // db.sp_CategoryAdd(txtBxCategoryName.Text, txtBxDescription.Text);
            Temizle();
           // MessageBox.Show("Ürün SP ile Eklenmiştir!");

            GetCategories();
            #endregion
        }

        Product guncellenek;
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
           #region Silme // Datada seçili olanın ID'sini id'ye attık. O id'ye ait detaylarını cat'a attık. Sonrada bunu sildik.
            if (dGVCategories.SelectedRows.Count > 0)
            {
                int id = (int)dGVCategories.SelectedRows[0].Cells["CategoryID"].Value;
                Category cat = db.Categories
                                  .Where(x => x.CategoryID == id)
                                  .FirstOrDefault();
                db.Categories.Remove(cat);
                db.SaveChanges();
                MessageBox.Show("Ürün Silinnmiştir!");
                GetCategories();
            #endregion

            }
        }

        Category guncellenecek;
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Güncelle
            if (dGVCategories.SelectedRows.Count > 0)
            {
                int id = (int)dGVCategories.SelectedRows[0].Cells["CategoryID"].Value;
               guncellenecek =  db.Categories
                                  .Where(x => x.CategoryID == id)
                                  .FirstOrDefault();
                txtBxCategoryName.Text = guncellenecek.CategoryName;
                txtBxDescription.Text = guncellenecek.Description;
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                GetCategories();
            #endregion

            }
        }


        private void Temizle()
        {
            txtBxCategoryName.Text = "";
            txtBxDescription.Text = "";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            guncellenecek.CategoryName = txtBxCategoryName.Text;
            guncellenecek.Description = txtBxDescription.Text;
            db.SaveChanges();

            Temizle();
            MessageBox.Show("Güncelleme İşleminiz Tamamlandı!");
            btnSave.Visible = true;
            btnUpdate.Visible = false;

            GetCategories();
        }
    }
}