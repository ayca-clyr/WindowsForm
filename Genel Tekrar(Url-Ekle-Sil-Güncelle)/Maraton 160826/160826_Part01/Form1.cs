using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160826_Part01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string deger1 = txtBxString.Text;
            
            MessageBox.Show(deger1);
            
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int i;
            bool durum = int.TryParse(txtBxInt.Text, out i);
            if (!durum)
            {
                MessageBox.Show("Yanlıs Deger Girdiniz!");
            }else
            MessageBox.Show(""+i);
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            decimal i;
            bool durum = decimal.TryParse(txtBxDecimal.Text,out i);
            if (!durum)
            {
                MessageBox.Show("Yanlıs Deger Girdiniz!");
            }
            else
            MessageBox.Show(""+i);
        }

        private void btnDatetime_Click(object sender, EventArgs e)
        {
            DateTime i;
            bool durum = DateTime.TryParse(txtBxDatetime.Text,out i);
            if (!durum)
            {
                MessageBox.Show("Yanlıs Deger Girdiniz!");
            }
            else
            MessageBox.Show(""+i);
        }

        private void btnYuvarla_Click(object sender, EventArgs e)
        {

            double i;
            bool durum = double.TryParse(txtBxYuvarla.Text,out i);
           i = Math.Round(i, 0);
           if (!durum)
           {
               MessageBox.Show("Yanlıs Deger Girdiniz!");
           }
           else
            MessageBox.Show(""+i);
        }

        
    }
}
