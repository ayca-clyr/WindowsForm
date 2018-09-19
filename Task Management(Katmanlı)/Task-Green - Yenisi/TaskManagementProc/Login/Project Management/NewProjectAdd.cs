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
    public partial class NewProject : Form
    {
        ProjectBLL _projectBLL;
        public Project _project;
        CustomerBLL _customerBLL;
        EmployeeBLL _employeeBLL;
        public bool isSave = false;

        private void RefreshList()
        {
            foreach (Form item in this.MdiParent.MdiChildren)
            {
                if (item is ProjectList)
                {
                    ((ProjectList)item).GetProject();
                }
            }
        }
        public NewProject()
        {
            InitializeComponent();
            _projectBLL = new ProjectBLL();
            _customerBLL = new CustomerBLL();
            _employeeBLL = new EmployeeBLL();
            _project = new Project();
            isSave = true;
            btnSave.Text = "Kaydet";
        }
        public NewProject(int id)
        {
            InitializeComponent();
            _projectBLL = new ProjectBLL();
            _employeeBLL = new EmployeeBLL();
            _customerBLL = new CustomerBLL();
            _project = _projectBLL.Get(id);
            isSave = false;
            btnSave.Text = "Güncelle";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result;
            _project.ProjectStatus = false;
            _project.Name = txtProjectName.Text;
            _project.Description = txtProjectDesc.Text;
            _project.EmployeeID = (int)cmbEmploye.SelectedValue;
            _project.CustomerID = (int)cmbCustomer.SelectedValue;
            _project.GenerateDate = dtpProjectGeneration.Value;
            _project.DeadLine = dtpProjectDeadLine.Value;
            _project.SituaitionID = 1;

            if (isSave)
            {
                result = _projectBLL.Add(_project);
                Clear();
                if (result)
                {
                    MessageBox.Show("Işleminiz başarıyla gerçekleşmiştir!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RefreshList();
                }
                else
                {
                    MessageBox.Show("Başarısız!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();
                }
            }
            else
            {
                _project.ProjectID = ProjectList.ID;
                result = _projectBLL.Update(_project);
                Clear();
                if (result)
                {
                    RefreshList();
                    MessageBox.Show("Güncelleme İşleminiz Başarıyla Gerçekleşmiştir!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RefreshList();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Güncelleme İşleminiz Başarısız!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Clear()
        {
            txtProjectDesc.Text = "";
            txtProjectName.Text = "";
            cmbCustomer.Text = "";
            cmbEmploye.Text = "";
            dtpProjectDeadLine.Value = DateTime.Now;
            dtpProjectGeneration.Value = DateTime.Now;
        }


        private void NewProject_Load_1(object sender, EventArgs e)
        {
            cmbCustomer.Text = "";
            cmbEmploye.Text = "";
            cmbEmploye.DataSource = _employeeBLL.GetAll();
            cmbEmploye.DisplayMember = "FullName";
            cmbEmploye.ValueMember = "EmployeeID";
            cmbCustomer.DataSource = _customerBLL.GetAll();
            cmbCustomer.DisplayMember = "CompanyName";
            cmbCustomer.ValueMember = "CustomerID";
        }
    }
}
