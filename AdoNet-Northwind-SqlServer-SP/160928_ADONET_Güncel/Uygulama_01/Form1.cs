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
        SqlConnection cnn = new SqlConnection("server=PC;database=Northwind;Integrated Security=true;");
        private void Form1_Load(object sender, EventArgs e)
        {
            // SQL Server Authentication
            // SqlConnection cnn = new SqlConnection("server=PC;database=Northwind;User ID=brcng;password=1234;");  // Server = diyip SQL server'deki adı yaz. "PC" 

            // Windows Authentication
            // SqlConnection cnn = new SqlConnection("server=PC;database=Northwind;Integrated Security=true;");
            // Server => Data Source
            // User ID => uid
            // Password => pwd

            BaglantiAcKapat();
            
            //this.Text = "Deneme";

        }

        public void BaglantiAcKapat()
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                    //MessageBox.Show("Bağlantı Açıldı.");
                    lblDurum.Text = "Açık";
                    lblDurum.BackColor = Color.Blue;
                    lblDurum.ForeColor = Color.White;
                    btnBaglanti.Text = "Bağlantıyı Kapat";
                }
                else
                {
                    cnn.Close();
                    lblDurum.Text = "Kapalı";
                    lblDurum.BackColor = Color.Red;
                    lblDurum.ForeColor = Color.White;
                    btnBaglanti.Text = "Bağlantıyı Aç";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
            
        }

        private void btnBaglanti_Click(object sender, EventArgs e)
        {
            BaglantiAcKapat();
        }
    }
}
