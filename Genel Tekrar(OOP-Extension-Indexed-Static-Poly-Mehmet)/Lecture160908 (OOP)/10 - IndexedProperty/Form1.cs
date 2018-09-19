using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10___IndexedProperty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Takım bilgilerini tutmak da istersek birsürü list oluşacak
            //List<string> lineUp = new List<string>();
            //lineUp.Add("Mehmet Avcı");
            //lineUp.Add("Mehmet Avcı2");

            Team team = new Team();
            team.Name = "Galatasaray";
            team.FounderYear = 1905;
            
            //_players dizisini kapattık private yaptık
            //team._players.Add("Eren Derdiyok");
            //team._players.Add("Wesley Sneijder");
            //team._players.Add("DIDIER DROGBA");


            team.AddPlayer("Fernando Muslera");
            team.RemovePlayer("Sabri");

          //  string firstPlayer = team._players[0];
            
            string firstPlayer = team.GetPlayer(0);
            firstPlayer = team[0];

            string player = team["GK",1];

            List<string> players = team[1, 2, 3, 12];   
        }
    }
}
