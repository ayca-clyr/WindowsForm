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
    public partial class UpdateProjectBusiness : Form
    {
        EmployeeBLL _eBLL;
        CustomerBLL _cBLL;
        TaskkBLL _tBLL;
        ProjectBLL _pBLL;
        public Taskk _tas;
        public bool isSave = false;
        public UpdateProjectBusiness()
        {
            InitializeComponent();
            _eBLL = new EmployeeBLL();
            _cBLL = new CustomerBLL();
            _tBLL = new TaskkBLL();
            _pBLL = new ProjectBLL();
            _tas = new Taskk();
            isSave = true;
        }

        public UpdateProjectBusiness(int id)
        {
            InitializeComponent();
            _eBLL = new EmployeeBLL();
            _cBLL = new CustomerBLL();
            _tBLL = new TaskkBLL();
            _tas = _tBLL.Get(id);
            isSave = false;
        }

        private void UpdateProjectBusiness_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }
        private void RefreshList()
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item is BusinessAnalyst)
                {
                    ((BusinessAnalyst)item).GetProjectReflesh();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool result;
            if (isSave == false)
            {
                Taskk tas = _tBLL.Get(BusinessAnalyst.ID);


                if (tas.RequestType == "İstek" && rBtnImproved.Checked == true)
                {
                    MessageBox.Show("Müşteri Talebi Zaten İstek Durumundadır!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tas.RequestType == "Hata" && rBtnError.Checked == true)
                {
                    MessageBox.Show("Müşteri Talebi Zaten Hata Durumundadır!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tas.RequestType == "Hiçbiri" && rBtnNothing.Checked == true)
                {
                    MessageBox.Show("Müşteri Talebi Zaten Eklenmemiştir!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (rBtnError.Checked == true)
                    {
                        _tas.RequestType = rBtnError.Text;

                    }
                    else if (rBtnNothing.Checked == true)
                    {
                        _tas.RequestType = rBtnNothing.Text;
                    }
                    else if (rBtnImproved.Checked == true)
                    {
                        _tas.RequestType = rBtnImproved.Text;
                    }

                    tas.RequestTypeDescription = txtProcRequestDesc.Text;
                    tas.RequestType = _tas.RequestType;
                    result = _tBLL.Update(tas);
                    if (result)
                    {
                        MessageBox.Show("Güncelleme İşleminiz Başarıyla Gerçekleşmiştir!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        RefreshList();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme İşleminiz Başarısız!");
                    }
                } }
        }
    }
}
