using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color color;
        int track;
        int baslaX, baslaY;
        bool islem=false;
        private Graphics g;
        Bitmap bitmap;
        private void renklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;

        }

        private void menuItemColor_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            islem = true;
            baslaX = e.X;
            baslaY = e.Y;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            islem = false;
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (islem == true)
            {
                
                g = Graphics.FromImage(bitmap);
                Pen p = new Pen(color,track);
            Point point1 = new Point(baslaX, baslaY);
            Point point2 = new Point(e.X, e.Y);

           
                g.DrawLine(p, point1, point2);
                baslaX = e.X;
                baslaY = e.Y;
                pictureBox1.Image = bitmap;

            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar1 =  (TrackBar)sender;
            track = trackBar1.Value; 

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           // color = this.BackColor;
            color = Color.White;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(600, 600);
            Graphics graph = Graphics.FromImage(bitmap);
            Pen pen = new Pen(color, trackBar1.Value);
            graph.DrawLine(pen, baslaX, baslaY, 100, 100);
            pictureBox1.Image = bitmap;
        }

        private void btnDikdörtgen_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(600, 600);
            Graphics graph = Graphics.FromImage(bitmap);
            Pen pen = new Pen(color, trackBar1.Value);
            graph.DrawRectangle(pen, baslaX, baslaY, 200, 100);
            pictureBox1.Image = bitmap;
        }

        private void btnCember_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(600, 600);
            Graphics graph = Graphics.FromImage(bitmap);
            Pen pen = new Pen(color, trackBar1.Value);
            graph.DrawEllipse(pen, baslaX, baslaY, 100, 100);
            pictureBox1.Image = bitmap;
        }

        private void btnDoldur_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(600, 600);
            Graphics graph = Graphics.FromImage(bitmap);           
            Brush pen = new SolidBrush(color);
            graph.FillEllipse(pen, baslaX, baslaY, 100, 100);
            pictureBox1.Image = bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

       
    }
}