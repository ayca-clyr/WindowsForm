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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        object gelenDeger;
        SqlConnection cnn;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection("server=.;database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand(string.Format("insert into Employees(FirstName,LastName) values('{0}','{1}')", txtBxFirstName.Text, txtBxLastName.Text), cnn);
            cnn.Open();
            int etkilenenSatırSayısı = cmd.ExecuteNonQuery();

            if (etkilenenSatırSayısı > 0)
                MessageBox.Show("Kayıt başarılı");
            else
                MessageBox.Show("Kayıt başarısız");
            cnn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection("server=.;database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand(string.Format("update Emloyees set FirstName='{0}',LastName='{1}' where EmployeeID=2)", txtBxFirstName.Text, txtBxLastName.Text, gelenDeger.ToString()), cnn);
            cnn.Open();
            int etkilenen = cmd.ExecuteNonQuery();
            if(etkilenen>0)
                MessageBox.Show("Kayıt başarılı");
            else
                MessageBox.Show("Kayıt başarısız");

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string name = txtBxFirstName.Text;
            cnn = new SqlConnection("server=.;database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand(string.Format("select EmployeeID from Employees where FirstName='{0}'", name), cnn);

            cnn.Open();
            gelenDeger = cmd.ExecuteScalar();
            if (gelenDeger != null)
            {
                MessageBox.Show(name + " ismine aitürünüm id'si= " + gelenDeger.ToString());
            }
            else
            {
                MessageBox.Show("Öyle bir verim yok!");
            }
            cnn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtBxFirstName.Text;
            SqlConnection cnn = new SqlConnection("server=.;database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand(string.Format("delete from where FirstName='{0}'", name), cnn);
            cnn.Open();
            int etkilenen = cmd.ExecuteNonQuery();
            if (etkilenen > 0)
            {
                MessageBox.Show("Verileriniz silindi!");
            }
            else
            {
                MessageBox.Show("Veriyi silerken bir hata oluştu!");
            }
            cnn.Close();
        }
    }
}
