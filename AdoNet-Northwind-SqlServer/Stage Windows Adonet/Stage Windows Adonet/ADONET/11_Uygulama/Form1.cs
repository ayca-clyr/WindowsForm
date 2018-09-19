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

namespace _11_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlDataAdapter dataAdapter;
        DataTable datatable;
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
        }
        SqlCommandBuilder builder; // Arka planda yaptığım insert, delete işlemlerini otomatik yapıyor.
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DialogResult result=MessageBox.Show("Değişikleri veritabanına kaydetmek istediğinize emin misiniz?","Sekron uyarısı",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                builder = new SqlCommandBuilder(); // İnsert,update,delete işlemlerini yapabilmek için ekleriz.
                builder.DataAdapter = dataAdapter;
                dataAdapter.Update(datatable);
                DataGridDoldur();
            }
            else
            {
                MessageBox.Show("İşleminiz iptal oldu!","İptal Uyarısı",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                DataGridDoldur();
            }
        }

        private void DataGridDoldur()
        {
            dataAdapter = new SqlDataAdapter("select * from Shippers", SqlHelper.cnn);
            datatable = new DataTable();
            dataAdapter.Fill(datatable);
            dtgShippers.DataSource = datatable;
        }
    }
}
