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
    public partial class TeamLeaderLogin : Form
    {
        public TeamLeaderLogin()
        {
            InitializeComponent();
        }

        private void projectListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TeamLeader teamProList = new TeamLeader();
            teamProList.MdiParent = this;
            teamProList.Show();
        }

        private void taskAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskManagement taskMan = new TaskManagement();
            taskMan.MdiParent = this;
            taskMan.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
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
