using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace _160905_HW_xmlSerializer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        DialogResult soru = new DialogResult();
        XmlDocument document = new XmlDocument();//Döküman oluşturduk.

        string filestream = Application.StartupPath + "\\KisiListesi.xml"; //Xml dosyasının yolunu verdik.

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (!(txtBxKayıtAdı.Text.Length > 0 && txtBxKayıtSoyadı.Text.Length > 0 && mskTxtBxKayıtTelefon.Text.Length > 0))//Boş geçilemesin kontrolü yaptık.
                return;
            document.Load(filestream);//dökümanı yükledik.

            XmlElement add = document.CreateElement("Kisi");// dökümana kayıt yapmak için Kisi ve ID adında bizim sonradan aramakta sıkıntı cekmeyecegımız yardımcılar ekledik.
            XmlAttribute ID = document.CreateAttribute("ID");

            XmlNode adi = document.CreateNode(XmlNodeType.Element, "Ad", null);//Düğüm ekliyoruz. Xml dosyası içerisinde <Ad> </Ad> şeklinde oluşur.
            XmlNode soyadi = document.CreateNode(XmlNodeType.Element, "Soyad", null);
            XmlNode telefon = document.CreateNode(XmlNodeType.Element, "Telefon", null);

            XmlNode lastElement = document.SelectSingleNode("Kisiler").LastChild;// Son kaydedilen kişinin ID kontrol ettik. Bir sonraki kişi ID+1 şeklinde kaydolcak.
            int sonID;
            if (lastElement != null)
            {
                sonID = int.Parse(lastElement.Attributes["ID"].Value);
            }
            else
                sonID = 0;

            ID.Value = (sonID + 1).ToString();
            adi.InnerText = txtBxKayıtAdı.Text;
            soyadi.InnerText = txtBxKayıtSoyadı.Text;
            telefon.InnerText = mskTxtBxKayıtTelefon.Text;


            add.Attributes.Append(ID);//Xml içerisine elementleri ekledik.
            add.AppendChild(adi);
            add.AppendChild(soyadi);
            add.AppendChild(telefon);

            document.DocumentElement.AppendChild(add);//Eklenen "add"'ları xml içerisine ekledik.
            document.Save(filestream);// dökümanın bu halini kaydettik.

           
            MessageBox.Show("Kisiniz kaydedildi.");

            Temizle();//Textbox ve maskedTextBox'ları temizledik.
            EkranaGetir();//Kaydedileni listbox'ta gösterdik.

            
        
            
        }

         void Temizle()// Temizlemek için kullandığımız metod.
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                else if (control is MaskedTextBox)
                {
                    control.Text = "";
                }
            }
        }

         void EkranaGetir()// Xml'i listbox'ta göstermemiz için kullandığımız metot
         {
             lstTelefonListesi.Items.Clear();
             document.Load(filestream);

             XmlNode kök = document.SelectSingleNode("Kisiler");

             foreach (XmlNode element in kök.SelectNodes("Kisi"))
             {
                 string adi = element.SelectSingleNode("Ad").InnerText;
                 string soyad = element.SelectSingleNode("Soyad").InnerText;
                 string ID = element.Attributes["ID"].Value;
                 lstTelefonListesi.Items.Add(ID + " - " + adi + "  " + soyad);
                 
             }
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            EkranaGetir(); 
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            document.Load(filestream);//Xml yüklendi.

            XmlNode edit = document.SelectSingleNode("Kisiler/Kisi[@ID='" + txtBxGüncellemeAdı.Tag.ToString() + "']");// Düzenlenecek olan öğelerin kullanıcı adı için oluşturduğumux textbox'un tag'ını kullanarak yukarıda oluşturduğumuz ID üzerinden işlem yapıyoruz.

            edit.SelectSingleNode("Ad").InnerText = txtBxGüncellemeAdı.Text;//İlgili yerlere ID üzerinden ulaşıp xml içerisini değiştiriyoruz.
            edit.SelectSingleNode("Soyad").InnerText = txtBxGüncellemeSoyadı.Text;
            edit.SelectSingleNode("Telefon").InnerText = mskTxtBxGüncellemeTelefon.Text;

            document.Save(filestream);//Xml dosyasının son halini kaydediyoruz.
            MessageBox.Show("Güncelleme işlemi başarıyla gerçekleştirildi.");
            Temizle();
            EkranaGetir();
        }

        

        private void btnSil_Click(object sender, EventArgs e)
        {
            soru = MessageBox.Show("Seçtiğiniz kaydı silmek istediğinizden emin misiniz?", "Kayıt Silme", MessageBoxButtons.YesNo);
            if (soru == DialogResult.Yes)
            {
                document.Load(filestream);//Xml dosyasını yüklüyoruz.

                XmlNode deleted = document.SelectSingleNode("Kisiler/Kisi[@ID='" + txtBxSilAdı.Tag.ToString() + "']");// İsmin.Tag'ını ID olarak tanımladığımız için 
                document.DocumentElement.RemoveChild(deleted);// Xml içerine ulaşıp siliyoruz.
                document.Save(filestream);// Son hali kaydediyoruz.
                Temizle();//Textbox ve MaskedTextBox'ları temizledik.
                EkranaGetir();//Xml'in içerisindeki verileri listbox'ta gösterdik.
            }
            else
            {
                Temizle();
                EkranaGetir();
            }
        }

        private void lstTelefonListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = lstTelefonListesi.SelectedItem.ToString();// listbox'taki öğelere ulaşmak için bir değişken tanımladık.
            string[] result = selected.Split('-');
            string editedID = result[0].Trim();//İlk bulduğu tirede Id'yi yakaladı.

            document.Load(filestream);//Xml yükledik.

            XmlNode edit = document.SelectSingleNode("Kisiler/Kisi[@ID='" + editedID + "']");// ID üzerinden işlem yapıyoruz.

            //Listbox'un öğesi seçili haldeyken sil ve kaydet işlemlerine öğenin verisi gidiyor.
            txtBxGüncellemeAdı.Text = edit.SelectSingleNode("Ad").InnerText;
            txtBxGüncellemeSoyadı.Text = edit.SelectSingleNode("Soyad").InnerText;
            mskTxtBxGüncellemeTelefon.Text = edit.SelectSingleNode("Telefon").InnerText;
            txtBxGüncellemeAdı.Tag = edit.Attributes["ID"].Value;


            txtBxSilAdı.Text = edit.SelectSingleNode("Ad").InnerText;
            txtBxSilSoyadı.Text = edit.SelectSingleNode("Soyad").InnerText;
            mskTxtBxSilTelefon.Text = edit.SelectSingleNode("Telefon").InnerText;
            txtBxSilAdı.Tag = edit.Attributes["ID"].Value;
        }
    }
}
