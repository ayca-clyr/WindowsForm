using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1
{
    public partial class Conneciton : Form
    {
        public Conneciton()
        {
            InitializeComponent();
        }
        public void BaglantiAcKapat()
        {
        

            try
            {
                if (SqlHelper.Cnn.State == System.Data.ConnectionState.Closed)
                {
                    SqlHelper.Cnn.Open();
                    //MessageBox.Show("Bağlantı Açıldı.");
                    lblDurum.Text = "Veritabanı Bağlantısı Açıldı";
                    lblDurum.BackColor = Color.Green;
                    lblDurum.ForeColor = Color.White;
                    btnConnection.Text = "Bağlantıyı Kapat";
                }
                else
                {
                    SqlHelper.Cnn.Close();
                    lblDurum.Text = "Veritabanı Bağlantısı Kesildi";
                    lblDurum.BackColor = Color.Red;
                    lblDurum.ForeColor = Color.White;
                    btnConnection.Text = "Bağlantıyı Aç";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }
        private void btnConnection_Click(object sender, EventArgs e)
        {
            BaglantiAcKapat();
            
        }
    }
}
