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
    public partial class ProductEditForm : Form
    {
        public ProductEditForm()
        {
            InitializeComponent();
            _proBLL = new ProductBLL();
            pro = new Product();
            isSave = true;
            btnSave.Text = "Save";
        }

        public ProductEditForm(int id )
        {
            InitializeComponent();
            _proBLL = new ProductBLL();
            pro = new Product();
            pro = _proBLL.Get(id);
            isSave = false;
            btnSave.Text = "Update";

        }
        ProductBLL _proBLL;
        Product pro;
        bool isSave = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result;

            pro.ProductName = txtBxProductName.Text;
            pro.UnitsInStock = Int16.Parse(txtBxStock.Text);
            pro.UnitPrice = decimal.Parse(txtBxPrice.Text);

            if (isSave)
            {
                result = _proBLL.Insert(pro);
            }
            else
            {
                result = _proBLL.Update(pro);
            }
            if (result == true)
            {
                MessageBox.Show("İşlem Başarıyla Gerçekleşti!");
            }
            else
            {
                MessageBox.Show("İşlem Başarısız!");
            }
            
        }

        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            if (isSave == false)
            {
                txtBxProductName.Text = pro.ProductName;
                txtBxStock.Text = ((int)pro.UnitsInStock).ToString();
                txtBxPrice.Text = ((int)pro.UnitPrice).ToString();

            }
        }
    }
}
