using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // Abstract (soyut) sınıflar
    // 1.Abstract sınıflardan instance alınamaz. (new Keyword'ü ile birlikte)
    // 2.Abstract sınıflar miras alındığı takdirde kullanılabilir.
    // 3.Abstract sınıftan miras almış sınıfların insance'i oluşturalabilir.
    // Mutlaka Base Sınıf yani miras veren (Abstract) olmalı.

    // Abstract Üyeler
    // 1.Abstract üyeler yalnızca abstract sınıflarda yazılabilir.
    // 2.Abstract üyelerin detayları (kodları) (implementation) yoktur.
    // 3.Yalnızca metotlar (+property) abstract olarak işaretlenebilir. (Fieldlar işaretlenemez.)
    // 4.Abstract üyeler kesinlikle private olamaz. Proctected olabilir. Proctected Kalıtım ve sınıflara erişim sağlayabilir.
    // 5.Abstract üyeler mutlaka türetilen sınıf tarafından ezilmek zorundadır. (Override edilmeli.)

    // Virtual (Sanal) üyeler
    // 1.Virtual üyeleri abstract veya normal sınıflarda yazabiliriz.
    // 2.Virtual üyelerin varsayılan uyarlaması (kodlaması) (implementation) vardır.
    // 3.Yalnızca metotlar (+propery) Virtual olarak işaretlenebilir. (Fieldlar işaretlenemez.)
    // 4.Virtual üyelerin kesinlikle private olamaz.
    // 5.Virtual üyeler ezilmek zorunda değildir.
    abstract class Vehicle : Object // internal class Vehicle
    {
        public string Make { get; set; }    // Marka
        public string Model { get; set; }   // Model
        public int Engine { get; set; }     // Motor gücü
        public Color Color { get; set; }    // Renk

        // Abstract üyeleri ezmek Farz
        public abstract string Start(); // Her araç aynı sesi çıkarmayacağı için metodu abstract yaptık.
        //public string Start()
        //{
        //    return "Tırtırtır";
        //}

        public abstract string Stop();
        //public string Stop()
        //{
        //    return "Şıp";
        //}

        // Virtual üyeleri ezmek Keyfekeder
        public virtual string Horn() // Varsayılan olarak duyulsun. Ama istediğimiz yerde bunu değiştirebilmeliyiz. (Virtual)
        {
            return "Düüüt";
        }
    }
}
