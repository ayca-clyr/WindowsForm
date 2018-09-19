using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // LINQ => Language Integrated Query
        // Linq to Object
        // Linq to SQL
        // Linq to Entitiy
        // Linq to XML

        List<string> namesList = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            namesList.Add("Burcu Engin");
            namesList.Add("Ali Ozan Pişkin");
            namesList.Add("Doğan Kahveci");
            namesList.Add("Toni Demirci");
            namesList.Add("Gürkan Fidan");
            namesList.Add("Fidan Kartal");
            namesList.Add("Ayça Calayır");
            namesList.Add("Burak Kaya");
            namesList.Add("Ferhat Demirci");
            namesList.Add("Bilal Günaydın");
            namesList.Add("Raif Çıplak");
            namesList.Add("Mehmet Avcı");
            namesList.Add("İsmail Can Ateş");
            namesList.Add("Turgay Kaya");
            namesList.Add("Yiğit Taş");

            BindListBox(namesList);
        }

        private void BindListBox(List<string> data)
        {
            lstNames.DataSource = null;
            lstNames.DataSource = data;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string value = txtBxSearch.Text;
            //List<string> result = (
            //    from name in namesList
            //    where name.ToLower().Contains(value)  // ToLower() --> Bütün Harfleri küçültür.
            //    orderby name
            //    select name).ToList();

            List <string> result =(
                from item in namesList
                    where item.ToLower().StartsWith(value)
                    orderby item
                    select item).ToList();
                    
            BindListBox(result);
        }

        private void txtBxSearch_TextChanged(object sender, EventArgs e)
        {
            string value = txtBxSearch.Text.ToLower();
            List<string> result = (
                from item in namesList                // Foreach Mantığı.
                where item.ToLower().Contains(value)
                orderby item
                select item).ToList();
            BindListBox(result);

        }

    }
}
