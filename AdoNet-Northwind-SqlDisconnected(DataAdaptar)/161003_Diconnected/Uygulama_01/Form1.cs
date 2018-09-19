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

namespace Uygulama_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetCategories_Click(object sender, EventArgs e)
        {
            string query = "select * from Categories";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query,SqlHelper.Cnn);

           // SqlDataAdapter dataAdapter1 = new SqlDataAdapter("select * from Categories", SqlHelper.Cnn);

            // SqlDataAdapter => server bağlantısını kendi açıp kapar.
            
            // DataSet => Bu yapı RAM üzerindeki sanal tablolarımız olarak adlandırılabilir. Ancak DataSet'ler üzerinde asla bir veri bulunmaz. Bilgiler her zaman DataTable üzerinde tutulur.
            // DataSet'in amacın DataTable'ları bir arada tutmaktır.
            DataSet ds = new DataSet();  // DataSet veritabanı, Tables tablolarımız
            dataAdapter.Fill(ds);
            dGVCategories.DataSource = ds.Tables[0];
        }
    }
}
