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
using System.Xml.Linq;

namespace HafızaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OyunKısmı oyunKısmı = new OyunKısmı();
        int puan2 = 100;
        int rastgele;
        public  List<Button> arrayBtn = new List<Button>();
        Color renk = Color.White;
        int[] array;
        int Puan = 500;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            
            timerZaman.Interval = 1000;
            if(cmBoxZorluk.SelectedIndex==0)
            {
                
                ButonOlustur();
                Gizle();
                RastgeleYerBelirle();
                renkVer();
                timer1.Interval = 1000;

            }
            else if(cmBoxZorluk.SelectedIndex==1)
            {
                
                ButonOlustur();
                Göster();
                RastgeleYerBelirle();
                renkVer();
                timer1.Interval = 1000;
                puan2 = 100;
            }
            else if (cmBoxZorluk.SelectedIndex == 2)
            {
                
                ButonOlustur();
                Göster();
                RastgeleYerBelirle();
                renkVer();
                timer1.Interval = 500;
                puan2 = 200;
            }
            else if (cmBoxZorluk.SelectedIndex == 3)
            {
                
                ButonOlustur();
                Göster();
                RastgeleYerBelirle();
                renkVer();
                timer1.Interval = 200;
                puan2 = 300;
            }
            timer1.Start();
            timerZaman.Start();
        }

        public void ButonOlustur()
        {
            int location=50;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                   
                    Button bttn = new Button();
                    bttn.Name = "btn" + i + j;
                    bttn.Width = 40;
                    bttn.Height = 40;
                    bttn.Top = location;
                    bttn.Left = 50 * j + 50;
                    bttn.BackColor = Color.White;
                    bttn.Click += bttn_Click;
                    arrayBtn.Add(bttn);
                    oyunKısmı.Controls.Add(bttn);
                }
                location += 50;
            }
            oyunKısmı.Show();
            this.Hide();
        }
        int hakKontrol = 0;
        int oyunSonu = 0;
        void bttn_Click(object sender, EventArgs e)
        {
            Button clickButton = sender as Button;
            
                if (arrayBtn[array[0]] == clickButton)
                {
                    if (arrayBtn[array[0]].BackColor == Color.White)
                    {
                        arrayBtn[array[0]].BackColor = Color.Blue;
                        Puan += puan2;
                        oyunSonu++;
                    }
                }
                else if (arrayBtn[array[1]] == clickButton)
                {
                    
                    if(arrayBtn[array[1]].BackColor == Color.White)
                    {

                        arrayBtn[array[1]].BackColor = Color.Blue;
                        Puan += puan2;
                        oyunSonu++;
                    }
   
                }
                else if (arrayBtn[array[2]] == clickButton)
                {
                    if (arrayBtn[array[2]].BackColor == Color.White)
                    {
                        arrayBtn[array[2]].BackColor = Color.Blue;
                        Puan += puan2;
                        oyunSonu++;
                    }
                }
                else if (arrayBtn[array[3]] == clickButton)
                {
                    if (arrayBtn[array[3]].BackColor == Color.White)
                    {
                        arrayBtn[array[3]].BackColor = Color.Blue;
                        Puan += puan2;
                        oyunSonu++;
                    }

                }
                else if (arrayBtn[array[4]] == clickButton)
                {
                    if (arrayBtn[array[4]].BackColor == Color.White)
                    {
                        arrayBtn[array[4]].BackColor = Color.Blue;
                        Puan += puan2;
                        oyunSonu++;
                    }
                }
                else
                {
                    clickButton.BackColor = Color.Red;
                    hakKontrol++;
                    Puan -= 10;
                }
            if(hakKontrol>3)
            {
                timerZaman.Stop();
                MessageBox.Show("Malesef Bitti. BAŞARAMADIN.");
                Application.Restart();
            }
            if(oyunSonu==5)
            {
                
                timerZaman.Stop();
                MessageBox.Show("Tebrikler Usta Başarılı");
                if(txtName.Text!=string.Empty)
                {
                    XmlDocument doc = new XmlDocument(); // Xml dosyamızı okumak için XmlDocument sınıfından yararlanıyoruz.
                    doc.Load("xmlKlasor.xml");
                    XmlElement root = doc.DocumentElement;
                    XmlNodeList kayitlar = root.SelectNodes("/Rekor/Kisiler");
                    if (File.Exists("xmlKlasor.xml")) // Xml dosyamıza kayıt eklemede hata almamak için dosyanın var olup olmadığını kontrol ediyoruz.
                    {
                        XDocument xDoc = XDocument.Load("xmlKlasor.xml");
                        XElement currentElement = xDoc.Root.Elements().FirstOrDefault(xe => xe.Element("adi").Value == txtName.Text );
                        if (currentElement != null)
                        {
                            XElement currentElement2 = xDoc.Root.Elements().FirstOrDefault(xe => int.Parse(xe.Element("puan").Value) < int.Parse(oyunKısmı.lblPuan.Text));
                            if (currentElement2 != null)
                            {
                                currentElement.SetElementValue("puan", oyunKısmı.lblPuan.Text);
                                xDoc.Save("xmlKlasor.xml");
                            }
                        }
                        else
                        {
                            XmlElement UserElement = doc.CreateElement("Kisiler"); // Veritabanından tablo ismi gibi düşünbebilirsiniz.

                            XmlElement adi = doc.CreateElement("adi"); //Oluşturulan xml içindeki Kullanicilar elementine adi isimli element (DB deki gibi düşünürsek Kullanicilar tablosuna adi kolonunu ekliyoruz.)
                            adi.InnerText = txtName.Text;
                            UserElement.AppendChild(adi);

                            XmlElement Puan = doc.CreateElement("puan"); // İkinci elementi ekliyoruz.(Yani ikinci kolonu)
                            Puan.InnerText = oyunKısmı.lblPuan.Text;
                            UserElement.AppendChild(Puan);



                            doc.DocumentElement.AppendChild(UserElement);

                            XmlTextWriter xmleekle = new XmlTextWriter("xmlKlasor.xml", null);
                            xmleekle.Formatting = Formatting.Indented;
                            doc.WriteContentTo(xmleekle);
                            xmleekle.Close();
                        }
                    }
                    List();
                    
                }Application.Restart();
            }
        }
        public void Göster()
        {
            oyunKısmı.label1.Show();
            oyunKısmı.label3.Show();
            oyunKısmı.lblPuan.Show();
            oyunKısmı.lblZaman.Show();
        }
        public void Gizle()
        {
            oyunKısmı.label1.Hide();
            oyunKısmı.label3.Hide();
            oyunKısmı.lblPuan.Hide();
            oyunKısmı.lblZaman.Hide();
        }
        public void RastgeleYerBelirle()
        {
            array = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < 5; )
            {
                rastgele = rnd.Next(0, 100);
                if(i==0)
                {
                    array[i] = rastgele;
                    i++;
                }
                else if (array.Contains(rastgele))
                {
                    continue;
                }
                else
                {
                    array[i] = rastgele;
                    i++;
                }
            }
            
        }
        int sayi = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayi % 2 == 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    arrayBtn[array[i]].BackColor = Color.Blue;
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    arrayBtn[array[i]].BackColor = Color.White;
                }
            }
            if (sayi == 5)
                timer1.Stop();
            sayi++;
            //sayi++;
            //if(sayi==number)
            //{
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        arrayBtn[array[i]].BackColor = Color.White;
                    
            //    }
            //    timer1.Stop();
            //}
        }
        int zamanKontrol = 50;
        
        private void timerZaman_Tick(object sender, EventArgs e)
        {
            oyunKısmı.lblZaman.Text = zamanKontrol.ToString();
            oyunKısmı.lblPuan.Text = Puan.ToString();
            zamanKontrol--;
            Puan -= 10;
            if(zamanKontrol==0)
            {
                MessageBox.Show("Oyun Bitti Başaramadın.!");
                timerZaman.Stop();
                
            }
            if(Puan==0)
            {
                MessageBox.Show("Oyun Bitti Başaramadın.!");
                timerZaman.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmBoxZorluk.SelectedIndex = 0;
            if (!File.Exists("xmlKlasor.xml"))//dosya varmı diye kontrol ettirdim.
            {
                XmlTextWriter xmlCreate = new XmlTextWriter("xmlKlasor.xml", null);

                xmlCreate.WriteStartDocument();

                xmlCreate.WriteComment("Oluşturulan xml hakkında bilgi");

                xmlCreate.WriteStartElement("Rekor"); // Rehber elementi gibi özellikleri ekledik.

                xmlCreate.WriteEndDocument();

                xmlCreate.Close();
            }
            List();
        }
        public void List()
        {
            if (File.Exists("xmlKlasor.xml"))
            {
                lstVw.Items.Clear();

                XmlDocument doc = new XmlDocument();

                doc.Load("xmlKlasor.xml");
                XmlElement root = doc.DocumentElement;
                XmlNodeList users = root.SelectNodes("/Rekor/Kisiler");
                
                foreach (XmlNode selected in users)
                {
                    ListViewItem lv = new ListViewItem();
                    lv.Text = selected["adi"].InnerText;
                    lv.SubItems.Add((selected["puan"].InnerText));
                    lstVw.Items.Add(lv);
                    
                }
                lstVw.Items.Clear();
                XElement root2 = XElement.Load("xmlKlasor.xml");
                var orderedtabs = root2.Elements().OrderByDescending(a => (int)a.Element("puan")).ToList().Take(10);

                foreach (var tab in orderedtabs)
                {
                    var Nick = tab.Element("adi").Value.ToString();
                    var Score = tab.Element("puan").Value.ToString();
                    ListViewItem listViewItem = new ListViewItem();

                    listViewItem.Text = Nick;
                    listViewItem.SubItems.Add(Score);
                    lstVw.Items.Add(listViewItem);
                }
            }
        }

        private void LstVw_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
        }

        private void renkVer()
        {
            for (int i = 0; i < 5; i++)
            {
                arrayBtn[array[i]].BackColor = renk;
            }
        }

        private void lstVw_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
