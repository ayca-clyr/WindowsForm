using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3__StructInWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// Button sınıftır
            //Button button = new Button();
            ////Volume struct
            //Volume volume = new Volume();

            // sınıflar referans olarak null ı atayabiliyor
            Button button = null;

            // volume e atayamayız , değer tiplidir. Değiştirilemez bizim oluşturduğumuz koşullar sonucunda volume değeri vardır zaten. Formülü var yani.


            // küçük oluşumlar olacak ve değer tiplidir. Struct.
            //Volume volume = null; // ÇALIŞMAZ

            Volume volume = new Volume();
            volume.Depth = 5;
            volume.Height = 5;
            volume.Width = 5;
            bool IsCube = volume.IsCube();




        }
    }
}
