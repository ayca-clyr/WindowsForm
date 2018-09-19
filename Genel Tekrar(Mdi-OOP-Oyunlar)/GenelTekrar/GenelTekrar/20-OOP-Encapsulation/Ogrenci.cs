using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_Encapsulation
{
    public class Ogrenci
    {
        /*
         * Auto Property = Field'i içinde olan property'dir. Faydası tekrar field oluşturmayız, böylelikle field kalabalığı oluşmamış olur. Property field'ını kendi içinde oluşturur(backing field)
         * auto propert içerisindeki get ve set komutlarının içinde komut olamaz. olursa auto property bozulur. Get veya set silinimez. Eğer silinirse auto property bozulur.
         */
        private string adi;//Field

        public string Adi//Scorp parantezi açtığımız anda bu bir Property olur.
        {
            get { return adi; }
            set
            {
                if (value == "Alper")
                    throw new Exception("Alper değeri kabul edilebilir bir değer değildir.");
                adi = value;
            } // dışarıdan gönderilen değer value ile gelir. 
        }

        public string Soyadi { private get; set; }//auto property 
        public string TCKN { get; private set; }
        private DateTime dogumTarihi;

        public DateTime DogumTarihi
        {
            get { return dogumTarihi; }

            set
            {
                if (value <= DateTime.Now)
                    dogumTarihi = value;
                else
                    dogumTarihi = DateTime.Now;
            }
        }

        public int Yas
        {

            get
            {
                return
                    (int)((DateTime.Now - DogumTarihi).TotalDays / 365); //timspan zamansal büyüklük 
            }
        }

        double vize;

        public double Vize
        {
            get { return vize; }
            set { if (value >= 0 && value <= 100)vize = value; }
        }

        double final;

        public double Final
        {
            get { return final; }
            set { if (value >= 0 && value <= 100)final = value; }
        }

        private double ortalama;

        public double Ortalama
        {
            get { return Vize * 0.4 + Final * 0.6; }

        }

        /*public void setAdi(string value)
        {
            if (value == "Alper")
                throw new Exception("Alper kabul edilemez");
            adi = value;
        }
        public string getAdi()
        {
            return adi;
        }*/
    }
}
