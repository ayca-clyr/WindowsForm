﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OOP_Constructor
{
    public class Personel
    {
     /*
        Class içinde tanımlanan değişkenlere field(alan) denir. Class ile ilgili her bir nesnenin özelliği olacaktır.
        Access Modifiers: Sınıfın içindeki elemanlara nerelerden erişileceğini belirleyen elemanlara Access Modifier denir 5 tanedir.

        Private: Özelliği sadece tanımlandığı sınıf içinden erişilebilir yapar. Sınıf içinde access modifier yazılmadıysa private kabul edilir.
        Protected: Miras alınan sınıflardan erişilebilmeyi sağlar.
        İnternal : Bulunduğu proje içindeki her yerden erişilmeyi sağlar.
        Protected - Internal : hem miras alınan hem de proje içinde erişilmeyi sağlar.
        Public : Umumi demektir her yerden erişilebilmeyi sağlar. Hiçbir kısıtlama koymaz bütün izinleri açar.

        Constructor : Yapıcı metotdur. Ram'de nesneyi üreten metotdur. 
        class oluşurken bizim de yapmak istediğimiz işlemler var ise onları yapmak için kullanabiliriz.
        Veya sınıfın tanmlanması sırasında parametre alarak tek satırda oluşmasını sağlayabiliriz.
        Geriye dönüş tipi olmayan tek metotdur. 
        Tanımlanmazsa varsıyalan olarak Default Constructor geçerlidir.(parametre almayan new Personel() metodu)
        Tanımlanırsa Defult iptal olur. Tanımlanan geçerlidir.
        Overload yapılabilir.
        */

        public Personel()//Constructor örneği
        {
            IseGirisTarihi = DateTime.Now;
            Adi = "No Name";
            Soyadi = "Anonymous";
            TCKimlik = "Girilmedi";
            SicilNo = "Girilmedi";

        }

        public Personel(string adi,string soyadi)
        {
            IseGirisTarihi = DateTime.Now;
            Adi = adi;
            Soyadi = soyadi;
        }
        ~Personel()//Destructor - SonSöz: İşlemler sona ererken son yapılacak işlemdir.
        {
            System.Windows.Forms.MessageBox.Show("Bayyy");
        }
        internal string Adi;
        internal string Soyadi;
        internal string SicilNo;
        internal string TCKimlik;
        internal decimal Maas;
        internal DateTime IseGirisTarihi;

        internal void İseAl()
        {

        }
        internal decimal KidemTazminatiHesapla()
        {
            return 0;
        }
        internal void Kov()
        {

        }
    }
}
