using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartDagitim
{
    public partial class Form1 : Form
    {
        bool isExit = true;
        public string koltuk1, koltuk2, koltuk3, koltuk4;
        string[] kartTipi = new string[] { "MAÇA", "KARO", "SİNEK", "KUPA" };
        string[] kartlar = new string[] { "AS", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        ArrayList tumKartlar = new ArrayList();
        ArrayList oyuncu1 = new ArrayList();
        ArrayList oyuncu2 = new ArrayList();
        ArrayList oyuncu3 = new ArrayList();
        ArrayList oyuncu4 = new ArrayList();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string gelenKart;
            for (int i = 0; i < kartTipi.Length; i++)
            {
                for (int j = 0; j < kartlar.Length; j++)
                {
                    gelenKart = kartTipi[i] + " " + kartlar[j];
                    tumKartlar.Add(gelenKart);
                    
                }
            }
            Login isimler = new Login();

            btnKartGoster1.Hide();
            btnKartGoster2.Hide();
            btnKartGoster3.Hide();
            btnKartGoster4.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            lblOyuncu1.Text = koltuk1.ToUpper();
            lblOyuncu2.Text = koltuk2.ToUpper();
            lblOyuncu3.Text = koltuk3.ToUpper();
            lblOyuncu4.Text = koltuk4.ToUpper();

            btnKartGoster1.Show();
            btnKartGoster2.Show();
            btnKartGoster3.Show();
            btnKartGoster4.Show();
 

            for (int i = 1; i <= 13; i++)
            {
                PictureBox upSide = new PictureBox();
                upSide.Name = "pcb" + i;
                upSide.Size = new Size(70, 90);
                upSide.Location = new Point(100, 20);
                upSide.BackColor = Color.Black;
                upSide.Left += 40 * i;
                upSide.ImageLocation = @"..\\..\\images\\0.png";
                upSide.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(upSide);
            }

            for (int i = 1; i <= 13; i++)
            {
                PictureBox leftSide = new PictureBox();
                leftSide.Name = "pcb" + i;
                leftSide.Size = new Size(90, 60);
                leftSide.Location = new Point(20, 50);
                leftSide.BackColor = Color.Black;
                leftSide.Top += 40 * i;
                leftSide.ImageLocation = @"..\\..\\images\\0.png";
                leftSide.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(leftSide);
            }

            for (int i = 1; i <= 13; i++)
            {
                PictureBox downSide = new PictureBox();
                downSide.Name = "pcb" + i;
                downSide.Size = new Size(70, 90);
                downSide.Location = new Point(100, 580);
                downSide.BackColor = Color.Black;
                downSide.Left += 40 * i;
                downSide.ImageLocation = @"..\\..\\images\\0.png";
                downSide.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(downSide);
            }


            for (int i = 1; i <= 13; i++)
            {
                PictureBox rightSide = new PictureBox();
                rightSide.Name = "pcb" + i;
                rightSide.Size = new Size(90, 60);
                rightSide.Location = new Point(715, 50);
                rightSide.BackColor = Color.Black;
                rightSide.Top += 40 * i;
                rightSide.ImageLocation = @"..\\..\\images\\0.png";
                rightSide.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(rightSide);
            }
            int gidenKart;
            for (int i = 0; i < 13; i++)
            {
                gidenKart = rnd.Next(0, tumKartlar.Count);
                oyuncu1.Add(tumKartlar[gidenKart]);
                tumKartlar.RemoveAt(gidenKart);
            }

            for (int i = 0; i < 13; i++)
            {
                gidenKart = rnd.Next(0, tumKartlar.Count);
                oyuncu2.Add(tumKartlar[gidenKart]);
                tumKartlar.RemoveAt(gidenKart);
            }

            for (int i = 0; i < 13; i++)
            {
                gidenKart = rnd.Next(0, tumKartlar.Count);
                oyuncu3.Add(tumKartlar[gidenKart]);
                tumKartlar.RemoveAt(gidenKart);
            }

            for (int i = 0; i < 13; i++)
            {
                gidenKart = rnd.Next(0, tumKartlar.Count);
                oyuncu4.Add(tumKartlar[gidenKart]);
                tumKartlar.RemoveAt(gidenKart);

            }

            pictureBox1.Hide();
        }

        private void btnKartGoster1_Click(object sender, EventArgs e)
        {
            ElGoster el = new ElGoster();
            el.kart = oyuncu1;
            el.Show();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            lblUyari.Text = "Kartları Dağıtmak İçin Resme Tıklayınız";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lblUyari.Text = "";
        }

        private void btnKartGoster2_Click(object sender, EventArgs e)
        {
            ElGoster el = new ElGoster();
            el.kart = oyuncu2;
            el.Show();
        }
        private void btnKartGoster3_Click(object sender, EventArgs e)
        {
            ElGoster el = new ElGoster();
            el.kart = oyuncu3;
            el.Show();
        }

        private void btnKartGoster4_Click(object sender, EventArgs e)
        {
            ElGoster el = new ElGoster();
            el.kart = oyuncu4;
            el.Show();
        }

        //private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            
        //    DialogResult result = new DialogResult();
        //        result = MessageBox.Show("Çıkmak İstediğine Emin Misin?","Dikkat",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
        //        if (result == DialogResult.Yes)
        //        {
        //            Application.Exit();
        //        }

        //}

        private void kapatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Çıkmak İstediğine Emin Misin?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}