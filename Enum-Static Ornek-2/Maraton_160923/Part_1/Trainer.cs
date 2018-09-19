using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    public class Trainer : Person
    {
        public WorkHistory Professional()
        {

            WorkHistory professional = null;
            for (int i = 0; i < Work.Count; i++)
            {

                if (Work[i].WorkEndDate == null)
                {

                    professional = Work[i];
                    return professional;
                }
            }

            return professional;
        }

        internal Team Team { get; set; }

        public Tasks Tasks { get; set; }

        public WorkBranch workBranch { get; set; }

        private Class _className;
        internal Class ClassName
        {
            get { return _className; }
        }

        private Classroom _classroom;
        public Classroom Classroom
        {
            get { return _classroom; }
        }

        private Session _seans;
        public Session Seans
        {
            get { return _seans; }
        }

        public override string Cv(string text)
        {
            string text2 = string.Format("Adı :{0}\nSoyadı : {1}\nDoğum Tarihi {2}\nCinsiyeti : {3}\nOkul Bilgileri : {4}\nİş Bilgileri {5}\nUzmanlık Alanı : {6}\nGörevi : {7}", FirstName, LastName, DateOfBirth.ToShortDateString(), Gender, Education, Work, Professional(), Tasks);
            return text2;
        }

        public override string ToString()
        {
            return Cv(FirstName);
        }



    }
}
