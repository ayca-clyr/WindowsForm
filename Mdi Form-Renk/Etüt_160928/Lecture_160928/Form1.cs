using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_160928
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExample_Click(object sender, EventArgs e)
        {
            if (btnExample.Enabled == true)
            {
                btnExample.Text = "Button text changed";
            }

            //btnExample.Text = "Button text changed";  >>>>>>>Alternatif
        }
    }
}
