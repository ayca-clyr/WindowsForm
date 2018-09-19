using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_OOP_Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * Class ismine nokta yazarak ulasilan elemanlara static elemanlar denir.
         * amacı instance alarak zaman ve bellek harcamasını azaltma 
         */
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ögrenci = new Ogrenci();
            ögrenci.Adi = "Multaza";
            Ogrenci ögrenci2 = new Ogrenci();
            ögrenci2.Adi="Kadriye";

            //Ogrenci.TanimliOgrenciSayisi//Ogrenci class'ındaki özelliğin başına static yazınca instance almadan direk property'e ulaşabiliyorum.
            Ogrenci.YoklamaAl();
        }
    }
}
