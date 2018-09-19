using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_MoveButtons
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
            firstForm.MdiParent = this;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button button = new Button();
                    button.Name = "btn" + i + j;
                    button.Text = button.Name;
                    button.Size = new Size(50, 50);
                    button.Location = new Point(20 + (50 * i), 10 + (50 * j));
                    button.Click += button_Click;
                    firstForm.Controls.Add(button);
                }
            }
            firstForm.Show();
            SecondForm secondform = new SecondForm();
            secondform.MdiParent = this;
            secondform.Show();
        }

        void button_Click(object sender, EventArgs e)
        {
            Button tobeCarried = (Button)sender;
            Form owner = this.ActiveMdiChild;

            foreach (Form  form in this.MdiChildren)
            {
                if (owner is FirstForm && form is SecondForm)
                {
                    form.Controls.Add(tobeCarried);
                    tobeCarried.BackColor = Color.Azure;
                    break;
                }
                if (owner is SecondForm && form is FirstForm)
                {
                    form.Controls.Add(tobeCarried);
                    tobeCarried.BackColor = Color.Lavender;
                    break;
                }
            }

        }
    }
}
