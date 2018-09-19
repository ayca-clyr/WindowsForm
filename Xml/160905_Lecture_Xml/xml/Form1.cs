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

namespace xml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public List<Student> _öğrenciListesi = new List<Student>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //txtBxFirstName.Text  != ""  if içine yazılabilirdi.
            if (!(txtBxFirstName.Text.Length > 0 && txtBxLastName.Text.Length > 0 && numericSchoolNo.Value > 0))
            {
                return;   // Eğer bu girdiklerimiz olmazsa başa dön.
            }

            Student student = new Student();
            student.firstName = txtBxFirstName.Text;
            student.lastName = txtBxLastName.Text;
            student.schoolNo =(int)numericSchoolNo.Value;
            student.dateOfBirth = dtpDateOfBirth.Value;
            student.age = DateTime.Now.Year - student.dateOfBirth.Year;

            // İlk değer txt olarak ata sonrakiler SubItems şeklinde eklenir.
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = student.firstName;
            //lvI.SubItems.Add(student.firstName);
            listViewItem.SubItems.Add(student.lastName);
            listViewItem.SubItems.Add(student.schoolNo.ToString());
            listViewItem.SubItems.Add(student.dateOfBirth.ToShortDateString()); // Saat olmadan tarihi gösterir.
            listViewItem.SubItems.Add(student.age.ToString());

            lVOgrenci.Items.Add(listViewItem);

            // Nesneye atanmış değerleri başka yere taşımamı sağlar. Tek Tek tanımlamak yerine tüm hepisni getirir.
            listViewItem.Tag = student; 

            MessageBox.Show("Yeni Öğrenci Eklenmiştir.");

           Temizle();
          
        }

    

        private void Temizle()
        {
            #region For'lu
            // Toolbox'daki herşey Controls'dur.
            //for (int i = 0; i < this.Controls.Count; i++)
            //{
            //    if (Controls[i] is TextBox)
            //    {
            //        Controls[i].Text = "";
            //        Controls[i].Text = string.Empty;
            //    }
            //    else if(Controls[i] is NumericUpDown)
            //    {
            //        (Controls[i] as NumericUpDown).Value = 0;  // Cast işlemi yaptık.
            //    }
            //    else if (Controls[i] is DateTimePicker)
            //    {
            //        (Controls[i] as DateTimePicker).Value = DateTime.Now;
            //    }
            //}
            #endregion 
            // Foreach'li
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

        private void btnTekOgrenciKaydet_Click(object sender, EventArgs e)
        {
            if (!(txtBxFirstName.Text != "" && txtBxLastName.Text.Length > 0 && numericSchoolNo.Value > 0))
            {
                return;
            }

            Student student = new Student();
            student.firstName = txtBxFirstName.Text;
            student.lastName = txtBxLastName.Text;
            student.schoolNo =(int) numericSchoolNo.Value;
            student.dateOfBirth = dtpDateOfBirth.Value;
            student.age = DateTime.Now.Year - student.dateOfBirth.Year;

            // Adım 1 : XML dosyasını oluşturup, o dosya ile bağlantı sağlayacak hamal nesne oluşturulur.

            FileStream dosyaAkışı = File.Create("öğrenciListesi.xml"); // bin dosyasına kaydediyor.

            // Adım 2 : Oluşan XML dosyaya XML datası yerleştirmemiz gerekiyor.
            // Bu XML datasını üretecek nesneyi oluşturuyor.
            // XmlSerializer, belli bir sınıfın nesnesini XML koduna dönüştürür.

            // Student nesnesini Xml'e çevirdik. typeof = tip
            XmlSerializer xmlSerileştirici = new XmlSerializer(typeof (Student));

            // Adım 3:  Xml'e dönüştürme işlemi Serialize() methodu üzerinden yapılır.
            xmlSerileştirici.Serialize(dosyaAkışı, student);

            // Adım 4 : Her akışta olduğu gibi bu doay akışında da kapatıyoruz.
            dosyaAkışı.Close();

            MessageBox.Show("İlgili Öğrenci Serilize Edildi.(Serileştirildi.)");
            

        }

        private void btnTumOgrenciler_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            foreach (ListViewItem item in lVOgrenci.Items)  //ListView'deki değerleri tadgakiÖgrenciye tek tek atıyor.
            {
                Student tagdakiOgrenci =(Student)item.Tag;  // item.Tag as Student
                students.ÖğrenciListesi.Add(tagdakiOgrenci);
            }

            // A1 : DosyaAkısi oluşturduk.
            FileStream dosyaAkısi = File.Create("BütünÖğrenciler.xml");
            
            // A2 : Serileştirici nesne tanımlandı.
            XmlSerializer xmlSerilestirici = new XmlSerializer(typeof (List<Student>));
            // XmlSerializer xmlSerilestirici = new XmlSerializer(typeof(List<Students));

            // A3 : Serileştirme yapıldı.
            xmlSerilestirici.Serialize(dosyaAkısi, students.ÖğrenciListesi);

            // A4 : DosyaAkısi boşa çıkar.
            dosyaAkısi.Close();

            MessageBox.Show("Tüm öğrenciler Xml tipinde serileştirildi.");

        }

       
    }
}
