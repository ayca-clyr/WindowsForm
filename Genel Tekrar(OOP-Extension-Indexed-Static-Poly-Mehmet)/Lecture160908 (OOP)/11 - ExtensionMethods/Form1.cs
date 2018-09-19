using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11___ExtensionMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string name = "    asdasd     asdasdasd ";
           // string result = StringExtensions.FullTrim(name); // bu da olabilir
            string result = name.FullTrim(); // içine bir şey almıyor name i parametre gibi alıyor

            string result2 = name.FullTrim2(10); // parametre alan extensions method

            string input = Console.ReadLine();
            int number;
            number = input.ToInt();

            bool b = number.ToBoolean();

        }

      
    }
}
