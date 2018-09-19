using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    static class DummyData
    {
        private static List<Student> _data;
        public static List<Student> StudentData {

            get { return _data;}
        }
        static DummyData()
        {
            // Declaration
            Student student;

            _data = new List<Student>();
            // Instance

            // Liste static olduğu için veri kaybı yaşamıyoruz.
            student = new Student();
            student.FirstName = "Burak";
            student.LastName = "Kaya";
            student.Gender = Gender.Male;
            student.StudentNumber = 23234;
            _data.Add(student);

            student = new Student();
            student.FirstName = "Toni";
            student.LastName = "Demirci";
            student.Gender = Gender.Male;
            student.StudentNumber = 46456;
            _data.Add(student);

            student = new Student();
            student.FirstName = "Fidan";
            student.LastName = "Kartal";
            student.Gender = Gender.Female;
            student.StudentNumber = 23497;
            _data.Add(student);

            student = new Student();
            student.FirstName = "Ayça";
            student.LastName = "Calayır";
            student.Gender = Gender.Female;
            student.StudentNumber = 85749;
            _data.Add(student);

            student = new Student();
            student.FirstName = "Gürkan";
            student.LastName = "Fidan";
            student.Gender = Gender.Male;
            student.StudentNumber = 74572;
            _data.Add(student);

        }

    }
}
