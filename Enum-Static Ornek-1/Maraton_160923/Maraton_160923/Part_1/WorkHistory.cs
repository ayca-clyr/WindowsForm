using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_1
{
    class WorkHistory
    {
        private string _workName;
        public string WorkName
        {
            get { return _workName; }
            set { _workName = value; }
        }
        private DateTime _workStartDate;
        public DateTime WorkStartDate
        {
            get { return _workStartDate; }
        }

        public Nullable<DateTime> WorkEndDate { get; set; }
        public WorkBranch WrokBranch { get; set; }   // İş Alanı

        public override string ToString()
        {
            return _workName;
        }
    }
}
