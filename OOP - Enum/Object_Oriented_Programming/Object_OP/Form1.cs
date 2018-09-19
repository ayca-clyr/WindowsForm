using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_OP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Left =90;  // get; set;   Bir tarafa göre ayarlayabiliyorsak, diğer yön otomatik olarak ayarlanır zaten.
           // button1.Right = 100 // get;   = 100 diyemeyiz. Çünkü sola değer verdik ve böylece otomatik ayarlandı.
            button1.Top = 100;
            /*
             StudentNumber'e değer veremeyiz.(Student sınıfında) Çünkü değeri her seferinde değiştirilmeli. 
            //Student student = new Student();
            //student.StudentNumber = txtStudentNumber.Text;
             */
            Student.Book sBook = new Student.Book();
            Student ogrenci = new Student();
            ogrenci.LastName = "Tuncer";
            ogrenci.OnluguVarMı = true;
        
            // Fiel'e değer atamak sadece onun değerini değiştirir.
            // Property'e değer atamaz onu değiştirmez.


            // Bu class'ın görevi sadece data işlemleri yapmak. Silmek-Eklemek-Atamak.
            StudentDataManager dataManager = new StudentDataManager();    
            dataManager.DeleteStudent(ogrenci);

            // Solid prensible

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student ogrenci = new Student();
            // Propertylerine atamalar burada yapılır.

            StudentDataManager dataManager = new StudentDataManager();
            dataManager.DeleteStudent(ogrenci);
        }


    }
}
