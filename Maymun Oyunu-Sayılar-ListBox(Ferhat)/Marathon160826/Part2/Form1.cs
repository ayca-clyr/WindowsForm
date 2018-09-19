using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Part2
{
    public partial class Form1 : Form
    {
        int Id = 0;
        int SelectId;
        ArrayList listPlayer = new ArrayList();
        Player p = new Player();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Id++;
            PlayerClassAdd();
            listPlayer.Add(p);
            lBoxPlayer.Items.Add(p.FirstName + " " + p.LastName);
            Clear();
        }

        private void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtSpecialShoot.Text = "";
            cBoxTeam.Text = "";
            dtPickerDateOfBirth.Text = DateTime.Now.ToString();
            numericUpDownDribbling.Value = numericUpDownPassing.Value = numericUpDownShooting.Value = 0;
        }

        private void PlayerClassAdd()
        {
            p.Id = Id;
            p.FirstName = txtFirstName.Text;
            p.LastName = txtLastName.Text;
            p.DateOfBirth = DateTime.Parse(dtPickerDateOfBirth.Text);
            p.Team = cBoxTeam.Text;
            p.SpecialShoot = txtSpecialShoot.Text;
            p.Shooting = (int)numericUpDownShooting.Value;
            p.Passing = (int)numericUpDownPassing.Value;
            p.Dribbling = (int)numericUpDownDribbling.Value;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selection = lBoxPlayer.SelectedIndex;
            listPlayer.RemoveAt(selection);
            lBoxPlayer.Items.RemoveAt(selection);
        }

        private void lBoxPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selection = lBoxPlayer.SelectedIndex;
            p = (Player)listPlayer[selection];
            SelectId = p.Id;
            txtFirstName.Text = p.FirstName;
            txtLastName.Text = p.LastName;
            dtPickerDateOfBirth.Text = p.DateOfBirth.ToString();
            txtSpecialShoot.Text = p.SpecialShoot;
            cBoxTeam.SelectedText = p.Team;
            numericUpDownShooting.Value = p.Shooting;
            numericUpDownPassing.Value = p.Passing;
            numericUpDownDribbling.Value = p.Dribbling;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PlayerClassAdd();
            int selection = lBoxPlayer.SelectedIndex;
            listPlayer[selection] = p;
            lBoxPlayer.Items.Clear();
            foreach (var item in listPlayer)
            {
                p = (Player)item;
                lBoxPlayer.Items.Add(p.FirstName+" "+p.LastName);
            }
            Clear();
        }

    }
    public class Player
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public string Team;
        public string SpecialShoot;
        public int Shooting;
        public int Passing;
        public int Dribbling;
    }
}
