using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ChangeOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKur_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDokuman = new XmlDocument();
            xmlDokuman.Load("Kurlar.xml");

            XmlElement rootEleman = xmlDokuman.DocumentElement;
            XmlNodeList liste = rootEleman.GetElementsByTagName("Currency");

            for (int i = 0; i < liste.Count; i++)
            {
                // Isım = ad;   ForexBuying = Soyad;
                Döviz döviz = new Döviz();
                XmlElement currency =(XmlElement)liste[i];
               string dövizTürü = currency.GetElementsByTagName("Isim")[i].InnerText; // İki tag arasındaki elementi al.
               string alisfiyatı = currency.GetElementsByTagName("ForexBuying")[i].InnerText;
               if (!string.IsNullOrEmpty(alisfiyatı))
               {
                   döviz.AlışFiyatı = Convert.ToDecimal(alisfiyatı);
               }

               döviz.DövizAdı = dövizTürü;

               lstKurBilgileri.Items.Add(döviz);
            }

        }
    }
}
