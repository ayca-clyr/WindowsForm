using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_TaşKagıtMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            switch (rnd.Next(1, 4))
            {
                case 1:
                    label1.Text = "Taş";
                    break;
                case 2:
                    label1.Text = "Makas";
                    break;
                case 3:
                    label1.Text = "Kağıt";
                    break;
            }
            if (label1.Text == "Taş" && label2.Text == "Makas")
            {
                lblResult.Text = "Taş makası kırar. Player 1 Kazandı.";
            }
            else if (label1.Text == "Taş" && label2.Text == "Kağıt")
            {
                lblResult.Text = "Kağıt taşı sarar. Player 2 Kazandı.";

            }
            else if (label1.Text == "Makas" && label2.Text == "Taş")
            {
                lblResult.Text = "Taş makası kırar. Player 2 Kazandı";

            }
            else if (label1.Text == "Makas" && label2.Text == "Kağıt")
            {
                lblResult.Text = "Makas kağıdı keser. Player 1 Kazandı.";
            }
            else if (label1.Text == "Kağıt" && label2.Text == "Taş")
            {
                lblResult.Text = "Kağıt taşı sarar. Player 1 Kazandı.";
            }
            else if (label1.Text == "Kağıt" && label2.Text == "Makas")
            {
                lblResult.Text ="Makas kağıdı keser. Player 2 Kazandı.";
            }
            
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            switch (rnd.Next(1, 4))
            {
                case 1:
                    label2.Text = "Taş";
                    break;
                case 2:
                    label2.Text = "Makas";
                    break;
                case 3:
                    label2.Text = "Kağıt";
                    break;
                    if (label1.Text == "Taş" && label2.Text == "Makas")
                    {
                        lblResult.Text = "Taş makası kırar. Player 1 Kazandı.";
                    }
                    else if (label1.Text == "Taş" && label2.Text == "Kağıt")
                    {
                        lblResult.Text = "Kağıt taşı sarar. Player 2 Kazandı.";

                    }
                    else if (label1.Text == "Makas" && label2.Text == "Taş")
                    {
                        lblResult.Text = "Taş makası kırar. Player 2 Kazandı";

                    }
                    else if (label1.Text == "Makas" && label2.Text == "Kağıt")
                    {
                        lblResult.Text = "Makas kağıdı keser. Player 1 Kazandı.";
                    }
                    else if (label1.Text == "Kağıt" && label2.Text == "Taş")
                    {
                        lblResult.Text = "Kağıt taşı sarar. Player 1 Kazandı.";
                    }
                    else if (label1.Text == "Kağıt" && label2.Text == "Makas")
                    {
                        lblResult.Text = "Makas kağıdı keser. Player 2 Kazandı.";
                    }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            lblResult.Text = "";
        }
    }
}
