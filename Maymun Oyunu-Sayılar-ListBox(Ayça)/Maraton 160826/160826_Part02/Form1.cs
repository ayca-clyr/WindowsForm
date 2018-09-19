using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _160826_Part02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        int id = 0;
        ArrayList futbolcuIsimleri = new ArrayList();

        Player futbolcu1 = new Player();

        private void Temizleme()
        {
            txtBxFirstName.Clear();
            txtBxLastName.Clear();
            txtBxSpecialShooting.Clear();
            numericDribbling.Value = 0;
            numericPassing.Value = 0;
            numericShooting.Value = 0;
            cBxTeam.Text = "";
            dtpDogumTarihi.Value = DateTime.Now;

            foreach (var item in futbolcuIsimleri)
            {
                lstBxFutbolcuKayitlari.Items.Add(item);
            }
            futbolcuIsimleri.Clear();
        }
        private void btnSilme_Click(object sender, EventArgs e)
        {
            DialogResult exit = new DialogResult();
            exit = MessageBox.Show("Silmek İstediğinizden Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);

            if ( exit == DialogResult.Yes)
            { 
                lstBxFutbolcuKayitlari.Items.Remove(lstBxFutbolcuKayitlari.SelectedItem);
                MessageBox.Show("Silindi!");
                // Application.Exit();
            }
            else if (exit == DialogResult.No)
            {
                MessageBox.Show("Silinmedi!");
            }          
        }
        public void FutbolcularinBilgileri()
        {
            futbolcu1.FirstName = txtBxFirstName.Text;
            futbolcu1.LastName = txtBxLastName.Text;
            futbolcu1.SpecialShoot = txtBxSpecialShooting.Text;
            futbolcu1.Shooting = Convert.ToInt32(numericShooting.Value);
            futbolcu1.Dribbling = Convert.ToInt32(numericDribbling.Value);
            futbolcu1.Passing = Convert.ToInt32(numericPassing.Value);
            futbolcu1.DateOfBirth = dtpDogumTarihi.Value;
            futbolcu1.Team = cBxTeam.Text;

            
        }



        private void btnKaydetme_Click(object sender, EventArgs e)
        {
           
            id++;


            FutbolcularinBilgileri();


            if (txtBxFirstName.Text != "" && txtBxFirstName.Text != null && txtBxLastName.Text != "" && txtBxLastName.Text != null)
            {
                futbolcuIsimleri.Add(futbolcu1);
                Player yeni = (Player)futbolcuIsimleri[0];
                yeni.FirstName = txtBxFirstName.Text;
                yeni.LastName = txtBxLastName.Text;
                yeni.SpecialShoot = txtBxSpecialShooting.Text;
                yeni.Shooting = Convert.ToInt32(numericShooting.Value);
                yeni.Dribbling = Convert.ToInt32(numericDribbling.Value);
                yeni.Passing = Convert.ToInt32(numericPassing.Value);
                yeni.DateOfBirth = dtpDogumTarihi.Value;
                yeni.Team = cBxTeam.Text;

                Temizleme();

            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Değer Giriniz.");
            }
        }

       

        private void txtBxFutbolcular_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            try
            {
                



            }
            catch (Exception)
            {
                MessageBox.Show("Seçmediniz!");
            }
        }

        private void lstBxFutbolcuKayitlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player SecilenNesne =(Player)lstBxFutbolcuKayitlari.SelectedItem;

            txtBxFirstName.Text = SecilenNesne.FirstName;
            txtBxLastName.Text = SecilenNesne.LastName;
            txtBxSpecialShooting.Text = SecilenNesne.SpecialShoot;
            numericShooting.Value = SecilenNesne.Shooting; 
            numericDribbling.Value = SecilenNesne.Dribbling;
            numericPassing.Value = SecilenNesne.Passing;
            dtpDogumTarihi.Value = SecilenNesne.DateOfBirth;
            cBxTeam.Text = SecilenNesne.Team;
        }
    }


    class Player
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public string Team;
        public string SpecialShoot;
        public int Shooting;
        public int Passing;
        public int Dribbling;

        public override string ToString() { 
        
        
            return FirstName +" "+ LastName;
        }
    }
}
