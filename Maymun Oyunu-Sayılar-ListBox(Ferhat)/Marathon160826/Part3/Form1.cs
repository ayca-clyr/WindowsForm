using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList frame = new ArrayList();
        Frame f = new Frame();
        int index = 0;
        private void btnBack_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void BackImages()
        {
            index--;
            if (index >= 0)
            {
                f = (Frame)frame[index];
                pBoxImages.ImageLocation = f.ImageURL;
            }
            if (index < 0)
            {
                index = frame.Count - 1;
                f = (Frame)frame[index];
                pBoxImages.ImageLocation = f.ImageURL;
            }
            timer4.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Frame f = new Frame();
            f.Name = txtName.Text;
            f.ImageURL = txtURL.Text;
            frame.Add(f);
            cboxImages.Items.Add(f.Name);
            txtURL.Text = txtName.Text = "";
            ShowPicture();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selection = cboxImages.SelectedIndex;
            frame.RemoveAt(selection);
            cboxImages.Items.RemoveAt(selection);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ShowPicture()
        {
            if (frame.Count > 0)
            {
                f = (Frame)frame[index];
                pBoxImages.ImageLocation = f.ImageURL;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void NextImages()
        {
            index++;
            if (index < frame.Count)
            {
                f = (Frame)frame[index];
                pBoxImages.ImageLocation = f.ImageURL;
            }
            if (index == frame.Count)
            {
                index = 0;
                f = (Frame)frame[index];
                pBoxImages.ImageLocation = f.ImageURL;
            }
            timer2.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Right)
            {
                timer1.Enabled = true;
            }
            else if (e.KeyCode==Keys.Left)
            {
                timer3.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pBoxImages.Top<=670)
            {
                pBoxImages.Top+=5;
            }
            else
            {
                timer1.Enabled = false;

                NextImages();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pBoxImages.Top>=200)
            {
                pBoxImages.Top-=5;
            }
            else
            {
                timer2.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pBoxImages.Top <= 670)
            {
                pBoxImages.Top += 5;
            }
            else
            {
                timer3.Enabled = false;
                BackImages();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (pBoxImages.Top >= 200)
            {
                pBoxImages.Top -= 5;
            }
            else
            {
                timer4.Enabled = false;
            }
        }
    }
    public class Frame
    {
        public string Name="";
        public string ImageURL="";
    }
}