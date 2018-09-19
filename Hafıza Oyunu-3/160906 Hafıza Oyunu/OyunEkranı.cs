using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160906_Hafıza_Oyunu
{
    public partial class OyunEkranı : Form
    {
        public OyunEkranı()
        {
            InitializeComponent();
        }

        KullanıcıKayıt kullanıcıKayıt = new KullanıcıKayıt();

        Button[] buton = new Button[100];
        // 100 tane buton oluşturdum.
        Button btn;
        Random rnd = new Random();// random değer için rnd değişkenini tanımladım.
        bool timerDurum = true;//Timer'ın aşağıda durumunu belirlemek için bayrak yöntemi kullandım.
        int timerSayacı = 6;//Timer'ın 6 defa çalışmasını sağladım.
        int satırsayısı, sütunsayısı;//10x10'luk bir buton dizisi oluşturmak için değişken tanımladım.
        int puan = 0;
        int saniye = 60;
        int dogru = 0;
        public void butonOlustur()//Buton oluşturmak için metod yazdım.
        {
            btnPanel.Controls.Clear();
            for (int i = 0; i < satırsayısı; i++)
            {
                for (int j = 0; j < sütunsayısı; j++)
                {
                    btnPanel.Height = satırsayısı * 50;
                    btnPanel.Width = sütunsayısı * 50;
                    btn = new Button();
                    btn.Name = "Button" + (i * 10 + j);
                    btn.BackColor = Color.Gray;
                    btn.Size = new Size(40, 40);
                    btn.Location = new Point(j * 50, i * 50);
                    btnPanel.Controls.Add(btn);
                    buton[i * satırsayısı + j] = btn;
                    btn.TabStop = false;
                    btn.Enabled = false;
                    btn.Click += btn_Click;
                    
                }
            }
        }
        int hak = 3;
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (hak > 0)
            {
               if (btn.Name == "Button" + random1 ||
               btn.Name == "Button" + random2 ||
               btn.Name == "Button" + random3 ||
               btn.Name == "Button" + random4 ||
               btn.Name == "Button" + random5)
                {
                    btn.BackColor = Color.Green;
                    puan = puan + 100;
                    dogru = dogru + 1;
                    if (dogru == 5)
                    {
                        hak = 0;
                       
                    }
                }
                else
                {
                    //yanlıs kısım
                    hak = hak - 1;
                    puan = puan - 100;
                    btn.BackColor = Color.Red;

                }
                kullanıcıKayıt.lblKullanıcıGösterilenPuan.Text = lblGösterilenPuan.Text = puan.ToString();
            }

            else
            {
                timer2.Enabled = false;
                MessageBox.Show("Oyun Bitti");
                Hide();
                kullanıcıKayıt.Show();

            }

        }

        private void OyunEkranı_Load(object sender, EventArgs e)
        {

        }
        int random1 = 0;//5 buton için 5 adet random sayı üretmek için değişken tanımladım.
        int random2 = 0;
        int random3 = 0;
        int random4 = 0;
        int random5 = 0;
        public void sayıOlustur()// 5 tane random değer ürettim
        {
            random1 = rnd.Next(0, sütunsayısı * satırsayısı);
            random2 = rnd.Next(0, sütunsayısı * satırsayısı);
            random3 = rnd.Next(0, sütunsayısı * satırsayısı);
            random4 = rnd.Next(0, sütunsayısı * satırsayısı);
            random5 = rnd.Next(0, sütunsayısı * satırsayısı);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Burada timer her 1 saniyede bir rengi beyaz yapıp sonra mavi yapıyor.
            timerSayacı--;

            if (!timerDurum)
            {
                foreach (Button item in btnPanel.Controls)
                {
                    item.BackColor = Color.Gray;
                }
                timerDurum = true;
            }
            else
            {

                buton[random1].BackColor = Color.Blue;
                buton[random2].BackColor = Color.Blue;
                buton[random3].BackColor = Color.Blue;
                buton[random4].BackColor = Color.Blue;
                buton[random5].BackColor = Color.Blue;
                timerDurum = false;
            }
            if (timerSayacı == 0) timer1.Enabled = false;//Timer'ın sayaç değeri 0 olunca timer'ı durdurdum.
        }

        private void rdBtnAntreman_CheckedChanged(object sender, EventArgs e)
        {
            satırsayısı = 10;
            sütunsayısı = 10;
            timer1.Interval = 1000;
            timer2.Enabled = false;
            lblZaman.Visible = false;
            lblKalanZaman.Visible = false;
            butonOlustur();
            sayıOlustur();

        }

        private void rdBtnKolay_CheckedChanged(object sender, EventArgs e)
        {
            satırsayısı = 10;
            sütunsayısı = 10;
            timer1.Interval = 750;
            lblZaman.Visible = true;
            lblKalanZaman.Visible = true;
            butonOlustur();
            sayıOlustur();
        }

        private void rdBtnOrta_CheckedChanged(object sender, EventArgs e)
        {
            satırsayısı = 10;
            sütunsayısı = 10;
            timer1.Interval = 500;
            lblZaman.Visible = true;
            lblKalanZaman.Visible = true;
            butonOlustur();
            sayıOlustur();
        }

        private void rdBtnZor_CheckedChanged(object sender, EventArgs e)
        {
            satırsayısı = 10;
            sütunsayısı = 10;
            timer1.Interval = 250;
            lblZaman.Visible = true;
            lblKalanZaman.Visible = true;
            butonOlustur();
            sayıOlustur();
        }



        private void btnBaslat_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            timer2.Start();
            foreach (Button item in buton)
            {
                item.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye--;
            lblKalanZaman.Text = saniye.ToString();
            if (saniye == 0)
            {
                timer2.Enabled = false;
                MessageBox.Show("Oyun bitti");
                kullanıcıKayıt.lblKullanıcıGösterilenPuan.Text = lblGösterilenPuan.Text = puan.ToString();
                Hide();
                kullanıcıKayıt.Show();
            }
        }
    }
}
