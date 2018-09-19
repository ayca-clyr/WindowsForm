using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Person
    {
        static Person instance = new Person();
        public Person()
        {
            Properties = new List<string>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public List<string> Properties { get; set; } // Mal-Mülk

        public static string FullTrim(string value)
        {
            //

            return "";
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

        // p1'den erişienler instance, Person'dan erişilenler static methodu.
        // Instance methodundan instance methodda, static methodda erişilebilir.
        // Static methoddan static method erişilebilir, ancak instance methodlarına erişilemez.
        public void InstanceMethod()
        {
            StaticMethod1();
            StaticMethod2();
        }
        public static void StaticMethod1()
        {
            //
            StaticMethod2();
        }
        // Ram üzerinden gerçekleşiyor olaylar. 
        public static void StaticMethod2()
        {
            
            // InstanceMethod();  Bunu yapamayız.
            Person p = new Person();
            p.InstanceMethod();

            instance.InstanceMethod();
        }
    }
}
