using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    // GoF Design Pattern = 23 tane durumdan 1 tane Singleton Pattern.
    // Singleton Pattern
    // ctor kapatmak instance alınamasın. Kendi tipinde bir tane instance static döndür.
    class Gender
    {

        static Gender()
        {
            _male = new Gender();
            _male._name = "Erkek"; 

            _female = new Gender();
            _female._name = "Kadın";

            _allValues = new Gender[2];
            _allValues[0] = _male;
            _allValues[1] = _female;
        }
        private Gender()  
        {
                // Gender'den instance alınamasın diye private yaptık. Male ve Female değeri dışında değer eklenmesin ve değiştirelemesin diye set kaldırıldı. Enum gibi Gender.Male olması içinde static yaptık.
        }
        private string _name;
        public string Name { 
            get{return _name ;}
        }

        // Ya bu yada display olayı yapılmalı.
        public override string ToString()
        {
            return this.Name;
        }

        private static Gender _male;
        public static Gender Male
        {
            get { return _male; }
        }

        private static Gender _female;
        public static Gender Female
        {
            get { return _female; }
        }


        private static Gender[] _allValues;
        public static Gender[] AllValues
        {
            get { return _allValues; }
        }
    }

    //Kod ingilizce görüntü türkçe olması lazım.
    //enum Gender
    //{
    //    None = 0,
    //    Male,
    //    Female
    //}
}
