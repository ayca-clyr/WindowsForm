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
    public partial class UpdateProjectError : Form
    {
        EmployeeBLL _eBLL;
        CustomerBLL _cBLL;
        ProjectBLL _pBLL;
        TaskkBLL _tBLL;
        public Taskk _taskk;
        public bool isSave = false;
        public UpdateProjectError()
        {
            InitializeComponent();

            _eBLL = new EmployeeBLL();
            _cBLL = new CustomerBLL();
            _tBLL = new TaskkBLL();
            _pBLL = new ProjectBLL();
            _taskk = new Taskk();
            isSave = true;


        }
        public UpdateProjectError(int id)
        {
            InitializeComponent();
            _eBLL = new EmployeeBLL();
            _cBLL = new CustomerBLL();
            _tBLL = new TaskkBLL();
            _taskk = _tBLL.Get(id);
            isSave = false;
        }


        private void UpdateProjectTeam_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void RefreshList()
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item is TeamLeader)
                {
                    ((TeamLeader)item).GetProjectList();
                }
            }
        }

     
        private void btnSave_Click(object sender, EventArgs e)
        {
            RefreshList();
            bool result;
            if (isSave == false)
            {
                Taskk taskk = _tBLL.Get(TeamLeader.ID);

                if (taskk.RequestType == "İstek" && rBtnImproved.Checked == true)
                {
                    MessageBox.Show("Müşteri Talebi Zaten İstek Durumundadır!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (taskk.RequestType == "Hata" && rBtnError.Checked == true)
                {
                    MessageBox.Show("Müşteri Talebi Zaten Hata Durumundadır!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (taskk.RequestType == "Hiçbiri" && rBtnNothing.Checked == true)
                {
                    MessageBox.Show("Müşteri Talebi Zaten Eklenmemiştir!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (rBtnError.Checked == true)
                    {
                        _taskk.RequestType = rBtnError.Text;

                    }
                    else if (rBtnNothing.Checked == true)
                    {
                        _taskk.RequestType = rBtnNothing.Text;
                    }
                    else if (rBtnImproved.Checked == true)
                    {
                        _taskk.RequestType = rBtnImproved.Text;
                    }

                    taskk.RequestType = _taskk.RequestType;
                    taskk.RequestTypeDescription = txtRequestDesc.Text;
                    result = _tBLL.Update(taskk);
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

        }
    }
}

