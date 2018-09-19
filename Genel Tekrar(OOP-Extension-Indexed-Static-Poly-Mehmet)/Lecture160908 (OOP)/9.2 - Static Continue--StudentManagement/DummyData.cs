using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2___Static_Continue__StudentManagement
{
    static class DummyData
    {
        static DummyData()
        {
            //Declaration 
            //delaration
            Student student;

            _data = new List<Student>(); // ilk değer atama inilations denir.

            student = new Student();
            student.FirstName = "Burak";
            student.LastName = "Kaya";
            student.Gender = Gender.Male;
            student.StudentNumber = 1233;
            _data.Add(student);

            student = new Student();
            student.FirstName = "Toni";
            student.LastName = "Demirci";
            student.Gender = Gender.Male;
            student.StudentNumber = 33332;
            _data.Add(student);

            student = new Student();
            student.FirstName = "Fidan";
            student.LastName = "Kartal";
            student.Gender = Gender.Female;
            student.StudentNumber = 6543;
            _data.Add(student);

            student = new Student();
            student.FirstName = "Ayça";
            student.LastName = "Calayır";
            student.Gender = Gender.Female;
            student.StudentNumber = 98765;
            _data.Add(student);

            student = new Student();
            student.FirstName = "Gürkan";
            student.LastName = "Fidan";
            student.Gender = Gender.Male;
            student.StudentNumber = 7777;
            _data.Add(student);
        }

        private static List<Student> _data;
        public static List<Student> StudentData
        {
            get
            {
                return _data;

            }
            // set metodunu kapatmak add remove methodunu kapatmak anlamına gelmiyordur.
            // ya da bir elemana atama yapmayı kapatmak anlamına gelmiyor DummyData.StudentData[0] = null atama yapılabilir
            // DummyData.StudentData = null a atama yapılamaz
        }

    }
}
