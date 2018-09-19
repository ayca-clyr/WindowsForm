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

    public partial class BusinessAnalyst : Form
    {
        public static int ID;
        TaskkBLL _tBLL;
        ProjectBLL _pBLL;
        TaskBusiness taskBs = new TaskBusiness();
        Taskk _taskk;
        public bool isSave = false;
        public BusinessAnalyst()
        {
            InitializeComponent();
            _tBLL = new TaskkBLL();
            _taskk = new Taskk();
            _pBLL = new ProjectBLL();
            isSave = true;
        }
        public BusinessAnalyst(int id)
        {
            InitializeComponent();
            _tBLL = new TaskkBLL();
            _taskk = _tBLL.Get(id);
            _pBLL = new ProjectBLL();
            isSave = false;
        }
        public void HideList()
        {
            dGVProjectList.Columns[11].Visible = false;
            dGVProjectList.Columns[12].Visible = false;
        }

        public void GetProjectReflesh()
        {
            dGVProjectList.DataSource = null;
            dGVProjectList.DataSource = _pBLL.ProjectGetAllListTeam();
        }
        private void BusinessAnalyst_Load(object sender, EventArgs e)
        {
            GetProjectReflesh();
            HideList();
        }

        private void btnTaskSave_Click(object sender, EventArgs e)
        {
            taskBs.Show();
            this.HideList();
        }

        private void hataİstekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProjectBusiness uProBus = new UpdateProjectBusiness();
            uProBus.isSave = false;
            ID = (int)dGVProjectList.SelectedRows[0].Cells[0].Value;
            _taskk = _tBLL.Get(ID);
            uProBus.cBxProjectName.Text = _taskk.Name;
            uProBus.txtProjectDesc.Text = _taskk.Description;
            uProBus.cmbCustomer.SelectedValue = _taskk.Project.CustomerID;
            uProBus.cmbEmploye.SelectedValue = _taskk.EmployeeID;
            uProBus.dtpProjectGeneration.Value = _taskk.Project.GenerateDate;
            uProBus.dtpProjectDeadLine.Value = _taskk.Project.DeadLine;
            uProBus.txtProcRequestDesc.Text = _taskk.RequestTypeDescription;
            uProBus.Show();
        }

        private void geliştirilecekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessAnalyst bussines = new BusinessAnalyst();
            isSave = false;
            ID = (int)dGVProjectList.SelectedRows[0].Cells[0].Value;
            _taskk = _tBLL.Get(ID);

            bool result;
            if (isSave == false)
            {
                Taskk taskk = _tBLL.Get(BusinessAnalyst.ID);
                if (_taskk.SituaitionID == 1)
                {
                    _taskk.SituaitionID = 2;
                    taskk.Situaition = _taskk.Situaition;
                    result = _tBLL.Update(taskk);
                    if (result)
                    {
                        MessageBox.Show("Güncelleme İşleminiz Başarıyla Gerçekleşmiştir!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        GetProjectReflesh();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme İşleminiz Başarısız!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_taskk.SituaitionID == 2)
                {
                    MessageBox.Show("Proje zaten geliştirilecek durumdadır.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetProjectReflesh();
                }
                else if (_taskk.SituaitionID == 3)
                {
                    MessageBox.Show("Test edilecek projeyi geliştiremezsiniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetProjectReflesh();
                }
            }
        }
    }
}
