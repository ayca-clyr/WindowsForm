using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_CodeFirst
{
    public partial class Form1 : Form
    {

        // 1. Class'ları oluşturmak.
        // 2. App.config ConnectionString oluşturmak.
        // 3. DbContex'i oluşturmak. (Class'larla App.config'i birbirini bağlamak)
        // 4. Migration

        // Classları yazdık 
        // App.config'de entitiyFramework ve  "configuration" arasına "connectionStrings" <add name="SahteNorthwind" connectionString="server=.;database=StokTakipDB;integrated security=true;" providerName="System.Data.SqlClient"/> </connectionStrings> kodu yazıyoruz.  SahteNorthwind bizim oluşturduğumuz isim. StokTakipDB ise Sql'de oluşturduğumuz database ismi.
       
        // StockContex'e geliyoruz ctor açıyoruz :base("name=SahteNorthwind") diyoruz.  StockContex'e kalıtım olark : DbContext diyoruz ve ctrl + . de ve entity ekle. Daha sonra tablolar için public DbSet<Category> Categories {get;set;} diyoruz.
        // Tools - nugget package manager - Package manager consol
        //      Altta Package Manager Consol geliyor;
        //          -PM> enable-migrations
        //          -PM> add-migration FirstMigration
        //          -PM>update-database
        // 3 adımdan sonra veritabanı oluşturulmuş oluyor.

        // 2. class oluştur DbSet yapıyoruz o class'ıda ekliyoruz. Sonra package manager consola add-migration AddProduct diyoruz ve update-database diyoruz.

        // Configurasyonda Auto'yu true yap böylece her değişiklik için sadece update-database yazman yeterli.

        // int? yaptıktan sonra null geçilebilir yapıyoruz.
        public Form1()
        {
            InitializeComponent();
        }



        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
