using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_MDIForms
{
    public partial class ProductForm : Form
    {
        public string _ProductName = string.Empty;
        public string _ProductStock = string.Empty;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            _ProductName = txtBxProductÜrünAdı.Text;
            _ProductStock = txtBxProductStokSayı.Text;
        }
    }
}
