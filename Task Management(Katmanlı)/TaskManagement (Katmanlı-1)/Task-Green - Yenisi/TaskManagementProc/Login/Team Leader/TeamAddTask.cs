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
    public partial class TaskManagement : Form
    {
        CustomerBLL _customerBLL;
        EmployeeBLL _employeeBLL;
        ProjectBLL _projectBLL;
        TaskkBLL _taskkBLL;
        public static int ID;
        SituaitionBLL _siBLL;
        bool isSave = false;
        Project _pro;

        public TaskManagement()
        {
            InitializeComponent();
            _projectBLL = new ProjectBLL();
            _customerBLL = new CustomerBLL();
            _employeeBLL = new EmployeeBLL();
            _taskkBLL = new TaskkBLL();
            _siBLL = new SituaitionBLL();
            _pro = new Project();
            isSave = true;
            btnTaskSave.Text = "Görevi Ata";
        }

        public TaskManagement(int id)
        {
            InitializeComponent();
            _projectBLL = new ProjectBLL();
            _customerBLL = new CustomerBLL();
            _employeeBLL = new EmployeeBLL();
            _taskkBLL = new TaskkBLL();
            _siBLL = new SituaitionBLL();
            _pro = _projectBLL.Get(id);
            _task = _taskkBLL.Get(id);
            isSave = false;
            btnTaskSave.Text = "Değiştir";
        }

        public void TaskList()
        {
            dGVTaskList.DataSource = null;
            dGVTaskList.DataSource = _projectBLL.ProjectGetAllListTeam();
            dGVTaskList.Columns[13].Visible = false;
            dGVTaskList.Columns[14].Visible = false;
            dGVTaskList.Columns[15].Visible = false;
            dGVTaskList.Columns[16].Visible = false;

        }
        public void TaskNotRequestList()
        {
            dGVCustomerRequestList.DataSource = null;
            dGVCustomerRequestList.DataSource = _projectBLL.GetTaskAll();
            dGVCustomerRequestList.Columns[13].Visible = false;
            dGVCustomerRequestList.Columns[14].Visible = false;
            dGVCustomerRequestList.Columns[15].Visible = false;
            dGVCustomerRequestList.Columns[16].Visible = false;

        }

        private void TaskManagement_Load(object sender, EventArgs e)
        {
            TaskList();
            TaskNotRequestList();
            cBxEmployeeID.DataSource = _employeeBLL.GetCBxTest();
            cBxManagerID.DataSource = _employeeBLL.GetCBxTestManager();
            cBxProjectName.DataSource = _projectBLL.GetAll();
            cBxSituation.DataSource = _siBLL.GetAll();

            cBxEmployeeID.DisplayMember = "FullName";
            cBxManagerID.DisplayMember = "FullName";

            cBxProjectName.DisplayMember = "Name";
            cBxSituation.DisplayMember = "Name";

            cBxSituation.ValueMember = "SituationID";
            cBxProjectName.ValueMember = "ProjectID";

            cBxEmployeeID.ValueMember = "EmployeeID";
            cBxManagerID.ValueMember = "EmployeeID";
        }
        Taskk _task;
        public void Clear()
        {
            txtBxTaskName.Text = "";
            txtBxDescription.Text = "";
            cBxEmployeeID.SelectedValue = "";
            cBxManagerID.SelectedValue = "";
            cBxProjectName.SelectedValue = "";
            cBxSituation.SelectedValue = "";
            dTPStartTime.Value = DateTime.Now;
            dTPEndTime.Value = DateTime.Now;
        }
        public void Save()
        {
            _task = new Taskk();

            _task.Name = txtBxTaskName.Text;
            _task.Description = txtBxDescription.Text;
            _task.EmployeeID = (int)cBxEmployeeID.SelectedValue;
            _task.ManagerID = (int)cBxManagerID.SelectedValue;
            _task.ProjectID = (int)cBxProjectName.SelectedValue;
            _task.SituaitionID = (int)cBxSituation.SelectedValue;
            _task.StartDate = dTPStartTime.Value;
            _task.EndDate = dTPEndTime.Value;

            bool result;
            if (isSave)
            {
                result = _taskkBLL.Add(_task);

                Clear();
                if (result)
                {
                    MessageBox.Show("Görev Başarıyla Eklenmiştir","Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    TaskList();
                    RefreshList();
                }

                else
                {
                    MessageBox.Show("Ekleme İşlemi Başarısız!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();
                }
            }
            else
            {
                Taskk taskk = _taskkBLL.Get(ID);
                taskk.Name = txtBxTaskName.Text;
                taskk.Description = txtBxDescription.Text;
                taskk.EmployeeID = (int)cBxEmployeeID.SelectedValue;
                taskk.ManagerID = (int)cBxManagerID.SelectedValue;
                taskk.ProjectID = (int)cBxProjectName.SelectedValue;
                taskk.SituaitionID = (int)cBxSituation.SelectedValue;
                taskk.StartDate = dTPStartTime.Value;
                taskk.EndDate = dTPEndTime.Value;
                result = _taskkBLL.Update(taskk);
                Clear();
                if (result)
                {
                    MessageBox.Show("Görev Atama İşlemindeki Değişiklikleriniz Başarıyla Kaydedilmiştir!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    TaskList();
                    btnTaskSave.Text = "Görevi Ata";
                    isSave = true;
                    RefreshList();
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTaskSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dGVTaskList.SelectedRows[0].Cells[0].Value;
            Taskk task = _taskkBLL.Get(id);


            DialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (DialogResult == DialogResult.Yes)
            {
                bool result = _taskkBLL.Remove(task);
                if (result)
                {
                    MessageBox.Show("İşlem Gerçekleşti", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    TaskList();
                }
                else
                {
                    MessageBox.Show("İşlem Gerçekleşmedi", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RefreshList()
        {
            foreach (Form item in this.MdiParent.MdiChildren)
            {
                if (item is TeamLeader)
                {
                    ((TeamLeader)item).GetProjectList();
                }
            }
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ID = (int)dGVTaskList.SelectedRows[0].Cells[0].Value;
            _task = _taskkBLL.Get(ID);
            txtBxTaskName.Text = _task.Name;
            txtBxDescription.Text = _task.Description;
            cBxEmployeeID.SelectedValue = _task.EmployeeID;
            cBxProjectName.SelectedValue = _task.ProjectID;
            cBxSituation.SelectedValue = _task.SituaitionID;
            cBxManagerID.SelectedValue = _task.ManagerID;
            dTPStartTime.Value = _task.StartDate;
            dTPEndTime.Value = _task.EndDate;

            btnTaskSave.Text = "Değiştir";
            isSave = false;
            RefreshList();
        }

        TeamLeader tLider = new TeamLeader();
        private void btnError_Click(object sender, EventArgs e)
        {
            RefreshList();
            this.Hide();
        }

    }
}
