using BussinessLayer;
using Entities;
using Login.Team_Leader;
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
    public partial class TeamLeader : Form
    {
        TaskkBLL _tBLL;
        Taskk _taskk;
        ProjectBLL _pBLL;
        public static int ID;

        public TeamLeader()
        {
            InitializeComponent();
            _tBLL = new TaskkBLL();
            _taskk = new Taskk();
            _pBLL = new ProjectBLL();
        }
        public TeamLeader(int id)
        {
            InitializeComponent();
            _tBLL = new TaskkBLL();
            _taskk = _tBLL.Get(id);
            _pBLL = new ProjectBLL();
        }

        public void GetProjectList()
        {
            dGVProjectList.DataSource = null;
            dGVProjectList.DataSource = _pBLL.ProjectGetAllListTeam();
            dGVProjectList.Columns[13].Visible = false;
            dGVProjectList.Columns[14].Visible = false;
            dGVProjectList.Columns[15].Visible = false;
            dGVProjectList.Columns[16].Visible = false;
        }

        public void TeamLeader_Load(object sender, EventArgs e)
        {
            GetProjectList();          
        }


        private void hataİstekEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProjectError uProTeam = new UpdateProjectError();
            uProTeam.isSave = false;
            ID = (int)dGVProjectList.SelectedRows[0].Cells[0].Value;
            _taskk = _tBLL.Get(ID);
            uProTeam.cBxProjectName.Text = _taskk.Name;
            uProTeam.txtProjectDesc.Text = _taskk.Description;
            uProTeam.cmbCustomer.SelectedValue = _taskk.Project.CustomerID;
            uProTeam.cmbEmploye.SelectedValue = _taskk.EmployeeID;
            uProTeam.dtpProjectGeneration.Value = _taskk.Project.GenerateDate;
            uProTeam.dtpProjectDeadLine.Value = _taskk.Project.DeadLine;
            uProTeam.txtRequestDesc.Text = _taskk.RequestTypeDescription;
            uProTeam.Show();

        }

        private void güncelleGeliştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamUpdateSitauition uProStation = new TeamUpdateSitauition();
            uProStation.isSave = false;
            ID = (int)dGVProjectList.SelectedRows[0].Cells[0].Value;
            _taskk = _tBLL.Get(ID);
            uProStation.Show();
        }
    }
}
