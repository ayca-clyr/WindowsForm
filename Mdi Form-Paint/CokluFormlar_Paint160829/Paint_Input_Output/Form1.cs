using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Input_Output
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap resim;
        Graphics grafik;
        int boyut = 0;
        Pen kalem = new Pen(Color.Black,10);
        SolidBrush firca = new SolidBrush(Color.Black);
        bool fareTiklandimi = false;
        int baslangicX = 0;
        int baslangicY = 0;
        int size = 10;

        private void Form1_Load(object sender, EventArgs e)
        {
            resim = new Bitmap(pBxÇizimAlanı.Width, pBxÇizimAlanı.Height);
            grafik = Graphics.FromImage(resim);
            pBxÇizimAlanı.Image = resim;
            grafik.Clear(Color.White);
            pBxÇizimAlanı.Refresh();

        }

        private void btnColorSelector_Click(object sender, EventArgs e)
        {
            // ColorDialog nesnesi kullanıcıya renklerin olduğu bir form açar.
            // Kullanıcı rengi seçip OK derse, seçilen rengi kendi üzerindeki Color Property'sine aktarır.

            DialogResult sonuc = colorDialog1.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                // Seçilen rengi kullanıcının da görmesi için label'ın arka plan rengini değiştirdik.
                lblColor.BackColor = colorDialog1.Color;


           
                // Kalem ve fırçamızın rengini de seçilen renk değeri yaptık.
                kalem.Color = colorDialog1.Color;
                firca.Color = colorDialog1.Color;
            }


        }

        private void pBxÇizimAlanı_MouseMove(object sender, MouseEventArgs e)
        {
            if (fareTiklandimi == true)
            {
                // İki koordinat arasına çizgi çekmeye yarayan metoddur : DrawLine
                grafik.DrawLine(kalem, baslangicX, baslangicY, e.X, e.Y);

                // Çizerken kenarlarda boşluklar var. Bu yüzden e.X 'den size/2 yi çıkarıyoruz.
                grafik.FillEllipse(firca, e.X - size / 2, e.Y - size / 2, size, size);


                // PictureBox arkaplanına eklediğimiz resim üzerinde (çizgi çekerek) değişiklik yaptık.
                // Bu değişikliğin görünebilmesi için pbÇizimAlanı nesnesini yeniledik. 
                // Böylece arkaplan olarak verdiğimiz resmin güncel (çizilmiş) halini gördük.
                pBxÇizimAlanı.Refresh();
            }

            // Her çizgi çekildiğinde bizim başlangıç koordinatlarını son çizim yapılan nokta ile güncellememiz gerekiyor.
            baslangicX = e.X;
            baslangicY = e.Y;
        }

        private void pBxÇizimAlanı_MouseUp(object sender, MouseEventArgs e)
        {
            fareTiklandimi = false;
        }

        private void pBxÇizimAlanı_MouseDown(object sender, MouseEventArgs e)
        {
            fareTiklandimi = true;
        }

        private void contexMenuKaydet_Click(object sender, EventArgs e)
        {
            // Yöntem 1 : Dosyayı kendi istediğimiz bir konuma istediğimiz uzantı ile kaydetme.

            if (resim != null)
            {
                // BA 
                resim.Save("C:\\Users\\BA\\Desktop\\benimŞahaserim.Jpeg");
               
                MessageBox.Show("Çizdiğiniz DaVinci Tablosu kaydedildi.");
            }





        }

        private void contexMenuAc_Click(object sender, EventArgs e)
        {
            // jpg = jpeg (Aynıdır.)  Uzantılar.  Açıklamasını yazdığım yerlerde | sonrası message'dir. O uzantıları arar.
            // Aralarına boşluk koyma ve ; ile ayır.
            openFileDialog1.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.png) |*.jpg;*jpeg;*.jpe;*.png;";
            DialogResult sonuc = openFileDialog1.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                // Adını string tutuyor. Bunuda bir string'e atadık.
                string yol = openFileDialog1.FileName;
                
                // Kullanıcının işaret ettiği resim dosyasını dosya yolu üzerinden bitmap'e çevirdik. (Cast ettik.)
                resim = (Bitmap)Bitmap.FromFile(yol);

                // Strech = Yaymak. 
                // Aldığımız resim pictureBox'a basılırken yeni genişlik ve yükseklik vererek bir nevi strech işlemi uyguladık.
                resim = new Bitmap(resim,pBxÇizimAlanı.Width,pBxÇizimAlanı.Height);

                // Tabiki çizim yapacağımız araç graph nesnesidir.
                // Üzerinde işlem yapacağım yeni bitmap'i bilmesi gerekir.
                // Yeni Bitmap graph nesnesinine bildirdik.
                grafik = Graphics.FromImage(resim);

                // PictureBox'a da yeni bitmap'i (resim) bastık.
                pBxÇizimAlanı.Image = resim;
            }    
        }

        private void contexMenuKaydet2_Click(object sender, EventArgs e)
        {
            // Yöntem 2 : Dosyayı kullanıcının işaret ettiği bir konuma kaydet.
           
            if(resim != null)
            {
                saveFileDialog1.Filter = "Bmp Dosyaları |*.bmp| Jpeg Dosyaları |*.jpeg| PNG Dosyaları |*.png";
                DialogResult sonuc = saveFileDialog1.ShowDialog();

                if (sonuc == DialogResult.OK)
                {
                    string yol = saveFileDialog1.FileName;
                    resim.Save(yol);
                    MessageBox.Show("Çizdiğiniz Şahaser >Dialoglu< kayboldu");
                }
            }
        }

        private void tbScroll_Scroll(object sender, EventArgs e)
        {
            TrackBar tbScroll =(TrackBar)sender;
            boyut = tbScroll.Value;
        }

        private void contexMenuTemizle_Click(object sender, EventArgs e)
        {         
            // Transparan Temizle     // Strech = Yaymak(Sığdırmak.)
            resim = new Bitmap(pBxÇizimAlanı.Width, pBxÇizimAlanı.Height);
            grafik = Graphics.FromImage(resim);
            pBxÇizimAlanı.Image = resim;
        }

        private void contexMenuÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
