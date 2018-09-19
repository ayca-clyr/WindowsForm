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

namespace _01_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection("server=AYCACALAYIR\\SQLEXPRESS;database=NORTHWND; Integrated Security=true;");
        private void Form1_Load(object sender, EventArgs e)
        {
        //    SqlConnection cnn = new SqlConnection("server=.;database=Northwind;");
        //    //Sql server'deki kullanıcı adı yazılır.
        //    SqlConnection cnn = new SqlConnection("server=.;database=Northwind;User ID=brcgn;password=1234;"); //Kullanıcı adı ve şifre varsa böyle girilir. 
            
            //Server => Data Source
            //User ID =>
            //Password =>pwd
            try
            {
                cnn.Open();
                //MessageBox.Show("Bağlantı açıldı.");
                label1.Text = "Açık";
                label1.BackColor = Color.Blue;
                label1.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void BaglantiAcKapa()
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                    label1.Text = "Açık";
                    label1.BackColor = Color.Blue;
                    label1.ForeColor = Color.White;
                }
                else
                {
                    cnn.Close();
                    label1.Text = "Kapalı";
                    label1.BackColor = Color.Red;
                    label1.ForeColor = Color.White;


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnOpenClosed_Click(object sender, EventArgs e)
        {
            BaglantiAcKapa();
        }
    }
}
