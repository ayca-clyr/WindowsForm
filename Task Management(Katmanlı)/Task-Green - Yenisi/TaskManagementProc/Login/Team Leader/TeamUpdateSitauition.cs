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

namespace Login.Team_Leader
{
    public partial class TeamUpdateSitauition : Form
    {
        public static int ID;
        TaskkBLL _tBLL;
        public Taskk _taskk;
        ProjectBLL _pBLL;
        public bool isSave = false;
        TeamLeader tLider = new TeamLeader();
        public TeamUpdateSitauition()
        {
            InitializeComponent();
            _tBLL = new TaskkBLL();
            _taskk = new Taskk();
            _pBLL = new ProjectBLL();
            isSave = true;
        }

        public TeamUpdateSitauition(int id)
        {
            InitializeComponent();
            _tBLL = new TaskkBLL();
            _taskk = _tBLL.Get(id);
            _pBLL = new ProjectBLL();
            isSave = false;
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
            bool result;
            if (isSave == false)
            {
                Taskk taskk = _tBLL.Get(TeamLeader.ID);


                if (taskk.SituaitionID == 2 && rbDevelopment.Checked == true)
                {
                    MessageBox.Show("Proje Durumu Zaten Geliştirilecek Durumdadır!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (taskk.SituaitionID == 3 && rbUpdate.Checked == true)
                {
                    MessageBox.Show("Proje Durumu Zaten Test Edilecek Durumdadır!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (rbDevelopment.Checked == true)
                    {
                        _taskk.SituaitionID = 2;
                    }
                    else if (rbUpdate.Checked == true)
                    {
                        _taskk.SituaitionID = 3;
                    }


                    taskk.SituaitionID = _taskk.SituaitionID;
                    result = _tBLL.Update(taskk);
                    if (result)
                    {
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
