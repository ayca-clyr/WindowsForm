using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_05
{
    public partial class Listele : Form
    {
        public Listele()
        {
            InitializeComponent();
        }
        public List<Listele> listele;
        private void Listele_Load(object sender, EventArgs e)
        {
            listele = new List<Listele>();
            dataGridView1.DataSource = listele;
            
        }
    }
}
