using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9__Static
{
    class Person
    {
        static Person instance = new Person();
        public Person()
        {
            // eğer bi sınıfta collection varsa ilk instancesini burada oluşturun.
            Properties = new List<string>();
            // çünkü ekleme yaparken instance almak zorundayız bu şekilde.
            // bunu almamak için ctor içinde alması lazım.
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public static List<string> Properties { get; set; }

        public static string FullTrim2(string value)
        {
            string trimmedValue = value.Trim();

            string fixedValue = "";

            for (int i = 0; i < trimmedValue.Length; i++)
            {
                if (i == 0)
                {
                    fixedValue += char.ToUpper(trimmedValue[i]);
                }
                else
                {
                    fixedValue += char.ToLower(trimmedValue[i]);
                }
            }

            return fixedValue;
        }

        public void Walk()
        {
            while (true)
            {
                Step();
            }
        }

        public void Step()
        {

        }

        //person p1 = new person();
        //p1 nesnesi üzerinden eriştiğimiz methodlar instance method
        //person.methodName => static methodtur

        public void InstanceMethod()
        {
            StaticMethod1();
            StaticMethod2();
        }

        public static void StaticMethod1()
        {
            //
        // Erişilemez =>    InstanceMethod();
            StaticMethod2();
        }

        public static void StaticMethod2()
        {
            // Ama instanceyi içinde alıp çağırırsak instance methodu çağırabiliriz. 
            Person p = new Person();
            p.InstanceMethod();

            instance.InstanceMethod();

            StaticMethod1();
        }
    }
}
