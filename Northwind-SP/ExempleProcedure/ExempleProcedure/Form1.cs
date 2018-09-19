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

namespace ExempleProcedure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();//Sql sorgusu için SqlCommand sınıfından nesne türettik 
            cmd.CommandText = "sp_EmployeeSave";//Çalıştıracağımız sorguyu yazdık

            cmd.CommandType = CommandType.StoredProcedure;//Çalışacak sorgunun tipini belirttik

            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);//Çalışacak sorgumuz stored procedure olduğundan göndereceğimiz ilk parametreyi belirttik

            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);//Çalışacak sorgumuz stored procedure olduğundan göndereceğimiz ikinci parametreyi belirttik

            cmd.Connection = SqlHelper.Conn; // komutumuzun bağlanacağı veritabanının yolunu SqlHelper sınıfında belirttiğimiz yol olarak belirttik

            SqlHelper.Conn.Open();//Bağlantımızı açltık

            int resualt = cmd.ExecuteNonQuery(); // Sorgumuzu (Procedure) çalıştırdık ve sorgu sonucunda etkilenen satır sayısını aldık

            if (resualt>0) // Etkilenen satır varsa sorgumuz başarılı bir şekilde çalışmışsa
            {
                MessageBox.Show("Kayıt başarılı"); // Mesajını verdirdk.
            }

            SqlHelper.Conn.Close();// şimdilik veritabanında işimiz olmadığından bağlantımızı kapattık.
        }
    }
}
