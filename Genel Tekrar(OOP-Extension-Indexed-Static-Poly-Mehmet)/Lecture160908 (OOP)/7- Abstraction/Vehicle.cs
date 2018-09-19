using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__Abstraction
{
    // default olarak internaldır

    // Abstract (soyut) sınıflar
    //1.Abstract classlardan instance alınamaz(new Keyword'ü ile birlikte) 
    //2.Absstact classlar miras alındığı takdirde kullanılabilir. (Base sınıf: Miras veren sınıf. Abstract classlar kesinlikle base sınıf olmalı ki kullanılabilsin.)
    // 3.Abstract sınıftan miras aslmış sınıfların instance' ı oluşturulabilir.


    // Abstract Üyeler
    //1. Abstract üyeler yalnızca abstract sınıflarda yazılabilir.
    //2. Abstract üyelerin detayları yoktur (kodları) (implementation) - kodların yazılması - Car sınıfında start methonunda kodların yazılması implementation olur
    //3. Yalnızca methodlar (+property) abstract olarak işaretlenebilir.
    //4. Abstract üyeler kesinlikle private olamaz. // protected olabilir - kalıtım alıyoruz zaten
    //5. Abstract üyeler mutlaka türetilen sınıf tarafından ezilmek zorundadır.


    // Virtual 
    // Ezmek şart değildir istersek ezebiliriz.
    // Kendi yazdığımız method u ezebilmek için kullanılır.
    // İlla abstract sınıfta yazılacak diye bir kaide yok 

    //1- Virtual üyeleri abstract veya normal sınıflarda yazabiliriz.
    //2- Virtual üyelerin varsayılan uyarlaması (kodlaması) (implementation) vardır.
    //3- Yalnızca metotlar(+ property) virtual olarak işaretlenebilir,
    //4- virtual üüyeler kesinlikle private olamaz
    // 5- virtual üyeler ezilmek zorunda değildir.

    // Bu sınıf hiçbir şeyden miras almıyor derlenme aşamasında Vehicle : Object 'ten miras alır
   abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Engine { get; set; }
        public Color Color { get; set; }

        // Her sesi farklı çıkartmak için abstact yapmalıyız böyle hep aynı şey döner
        //public string Start()
        //{
        //    return "Tırtırtır";
        //}

        public abstract string Start();

        //public string Stop()
        //{
        //    return "Şıp";
        //}

        public abstract string Stop();

        public virtual string Horn()
        {
            return "Düüüüt";
        }
    }
}
