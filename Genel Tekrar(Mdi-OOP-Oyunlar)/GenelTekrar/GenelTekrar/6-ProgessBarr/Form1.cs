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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        indirmeEkranı downloadform = new indirmeEkranı();
        public static string secilen;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            secilen = radioButton1.Text;
            downloadform.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            secilen = radioButton2.Text;
            downloadform.Show();
            this.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            secilen = radioButton3.Text;
            downloadform.Show();
            this.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            secilen = radioButton4.Text;
            downloadform.Show();
            this.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            secilen = radioButton5.Text;
            downloadform.Show();
            this.Hide();
        }
        
    }
}
