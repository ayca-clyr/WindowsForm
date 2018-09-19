using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ProjectManagement : Form
    {
        public ProjectManagement()
        {
            InitializeComponent();
        }

        private void yeniProjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProject project = new NewProject();
            project.MdiParent = this;
            project.Show();
        }

        private void projeListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectList proclist = new ProjectList();
            proclist.MdiParent = this;
            proclist.Show();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerRegistery customerReg = new CustomerRegistery();
            customerReg.MdiParent = this;
            customerReg.Show();
        }

        private void projeGöreviAtaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskManagement taskm = new TaskManagement();
            taskm.MdiParent = this;
            taskm.Show();
        }

        private void çalışanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.MdiParent = this;
            employee.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            DialogResult = MessageBox.Show("Uygulamadan Çıkmak İstediğinizden emin misiniz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (DialogResult == DialogResult.Yes)
            {
                lg.Show();
                this.Hide();
            }

        }
    }
}
