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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public EmployeeForm employeeForm;
        public EmployeeListForm employeeListForm;
        public ProductForm productForm;
        public ProductListForm productListForm;

        private void yeniPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                if (form is EmployeeForm)
                {
                    form.BringToFront();
                    return;
                }
            }
            foreach (Form form in this.MdiChildren)
            {
                if (form is EmployeeListForm)
                {
                    form.BringToFront();
                }
            }

            employeeForm = new EmployeeForm();
            employeeListForm = new EmployeeListForm();
            employeeForm.MdiParent = this;
            employeeForm.Show();

            employeeForm.btnEmployeeKaydet.Click += btnEmployeeKaydet_Click;
            employeeListForm.MdiParent = this;
            employeeListForm.Show();
        }

        void btnEmployeeKaydet_Click(object sender, EventArgs e)
        {
            string firstName = employeeForm._FirstName;
            string lastName = employeeForm._LastName;
            employeeListForm.LstEmployeeListForm.Items.Add(firstName + " " + lastName); 
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeListForm = new EmployeeListForm();
            employeeListForm.Show();
        }

        private void yeniÜrünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                if (form is ProductForm)
                {
                    form.BringToFront();
                    return;
                }
            }
            foreach (Form form in this.MdiChildren)
            {
                if (form is ProductListForm)
                {
                    form.BringToFront();
                }
            }

            productForm = new ProductForm();
            productListForm = new ProductListForm();
            productForm.MdiParent = this;
            productForm.Show();
            productForm.btnProductKaydet.Click += btnProductKaydet_Click;
            productListForm.MdiParent = this;
            productForm.FormClosing += productForm_FormClosing;
            productListForm.Show();
            
            ((ToolStripMenuItem)sender).Enabled = false;
            yeniÜrünToolStripMenuItem.Enabled = false;
            

            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            menuItem.Enabled = false;
           
        }

        void productForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            yeniÜrünToolStripMenuItem.Enabled = true;
        }

        void btnProductKaydet_Click(object sender, EventArgs e)
        {
            string productName = productForm._ProductName;
            string productStock = productForm._ProductStock;


            productListForm.lstProductListForm.Items.Add(productName + " " + productStock);
        }

        private void ürünListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productListForm = new ProductListForm();
            productListForm.Show();
        }

        private void basamakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void dikeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void yatayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ikonlarıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void hepsiniKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tüm pencereleri kapatmak istediğinizden emin misiniz?","Uyarı",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                foreach (Form form in this.MdiChildren)
                {
                    form.Close();
                }
            }
        }
       
    }
}
