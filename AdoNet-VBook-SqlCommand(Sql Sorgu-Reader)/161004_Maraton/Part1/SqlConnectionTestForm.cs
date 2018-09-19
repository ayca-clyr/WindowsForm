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

namespace Part1
{
    public partial class SqlConnectionTestForm : Form
    {
        public SqlConnectionTestForm()
        {
            InitializeComponent();
        }

     
        private void bağlantıAçKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conneciton connection = new Conneciton();
            connection.MdiParent = this;
            connection.Show();
        }

        private void categoriKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryEditForm catEdit = new CategoryEditForm();
            catEdit.MdiParent = this;
            catEdit.Show();
        }

        private void categoriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryListForm catList = new CategoryListForm();
            catList.MdiParent = this;
            catList.Show();
        }

   

        private void yazarİşlemleriToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AuthorAddForm auList = new AuthorAddForm();
            auList.MdiParent = this;
            auList.Show();

        }

        private void authorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorListForm auList = new AuthorListForm();
            auList.MdiParent = this;
            auList.Show();
        }

      

     

      

       
    }
}
