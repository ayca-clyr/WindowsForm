using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_RunTimeButonKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button btn;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ButonEkle();
        }
        
        void ButonEkle()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    panel1.Width = 5 * 50;
                    panel1.Height = 5 * 50;
                    btn = new Button();
                    btn.Name="Button"+i+j;
                    btn.Size = new Size(50, 50);
                    btn.Location = new Point(i * 50, j * 50);
                    btn.BackColor = Color.Sienna;
                    btn.Click += btn_Click;
                    panel1.Controls.Add(btn);
                }
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button tikla = sender as Button;
            tikla.BackColor = Color.Gold;
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void btnColorReset_Click(object sender, EventArgs e)
        {
            
            ColorReset();
        }
        void ColorReset()
        {
            foreach (Button panel in panel1.Controls)
            {
                panel.BackColor = Color.MintCream;
            }

        }
    }
}
