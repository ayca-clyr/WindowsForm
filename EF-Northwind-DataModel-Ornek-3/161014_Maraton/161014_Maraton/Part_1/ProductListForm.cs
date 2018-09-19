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
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        ProductEditForm proForm;
        List<Product> product = new List<Product>();
        public Product guncellenecek;

        private void ProductListForm_Load(object sender, EventArgs e)
        {

            cBxCategoryName.DataSource = (from c in db.Categories select c).ToList();
            cBxCategoryName.DisplayMember = "CategoryName";
            cBxCategoryName.ValueMember = "CategoryID";
            cBxCategoryName.Text = "";
            dGVProduct.DataSource = db.Products.ToList();

        }

        private void Yenile(List<Product> name)
        {

            dGVProduct.DataSource = null;
            dGVProduct.DataSource = name;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.ProductName = txtBxProductName.Text;

            List<Product> result = (
                from p in db.Products
                where p.ProductName.ToLower().StartsWith(pro.ProductName)
                orderby p.ProductName
                select p).ToList();
            Yenile(result);
        }

        private void cBxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBxCategoryName.SelectedIndex > -1)
            {
                Product pro = new Product();
                pro.CategoryID = cBxCategoryName.SelectedIndex + 1;
                List<Product> result = (
                     from p in db.Products
                     where p.CategoryID.ToString().Contains(pro.CategoryID.ToString())
                     orderby p.CategoryID
                     select p).ToList();

                Yenile(result);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dGVProduct.SelectedRows.Count > 0)
            {


                int id = (int)dGVProduct.SelectedRows[0].Cells["ProductID"].Value;
                Product pro = db.Products
                    .Where(x => x.ProductID == id)
                    .FirstOrDefault();

                db.Products.Remove(pro);
                db.SaveChanges();
            }
            MessageBox.Show("Silme İşleminiz Gerçekleşti!");

            dGVProduct.DataSource = db.Products.ToList();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proForm = new ProductEditForm();
            proForm.txtBxProductID.Enabled = false;
            int id = (int)dGVProduct.SelectedRows[0].Cells["ProductID"].Value;
            var query = (from p in db.Products
                         join c in db.Categories on p.CategoryID equals c.CategoryID
                         where p.ProductID == id
                         select new
                         {
                             c.CategoryName
                         }).FirstOrDefault();


            guncellenecek = db.Products
                .Where(x => x.ProductID == id)
                .FirstOrDefault();
            proForm.txtBxProductID.Text = guncellenecek.ProductID.ToString();
            proForm.txtBxProductName.Text = guncellenecek.ProductName;
            proForm.txtBxStock.Text = guncellenecek.UnitsInStock.ToString();
            proForm.cBxCategoryID.Text = query.ToString();
            proForm.cBxSupplierID.Text = (guncellenecek.Supplier.CompanyName).ToString();
            proForm.txtBxPrice.Text = (Convert.ToString(guncellenecek.UnitPrice));




            proForm.btnAdd.Text = "Update";
            proForm.MdiParent = NorthwindMainForm.ActiveForm;
            proForm.Show();
        }
    }
}
