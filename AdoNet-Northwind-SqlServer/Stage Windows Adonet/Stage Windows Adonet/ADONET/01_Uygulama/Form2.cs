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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cnnString="server=.;database=Northwind;Integrated Security=true;";
            SqlConnection cnn = new SqlConnection(cnnString);
            //Sqlcommand => T-Sql sorgularını yani select, insert, update delete gibi işlemleri yapmak için kullandığım yapı.

            string query = "insert into Products(ProductName,UnitsInStock,Discontinued) values ('" + txtBxProductName.Text+"',"+txtBxUnitInStock.Text+","+txtBxDiscountinued.Text+")";

            SqlCommand cmd = new SqlCommand(query,cnn);
            SqlCommand cmd2 = new SqlCommand(string.Format("insert into Products(ProductName,UnitsInStock,Discontinued) values('{0}',{1},{2})", txtBxProductName.Text, txtBxUnitInStock.Text, txtBxDiscountinued.Text), cnn);

            cnn.Open();
            //ExecuteNonQuery()=> Sorguyu çalıştırır ve etkilenen satır sayısını bana geri döndürür. Insert,update,delete için kullanılır. Sadece int bir değer döndürür.

            int etkilenenSatirSayisi = cmd2.ExecuteNonQuery();
            cnn.Close();

            if (etkilenenSatirSayisi > 0)
            MessageBox.Show("Kayıt eklendi!");
            else
                MessageBox.Show("Kayıt eklenmedi!");
            
               
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtBxProductName.Text;
            SqlConnection cnn = new SqlConnection("server=.;database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand(string.Format("delete from Products where ProductName='{0}'", name), cnn);
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
        object gelenDeger;
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string name = txtBxProductName.Text;
            SqlConnection cnn = new SqlConnection("server=.;database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand(string.Format("select ProductID from Products where ProductName='{0}'",name),cnn);
            cnn.Open();

            //ExecuteScalar => Tek bir değer döndüren sorgularda kullanıyorum. Object tipinde bir veri dönüyor.
            gelenDeger = cmd.ExecuteScalar();
            if (gelenDeger != null)
            {
                MessageBox.Show(name+" ismine aitürünüm id'si= "+gelenDeger.ToString());
            }
            else
            {
                MessageBox.Show("Öyle bir verim yok!");
            }
            cnn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("server=.;database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand(string.Format("Update Products set ProductName='{0}',UnitsInStock={1},Discontinued={2} where ProductId={3}", txtBxProductName.Text, txtBxUnitInStock.Text, txtBxDiscountinued.Text,gelenDeger.ToString()), cnn);
            cnn.Open();
            int etkilenen = cmd.ExecuteNonQuery();
            cnn.Close();
            if (etkilenen > 0)
            {
                MessageBox.Show("Update Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız!");
            }
        }
    }
}
