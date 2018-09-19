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
    public partial class SoftwareDeveloper : Form
    {
        TaskkBLL _tBLL;
        public static int ID;
        public static int ID2;
        Taskk _taskk;
        public bool isSave = false;
        ProjectBLL _pBLL;
        EmployeeBLL _eBLL;
        Employee _emp;

        public SoftwareDeveloper()
        {
            InitializeComponent();
            _tBLL = new TaskkBLL();
            _taskk = new Taskk();
            _pBLL = new ProjectBLL();
            isSave = true;
            _eBLL = new EmployeeBLL();
            _emp = new Employee();
        }

        public SoftwareDeveloper(int id)
        {
            InitializeComponent();
            _tBLL = new TaskkBLL();
            _pBLL = new ProjectBLL();
            _taskk = _tBLL.Get(id);
            isSave = false;
            _emp = _eBLL.Get(id);
            _eBLL = new EmployeeBLL();
        }
    public void  GetProjectTestingReflesh()
        {
            dGVTaskList.DataSource = null;
            dGVTaskList.DataSource = _pBLL.GetTaskSoftWare();
            dGVTaskList.Columns[9].Visible = false;
            dGVTaskList.Columns[10].Visible = false;
            dGVTaskList.Columns[11].Visible = false;
  cBxEmployeeID.DataSource = _eBLL.GetCBxTestPost();
            cBxEmployeeID.DisplayMember = "FullName";
            cBxEmployeeID.ValueMember = "EmployeeID";
        }

        private void SoftwareDeveloper_Load(object sender, EventArgs e)
        {
            GetProjectTestingReflesh();
          
        }

        private void testEdilecekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoftwareDeveloper softWare = new SoftwareDeveloper();
            isSave = false;

            ID = (int)dGVTaskList.SelectedRows[0].Cells[0].Value;
           
            _taskk = _tBLL.Get(ID);
           


            bool result;
            if (isSave == false)
            {
                Taskk tas = _tBLL.Get(SoftwareDeveloper.ID);
                if (_taskk.SituaitionID == 2)
                {
                    _taskk.SituaitionID = 3;
                    _taskk.RequestType = "Hata";
                    tas.Situaition = _taskk.Situaition;
                    tas.RequestType = _taskk.RequestType;
                   // tas.Employee.AcoountTypeID = 4;
                    result = _tBLL.Update(tas);
                   

                    if (result)
                    {
                        MessageBox.Show("Görev Test Edilecek Durumuna Güncellenmiştir!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        GetProjectTestingReflesh();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme İşleminiz Başarısız!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
