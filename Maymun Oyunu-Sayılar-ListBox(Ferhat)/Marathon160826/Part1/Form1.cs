using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            string input = txtA.Text;
            lblAMesaj.Text = "string input = txtA.Text; = " + input;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            int number;
            bool control = int.TryParse(txtB.Text, out number);
            if (control)
            {
                lblBMesaj.Text = "int number = int.Parse(txtB.Text); = " + number.ToString();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            decimal number;
            number = Convert.ToDecimal(int.Parse(txtC.Text));
            lblCMesaj.Text = "decimal number = Convert.ToDecimal(int.Parse(txtC.Text)); = " + number.ToString();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(txtD.Text);
            lblDMesaj.Text = "DateTime date = DateTime.Parse(txtD.Text); = " + date.ToString() ;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            decimal number;
            number = Convert.ToDecimal(int.Parse(txtE.Text))/100;
            lblEMesaj.Text = "number = Convert.ToDecimal(int.Parse(txtE.Text))/100; = " + number.ToString();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            decimal decimalNumber = Convert.ToDecimal(txtF.Text);
            int number =(int)Math.Round(decimalNumber);
            lblFMesaj.Text = "decimal decimalNumber = Convert.ToDecimal(txtF.Text);\nint number =(int)Math.Round(decimalNumber); = " + number.ToString();
            
        }
    }
}
