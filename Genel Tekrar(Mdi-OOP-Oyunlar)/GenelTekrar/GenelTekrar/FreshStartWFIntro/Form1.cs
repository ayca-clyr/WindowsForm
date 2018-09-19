using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshStartWFIntro
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

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtBxAd.Text == "Bilal" && txtBxSifre.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı");
                açılacak acılacak = new açılacak();
                acılacak.ShowDialog();

            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }
    }
}
