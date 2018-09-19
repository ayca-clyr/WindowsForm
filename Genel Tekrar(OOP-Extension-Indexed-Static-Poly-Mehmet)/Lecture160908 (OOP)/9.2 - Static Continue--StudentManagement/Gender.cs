using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2___Static_Continue__StudentManagement
{
    // GoF Design Patterns - 23 - araştır.

    // 23'ten 1'i budur=> Singleton Pattern  -- ctor u kapat tek bir şekilde aynı instancelar kullanabilsin
    class Gender
    {
        // instance alınamaması için private aldık
        private Gender()
        {

        }

        // Static kısmına hizmet eden constructor // Normal sınıf ama static propertyleri olduğu için static gibi de davranıyor bir kısmı
        static Gender()
        {

            // Burada static propertylerin instance ı nı almak gerekir ilk değer vermek için
            _male = new Gender();
            _female = new Gender();



            _female._name = "Erkek";
            _male._name = "Kadın";

            _allValues = new Gender[2];


            _allValues[0] = _male;
            _allValues[1] = _female;
        }

        private string _name;
        public string Name { get { return _name; } }

        public override string ToString()
        {
            return this.Name;
        }

        private static Gender _male;
        public static Gender Male { get { return _male; } }

        private static Gender _female;
        public static Gender Female { get { return _female; } }

        private static Gender[] _allValues;
        public static Gender[] AllValues{ get{ return _allValues; } }
    }


    //enum Gender
    //{
    //    None=0,
    //    Male,
    //    Female
    //}
}
