using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Kategori kategori = new Kategori();
        private void btnSerialize_Click(object sender, EventArgs e)
        {
            // Dosya akışı oluşturdum.
            FileStream dosyaAkışı = new FileStream("DB.data", FileMode.Create);

            // Ne türde bir serilize işlemi yapacağız..
            // Binary serilize işlemi yapacağımız için BinaryFormatter'ı çağırdık.
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            // Birinci parametre Dosya Akışı
            // İkinci parametr Kategori nesnesinin bir instance'i.
            binaryFormatter.Serialize(dosyaAkışı, kategori);

            // İşimiz bitt akışı kapattık.
            dosyaAkışı.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            kategori.KategoriAdı = "Bilgisayar";
            kategori.Açıklama = "Süper bilgisayarlar";
            kategori.Tarih = DateTime.Now;
        }

        private void btnDeSerialize_Click(object sender, EventArgs e)
        {
            // Serilize işlemi gibi ilk önce dosya akışı oluşturduk.
            // Fark olarak FileMode Create değil de Open. Çünkü artık bir dosyamız var ve biz onu açıp kullanacağız.
            FileStream dosyaAkışı = new FileStream("DB.data", FileMode.Open);

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            Kategori atamaYapılanKategori = (Kategori)binaryFormatter.Deserialize(dosyaAkışı);

            dosyaAkışı.Close();
        }
    }
}
