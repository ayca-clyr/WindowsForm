using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Part_1
{
  class Team
    {
        private string _teamName;

        public string TeamName
        {
            get { return _teamName; }
            set { _teamName = value; }
        }

        #region TrainerCollection

        List<Trainer> _listTrainers;
        TrainerCollection _collectionTrainers;
        List<Class> _listClasses;
        ClassCollection _collectionClasses;
        public Team()
        {
            _collectionTrainers = new TrainerCollection();
            _listTrainers = new List<Trainer>();
            _collectionClasses = new ClassCollection();
            _listClasses = new List<Class>();
        }



        private class TrainerCollection
        {
            public TrainerCollection()
            {
                List<Trainer> trainers = new List<Trainer>();
            }
            public List<Trainer> _trainerList;
            public Trainer this[int index]
            {
                get
                {
                    return _trainerList[index];
                }
            }
        }



        internal List<Trainer> ReferanceTrainer()
        {
            return _collectionTrainers._trainerList = _trainers;
        }

        private List<Trainer> _trainers;
        internal List<Trainer> Trainers
        {
            get { return ReferanceTrainer(); }
        }

        #endregion


        #region ClassCollection

        private class ClassCollection
        {
            public ClassCollection()
            {
                List<Class> classes = new List<Class>();
            }
            public List<Class> _classList;
            public Class this[int index]
            {
                get
                {
                    return _classList[index];
                }
            }
        }



        internal List<Class> ReferanceClass()
        {
            return _collectionClasses._classList = _classes;
        }

        private List<Class> _classes;
        internal List<Class> Classes
        {
            get { return ReferanceClass(); }
        }

        #endregion


        private List<Student> _studentDetails;
        public List<Student> StudetnDetails
        {
            get { return _studentDetails; }

        }



        public void AddTrainer(Trainer trainer)
        {
            if (!(Trainers.Contains(trainer)))
            {
                _listTrainers.Add(trainer);




            }
        }


        public void RemoveTrainer(Trainer trainer)
        {

            if (!(Trainers.Contains(trainer)))
            {
                _listTrainers.Remove(trainer);
                trainer.Team = null;
            }
        }

        public void SwapTrainers(Class trainer, Class newTrainer)
        {
            if (_listTrainers.Contains(trainer.Trainer))
            {
                for (int i = 0; i < _listTrainers.Count; i++)
                {
                    if (trainer.Trainer == _listTrainers[i])
                    {
                        Trainer last;
                        last = _listTrainers[i];
                        _listTrainers[i] = newTrainer.Trainer;
                        _listTrainers[i] = last;
                        break;
                    }
                }
            }
        }

        Class classs;

        public void CreateClass(Course course, Classroom classroom, Session session)
        {
            classs = new Class();
            if (classs != null)
            {
                _collectionClasses._classList.Add(classs);
            }
        }
        public void CancelClass(Class classes)
        {
            if (_collectionClasses._classList.Contains(classes))
            {

                classs = null;
            }
        }

    }
}
