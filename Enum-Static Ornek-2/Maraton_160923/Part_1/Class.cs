using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
 class Class
    {

       public Class(Team team, Classroom classRoom, Course course, Session seans)
        {

        }
         #region StudentCollection
        public Class()
        {
            _collectionStudents = new StudentCollection();
            _listStudents = new List<Student>();
        }
       
        List<Student> _listStudents;
        StudentCollection _collectionStudents;

        private class StudentCollection
        {
            public StudentCollection()
            {
                List<Student> students = new List<Student>();
            }
            public List<Student> _studentList;
            public Student this[int index]
            {
                get
                {
                    return _studentList[index];
                }
            }
        }

      internal List<Student> Referance()
        {
            return _collectionStudents._studentList = _students;
        }

        private List<Student> _students;
        internal List<Student> Students
        {
            get { return Referance(); }
        }

        #endregion
        private string _className;
        public string ClassName
        {
            get { return _className.ToString(); }
        }
        public override string ToString()
        {
            return _course + " " + _className + " " + _seans;
        }

        private Team _team;
        public Team Team
        {
            get { return _team; }
        }

        private Course _course;
        public Course Course
        {
            get { return _course; }
        }
        private Classroom _classRoom;
        public Classroom ClassRoom
        {
            get { return _classRoom; }
        }
        private Session _seans;
        public Session Seans
        {
            get { return _seans; }
        }

        private Trainer _trainer;
        public Trainer Trainer
        {
            get { return _trainer; }
            set
            {
                if (Trainer.Classroom == null)
                {
                    _trainer = value;
                }
                else if (Trainer.Classroom != null)
                {
                    if (Trainer.Tasks == Tasks.TeamLeader)
                    {
                        _trainer = value;
                    }
                    else if (Trainer.Tasks == Tasks.Instructor || Trainer.Tasks == Tasks.CareerConsultant)
                    {
                        Trainer = null;
                    }
                }
                Trainer = null;
            }
        }


        private Nullable<DateTime> _startDate;
        public Nullable<DateTime> StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                if (_readyForEducation == true && _startDate != null)
                {
                    _startDate = StartDate;
                }

                _startDate = value;

            }
        }

        private Nullable<DateTime> _endDate;
        public Nullable<DateTime> EndDate
        {
            get
            {
                return _startDate.Value.AddDays(140);
            }
        }

        private bool _readyForEducation;
        public bool ReadyForEducation
        {
            get
            {
                if (ClassRoom.ComputerCount == 15 && ClassRoom.HasBlackboard == true && ClassRoom.HasProjector == true && ClassRoom.HasProjectionBoard == true && _students.Count == 15 && _trainer != null)
                {
                    return _readyForEducation;
                }
                return false;
            }
        }

        public bool CheckIfSuitable(Student student)
        {
            WorkHistory wH = new WorkHistory();
            EducationHistory eH = new EducationHistory();

            if ((eH.SchoolBranch == SchoolBranch.Numerical && (wH.WrokBranch == WorkBranch.Software || wH.WrokBranch == WorkBranch.System)) || ((eH.SchoolBranch == SchoolBranch.Numerical || eH.SchoolBranch == SchoolBranch.Counterweigh) && wH.WrokBranch == WorkBranch.ERP))
            {
                return true;
            }

            return false;
        }

        public void AddStudent(Student student)
        {
            if (CheckIfSuitable(student) == true && ClassRoom.Students.Count < 15)
            {
                _listStudents.Add(student);

            }


        }

        public void RemoveStuden(Student student)
        {
            if (DateTime.Now.Day > _startDate.Value.Day && _listStudents.Contains(student))
            {
                _students.Remove(student);
            }
        }

        public void ChangeStudent(Student student, Student newStudent)
        {
            if ((DateTime.Now.Day - _startDate.Value.Day <= 7 && DateTime.Now.Day - _startDate.Value.Day >= 0) && CheckIfSuitable(newStudent) == true)
            {
                if (_listStudents.Contains(student))
                {
                    for (int i = 0; i < _listStudents.Count; i++)
                    {
                        if (student == _listStudents[i])
                        {
                            _listStudents[i] = newStudent;
                            break;
                        }
                    }
                }
                
            }
        }


    }
}
