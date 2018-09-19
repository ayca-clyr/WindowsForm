using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMembers
{


    // Encapsulation - Sarmalama
    // PolyMorfizm - Çok Biçimlilik
    // Inheritance - Kalıtım
    // Abstraction - Soyutlama
    // Readonly --> Sadece get olan. 
    
    public class Student
    {
        // Simple Property

        private DateTime _dateOfBirth;  // Kapsüle ediyoruz. Ulaşılmasını engelledik private diyerek.
        public DateTime DateOfBirth  // Property içinde işlemler yapabiliriz, ama değer tutmaz. Değerleri field'e atıyoruz.
        {
            get
            {
                return _dateOfBirth;   // _dateOfBirth'e erişip bunu okusun.
            }
            set
            {
                _dateOfBirth = value;   // Değerini değiştirceksek burada value değerini _dateOfBirth'e ata.
            }
        }

        // Encapsulation işlemi yapıyoruz. Erişimi kapatıyoruz. Değer değişiebilir ama ismi değiştiremez.
        private string _firstName = "Mehmet";

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        // Full Property   
        // Simple'den farkı değeri al değiştir ama içine bir property yazarak bunu yaptığımızda değişikliği FixValue ile yaptıktan sonra getir.

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = FixValue(value); }
        }

        private string FixValue(string value)
        {
            string trimmedValue = value.Trim();  // Trimliyor.
            string fixedValue = "";
            for (int i = 0; i < trimmedValue.Length; i++)
            {
                if (i == 0)
                {
                    fixedValue += char.ToUpper(trimmedValue[i]); // İlk harfe bak onu büyük yap.
                }
                else
                {
                    fixedValue += char.ToLower(trimmedValue[i]); // Sonrakilere bak ve onları küçük yap.
                }
            }


            return fixedValue;
        }



    }
}
