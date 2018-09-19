using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Business_Alanyst
{
    public partial class BusinessAnalystLogin : Form
    {
        public BusinessAnalystLogin()
        {
            InitializeComponent();
        }
        private void projectListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessAnalyst bList = new BusinessAnalyst();
            bList.MdiParent = this;
            bList.Show();
        }
        private void taskAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskBusiness tBus =  new TaskBusiness();
            tBus.MdiParent = this;
            tBus.Show();
        }
        private void BusinessAnalystLogin_Load(object sender, EventArgs e)
        {

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
