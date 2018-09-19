using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Forms
{
    public partial class StockAddForm : Form
    {
        public StockAddForm()
        {
            InitializeComponent();
        }
        public int _stockMiktarı;
        private void btnSaveStock_Click(object sender, EventArgs e)
        {
            _stockMiktarı =int.Parse(txtBxStockAdd.Text);
        }
    }
}
