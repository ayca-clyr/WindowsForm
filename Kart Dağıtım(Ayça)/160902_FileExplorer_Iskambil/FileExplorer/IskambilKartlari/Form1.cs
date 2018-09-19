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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string isim1 = "";
        public static string isim2 = "";
        public static string isim3 = "";
        public static string isim4 = "";

        private void btnStart_Click(object sender, EventArgs e)
        {
            isim1 = txtBxPlayer1.Text;
            isim2 = txtBxPlayer2.Text;
            isim3 = txtBxPlayer3.Text;
            isim4 = txtBxPlayer4.Text;


            KartGoster kartGoster = new KartGoster();
            kartGoster.ShowDialog();



           
            
        }
    }
}
