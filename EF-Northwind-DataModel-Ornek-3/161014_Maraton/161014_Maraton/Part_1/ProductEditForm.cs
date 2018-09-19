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
    public partial class ProductEditForm : Form
    {
        public ProductEditForm()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();
        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            txtBxProductID.Enabled = false;
            cBxCategoryID.DataSource = (from c in db.Categories select c).ToList();
            cBxSupplierID.DataSource = (from s in db.Suppliers select s).ToList();
            cBxCategoryID.DisplayMember = "CategoryName";
            cBxCategoryID.ValueMember = "CategoryID";
            cBxSupplierID.DisplayMember = "CompanyName";
            cBxSupplierID.ValueMember = "SupplierID";

        }

        private void Clear()
        {
            cBxSupplierID.Text = "";
            txtBxProductID.Text = "";
            txtBxProductName.Text = "";
            txtBxStock.Text = "";
            cBxCategoryID.Text = "";
            txtBxPrice.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();


        }
        Product guncellenecek;
        ProductListForm proListForm;
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (btnAdd.Text == "Add")
            {

                db.Database.ExecuteSqlCommand("insert into Products (ProductName,CategoryID,SupplierID,UnitsInStock,UnitPrice) values(@proName,@catID,@supID,@stock,@price)", new SqlParameter("@proName", txtBxProductName.Text), new SqlParameter("@catID", (cBxCategoryID.SelectedIndex + 1).ToString()), new SqlParameter("@supID", (cBxSupplierID.SelectedIndex + 1).ToString()), new SqlParameter("@stock", int.Parse(txtBxStock.Text)), new SqlParameter("@price", decimal.Parse(txtBxPrice.Text)));
                MessageBox.Show("Kategori Eklenmiştir!");
           
          
                Clear();
            }
            else if (btnAdd.Text == "Update")
            {

                int id = int.Parse(txtBxProductID.Text);

                Product guncellenecek = db.Products
                     .Where(x => x.ProductID == id)
                     .FirstOrDefault();
                guncellenecek.ProductName = txtBxProductName.Text;
                guncellenecek.CategoryID = cBxCategoryID.SelectedIndex + 1;
                guncellenecek.SupplierID = cBxSupplierID.SelectedIndex + 1;
                guncellenecek.UnitsInStock = Int16.Parse(txtBxStock.Text);
                guncellenecek.UnitPrice = decimal.Parse(txtBxPrice.Text);
                db.SaveChanges();

                proListForm = new ProductListForm();
             
                proListForm.dGVProduct.DataSource = db.Products.ToList();
                MessageBox.Show("Güncelleme İşleminiz Gerçekleşmiştir.");
                this.Hide();



                proListForm.MdiParent = NorthwindMainForm.ActiveForm;
                Clear();
            }
        }
    }
}