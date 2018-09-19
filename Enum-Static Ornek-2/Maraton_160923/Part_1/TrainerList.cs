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
    public partial class TrainerList : Form
    {
        List<Trainer> listTrainer = new List<Trainer>();
        List<EducationHistory> listEgitim = new List<EducationHistory>();
        List<WorkHistory> listIs = new List<WorkHistory>();
        public TrainerList(List<Trainer> gelenEgitmen, List<WorkHistory> isGecmisi, List<EducationHistory> egitimGecmisi)
        {
            InitializeComponent();
            listTrainer = gelenEgitmen;
            listIs = isGecmisi;
            listEgitim = egitimGecmisi;
        }

        private void TrainerList_Load(object sender, EventArgs e)
        {
            lstBxTrainerList.DataSource = listTrainer;
            
         
        }
    }
}
