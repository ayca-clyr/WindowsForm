using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circus_Oyunu
{
    public partial class Circus : Form
    {
        public Circus()
        {
            InitializeComponent();
        }
        public static string secilen;
        CircusStart circusStart = new CircusStart();
        private void btnBilgilendirme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sağ'a hareket etmek için D tuşuna basınız.");
            MessageBox.Show("Sol'a hareket etmek için A tuşuna basınız.");
            MessageBox.Show("Atlamak için Space tuşuna basınız.");

        }

        private void rBtnPlayer_CheckedChanged(object sender, EventArgs e)
        {
            secilen = rBtnPlayer.Text;
             circusStart.Show();
            this.Hide();
        }
    }
}
