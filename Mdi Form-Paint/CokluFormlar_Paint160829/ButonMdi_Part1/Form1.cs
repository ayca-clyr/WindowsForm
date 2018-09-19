using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButonMdi_Part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FirstForm firstForm = new FirstForm();
            firstForm.Show();
            firstForm.MdiParent = this;

            int i, j;

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                   
                    Button btn = new Button();
                    btn.Name = "btn" + i + j;
                    btn.Text = "Button" + (j + 1) + " , " + (i + 1);
                    btn.Size = new Size(80, 60);
                    //btn.Height = 50 * i;    Location'la aynı yükseklik
                    //btn.Width = 50 * j;     Location'la aynı taban
                    btn.Location = new Point(i * 80, j * 60);
                    btn.BackColor = Color.Green;
                    // Event burada çağrılacak. Neden ? 
                   btn.Click += btn_Click; 
                    
                    firstForm.Controls.Add(btn);
                    

                   
                    
                }
            }

            firstForm.Show();
            SecondForm secondForm = new SecondForm();
            secondForm.MdiParent = this;
            // secondForm = this.MdiChildren;

            secondForm.Show();

        }

        void btn_Click(object sender, EventArgs e)
        {
            Button tasinanButton = (Button)sender;

            Form sahipOlunan = this.ActiveMdiChild;  // Aktif Form

            foreach (Form form in this.MdiChildren)
            {
                if (sahipOlunan is FirstForm && form is SecondForm)
                {
                    form.Controls.Add(tasinanButton);
                    tasinanButton.BackColor = Color.Red;
                } if (sahipOlunan is SecondForm && form is FirstForm)
                {
                    form.Controls.Add(tasinanButton);
                    tasinanButton.BackColor = Color.Green;
                    break;
                }
            }
        }


       
    }
    }

