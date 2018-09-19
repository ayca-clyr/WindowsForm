using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kategoriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryListForm catList = new CategoryListForm();
            catList.MdiParent = this;
            catList.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryEditForm catEdit = new CategoryEditForm();
            catEdit.MdiParent = this;
            catEdit.Show();
        }

   
    }
}
