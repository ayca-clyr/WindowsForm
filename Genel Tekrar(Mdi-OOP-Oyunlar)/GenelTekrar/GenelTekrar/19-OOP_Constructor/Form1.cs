using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_OOP_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Personeller personelform = new Personeller();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel prs = null;
            prs = new Personel();
            //prs = new Personel(textBox1.Text, textBox2.Text); //nesne ürettik.
            prs.Adi = textBox1.Text;
            prs.Soyadi = textBox2.Text;
            prs.SicilNo = textBox3.Text;
            prs.Maas = numericUpDown1.Value;

            personelform.PersonelEkle(prs);

            textBox1.Text = textBox2.Text = textBox3.Text = "";
            numericUpDown1.Value = 0;
            textBox1.Focus();//Focus, işlem bittikten sonra imlecin gideceği yerdir.
        }
        void PersonelAl(Personel yenikisi)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personelform.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            personelform.Show();
        }

    }
}
