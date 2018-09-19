using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
 public  class Classroom : Room
    {
        private List<Student> _students;
        public List<Student> Students
        {
            get { return _students; }
        }
        private int _computerCount;

        public int ComputerCount
        {
            get { return _computerCount; }
         
        }

        private bool _hasProjector;   // Projeksiyon var mı?

        public bool HasProjector
        {
            get { return _hasProjector; }
            set { _hasProjector = value; }
        }

        private bool _hasProjectionBoard;   // Perde var mı?

        public bool HasProjectionBoard
        {
            get { return _hasProjectionBoard; }
            
        }

        private bool _hasBlackboard;  // Tahta var mı ?
        public bool HasBlackboard
        {
            get { return _hasBlackboard; }
        }
    }
}
