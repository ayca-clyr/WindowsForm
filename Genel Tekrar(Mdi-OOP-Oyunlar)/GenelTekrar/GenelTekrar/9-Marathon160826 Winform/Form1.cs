using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Marathon160826_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDecimal2Hane_Click(object sender, EventArgs e)
        {
            decimal input = Convert.ToDecimal(txtBxDec2.Text);
            input = decimal.Round(input, 2);
            MessageBox.Show(input.ToString());
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(txtBxDouble.Text);
            MessageBox.Show(input.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string input = txtBxString.Text;
            MessageBox.Show(input);
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(txtBxInt.Text);
            MessageBox.Show(input.ToString());
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            decimal input = Convert.ToDecimal(txtBxDecimal.Text);
            MessageBox.Show(input.ToString());

        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            DateTime input = Convert.ToDateTime(txtBxDate.Text);
            MessageBox.Show(input.ToShortDateString());
        }
    }
}
