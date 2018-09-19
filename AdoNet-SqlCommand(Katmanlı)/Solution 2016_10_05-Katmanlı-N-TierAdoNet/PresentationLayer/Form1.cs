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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryEdit categoryEdit = new CategoryEdit();
            categoryEdit.MdiParent = this;
            categoryEdit.Size = this.Size;
            categoryEdit.WindowState = FormWindowState.Maximized;
            categoryEdit.Show();
        }

        private void kategoriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryList categoryList = new CategoryList();
            categoryList.MdiParent = this;
            categoryList.Size = this.Size;
            categoryList.WindowState = FormWindowState.Maximized;
            categoryList.Show();
        }
    }
}
