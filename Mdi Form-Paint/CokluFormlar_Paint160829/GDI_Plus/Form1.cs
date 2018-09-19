using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_Plus
{
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLine_Click(object sender, EventArgs e)
        { 
            Bitmap bitmap = new Bitmap(600,500);
            Graphics graph = Graphics.FromImage(bitmap);  // Grafik nesnesi aç. Bitmap ile açtığım yer kadar image ayır.
            Color redColor = Color.Red;
            // Color redColor2 = Color.FromArgb(255,0,0);
            Pen redPen = new Pen(redColor,10);    // Rengini ve kalınlığını doldurduk.
            graph.DrawLine(redPen,5,5,200,200);
            pBxCiz.Image = bitmap;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            //Bitmap bitmap = new Bitmap(600, 500);
            //Graphics graph = Graphics.FromImage(bitmap);  // Grafik nesnesi aç. Bitmap ile açtığım yer kadar image ayır.
            //Color redColor = Color.Red;
            // Color redColor2 = Color.FromArgb(255,0,0);
            //Pen redPen = new Pen(redColor, 10);    // Rengini ve kalınlığını doldurduk.
            //graph.DrawRectangle(redPen, 3, 5, 300, 100);
            //pBxCiz.Image = bitmap;

            Bitmap bitmap = new Bitmap(500,500);
            Graphics graph = Graphics.FromImage(bitmap);

            Brush blueBrush = Brushes.Blue;
            Rectangle rect = new Rectangle(50, 50, 300, 300);

            graph.FillRectangle(blueBrush, rect);
            pBxCiz.Image = bitmap;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(600, 500);
            Graphics graph = Graphics.FromImage(bitmap);  // Grafik nesnesi aç. Bitmap ile açtığım yer kadar image ayır.
            Color redColor = Color.Red;
            // Color redColor2 = Color.FromArgb(255,0,0);
            Pen redPen = new Pen(redColor, 10);    // Rengini ve kalınlığını doldurduk.
            graph.DrawRectangle(redPen, 5, 5, 200, 200);
            pBxCiz.Image = bitmap;
        }

        private void btnElipse_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(600, 500);
            Graphics graph = Graphics.FromImage(bitmap);  // Grafik nesnesi aç. Bitmap ile açtığım yer kadar image ayır.
            Color redColor = Color.Red;
            // Color redColor2 = Color.FromArgb(255,0,0);
            Pen redPen = new Pen(redColor, 10);    // Rengini ve kalınlığını doldurduk.
            graph.DrawEllipse(redPen, 3, 5, 300, 200);
            pBxCiz.Image = bitmap;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(600, 500);
            Graphics graph = Graphics.FromImage(bitmap);  // Grafik nesnesi aç. Bitmap ile açtığım yer kadar image ayır.
            Color redColor = Color.Red;
            // Color redColor2 = Color.FromArgb(255,0,0);
           // Pen redPen = new Pen(redColor, 10);    // Rengini ve kalınlığını doldurduk.
            //graph.DrawEllipse(redPen, 5, 5, 200, 200);

            Pen redPen = new Pen(redColor);
            graph.DrawEllipse(redPen, 5, 5, 200, 200);
            pBxCiz.Image = bitmap;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Bitmap bitmapSilme = new Bitmap(pBxCiz.Size.Width,pBxCiz.Size.Height);
            Graphics graph = Graphics.FromImage(bitmapSilme);
            pBxCiz.Image = null;
        }
    }
}
