using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartDagitim
{
    public partial class ElGoster : Form
    {
        public ArrayList kart = new ArrayList();
       public ElGoster()
        {
            InitializeComponent();
        }

        private void ElGoster_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {

            PictureBox picture = new PictureBox();
            picture.Name = "pcb" + i;
            picture.Size = new Size(90, 125);
            picture.Location = new Point(0, 0);
            picture.BackColor = Color.Black;
            picture.Left += 92 * i;
            picture.ImageLocation = @"..\\..\\images\\"+ kart[i] +".png";
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture);
            }


        }
    }
}
