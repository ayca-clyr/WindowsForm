using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1
{
    public partial class TrainerForm : Form
    {
        List<WorkHistory> listIs = new List<WorkHistory>();
        List<EducationHistory> listEgitim = new List<EducationHistory>();
        List<Trainer> listTrainer = new List<Trainer>();
        public TrainerForm(List<Trainer> gelenEgitmen, List<WorkHistory> isGecmisi, List<EducationHistory> egitimGecmisi)
        {
            InitializeComponent();
            listTrainer = gelenEgitmen;
            listIs = isGecmisi;
            listEgitim = egitimGecmisi;
        }
        
    

        private void TrainerForm_Load(object sender, EventArgs e)
        {
            cBxTrainerGender.DataSource = Enum.GetValues(typeof(Gender));
            cBxTrainerTasks.DataSource = Enum.GetValues(typeof(Tasks));
            cBxTrainerProfessional.DataSource = Enum.GetValues(typeof(WorkBranch));
            cBxTrainerSchoolBranch.DataSource = Enum.GetValues(typeof(SchoolBranch));
        }

   

        private void btnTrainerSave_Click(object sender, EventArgs e)
        {
            Trainer trainer = new Trainer();
            trainer.FirstName = txtBxTrainerFirstName.Text;
            trainer.LastName = txtBxTrainerLastName.Text;
            trainer.Gender = (Gender)cBxTrainerGender.SelectedItem;
            trainer.Tasks = (Tasks)cBxTrainerTasks.SelectedItem;
            trainer.workBranch =(WorkBranch) cBxTrainerProfessional.SelectedItem;
            trainer.DateOfBirth = dPTTrainersDateOfBirth.Value;
            listTrainer.Add(trainer);

            WorkHistory work = new WorkHistory();
            work.WorkName = txtBxTrainerWorkName.Text;
            work.WorkEndDate = dTPTrainerWorkEndDate.Value;
            listIs.Add(work);

            EducationHistory edution = new EducationHistory();
            edution.SchoolName = txtBxTrainerSchoolName.Text;
            edution.SchoolBranch = (SchoolBranch)cBxTrainerSchoolBranch.SelectedItem;
            edution.SchoolEndDate = dTPTrainerSchoolEndDate.Value;
            listEgitim.Add(edution);


        }
    }
}
