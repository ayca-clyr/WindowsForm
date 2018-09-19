using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // İnstance = Nesne (Object)   --Object ing olarak adı. Tip olarak değil.

            // Personda aldığımı p1 ile aşağıdaki p1 farklıdır. Bribirini etkilemez.
            // Computer'da en son ne aldıysa son değeride o olur. Metodu çağırdığımız için son değeri Toshiba olur.


            // Her instance'de aslında alınan class içinde constructor çalışıyor. Sadece new Keyword'üyle çağrıyoruz.

            Person p1 = new Person();
            // p1.FirstName = p1.FullTrim("  Tsubasa  ");  Static yokken.
            p1.FirstName = Person.FullTrim(" Tsubasa ").ToUpper();
            p1.LastName = Person.FullTrim("   Ozara       ");
            p1.Gender = Gender.Male;

            // Person'da constructor'da instancae almazsak bunu yaparız.Bunu burda yapmamalıyız.
            //p1.Properties = new List<string>();

            // Çalışır ama bunu burda yapmamızda doğru değil.
            //if (p1.Properties == null)
            //{
            //    p1.Properties = new List<string>();
            //}
            p1.Properties.Add("Villa");
            p1.InstanceMethod();

            Person.StaticMethod1();
            Person.StaticMethod2();


            Person p2 = new Person();
            p2.FirstName = "Misaki";
            p2.LastName = "Taro";
            p2.Gender = Gender.Male;
            p2.InstanceMethod();

            // new Computer. 


            //if (DateTime.Now.Hour < 20 && DateTime.Now.Hour > 13)
            //{
                string brand = Computer.Brand;




                Computer.Brand = "ASUS";
                Computer.Memory = 4096;
                Computer.Processor = 1.8f;
            //}
            Test();

            brand = Computer.Brand;
            // string brand = Computer.Brand;

            Computer.Run();

            Person.Equals(null, null);

            // Static değilse instance alıp kullanırız.
            //StringHelper helper = new StringHelper();
            //Car car = new Car();
            //car.Make = helper.FullTrim("   Alfa   Romeo");


            // Toolkit, Utility, Helper sınıfları static tasarlanabilir.
            Car car = new Car();
            car.Make = StringHelper.FullTrim("   Alfa   Romeo");


        }

        void Test()
        {
            Person p1 = new Person();
            p1.FirstName = "Hyuga";
            p1.LastName = "Kojiro";
            p1.Gender = Gender.Male;

            Computer.Brand = "Toshiba";
            Computer.Memory = 2048;



        }
    }
}
