using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapciOrnegi
{
    public partial class Form1 : Form
    {

        KitapBilgileri kitapBilgileri;
        List<KitapBilgileri> kitapList = new List<KitapBilgileri>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKitap.Text != "" &&
                txtYazar.Text != "" &&
                cmbKategori.Text != "" &&
                dtpTarih.Text != "")
            {
            kitapBilgileri = new KitapBilgileri();
            kitapBilgileri._kitapAdi = txtKitap.Text;
            kitapBilgileri._kategori = cmbKategori.Text;
            kitapBilgileri._YazarAdi = txtYazar.Text;
            kitapBilgileri._yayinlanmaTarihi = Convert.ToDateTime(dtpTarih.Text);
            kitapList.Add(kitapBilgileri);
            lstKitapListesi.Items.Add(kitapBilgileri);
            txtKitap.Text = "";
            txtYazar.Text = "";
            cmbKategori.SelectedIndex = -1;

            MessageBox.Show("Kayıt Eklendi");
            }
            else
            {
                MessageBox.Show("Boş Alanlar Var.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
            //kitap listesinden kaldır --- listBoxtaki seçilen itemi KitapBilgilerine Cast ederek.
            kitapList.Remove((KitapBilgileri)lstKitapListesi.SelectedItem); //burdayken obje tipinde. cast gerekiyor.
            lstKitapListesi.Items.Clear();
            foreach (KitapBilgileri kitap in kitapList)
            {
                lstKitapListesi.Items.Add(kitap);
            }
            txtKitap.Text = "";
            txtYazar.Text = "";
            cmbKategori.SelectedIndex = -1;

            MessageBox.Show("Kayıt Silindi");

            }
            catch (Exception)
            {
                         
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKitap.Text != "" &&
                txtYazar.Text != "" &&
                cmbKategori.Text != "" &&
                dtpTarih.Text != "")
                {
                    kitapBilgileri = new KitapBilgileri();                
                    KitapBilgileri kitapp = (KitapBilgileri)lstKitapListesi.SelectedItem;

                    kitapp._kitapAdi = txtKitap.Text;
                    kitapp._kategori = cmbKategori.Text;
                    kitapp._YazarAdi = txtYazar.Text;
                    kitapp._yayinlanmaTarihi = dtpTarih.Value;

                lstKitapListesi.Items.Clear();
                foreach (KitapBilgileri kitap in kitapList)
                {
                    lstKitapListesi.Items.Add(kitap);
                }
                txtKitap.Text = "";
                txtYazar.Text = "";
                cmbKategori.SelectedIndex = -1;

                MessageBox.Show("Kayıt Güncellendi");
                }
                else
                {
                    MessageBox.Show("Boş alanlar var. Güncelleme yapılamadı.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Listeden Kitap Seçilmedi..");           
            }
        }

        private void lstKitapListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //KitapBilgileri türünde nesne olusturup, içine listBoxtan yakaladıgımızı, Cast ederek attık.
            KitapBilgileri kitapp = (KitapBilgileri)lstKitapListesi.SelectedItem;

            try
            {
                txtKitap.Text = kitapp._kitapAdi;
                cmbKategori.Text = kitapp._kategori;
                txtYazar.Text = kitapp._YazarAdi;
                dtpTarih.Value = kitapp._yayinlanmaTarihi;

            }
            catch (Exception)
            {
                
     
            }
     
        }
    }
}
