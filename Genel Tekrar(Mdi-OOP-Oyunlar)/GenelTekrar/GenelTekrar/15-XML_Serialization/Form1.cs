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
using System.Xml.Serialization;

namespace _15_XML_Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(txtBxAdı.Text.Length > 0 && txtBxSoyadı.Text.Length > 0 && numOkulNo.Value > 0))
                return;
            Öğrenci öğrenci = new Öğrenci();
            öğrenci.Adı = txtBxAdı.Text;
            öğrenci.Soyadı = txtBxSoyadı.Text;
            öğrenci.OkulNo =(int)numOkulNo.Value;
            öğrenci.DogumTarihi = dtpDogumTarihi.Value;
            öğrenci.Yaş = DateTime.Now.Year - dtpDogumTarihi.Value.Year;

            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = öğrenci.Adı;
            listViewItem.SubItems.Add(öğrenci.Soyadı);
            listViewItem.SubItems.Add(öğrenci.OkulNo.ToString());
            listViewItem.SubItems.Add(öğrenci.DogumTarihi.ToShortDateString());
            listViewItem.SubItems.Add(öğrenci.Yaş.ToString());

            lwOgrenciler.Items.Add(listViewItem);
            lwOgrenciler.Tag = öğrenci;

            MessageBox.Show("Öğrenci kaydedildi");
            Temizle();
            
        }

        private void Temizle()
        {
            #region For'lu Yöntem
            //for (int i = 0; i < this.Controls.Count; i++)//Control forma eklediğim her öğedir. Labeller,butonlar,textBoxlar vs.. Herşey
            //{
            //    if(Controls[i] is TextBox)
            //    {
            //        Controls[i].Text = string.Empty;
            //    }
            //    else if (Controls[i] is NumericUpDown)
            //    {
            //        (Controls[i] as NumericUpDown).Value=0; //  Numeric up down olan kontrollerin değerini 0 yapar. Bu şekilde cast etmiş oluyoruz.
            //    }
            //    else if (Controls[i] is DateTimePicker)
            //    {
            //        (Controls[i] as DateTimePicker).Value = DateTime.Now;
            //    }

            //}
            #endregion

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                else if (control is NumericUpDown)
                {
                    (control as NumericUpDown).Value = 0;
                }
                else if (control is DateTimePicker)
                {
                    (control as DateTimePicker).Value = DateTime.Now;
                }
            }
        }

        private void btnSingleSerialization_Click(object sender, EventArgs e)
        {
            if (!(txtBxAdı.Text.Length > 0 && txtBxSoyadı.Text.Length > 0 && numOkulNo.Value > 0))
                return;

            Öğrenci öğrenci = new Öğrenci();
            öğrenci.Adı = txtBxAdı.Text;
            öğrenci.Soyadı = txtBxSoyadı.Text;
            öğrenci.OkulNo = (int)numOkulNo.Value;
            öğrenci.DogumTarihi = dtpDogumTarihi.Value;
            öğrenci.Yaş = DateTime.Now.Year - dtpDogumTarihi.Value.Year;

            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = öğrenci.Adı;
            listViewItem.SubItems.Add(öğrenci.Soyadı);
            listViewItem.SubItems.Add(öğrenci.OkulNo.ToString());
            listViewItem.SubItems.Add(öğrenci.DogumTarihi.ToShortDateString());
            listViewItem.SubItems.Add(öğrenci.Yaş.ToString());
            lwOgrenciler.Items.Add(listViewItem);

            lwOgrenciler.Tag = öğrenci;

            FileStream hamal = File.Create("Öğrenciler.xml");

            XmlSerializer xmlSerileştirici = new XmlSerializer(typeof(Öğrenci));
            xmlSerileştirici.Serialize(hamal, öğrenci);
            hamal.Close();
            
            MessageBox.Show("Öğrenci Xml'e kaydoldu.");

            Temizle();
           
        }

        private void btnAllSerialization_Click(object sender, EventArgs e)
        {
            Öğrenciler öğrenciler = new Öğrenciler();

            foreach (ListViewItem item in lwOgrenciler.Items)
            {
                Öğrenci tagdangelen = item.Tag as Öğrenci;
                öğrenciler.ÖğrenciListesi.Add(tagdangelen);
                
            }

            FileStream hamal = File.Create("Bütün Öğrenciler.xml");

            XmlSerializer xmlSerileştirici = new XmlSerializer(typeof(List<Öğrenci>));

            xmlSerileştirici.Serialize(hamal, öğrenciler.ÖğrenciListesi);

            hamal.Close();

            MessageBox.Show("Tüm öğrenciler Xml'e dönüştü.");
            Temizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
