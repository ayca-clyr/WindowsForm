using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_OOP_Polymorhism_Çok_Biçimlilik_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ögrenci = new Ogrenci();
            ögrenci.Adi = textBox1.Text;
            ögrenci.Soyadi = textBox2.Text;
            ögrenci.Vize = numericUpDown1.Value;
            ögrenci.Final = numericUpDown2.Value;

            listBox1.Items.Add(ögrenci);
            textBox1.Focus();
            Temizle();
            
        }
        void Temizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    control.Text = "";
                else if(control is NumericUpDown)
                    (control as NumericUpDown).Value = 0;
                
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;

            Ogrenci secilen = (Ogrenci)listBox1.SelectedItem;
            textBox1.Text = secilen.Adi;
            textBox2.Text = secilen.Soyadi;
            numericUpDown1.Value = secilen.Vize;
            numericUpDown2.Value = secilen.Final;
           
        }
    }
}
