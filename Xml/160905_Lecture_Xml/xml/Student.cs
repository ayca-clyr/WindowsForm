using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace xml
{
    public class Student
    {
        // get --> Erişebilir.   set --> Değiştirilebilir.
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int schoolNo { get; set; }
        public DateTime dateOfBirth { get; set; }
        
        [XmlIgnore] // Erişimini engelle. XML'de age göstermez. Tek satırlık kod. Altındaki 1 satırlık kodu göstermez.
        public int age { get; set; }

    }
    public class Students
    {
        public Students()  // ctor Nesne'den örnek alınır alınmaz bu method çalışacak. İki skop arasında çalışacak ilk methoddur bu.
        {
            ÖğrenciListesi = new List<Student>();  
        }
        public List<Student> ÖğrenciListesi { get; set; } // Instance almıyor. İstediği yere yazılabilir. Amaç listenin okunabilir ve değiştirebilir olmasıdır.
    }
}
