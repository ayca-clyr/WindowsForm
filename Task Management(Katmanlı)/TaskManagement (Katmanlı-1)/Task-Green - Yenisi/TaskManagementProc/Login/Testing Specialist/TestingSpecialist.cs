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
    public partial class TestingSpecialist : Form
    {
        ProjectBLL _pBLL;
        Project _project;
        public static int ID;
        TaskkBLL _tBLL;
        Taskk _task;
        EmployeeBLL _eBLL;
        Employee _emp;
        public TestingSpecialist()
        {
            InitializeComponent();
            _pBLL = new ProjectBLL();
            _project = new Project();
            _tBLL = new TaskkBLL();
            _task = new Taskk();
            _eBLL = new EmployeeBLL();
            _emp = new Employee();
        }
        public TestingSpecialist(int id)
        {
            InitializeComponent();
            _pBLL = new ProjectBLL();
            _tBLL = new TaskkBLL();
            _task = _tBLL.Get(id);
            _project = _pBLL.Get(id);
            _eBLL = new EmployeeBLL();
            _emp = _eBLL.Get(id);
        }

        public void TaskkList()
        {
            dGVTaskList.DataSource = null;
            dGVTaskList.DataSource = _pBLL.GetTaskTesting();
            dGVTaskList.Columns[9].Visible = false;
            dGVTaskList.Columns[10].Visible = false;
            dGVTaskList.Columns[11].Visible = false;
            dGVTaskList.Columns[12].Visible = false;
            cBxEmployeeID.DataSource = _eBLL.GetCBxTestingPost();
            cBxEmployeeID.DisplayMember = "FullName";
            cBxEmployeeID.ValueMember = "EmployeeID";

        }
        private void TestingSpecialist_Load(object sender, EventArgs e)
        {

            TaskkList();
        }

        private void atamaİşleminiGerçekleştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestingSpecialist test = new TestingSpecialist();
            _task.TaskID = (int)dGVTaskList.SelectedRows[0].Cells[0].Value;
            ID = _task.TaskID;
            _task = _tBLL.Get(ID);
            int id = (int)_task.ProjectID;
            _project = _pBLL.Get(id);
            Taskk task = _tBLL.Get(TestingSpecialist.ID);


            if (_task.RequestType == "Hata")
            {
                _task.SituaitionID = 2;

               // task.Employee.AcoountTypeID = 5;

            }
            else if (_task.RequestType == "İstek")
            {
                _task.SituaitionID = 1;
               // _task.Employee.AcoountTypeID = 2;
            }

            task.SituaitionID = _task.SituaitionID;
           // task.Employee.AcoountTypeID = _task.Employee.AcoountTypeID;

            bool result;
            result = _tBLL.Update(task);
            if (result)
            {
                MessageBox.Show("Yazılım uzmanına geri bildirim sağlanmıştır.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TaskkList();
            }
            else
            {
                MessageBox.Show("Beklenmedik bir hata oluştu.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TaskkList();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
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
