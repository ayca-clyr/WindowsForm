using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Köstebek_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rast = new Random();
        int gpuan = 0;
        int sayac = 21;
        public void butonlar()
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            for (int i = 0; i < 54; i++)
            {
                Button btn = new Button();
                btn.Width = 60;
                btn.Height = 60;
                btn.Image = Image.FromFile("köstebek1.png");
                btn.Text = (i + 1).ToString();
                flowLayoutPanel1.Controls.Add(btn);
                btn.Tag = i.ToString();
                btn.Click += btn_Click;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            butonlar();
        }
        

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (int.Parse(btn.Tag.ToString()) == 1)
                gpuan++;
            else
                gpuan--;
            label1.Text ="puan : " +gpuan.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = rast.Next(0, 54);
             foreach(var a in flowLayoutPanel1.Controls)
             {
                 Button btn = a as Button;
                 if(btn.Text== sayi.ToString())
                 {
                     btn.Image = Image.FromFile("köstebek.gif");
                     btn.Tag = 1;
                 }
                 else
                 {
                     btn.Tag=2;
                     btn.Image = Image.FromFile("köstebek1.png");
                     
                 }
             }
             if (sayac == 0)
                 timer1.Enabled = false;
        }

        
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac--;
            label2.Text = "Kalan Süre : " + sayac.ToString();
            if(sayac==0)
            {
                timer2.Enabled = false;
                flowLayoutPanel1.Enabled = false;
                MessageBox.Show("Süreniz bitti puanınız : " + gpuan);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Puan : 0";
            gpuan = 0;
            sayac = 21;
            butonlar();
            flowLayoutPanel1.Enabled = true;
            timer1.Enabled = true;
            timer2.Enabled = true;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
