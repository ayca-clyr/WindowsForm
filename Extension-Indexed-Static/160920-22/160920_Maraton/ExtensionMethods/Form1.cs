using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionMethods
{
    public partial class Form1 : Form
    {
        // Aynı tipleri (this int, this string) farklı sınıflarda topla.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string name = "    Tsubasa    Ozara   ";
            // this - static eklediğimizde Class'da bunu instance hale getirebiliyoruz.
            string result = name.FullTrim();
            // Aşağıdaki normal yazım
            // string resul3 = StringExtensions.FullTrim(name);
            // string resul3 = StringExtensions.FullTrim(name,10);

            char firstChar = name.First();


            string input = Console.ReadLine();
            int number;
            // int.TryParse(intput, out number);
            number = int.Parse(input);
            number = input.ToInt();

            bool b = number.ToBoolean();


        }
    }
}
