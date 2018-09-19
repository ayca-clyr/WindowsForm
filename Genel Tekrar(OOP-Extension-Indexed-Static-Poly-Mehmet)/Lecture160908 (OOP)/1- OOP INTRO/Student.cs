using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__OOP_INTRO
{
    class Student
    {
        //Members

        //1.Field - genel alan değer tutuyor
        // Normalde dışarıda tanımladığımız değişkenler bi field'tır
        public string _firstName; // Field
        public string _lastName;
        public DateTime _dateOfBirth;

        //2.Method

        public int GetAge()
        {
            //age burada değişkendir.
            int age = DateTime.Today.Year - _dateOfBirth.Year;

            return age;
        }

        // 3. Property  / Özellik // Değer tutmaz, taşır
        // get ile eriş set ile manipüle et 

        /*
          // Property ile Field arasındaki farklar
        //Property değer tutmaz.
        //Property içerisindeki get,erişmeyi set,değiştirmeyi sağlar.
        //Property'nin değiştirebildiği şey nesne'nin property'sinin özelliğidir. 
        //Mesela button1.Left=100
         Left de bir propertydir.
         * button.Left = 100;
         Left 100 değildir.
         * button un lefti 100 dür.
         * 
         * Mehmet.StudentNumber = 1;
         * StudentNumber 1 değil mehmetin numarası 1;
         * 
         */

        public int StudentNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }


        //Nested -- içiçe geçmiş classlar
        // Mantık bütünlüğünü oluşturmak için kullanılır. Book classı sadece içindeki classla ilişkilendirmek için kullanılır.
        public class Book
        {
            public int MyProperty { get; set; }
        }

    }
}
