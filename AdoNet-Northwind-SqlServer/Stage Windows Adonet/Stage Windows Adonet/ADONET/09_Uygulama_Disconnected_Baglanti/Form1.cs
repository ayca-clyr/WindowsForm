using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_Uygulama_Disconnected_Baglanti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetCategory_Click(object sender, EventArgs e)
        {
            string query = "select * from Categories";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query,SqlHelper.cnn);
            //SqlDataAdapter => server bağlantısını kendisi açıp kapar.
            
            //DataSet => Bu yapı RAM üzerindeki sanal tablolarımız olarak adlandırılabilir. Ancak DataSet'ler üzerinde asla bir veri bulunmaz. Bilgiler her zaman DataTable üzerinde tutulur. 
            //DataSet'in amacı DataTable'ları bir arada tutmaktır.
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dtgCategory.DataSource = ds.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
