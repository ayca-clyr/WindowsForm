using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_OOP_Struct_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ögrenci = new Ogrenci();
            ögrenci.Adi = "Alaaddin";
            ögrenci.Soyadi = "Özdemir";
            ögrenci.Alani = Alan.Sayisal;
            Ders ders = new Ders { Adi = "Matematik", Vize = 60, Final = 60 };//Bu yönteme object initializer yöntemi denir.

            Ders ders2 = new Ders { Adi = "Fizik", Vize = 87, Final = 60 };

            ögrenci.Dersler.Add(ders);
            ögrenci.Dersler.Add(ders2);

            switch (ögrenci.Durum)
            {
                case ÖgrenciDurum.Gecti:
                    MessageBox.Show("Helal olsun direk geçtin");
                    break;
                case ÖgrenciDurum.SartliGecti:
                    MessageBox.Show("Neyse şimdilik geç bakalım,ama daha çok çalış olmaz böyle");
                    break;
                case ÖgrenciDurum.Devamsiz:
                    MessageBox.Show("Tek görevin bu, bunuda yapamadın");
                    break;
                case ÖgrenciDurum.Kaldi:
                    MessageBox.Show("seneye yine bekleriz");
                    break;
                case ÖgrenciDurum.SinifTekrari:
                    MessageBox.Show("Seneye görüşürüz");
                    break;
                default:
                    break;
            }

            
        }
    }
}
