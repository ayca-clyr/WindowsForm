using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_OOP_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            Mudur mudur = new Mudur();
            Ogretmen ogretmen = new Ogretmen();
            Memur memur = new Memur();
            Insan insan = ogrenci;
            TCKNSorgula(insan);
            TCKNSorgula(ogrenci);//İnsan class'ı için yazdığım metod onun çocuğu olan Ögrenci class'ı içinde kullanılabilir. Miras aldığımız için bu durum sağlandı.
            TCKNSorgula(mudur);
            TCKNSorgula(ogretmen);
            TCKNSorgula(memur);
                
        }
        void TCKNSorgula(Insan insan)
        {
            
        }
    }
}
