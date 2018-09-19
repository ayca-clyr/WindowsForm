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

namespace _160906_HafızaOyunu
{

    public partial class Form1 : Form
    {
      
        public int yukseklik = 50;
        public int genislik = 50;
        bool a = true;
        int dogruSayisi = 0;
        int yanlisSayisi = 0;
        int puan = 0;
        int sure ;
        

      

        int[] dizi = new int[5];
        Random rastgele = new Random();
        int tiklanma = 0;
        int dur;
        Button buton = new Button();


        public Form1()
        {
            InitializeComponent();
        }



    

        private void btnZor_Click_1(object sender, EventArgs e)
        {
            sure = 120;
            lblMod.Text = btnZor.Text;
            btnKolay.Visible = false;
            btnOrta.Visible = false;
            btnZor.Visible = false;
            dur = 0;

            panel1.Controls.Clear();
            timer1.Interval = 200;

            buton = new Button();
            int sayac = 0;


            int x = 0;
            while (x < 5)
            {
                int sayi = rastgele.Next(1, 101);
                if (dizi.Contains(sayi))
                    continue;

                dizi[x] = sayi;
                x++;
            }

            for (int j = 0; j < 10; j++)
            {
                {
                    for (int i = 0; i < 10; i++)
                    {
                        sayac++;

                        buton = new Button();
                        buton.Location = new Point(5 + (30 * j), 5 + (30 * i));
                        buton.Size = new Size(30, 30);
                        buton.BackColor = Color.White;
                        buton.Text = sayac.ToString();
                        buton.Click += new EventHandler(buton_Click);
                        panel1.Controls.Add(buton);
                        x = 0;

                        while (x < 5)
                        {
                            int butontext = int.Parse(buton.Text);

                            if (dizi[x] == butontext)
                            {
                                timer1.Start();
                                buton.BackColor = Color.Red;

                            }

                            x++;
                        }

                    }

                }

            }


        }

        private void btnOrta_Click(object sender, EventArgs e)
        {
            sure = 60;
            lblMod.Text = btnOrta.Text;
            btnKolay.Visible = false;
            btnOrta.Visible = false;
            btnZor.Visible = false;
            dur = 0;

            panel1.Controls.Clear();
            timer1.Interval = 500;

            buton = new Button();
            int sayac = 0;


            int x = 0;
            while (x < 5)
            {
                int sayi = rastgele.Next(1, 101);
                if (dizi.Contains(sayi))
                    continue;

                dizi[x] = sayi;
                x++;
            }

            for (int j = 0; j < 10; j++)
            {
                {
                    for (int i = 0; i < 10; i++)
                    {
                        sayac++;

                        buton = new Button();
                        buton.Location = new Point(5 + (30 * j), 5 + (30 * i));
                        buton.Size = new Size(30, 30);
                        buton.BackColor = Color.White;
                        buton.Text = sayac.ToString();
                        buton.Click += new EventHandler(buton_Click);
                        panel1.Controls.Add(buton);
                        x = 0;

                        while (x < 5)
                        {
                            int butontext = int.Parse(buton.Text);

                            if (dizi[x] == butontext)
                            {
                                timer1.Start();
                                buton.BackColor = Color.Red;

                            }

                            x++;
                        }

                    }

                }

            }

        }

        private void btnKolay_Click(object sender, EventArgs e)
        {
            sure = 30;
            lblMod.Text = btnKolay.Text;
            btnKolay.Visible = false;
            btnOrta.Visible = false;
            btnZor.Visible = false;
            dur = 0;

            panel1.Controls.Clear();
            timer1.Interval = 900;

            buton = new Button();
            int sayac = 0;


            int x = 0;
            while (x < 5)
            {
                int sayi = rastgele.Next(1, 101);
                if (dizi.Contains(sayi))
                    continue;

                dizi[x] = sayi;
                x++;
            }

            for (int j = 0; j < 10; j++)
            {
                {
                    for (int i = 0; i < 10; i++)
                    {
                        sayac++;

                        buton = new Button();
                        buton.Location = new Point(5 + (30 * j), 5 + (30 * i));
                        buton.Size = new Size(30, 30);
                        buton.BackColor = Color.White;
                        buton.Text = sayac.ToString();
                       buton.Click += new EventHandler(buton_Click);
                        panel1.Controls.Add(buton);
                        x = 0;

                        while (x < 5)
                        {
                            int butontext = int.Parse(buton.Text);

                            if (dizi[x] == butontext)
                            {
                                timer1.Start();
                                buton.BackColor = Color.Red;
                                
                            }

                            x++;
                        }
 
                    }

                }

            }

        }

        private void buton_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;


            if (btn.Text == dizi[0].ToString() || btn.Text == dizi[1].ToString() || btn.Text == dizi[2].ToString() || btn.Text == dizi[3].ToString() || btn.Text == dizi[4].ToString())
            {
                btn.BackColor = Color.Green;
                dogruSayisi++;

                lblDogruSayisi.Text = dogruSayisi.ToString();
            }
            else
            {
                btn.BackColor = Color.Red;
                yanlisSayisi++;
                lblYanlisSayisi.Text = yanlisSayisi.ToString();

                
            }
            if (yanlisSayisi == 3)
                {
                    timer1.Stop();
                timer2.Stop();
                   
                DialogResult result =new DialogResult();
                result = MessageBox.Show("Kaybettiniz! Yeniden Oynamak Istiyor musunuz?", "", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    Application.Restart();
                }else if(result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if(dogruSayisi == 5)
            {
                timer2.Stop();
                puan =int.Parse(lblSure.Text);
                MessageBox.Show("Tebrikler Kazandınız! Puanınız : "+puan);
           
                if (txtBxKullanıcıAdı.Text != "")
                {
                    string kullaniciAdi = txtBxKullanıcıAdı.Text;
                    int skorunuz = puan;
                    lstBxIsımler.Items.Add(kullaniciAdi +"  " +puan);


                    ArrayList aList = new ArrayList();


                    for (int i = 0; i < lstBxIsımler.Items.Count; i++)
                    {
                        aList.Add(Convert.ToString(lstBxIsımler.Items[i]));
                    }
                    aList.Sort();
                    lstBxIsımler.Items.Clear();


                    foreach (var item in aList)
                    {
                        lstBxIsımler.Items.Add(item);
                    }

                }
                else if(txtBxKullanıcıAdı.Text == "")
                {
                    MessageBox.Show("Lütfen Kullanıcı Adınızı Boş Bırakmayınız!");
                }
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Yeniden Oynamak Istiyor musunuz?","",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    Application.Restart();
                }else if(result == DialogResult.No)
                {
                    Application.Exit();
                }
                
            }
        }
       


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Start();
            int deger = 0;
            deger++;


            if (a)
            {
                foreach (Button item in panel1.Controls)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (item.BackColor == Color.Red)
                        {
                            item.BackColor = Color.White;
                        }
                    }
                }
                a = false;
            }
            else
            {
                foreach (Button item in panel1.Controls)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (dizi[i] == int.Parse(item.Text))
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
                a = true;
            }

            dur++;

            if (dur == 5)
            {
                timer1.Enabled = false;
            }


        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYeniden_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {

            if (btnDurdur.Text == "DURDUR")
            {
                btnDurdur.Text = "DEVAM";
                timer1.Enabled = false;
                timer2.Stop();

            }
            else if (btnDurdur.Text == "DEVAM")
            {
                timer1.Start();
                timer2.Start();
                btnDurdur.Text = "DURDUR";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            sure--;
            lblSure.Text = sure.ToString();
            if(sure == 0)
            {
                MessageBox.Show("Üzgünüm Süreniz Bitti!");
                timer2.Stop();
                
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }
    }
}


