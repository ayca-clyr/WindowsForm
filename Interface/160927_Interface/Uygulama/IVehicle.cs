using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama
{
    // Kullanıcı arayüzü değil ama kod arayüzü olarak düşünebiliriz.
    // İsimlendirirken ilk harf I olarak yazılır.(Şart değil ayırt edebilmek için)
    // Abstract class'lara çok benzer
    // Interface'lerde field oluşturalamaz.
    // Var olan bir interface'i bir class'a eklediğimizde sözleşmesini imzalayıp imzalamadığımızı sorar.
    // Interface içerisinde var olan tüm method ve property'leri class içerisinde aktarmak zorundayız.
    // Interface'lerde yazdığımız tüm methodlar ve propertyler kendiliğinden public olarak gelir.
    // Interface'lerden miras (inherit) alınmaz, uyarlanır. (implementation)
    // Bir class'a sadece bir class'dan miras alınabiliyorken birden fazla interface implement edilebilir.
    // Interface tanımlanırken içerisinde tanımlanan öğeler için herhangi bir erişim belirleyicisi kullanılamaz.(public)
    // Interface'deki tüm metotlar çağrıldığında hepsi gelmek zorunda.
    // Interface'de instance oluşturamaz. Kalıtım da ise nesne alabiliriz.
    
    interface IVehicle
    {
      
        void Start();
        void Stop();
        string Horn();
        void Accelerate();
        void Brake();

    }
}
