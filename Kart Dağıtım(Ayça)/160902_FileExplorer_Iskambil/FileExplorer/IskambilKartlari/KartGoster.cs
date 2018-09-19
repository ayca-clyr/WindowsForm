using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IskambilKartlari
{
    public partial class KartGoster : Form
    {
        public KartGoster()
        {
            InitializeComponent();
        }

        private void KartGoster_Load(object sender, EventArgs e)
        {

           
            lblPlayer1k.Text = Form1.isim1;
            lblPlayer2k.Text = Form1.isim2;
            lblPlayer3k.Text = Form1.isim3;
            lblPlayer4k.Text = Form1.isim4;

        }


        PictureBox[] kartResim = new PictureBox[52];
        Random rastgele = new Random();
        int[] kartIndisleri = new int[52];

        private void btnKartDagit_Click(object sender, EventArgs e)
        {

            int i = 0;

            while (i < 52)
            {
                int sayi = rastgele.Next(0, 52);
                if(sayi == 0)  // 0 olduğunda çıksın dediğimde ise program hata vermese de sonuçta vermiyor. O yüzden ekleme 0 bulduğunda ekleme olayı 1'den fazla olabiliyor.
                {
                   kartIndisleri[i] = sayi;
                 
                }else if (kartIndisleri.Contains(sayi))
                    continue;
                
                kartIndisleri[i] = sayi;

                i++;
            }




            for (int j = 0; j < 13; j++)
            {
                kartResim[j] = new PictureBox();
                kartResim[j].Name = "Kart" + j.ToString();
                kartResim[j].Location = new Point(60 * j + j * 20+ 200);

                kartResim[j].Visible = true;
                kartResim[j].SizeMode = PictureBoxSizeMode.AutoSize;
                this.Controls.Add(kartResim[j]);
                kartResim[j].BringToFront();

            }
            for (int l = 13, y = 0; l < 26 || y < 13; l++, y++)
            {
                kartResim[l] = new PictureBox();
                kartResim[l].Name = "Kart" + l.ToString();
                kartResim[l].Location = new Point(60 * y + y * 20 + 200, 500);

                kartResim[l].Visible = true;
                kartResim[l].SizeMode = PictureBoxSizeMode.AutoSize;
                this.Controls.Add(kartResim[l]);
                kartResim[l].BringToFront();

            }

            for (int z = 26, p = 0; z < 39 || p < 13; z++, p++)
            {
                kartResim[z] = new PictureBox();
                kartResim[z].Name = "Kart" + z.ToString();
                kartResim[z].Location = new Point(1300,  50*p );

                kartResim[z].Visible = true;
                kartResim[z].SizeMode = PictureBoxSizeMode.AutoSize;
                this.Controls.Add(kartResim[z]);
                kartResim[z].BringToFront();

            }
            for (int x = 39, t = 0; x < 52 || t < 13; x++, t++)
            {
                kartResim[x] = new PictureBox();
                kartResim[x].Name = "Kart" + x.ToString();
                kartResim[x].Location = new Point(0,  t * 50 );

                kartResim[x].Visible = true;
                kartResim[x].SizeMode = PictureBoxSizeMode.AutoSize;
                this.Controls.Add(kartResim[x]);
                kartResim[x].BringToFront();

            }



            for (int k = 0; k < 52; k++)
            {
                kartResim[k].Image = ımageList1.Images[kartIndisleri[k]];
                kartResim[k].Hide();

            }

            MessageBox.Show("Kartlar Dağıtılmıştır!");

        }

        private void btnGoster1_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < 13; k++)
            {
                kartResim[k].Show();
            }
        }

        private void btnGoster2_Click(object sender, EventArgs e)
        {
            for (int k = 26; k < 39; k++)
            {
                kartResim[k].Show();
            }
        }

        private void btnGoster3_Click(object sender, EventArgs e)
        {
            for (int k = 13; k < 26; k++)
            {
                kartResim[k].Show();
            }
        }
        private void btnGoster4_Click(object sender, EventArgs e)
        {
            for (int k = 39; k < 52; k++)
            {
                kartResim[k].Show();
            }
        }
    }
}
