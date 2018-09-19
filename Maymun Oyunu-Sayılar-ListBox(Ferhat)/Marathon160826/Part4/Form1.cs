using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part4
{
    public partial class Form1 : Form
    {
        int pattern = 3;
        int second = 60;
        int level = 0;
        int mode = 0;
        int successful = 0;
        int unsuccessful = 0;
        int rndButton;
        Random btnRnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton5X5_CheckedChanged(object sender, EventArgs e)
        {
            pattern = 5;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            successful = unsuccessful = 0;
            lblBasarili.Text = lblBasarisiz.Text= "0";
            panel1.Controls.Clear();
            for (int i = 0; i < pattern; i++)
            {
                for (int j = 0; j < pattern; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(80, 80);
                    btn.Location = new Point(i * 85, j * 85);
                    btn.Name = "btnTik" + ((i * pattern) + j);
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Click += btnTik;
                    this.panel1.Controls.Add(btn);
                }
            }
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void btnTik(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
           
            if (btn.BackgroundImage!=null)
            {
                successful = int.Parse(lblBasarili.Text);
                successful += 1;
                lblBasarili.Text= successful.ToString();
                btn.BackgroundImage = null;
            }
            else
            {
                Button btn2 = (Button)panel1.Controls[rndButton];
                unsuccessful = int.Parse(lblBasarisiz.Text);
                unsuccessful += 1;
                lblBasarisiz.Text = unsuccessful.ToString();
                btn2.BackgroundImage = null;
            }
        }

        private void radioButton4X4_CheckedChanged(object sender, EventArgs e)
        {
            pattern = 4;
        }

        private void radioButton3X3_CheckedChanged(object sender, EventArgs e)
        {
            pattern = 3;
        }

        private void radioButton1DK_CheckedChanged(object sender, EventArgs e)
        {
            second = 60;
        }

        private void radioButton2DK_CheckedChanged(object sender, EventArgs e)
        {
            second = 120;
        }

        private void radioButton3DK_CheckedChanged(object sender, EventArgs e)
        {
            second = 180;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var item in panel1.Controls)
            {
                Button btn = (Button)item;
                btn.BackgroundImage = null;
            }
            int piece = (successful / 10)+1;
            for (int i = 0; i < piece; i++)
            {
                rndButton = btnRnd.Next(0, (pattern * pattern));
                Button btn2 = (Button)panel1.Controls[rndButton];
                btn2.BackgroundImage = Properties.Resources.monkey;
            }
        }

        private void radioButtonKolay_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1500;
        }

        private void radioButtonOrta_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1100;
        }

        private void radioButtonZor_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 700;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (second>0)
            {
                second--;
                lblSecond.Text = second.ToString();
            }
            else
            {
                foreach (var item in panel1.Controls)
                {
                    Button btn = (Button)item;
                    btn.BackgroundImage = null;
                }
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("Başarılı Vurma = " + successful + "\n" + "Karavana = " + unsuccessful, "Sonuçlar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Duraklat")
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                button2.Text = "Devam Et";
            }
            else if (button2.Text == "Devam Et")
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                button2.Text = "Duraklat";
            }
        }
    }
}
