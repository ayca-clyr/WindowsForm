using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Marathon160826_Winform_Part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Oyuncu>Liste=new List<Oyuncu>();
        Oyuncu oyuncu = new Oyuncu();
        int Id=0;
        int secimSayac;
        
        public void Ekle()
        {
            oyuncu.id = Id;
            oyuncu.ad = txtBxFirstName.Text;
            oyuncu.soyad = txtBxLastName.Text;
            oyuncu.ozelSut = txtBxSpecial.Text;
            oyuncu.takım = cmbTeam.Text;
            oyuncu.dogumtarihi = DateTime.Parse(dateTimeBirth.Text);
            oyuncu.hız = (int)numDribbling.Value;
            oyuncu.pas = (int)numPassing.Value;
            oyuncu.sut = (int)numShooting.Value;
           
            
        }
        public void VeriyiSil()
        {
            
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Id++;
            Ekle();
            Liste.Add(oyuncu);
            lstKayıtlar.Items.Add(oyuncu.ad + " " + oyuncu.soyad);
            Temizle();
        }
        void Temizle()
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                else if (control is DateTimePicker)
                {
                    (control as DateTimePicker).Value = DateTime.Now;
                }
                else if (control is NumericUpDown)
                {
                    (control as NumericUpDown).Value = 0;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
        }

        private void lstKayıtlar_SelectedIndexChanged(object sender, EventArgs e)
        {

            int secim = lstKayıtlar.SelectedIndex;
            oyuncu =(Oyuncu)Liste[secim];
            secimSayac = oyuncu.id;
            txtBxFirstName.Text = oyuncu.ad;
            txtBxLastName.Text = oyuncu.soyad;
            txtBxSpecial.Text = oyuncu.ozelSut;
            cmbTeam.Text = oyuncu.takım;
            numDribbling.Value = oyuncu.hız;
            numPassing.Value = oyuncu.pas;
            numShooting.Value = oyuncu.sut;
            dateTimeBirth.Text = oyuncu.dogumtarihi.ToLongTimeString();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Ekle();
            int secim = lstKayıtlar.SelectedIndex;
            Liste[secim] = oyuncu;
            lstKayıtlar.Items.Clear();
            foreach (var item in Liste)
            {
                oyuncu = item;
                lstKayıtlar.Items.Add(item.ad + " " + item.soyad);
            }
            Temizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public class Oyuncu
    {
        public int id;
        public string ad;
        public string soyad;
        public DateTime dogumtarihi;
        public string ozelSut;
        public string takım;
        public int sut;
        public int pas;
        public int hız;


    }
    
}
