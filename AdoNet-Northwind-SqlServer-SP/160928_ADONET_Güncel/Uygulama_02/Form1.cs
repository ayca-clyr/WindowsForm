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

namespace Uygulama_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        object gelenDeger;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("server=Pc;database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand(string.Format("insert into Employees(FirstName, LastName, City) values('{0}','{1}','{2}')", txtBxFirstName.Text, txtBxLastName.Text, cBxCity.SelectedItem), cnn);
            cnn.Open();
            int etkilenenDeger = cmd.ExecuteNonQuery();
            cnn.Close();
            if (etkilenenDeger > 0)
            {
                MessageBox.Show("Eklendi");
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("server=PC;database=Northwind;Integrated Security= true;");
            SqlCommand cmd = new SqlCommand(string.Format("delete from Employees where FirstName = '{0}'", txtBxFirstName.Text), cnn);
            cnn.Open();
            int etkilenenDeger = cmd.ExecuteNonQuery();
            cnn.Close();
            if (etkilenenDeger > 0)
            {
                MessageBox.Show("Silindi");
            }
            else
            {
                MessageBox.Show("Öyle Bir Kişi Yok");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("server=PC;database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand(string.Format("select EmployeeID from Employees where FirstName='{0}'",txtBxFirstName.Text),cnn);
            cnn.Open();
            gelenDeger = cmd.ExecuteScalar();
            cnn.Close();
            if (gelenDeger != null)
            {
                MessageBox.Show(txtBxFirstName.Text + "'nın Id'si : "+gelenDeger.ToString());
            }
            else
            {
                MessageBox.Show("Böyle Bir Id Bulunamadı!");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("server=PC;database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand(string.Format("update Employees set LastName='{0}',City= '{1}' where EmployeeID={2} ",txtBxLastName.Text,cBxCity.SelectedItem,gelenDeger),cnn);
            cnn.Open();
            int etkilenenDeger = cmd.ExecuteNonQuery();
            cnn.Close();
            if (etkilenenDeger > 0)
            {
                MessageBox.Show("Değişiklik Yapılmıştır!");
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!");
            }
        }
    }
}
