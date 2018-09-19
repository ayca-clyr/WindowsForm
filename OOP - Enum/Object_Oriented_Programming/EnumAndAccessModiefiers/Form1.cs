using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumAndAccessModiefiers
{
    public partial class Form1 : Form
    {
        // Enum'dan instance alamazsın. 
        public Form1()
        {
            InitializeComponent();
            Day selectedDay = Day.Salı;
            Day2 selectedDay2 = Day2.Pazartesi;
        }

        // 1 pazartesi 2 olucak salı 3 olucak. 
        // Ama eğer Pazartesiye 3 girersek salı 4 olucak yeni değer atanana kadar 1'er artış gösteriyor.
        enum Day2
        {
            Pazar = 1,
            Pazartesi,
            Salı,
            
        }

        enum Gender
        {
            Erkek,
            Kadın
        }

        // Access Modifiers (Erişim Belirleyiciler)
        /*
            Public : Her yerden erişilebilir. Her proje
            Private : Sadece tanımlandığı sınıf içersinden erişilebilir. Sadece aynı class'da.
            Internal : Sadece bulunduğu projede erişilebilir. 1 projede 2 farklı class arasında. Kimse intenal class'a giremez ama internal class diğer class'lara gidebilir. 
            Protected : Sadece sınıfta yada o sınıfı miras alan sınıflardan erişilebilir.
            Protected -internal : Sadece tanımlandığı sınıfta yada o sınıfı miras alan sınıfrlardan erişilebilir. Protected'ten farkı : tanımlama aynı proje içerisinde olma şartı yoktur.
            Static :
        */
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Text = Gender.Erkek.ToString();
            radioButton2.Text = Gender.Kadın.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
    }
}
