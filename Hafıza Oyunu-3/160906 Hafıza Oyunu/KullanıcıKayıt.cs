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
using System.Xml.XPath;
using System.Xml;
using System.Xml.Serialization;

namespace _160906_Hafıza_Oyunu
{
    public partial class KullanıcıKayıt : Form
    {
        public KullanıcıKayıt()
        {
            InitializeComponent();
        }
        DialogResult dialogResult = new DialogResult();

       
        XmlDocument document = new XmlDocument();

        string filestream = Application.StartupPath + "\\PuanTablosu.xml";
        
        private void KullanıcıKayıt_Load(object sender, EventArgs e)
        {
            Yükle();
        }
        
        private void btnKullanıcıKaydet_Click(object sender, EventArgs e)
        {
            
            document.Load(filestream);
            XmlElement Oyuncu = document.CreateElement("Kullanici");
            XmlAttribute ID = document.CreateAttribute("ID");

            XmlNode kullanıcıİsmi = document.CreateNode(XmlNodeType.Element, "KullaniciAdi", null);

            XmlNode alınanPuan = document.CreateNode(XmlNodeType.Element, "Puan", null);

            XmlNode sonElement = document.SelectSingleNode("Kullanicilar").LastChild;

            int sonID;

            if (sonElement != null)
            {
                sonID = int.Parse(sonElement.Attributes["ID"].Value);
            }
            else
                sonID = 0;

            ID.Value = (sonID + 1).ToString();
            kullanıcıİsmi.InnerText = txtBxKayıtKullanıcıAdı.Text;
            alınanPuan.InnerText = lblKullanıcıGösterilenPuan.Text;

            Oyuncu.Attributes.Append(ID);
            Oyuncu.AppendChild(kullanıcıİsmi);
            Oyuncu.AppendChild(alınanPuan);

            document.DocumentElement.AppendChild(Oyuncu);
            document.Save(filestream);
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = txtBxKayıtKullanıcıAdı.Text;
            listViewItem.SubItems.Add(lblKullanıcıGösterilenPuan.Text);
            lstPuanTablosu.Items.Add(listViewItem);

            MessageBox.Show("Puanınız tabloya eklendi");

            VeriTemizle();
           
        }
        void VeriTemizle()
        {
            txtBxKayıtKullanıcıAdı.Clear();
            lblKullanıcıGösterilenPuan.Text = "";
        }

        void Yükle()
         {
            lstPuanTablosu.Items.Clear();
            document.Load(filestream);

            XmlNode RootElement = document.SelectSingleNode("Kullanicilar");

            foreach (XmlNode element in RootElement.SelectNodes("Kullanici"))
            {
                string kullanıcıAdı = element.SelectSingleNode("KullaniciAdi").InnerText;
                string puan = element.SelectSingleNode("Puan").InnerText;
                string ID = element.Attributes["ID"].Value;


                //Burada listView'in kolonları instance almama rağmen gelmedi. Mecbur ikisini bir olarak çekiyorm. Ondan tabloda okurken tek kolonda görünüyor.
                lstPuanTablosu.Items.Add(kullanıcıAdı + " Puanı:" + puan);
                
                
            }
        }
        

        private void lstPuanTablosu_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            dialogResult = MessageBox.Show("Yeniden oynamak ister misiniz?", "Yeni Oyun", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }
    }
}
