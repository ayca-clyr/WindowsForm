using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _15_XML_Serialization
{
    public class Öğrenci
    {
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public int OkulNo { get; set; }
        public DateTime DogumTarihi { get; set; }

        [XmlIgnore]// bu yaşı Xml'e içine kaydetmemesi için kullanılır. Yoruma almamamızın sebebi ben yaş'ı işlemlere katmak istiyorum ama xml'e kaydetmek istemiyorum. Bu şekilde xml'e kayıt işlemini engellemiş olup Yaş'ın işlevini yitirmesini engellemiş oldum.
        public int Yaş { get; set; }

    }

    public class Öğrenciler
    {
        public Öğrenciler()
        {
            ÖğrenciListesi = new List<Öğrenci>();
        }
        public List<Öğrenci> ÖğrenciListesi { get; set; }
    }
    
}
