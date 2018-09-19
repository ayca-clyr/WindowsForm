using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndexedProperty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Ctrl + Tab
        //  Alt + Tab
            
        private void Form1_Load(object sender, EventArgs e)
        {
            //List<string> lineUp = new List<string>();
            //lineUp.Add("Tsubasa Ozara");
            //lineUp.Add("Misaki Taro");

            Team team = new Team();
            team.Name = "Nankatsu";
            team.FoundedYear = 1950;
            //team._players.Add("Tsubasa Ozara");
            //team._players.Add("Misaki Taro");

            team.AddPlayer("Misaki Taro");
            team.AddPlayer("Tsubasa Ozara");
            
            team.RemovePlayer("Misaki Taro");

            // List'i dışarı kapattığımız için bizde GetPlayer(index) olarak metot oluşturduk.
            string firstPlayer = team.GetPlayer(0);

            firstPlayer = team[0];

            string player = team["GK", 1];

            List<string> players = team[10, 20, 40];
           
        }
    }
}
