using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9__Static
{

    // Static
    //1. Static sınıflar static sözcüğü class sözcüğünden önce yazılarak tanımlanır.
    //2. Static sınıfların içerisinde instance üyeleri(static olmayan üyeleri) tanımlayamıyoruz.
    //3. Static sınıflardan, new sözcüğünü kullanrk yeni bir instance oluşturamayız.
    //4. Static sınıflardan ilk ve tek olan instance, static sınıdın herhangi bir üyesine ilk kez ulaştığımızda yaratılır.
    //****Static sınıfın içindeki üyeler static olmalı ama normal bir sınıfın içinde static üyeler yazılabilir. Static olmayan sınıfın içerisinde static üyeler tanımlanabilir.
    //6. Static constructor yazarken access modifieder belirtilemez. belirtilse daha anlamı yok.
    // çünkü bilgisayar çağırıyor onu. developer elinde olan bir şey değil.
    // 7. static constructor metotlar yalnızca bir kez çalıştırılır.
    // 8. Static metotların içerisinden aynı sınıfın instance metotlarına (hatta diğer üyelerine de) erişilemez. static üyelerine erişilir.
  static class Computer
    {
      // Initalion ilk değerler ctorda atanır.
     static Computer()
      {
          //Brand = "Lenovo";
          //Memory = 12312;
          //Processor = 1.5f;


      }

      public static string Brand { get; set; }
      public static int Memory { get; set; }
      public static float Processor { get; set; }

      public static List<string> Components { get; set; }
      public static void Run()
      {
         
      }
    }
}
