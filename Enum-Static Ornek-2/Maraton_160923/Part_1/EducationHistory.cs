using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_1
{
   public class EducationHistory
    {
        
        private string _schoolName;
        public string SchoolName
        {
            get { return _schoolName; }
            set { _schoolName = value; }
        }

        private DateTime _schoolStartDate;
        public DateTime SchoolStartDate
        {
            get { return _schoolStartDate; }
        }

        public Nullable<DateTime> SchoolEndDate { get; set; }
        public SchoolBranch SchoolBranch { get; set; }  // Okul Alanı

        public string SchoolDivision { get; set; }  // Okul Bölümü


        public override string ToString()
        {
            return _schoolName;
        }

    }
}
