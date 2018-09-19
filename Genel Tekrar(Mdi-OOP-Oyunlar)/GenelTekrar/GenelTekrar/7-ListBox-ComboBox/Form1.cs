using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_ListBox_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList dizi = new ArrayList();
        Kayıtlar yeniKayıt = new Kayıtlar();


        private void btnEkle_Click(object sender, EventArgs e)
        {
            //dizi.Add(txtBxCity.Text + " " + txtBxPlate.Text); ;
            //listBox1.Items.Add(dizi[0]);
            //dizi.Clear();
            //txtBxCity.Clear();
            //txtBxPlate.Clear();
            yeniKayıt.Sehir = txtBxCity.Text;
            yeniKayıt.plaka = txtBxPlate.Text;
            listBox1.Items.Add(yeniKayıt.ToString());
            txtBxCity.Clear();
            txtBxPlate.Clear();

        }

    }
    public class Kayıtlar
    {
        public string Sehir;
        public string plaka;
        public override string ToString()
        {
            return plaka.ToString() + " " + Sehir;
        }
    }
}
