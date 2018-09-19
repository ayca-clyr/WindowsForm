using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HafızaOyunu
{
    public partial class OyunKısmı : Form
    {
        public OyunKısmı()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void OyunKısmı_Load(object sender, EventArgs e)
        {

        }

        private void OyunKısmı_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
