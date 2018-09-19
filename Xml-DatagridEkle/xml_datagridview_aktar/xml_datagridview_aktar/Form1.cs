using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace xml_datagridview_aktar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void yukle()
        {
            XmlDocument i = new XmlDocument();
            DataSet ds = new DataSet();
            //xml dosyamızı okumak için bir reader oluşturuyoruz.
            XmlReader xmlFile;
            //readerin içine pathini verdiğimiz dosyayı dolduruyoruz.burada önemli olan bir nokta var.ya path imizin başına @ yazacağız ya da çift  kullanacağız.
            xmlFile = XmlReader.Create(@"veri.xml", new XmlReaderSettings());
            //içeriği Dataset e aktarıyoruz.
            ds.ReadXml(xmlFile);
            //gridviewin kaynağı olarak dataseti gösteriyoruz.
            dataGridView1.DataSource = ds.Tables[0];
            xmlFile.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            yukle();

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");

            x.Element("Ogrenciler").Add(
            new XElement("ogrenci",
            new XElement("id", textBox1.Text),
            new XElement("adi",textBox2.Text),
            new XElement("soyadi",textBox3.Text),
            new XElement("telefonu", textBox4.Text)
            ));

            x.Save(@"veri.xml");
            yukle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");

            //ürün id= textbox'a girilen numaralı öğrenciyi sil
            x.Root.Elements().Where(a => a.Element("id").Value == textBox1.Text).Remove();
            x.Save(@"veri.xml");
            yukle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            XElement node = x.Element("Ogrenciler").Elements("ogrenci").FirstOrDefault(a => a.Element("id").Value.Trim() == textBox1.Text);
            if (node != null)
            {
                node.SetElementValue("adi", textBox2.Text);
                node.SetElementValue("soyadi", textBox3.Text);
                node.SetElementValue("telefonu", textBox4.Text);
                x.Save(@"veri.xml");
                yukle();
            }
        }
    }
}
