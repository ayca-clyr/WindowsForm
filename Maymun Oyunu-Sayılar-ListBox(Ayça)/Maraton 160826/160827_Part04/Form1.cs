using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace _160827_Part04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i, j;
        Button btn = new Button();
        bool durum = true;
        int sayac = 1;

        private void btnStart_Click(object sender, EventArgs e)

        {
            panel1.Show();
            timer1.Start();
            timer1.Interval = 700;
        }

        private void btn_MouseEnter(object sende, MouseEventArgs e)
        {
            lblSkor.Text = (++sayac).ToString();


            if (lblZaman.Text == "0")
            {
                timer1.Stop();
                MessageBox.Show("Skorunuz: " + lblSkor.Text);
            }
            else
            {
                lblZaman.Text = (Convert.ToInt32(lblZaman.Text) - 1).ToString();
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn.Enabled = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(btnPause.Text == "PAUSE") { 
            timer1.Stop();
            btnPause.Text = "DEVAM";
            }else if(btnPause.Text == "DEVAM")
            {
                btnPause.Text ="PAUSE";
                timer1.Start();
            }  
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            
            foreach (Control paneldekiler in panel1.Controls)
            {
                if(paneldekiler is Button){
                    timer1.Enabled = false;
                    panel1.Hide();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (durum == true)
            {
                btn.Text = "Tokmak Vur";
                btn.ForeColor = Color.Yellow;
                durum = false;
            }


            lblZaman.Select();


            Random r = new Random();


            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    btn.Visible = true;
                    btn.Tag = "GizliVeri";

                    panel1.Controls.Add(btn);
                    btn.BackColor = Color.Red;

                }



                btn.Size = new Size(80, 60);
                btn.Location = new Point(r.Next(1, 5) * 80, r.Next(1, 5) * 60);



            }

            btn.Enabled = true;



            //            Random r = new Random();          
            //            for (i = 0; i < 5; i++)
            //            {
            //                for (j = 0; j < 5; j++)
            //                {
            //                    btn.Visible = true;
            //                    //btn.Size = new Size(80, 60);
            //                    //btn.Location = new Point(j * 80, i * 60);
            //                    btn.Tag = "GizliVeri";

            //                    //btn.Click += YeniOlusturulanButonunKliclOlayi;
            //                    panel1.Controls.Add(btn);
            //                    btn.BackColor = Color.Yellow;

            //                }



            //                btn.Size = new Size(80, 60);
            //                btn.Location = new Point(r.Next(1, 5) * 80, r.Next(1, 5) * 60);



            //            }

            //btn.Enabled = true;

        }

    }

}



