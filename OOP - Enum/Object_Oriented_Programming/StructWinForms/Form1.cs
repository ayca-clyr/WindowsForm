using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // İçindeki özellikler değilde komplesine değiştiremiyoruz. Alttaki yorum satırındakileri değiştiremeyiz. Ama aldığımız istance ile onun değerlerini değiştirebiliriz.
        // Nesneyi değiştiremeyiz.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Burda da kopyasını değiştiriyoruz.
            Button button = new Button();
            Volume volume = new Volume();
            button.Left = 30;
            volume.Depth = 5;
            volume.Height = 5;
            volume.Width = 5;
            bool IsCube = volume.IsCube();


            //Button button = null;
            //Volume volume = null;    // Ben değerini değiştiremem. Çünkü struct'dır. O yüzden hata verir.
        }
    }
}
