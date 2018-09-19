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
        private void ProductListForm_Load(object sender, EventArgs e)
        {
            cBxCategoryName.DataSource = (from c in db.Categories select c).ToList();
            cBxCategoryName.DisplayMember = "CategoryName";
            cBxCategoryName.ValueMember = "CategoryID";
            cBxCategoryName.Text = "";
            dGVProduct.DataSource = db.Products.ToList();

        }
        List<Product> category = new List<Product>();
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
    }
}
