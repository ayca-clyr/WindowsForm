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
using System.Configuration;


namespace _08_Uygulama_StroeProcedure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //AppConfig ile bağlantı yaparken Using System.Configuration kütüphanesini eklemek gerekiyor.Ama öncelikle projeye reference olarak eklenecek(Assemblies kısmında)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cnnApp = new SqlConnection(ConfigurationManager.ConnectionStrings["bağlantı"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlHelper.cnn;
            cmd.CommandText = "sp_AddEmployee"; // Prosedürde sadece ismi yazılır.
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@firstName", txtBxFirstName.Text);
            cmd.Parameters.AddWithValue("@lastName", txtBxLast.Text);
            SqlHelper.cnn.Open();
            object result = cmd.ExecuteScalar();
            SqlHelper.cnn.Close();
            MessageBox.Show("Çalışan Eklendi");
            label1.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
