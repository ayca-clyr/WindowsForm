using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_ProgessBarr
{
    public partial class indirmeEkranı : Form
    {
        public indirmeEkranı()
        {
            InitializeComponent();
        }

        private void indirmeEkranı_Load(object sender, EventArgs e)
        {
            lblSuanZaman.Text = DateTime.Now.ToLongTimeString();
            lblİndirme.Text = Form1.secilen + "indirilmektedir.";
            timer1.Enabled = true;
        }

        private void btnBackHomePage_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnDownloadIptal_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBar1.Value = 0;
            MessageBox.Show(Form1.secilen + " İndirme işlemi iptal edildi.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.SlateBlue;
            progressBar1.Increment(1);
        }
    }
}
