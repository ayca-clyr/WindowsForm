using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_Struct_Enum
{
    class Ogrenci
    {
        public Ogrenci()
        {
            Dersler = new List<Ders>();
        }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Alan Alani { get; set; }
        public List<Ders> Dersler { get; set; }
        public decimal Ortalama
        {
            get
            {
                decimal toplam = 0;
                foreach (Ders not in Dersler)
                {
                    toplam += not.Ortalama;
                }
                return toplam / Dersler.Count();
            }
        }
        public ÖgrenciDurum Durum
        {
            get
            {
                if (Ortalama >= 70)
                    return ÖgrenciDurum.Gecti;
                else if (Ortalama >= 50)
                    return ÖgrenciDurum.SartliGecti;
                else
                    return ÖgrenciDurum.Kaldi;
            }


        }
    }



        struct Ders
        {

            public string Adi { get; set; }
            public decimal Vize { get; set; }
            public decimal Final { get; set; }
            public decimal Ortalama { get { return Vize * 0.4m + Final * 0.6m; } }
        }

        enum Alan
        {
            Sayisal,
            Sozel,
            EsitAgirlik,
            Dil
        }
        enum ÖgrenciDurum
        {
            Gecti,
            SartliGecti,
            Devamsiz,
            Kaldi,
            SinifTekrari
        }
    }
