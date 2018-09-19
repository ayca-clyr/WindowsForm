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

namespace _160826_03
{
    public partial class lblIsim : Form
    {
        public lblIsim()
        {
            InitializeComponent();
        }



        ArrayList Resimler = new ArrayList();
        Frame resim1 = new Frame();

        private void Temizle()
        {
            txtBxIsim.Text = "";
            txtBxUrl.Text = "";


        }
        public void ResimBilgiler()
        {
            resim1.Name = txtBxIsim.Text;
            resim1.Url = txtBxUrl.Text;

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Resimler.Add(resim1);
            Frame resim = (Frame)Resimler[0];

            pBxResim.ImageLocation = txtBxUrl.Text;
            cBxResimler.Items.Add(txtBxIsim.Text);
            Temizle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult exit = new DialogResult();
            exit = MessageBox.Show("Silmek İstediğinizden Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);

            if (exit == DialogResult.Yes)
            {
                cBxResimler.Items.Remove(cBxResimler.SelectedItem);
                MessageBox.Show("Silindi!");
                pBxResim.Image = null;
                // Application.Exit();
            }
            else if (exit == DialogResult.No)
            {
                MessageBox.Show("Silinmedi!");
            }
        }

        private void lblIsim_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void cBxResimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Frame f = (Frame)Resimler[cBxResimler.SelectedIndex];
            //pBxResim.ImageLocation = f.Url;

            // Seçilen Resmi Görüntülemeye çalıştım. Fakat Silme işlemi yapıyor.
        }
    }


    class Frame
    {
        public string Name;
        public string Url;
    }
}
