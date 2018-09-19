using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9__Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instance  = nesne (object)
            Person p1 = new Person();

            // bunu gördüğünde instance alır ve person sınıfının bir kısmı static person oluşuyormuş gibi davranır.
            p1.FirstName = Person.FullTrim2("     Mehmet").ToUpper();
            p1.LastName = "Avcı";
            p1.Gender = Gender.Male;
            // burada tekrar list için instance alınmaması için ctor içinde almak gerekir. öyle yapmasaydık.
            Person.Properties.Add("Villa");
            p1.InstanceMethod();

            // Bunun içine instance method çağrırsak hangi instancenin methodu olduğunu anlayamayacağı için içine instance method çağıramıyoruz.
            Person.StaticMethod1();

            // Ama instanceyi içinde alıp çağırırsak instance methodu çağırabiliriz. 

            Person p2 = new Person();
            p2.FirstName = "Ali";
            p2.LastName = "Aksoy";
            p2.Gender = Gender.Male;
            p2.InstanceMethod();
            // Yalnızca 1 tane oluşur ve yazılımla birlikte ramden temizlenir. 
            // Burada ilk instance oluşur . new Computer(); 
            Computer.Brand = "Asus";
            Computer.Memory = 5000;
            Computer.Processor = 3.5f;
            Computer.Run();

            
            
            // Bununla p1 nesnesini değiştiremeyiz ama Computer ın içindekilerini değiştirebiliriz.
            Test();

            //Toolhit, Utility, Helper sınıfları static tasarlanabilir.
            Car car = new Car();
            car.Make = StringHelper.FullTrim("             Alfa         Romeo          ");
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

            // Burada markaya erişilir.
            MessageBox.Show(Computer.Brand.ToString());
            
        }

        void Test()
        {
            Person p1 = new Person();
            p1.FirstName = "Mehmet2";
            p1.LastName = "Avcı2";
            p1.Gender = Gender.Male;

            Computer.Brand = "Toshiba";
            Computer.Memory = 5000;
            Computer.Processor = 3.5f;
        }
    }
}
