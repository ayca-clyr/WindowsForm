using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    public abstract class Person
    {
        public Person()
        {
            _education = new List<EducationHistory>();
            _work = new List<WorkHistory>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        private int _age;
        public int Age
        {
            get { return DateTime.Now.Year - DateOfBirth.Year; }
        }

        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
        }

        public Gender Gender { get; set; }

        private List<EducationHistory> _education;
        public List<EducationHistory> Education
        { // Eğitim Geçmişi
            get { return _education; }
        }

        private List<WorkHistory> _work;
        public List<WorkHistory> Work
        { // Çalışma Geçmişi
            get { return _work; }
        }

        public virtual string Cv(string text)
        {            
            string metin;
            metin = string.Format("Adı :{0}\nSoyadı : {1}\nDoğum Tarihi {2}\nCinsiyeti : {3}\nOkul Bilgileri : {4}\nİş Bilgileri {5}",FirstName,LastName,Gender,_education,_work);
            return metin;
        }

    }
}
