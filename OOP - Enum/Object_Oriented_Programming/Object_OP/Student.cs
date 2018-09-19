using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_OP
{
    public class Student
    {
        // Members

        // 1.Field  // Değer tutar.
        // String değer tipli. Datetime referans tipli.
        // Field ile değişken tanımlama arasında pek fark yok.
        // Field'ı methodda yazamazsın. Class'ın en yukarı konur. Method'da sadece Fiel'dı çağrırız.
        // Değişkenler sadec 2 scop arasında geçerlidir. Field ise tüm class boyunca heryerde kullanılır.

        public string _firstName;
        public string _lastName;
        public DateTime _dateOfBirth;
        public int _number = -1;

        // 2.Method
        // Bir Class'ın yapabildikleridir.
        public int GetAge()
        {
            int age = -1;
            age = DateTime.Today.Year - _dateOfBirth.Year; //   DateTime.Now.Year - _dateOfBirth;
            return age;
        }

        // 3.Property
        // Özellik tutar. Bunlara değer atamak'da özelliği değiştirmez. Hamallıktır.
        // Property değer tutmaz, taşır.
        // get; set; de get olmalı. İstisnalarda get olmasa da olur.
        public int StudentNumber { get; set; }  // = 5 diyemeyiz. Get Set bura her seferinde yeni değer taşıması gerekli.
        public string LastName { get; set; }
        public bool OnluguVarMı { get; set; }

        // Nested  --> İç içe geçmiş klaslar. 
        // Veri bütünlüğünü sağlamak için kullanırı.
        // Public yazarsak class'a heryerden erişilir. Ama Student.Book şeklinde erişilebilir.
        // Class altında class açmak eğer başınada public koyarsak mantıksız. Yeni class açmak Student gibi daha mantıklı olur.  

        // Eğer Class'ları item'den ekliyorsak direk public'dir ve biz onu private çeviremeyiz.
        // Namespace altında aynı kök dizinde bulunan classlar private yapılamaz.
        // Eğer private olarak değiştirmek istiyorsak class içinde class tanımlamamız gerekiyor.
        public class Book
        {

        }




    }
}
