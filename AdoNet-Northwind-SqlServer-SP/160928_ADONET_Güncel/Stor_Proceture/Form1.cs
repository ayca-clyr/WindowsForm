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

namespace Stor_Proceture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //AppConfig ile bağlantı yaparken Using System.Configuration kütüphanesini eklemek gerekiyor.Ama öncelikle projeye refence olarak eklenecek(Assemlies kısmında).
        SqlConnection cnnApp = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_AddEmployee",SqlHelper.Cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@firstName", txtBxFirstName.Text);
            cmd.Parameters.AddWithValue("@lastName", txtBxLastName.Text);

            SqlHelper.Cnn.Open();
            object result = cmd.ExecuteScalar();
            SqlHelper.Cnn.Close();
            MessageBox.Show("Çalışan Eklendi");
            lblId.Text = result.ToString();
        }
    }
}
