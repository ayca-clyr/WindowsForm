using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_ArabaYarısı
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        
        bool firstCar = true;
        bool secondCar = true;
       

        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            int bir = rnd.Next(1, 10);
            int iki = rnd.Next(1, 10);
            if (pctBxBirinci.Right <= pctBxBitis.Left)
            {
                pctBxBirinci.Left += bir;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Mavi araba kazandı");
            }
            if (pctBxİkinci.Right <= pctBxBitis.Left)
            {
                pctBxİkinci.Left += iki;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Gri araba kazandı");
            }
            
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Start();
            sayac++;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (sayac > 0 )
            {
                pctBxBirinci.Left = 0;
                pctBxİkinci.Left = 0;
                timer1.Interval = 100;
                timer1.Start();
            }
          
        }
    }
}
