using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_YönTusları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int direksiyon;

        private void btnKuzeyBatı_Click(object sender, EventArgs e)
        {
            direksiyon = 1;
            //btnKuzeyBatı.Top-=10;
            //btnKuzeyBatı.Left -= 10;
        }

        private void btnKuzey_Click(object sender, EventArgs e)
        {
            direksiyon = 2;
            //btnKuzey.Top -= 10;
        }

        private void btnKuzeyDogu_Click(object sender, EventArgs e)
        {
            direksiyon = 3;
            //btnKuzeyBatı.Top -= 10;
            //btnKuzeyBatı.Left += 10;
        }

        private void btnBatı_Click(object sender, EventArgs e)
        {
            direksiyon = 4;
            //btnBatı.Left -= 10;
        }

        private void btnDogu_Click(object sender, EventArgs e)
        {
            direksiyon = 5;
            //btnDogu.Left += 10;
        }

        private void btnGuneyBatı_Click(object sender, EventArgs e)
        {
            direksiyon = 6;
            //btnGuneyBatı.Top+=10;
            //btnGuneyBatı.Left += 10;
        }

        private void btnGuney_Click(object sender, EventArgs e)
        {
            direksiyon = 7;
            //btnGuney.Top += 10;
        }

        private void btnGuneyDogu_Click(object sender, EventArgs e)
        {
            direksiyon = 8;
            //btnGuneyDogu.Top += 10;
            //btnGuneyDogu.Left += 10;
        }

        private void btnX_Click(object sender, EventArgs e)
        {

        }
        void Hareket()
        {
            switch (direksiyon)
            {
                case 1:
             btnX.Top-=10;
             btnX.Left -= 10;
             break;
                case 2 :
             btnX.Top -= 10;
             break;
                case 3:
             btnX.Top -= 10;
             btnX.Left += 10;
             break;
                case 4:
             btnX.Left -= 10;
             break;
                case 5:
             btnX.Left += 10;
             break;
                case 6:
             btnX.Top += 10;
             btnX.Left -= 10;
             break;
                case 7:
             btnX.Top += 10;
             break;
                case 8:
             btnX.Top += 10;
             btnX.Left += 10;
             break;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hareket();
        }

        private void btnX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                direksiyon = 2;
            }
            else if (e.KeyCode == Keys.D)
            {
                direksiyon = 5;
            }
            else if (e.KeyCode == Keys.S)
            {
                direksiyon = 7;
            }
            else if (e.KeyCode == Keys.A)
            {
                direksiyon = 4;
            }
            else if (e.KeyCode == Keys.E)
            {
                direksiyon = 3;
            }
        }
    }
}
