using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12__Interface
{
    //Kullanıcı arayüzü değil ama kod arayüzü olarak düşünebiliriz.
    //İsimlendirirken ilk harfi I olarak yazılır.(Şart değil ayırt edebilmek için)
    //Abstract classlara çok benzer.
    //Interface'lerde field oluşturulamaz.
    //Var olan bir Interface'i bir class a eklediğimizde sözleşmesini imzalayıp imzalamadığımızı sorar.
    //Interface içerisinde var olan tüm method ve property leri class içerisine aktarmak zorundayız.
    //Interfacelerde yazdığımız tüm methodlar ve propertyler kendiliğinden public olarak gelir.
    //Interfacelerden miras (inherit) alınmaz, uyarlanır(implementatiton).
    //Bir class a sadece bir class dan miras alınabiliyorken birden fazla interface implement edilebilir.
    //Interface tanımlanırken içerisinde tanımlanan öğeler için herhangi bir erişim belirleyici kullanılmaz.
    interface IVehicle
    {
        void Start();
        void Stop();
        string Horn();
        string Accelerate();
        string Brake();

    }
}
