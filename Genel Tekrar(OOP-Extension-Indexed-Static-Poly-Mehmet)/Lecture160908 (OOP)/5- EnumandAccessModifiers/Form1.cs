using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5__EnumandAccessModifiers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            // Enum nesnesinden ınstance alamazsın
            // Sabit değerler için kullanılır
            // Mesela cinsiyet 

            Day selectedDay = Day.Cuma;


        }

        enum Gender
        {
            Erkek,
            Kadın
        }

        

        //private void rbErkek_CheckedChanged(object sender, EventArgs e)
        //{
        //   // rbErkek.Text= Gender.Erkek.ToString();
        //   // rbKadın.Text = Gender.Kadın.ToString();
        //}

        //Acces Modifiers (Erişim belirleyiciler)

        //Public : Her yerden erişilebilir.
        //Private : Sadece tanımlandığı Class içinden erişilebilir.
        //Internal : Sadece bulunduğu projeden erişir - Internal default
        //Protected - Kalıtım aldığı sınıftan erişebilir./Sadece sınıfta ya da miras alan sınıflardan erişilebilir.
        //Protected Internal -> Sadece tanımlandığı sınıfta ya da o sınıf miras alan sınıflardan erişilebilir.Protected'tan farkı : tanımlama aynı proje içerisinde olma şartı yoktur.
    
    }
}
