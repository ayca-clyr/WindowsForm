using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItemStudentList_Click(object sender, EventArgs e)
        {
            StudentListForm listForm = new StudentListForm();
            listForm.Text = "Öğrenci Listesi";
            listForm.MdiParent = this;
            listForm.Show();
        }

        private void menuItemNewStudent_Click(object sender, EventArgs e)
        {
            StudentEditForm editForm = new StudentEditForm();
            editForm.Text = "Yeni Öğrenci";
            editForm.MdiParent = this;
            editForm.Show();
        }
    }
}
