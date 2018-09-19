using BussinessLayer;
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

namespace Login
{
    public partial class ProjectList : Form
    {
        ProjectBLL _projectBLL;
        Project proc = new Project();
        public static int ID;

        public ProjectList()
        {
            InitializeComponent();
            _projectBLL = new ProjectBLL();

        }

        private void btnManagerBack_Click(object sender, EventArgs e)
        {
            ProjectManagement proc = new ProjectManagement();
            proc.Show();
            this.Close();
        }

        public void HideColumns()
        {
            dgvProjectList.Columns[10].Visible = false;
            dgvProjectList.Columns[11].Visible = false;
            dgvProjectList.Columns[12].Visible = false;
            
        }

        public void GetProject()
        {
            dgvProjectList.DataSource = null;
            dgvProjectList.DataSource = _projectBLL.ProjectGetAllList();
        }
        private void ProjectList_Load(object sender, EventArgs e)
        {
            GetProject();
            HideColumns();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProject newPro = new NewProject();
            newPro.btnSave.Text = "Güncelle";
            newPro.isSave = false;
            try
            {
                ID = (int)dgvProjectList.SelectedRows[0].Cells[0].Value;
                proc = _projectBLL.Get(ID);
                newPro.txtProjectName.Text = proc.Name;
                newPro.txtProjectDesc.Text = proc.Description;
                newPro.cmbCustomer.SelectedValue = proc.CustomerID;
                newPro.cmbEmploye.SelectedValue = proc.EmployeeID;
                newPro.dtpProjectGeneration.Value = proc.GenerateDate;
                newPro.dtpProjectDeadLine.Value = proc.DeadLine;
                newPro.MdiParent = this.MdiParent;
                newPro.Show();
            }
            catch (Exception)
            {


            }
        }
      

        private void btnCancel_Click(object sender, EventArgs e)
        {

            ID = (int)dgvProjectList.SelectedRows[0].Cells[0].Value;
            proc = _projectBLL.Get(ID);
            proc.Name = (string)dgvProjectList.SelectedRows[0].Cells["Name"].Value;
            proc.Description = (string)dgvProjectList.SelectedRows[0].Cells["Description"].Value;
            proc.DeadLine = (DateTime)dgvProjectList.SelectedRows[0].Cells["Deadline"].Value;
            proc.GenerateDate = (DateTime)dgvProjectList.SelectedRows[0].Cells["GenerateDate"].Value;
            proc.CustomerID = (int)dgvProjectList.SelectedRows[0].Cells["CustomerID"].Value;
            proc.EmployeeID = (int)dgvProjectList.SelectedRows[0].Cells["EmployeeID"].Value;
            proc.ProjectStatus = (bool)dgvProjectList.SelectedRows[0].Cells["ProjectStatus"].Value;

            if (proc.ProjectStatus == true)
            {
                proc.ProjectStatus = false;
                _projectBLL.Update(proc);
                MessageBox.Show("Proje Başarıyla Sonlanmıştır!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                GetProject();
                HideColumns();
            }
            else if (proc.ProjectStatus == false)
            {
                proc.ProjectStatus = true;
                _projectBLL.Update(proc);
                MessageBox.Show("Projeniz Aktif Hale Getirilmiştir!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                GetProject();
                HideColumns();
            }

        }
    }
}



