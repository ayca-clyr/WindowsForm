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

namespace Uygulama_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlDataAdapter dA;
        DataTable dt;
        SqlCommandBuilder builder;

        private void DataGridDoldur()
        {
            dA = new SqlDataAdapter("select * from Shippers", SqlHelper.Cnn);
            dt = new DataTable();
            dA.Fill(dt);

            dGVShippers.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Değişiklikleri veritabanına kaydetmek istediğinize emin misiniz?","Senkron Uyarısı",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
           if (result == DialogResult.Yes)
           {
                builder = new SqlCommandBuilder();
               builder.DataAdapter = dA;
               dA.Update(dt);
              
               DataGridDoldur();

           }
           else
           {
               MessageBox.Show("İşleminiz iptal oldu!","İptal Uyarısı",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
               DataGridDoldur();
           }
        }
    }
}
