using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{

    // Static
    // 1.Static sınıflar static sözcüğü class sözcüğünden önce yazılarak tanımlanır.
    // 2.Static sınıfların içerisinde instance (static olmayan) üyeleri tanımlayamıyorum.
    // 3.Static sınıflardan, new sözcüğünü kullanarak yeni bir instance oluşturamayız.
    // 4.Static sınıflardan ilk ve tek olan instance, static sınıfın herhangi bir üyesine ilk kez ulaştığımızda yaratılır.
    // 5.Static olmayan sınıfların içerisinde static üyeler tanımlanabilir.  (Singleton Pattern)
    // 6.Static constructor yazarken access modifier belirtilmez, belirtilemez.
    // 7.Static constructor metotlar yalnızca bir kez çalıştırılır.
    // 8.Static metotların içerisinden aynı sınıfın instance metotlarına (hatta diğer üyelerine de) erişilemez. Hangi instance'ye ait olduğunu bilmediğimiz için static içinde instance'yi erişemiyoruz.
    
   static class Computer
    {

        // Class static olduğu için constructorlarda static olmalı. Fakat başına public yazamayız.
       static Computer()
       {
           //Brand = "Lenova";
           //Memory = 4096;
           //Processor = 1.8f;
           Components = new List<string>();  // List static olmadığı için instance alabiliriz.

           var p = new Person();
               
       }

       public static string Brand { get; set; }  // Marka
       public static int Memory { get; set; }
       public static float Processor { get; set; } // İşlemci

       public static List<string> Components { get; set; }

       public static void Run()
       {

       }
    }
}
