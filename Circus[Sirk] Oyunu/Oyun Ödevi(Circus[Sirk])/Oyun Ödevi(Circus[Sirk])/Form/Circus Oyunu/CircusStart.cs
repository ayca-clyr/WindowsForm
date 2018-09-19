using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circus_Oyunu
{
    public partial class CircusStart : Form
    {
        public CircusStart()
        {
            InitializeComponent();
        }
        int direction;
        int puan = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pBxCircus.Right < pBxBlock.Left)
            {


                if (direction == 1)
                {
                    pBxCircus.Left += -5;


                }
                else if (direction == 2)
                {
                    pBxCircus.Left += +5;


                }
                else if (direction == 3)
                {
                    pBxCircus.Top += 5;
                    pBxCircus.Left += 5;

                    timer3.Start();

                }

            }
            else
            {
                timer3.Stop();
                timer1.Stop();
                timer5.Stop();
                lblPoint.Text = puan.ToString();
                MessageBox.Show("Puanınız : ",lblPoint.Text);
                DialogResult result = MessageBox.Show("Yandınız! Yeniden Oynamak İstiyor musunuz?","",MessageBoxButtons.YesNo);
                if(result ==DialogResult.Yes)
                {
                    Application.Restart();

                }else if(result == DialogResult.No)
                {
                    Application.Exit();
                }
            }


        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();           
            timer5.Start();
 
        }

        private void btnJump_Click(object sender, EventArgs e)
        {
            pBxCircus.Top += -pBxBlock.Location.Y - 150;
            pBxCircus.Left += (pBxBlock.Right - pBxBlock.Left) + 50;

            direction = 3;

        }



        private void CircusStart_Load(object sender, EventArgs e)
        {

        }

        private void CircusStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)  // Up
            {
                direction = 1;
            }
            else if (e.KeyCode == Keys.D) // Right
            {
                direction = 2;
            }
            else if (e.KeyCode == Keys.Space) // Down
            {
                direction = 3;
                pBxCircus.Top += -pBxBlock.Location.Y - 150;
                pBxCircus.Left += (pBxBlock.Right - pBxBlock.Left) + 50;
            }
            
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            pBxCircus.Left += -5;
            direction = 1;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            pBxCircus.Left += +5;
            direction = 2;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pBxCircus.Top += +pBxBlock.Location.Y;
            pBxCircus.Location = new Point(pBxCircus.Location.X, pBxBlock.Location.Y + 140);

        }



        private void timer5_Tick(object sender, EventArgs e)
        {

            pBxBlock.Left += -5;

            if (pBxBlock.Right < pBxCircus.Left)
            {
                
                    pBxBlock.Hide();
                
                puan += 10;
                
                pBxBlock.Location = new Point(804, 80);
                pBxBlock.Show();

                pBxBlock.Left += -5;

                if(puan == 20)
                {
                    timer5.Stop();
                    timer1.Stop();
                    MessageBox.Show("Tebrikler Bölümü Geçtiniz!");
                    DialogResult result = MessageBox.Show("Yeni Bölüme Geçmek İstiyor musunuz?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        puan = 0;
                        timer5.Interval = 50;
                        timer1.Interval = 50;                       
                        pBxCircus.Location = new Point(12, 256);




                    }
                    else if (result == DialogResult.No)
                    {
                        Application.Exit();
                    }

                }
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(btnPause.Text == "PAUSE") {
            timer1.Stop ();
            timer3.Stop();
            timer5.Stop();
      btnPause.Text = "UNPAUSE";
            }else if(btnPause.Text == "UNPAUSE")
            {
                timer1.Start();
                timer3.Start();
                timer5.Start();
                btnPause.Text = "PAUSE";
            }
            

        }
    }
}
