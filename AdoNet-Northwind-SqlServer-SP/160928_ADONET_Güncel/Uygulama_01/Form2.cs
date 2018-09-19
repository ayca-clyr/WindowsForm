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

namespace Uygulama_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // SqlConnection cnn = new SqlConnection("server=PC;database=NORTHWND;Integrated Security=true;");

        object gelenDeger;
    
    
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // String verileri ' ' arasına al, Int değerleri normal yaz.

            string cnnString = "server=PC;database=Northwind;Integrated Security=true;";
            SqlConnection cnn = new SqlConnection(cnnString);
            // SqlCommand => T-Sql sorgularını (SELECT,INSERT,UPDATE,DELETE) gibi işlemleri yapmak için kullandığım yapı.
            string query = "insert into Products(ProductName,UnitsInStock,Discontinued) values('" + txtBxProductName.Text + "'," + txtBxUnitInStock.Text + "," + txtBxDiscountinued.Text + ")";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlCommand cmd2 = new SqlCommand(string.Format("insert into Products(ProductName,UnitsInStock,Discontinued) values('{0}',{1},{2})", txtBxProductName.Text, txtBxUnitInStock.Text, txtBxDiscountinued.Text), cnn);

            cnn.Open();
            // ExecuteNonQuery() => Sorguyu çalıştrır ve etkilenen satır sayısını bana geri döndürür. INSERT, UPDATE,DELETE için kullanılır. Sadece int bir değer döndürür.
            int etkilenenSatirSayisi = cmd2.ExecuteNonQuery();
            cnn.Close();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Kayıt Eklendi");
            }
            else
            {
                MessageBox.Show("Kayıt Eklenirken Bir Hata Oluştu!");
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtBxProductName.Text;
            SqlConnection cnn = new SqlConnection("server=PC;database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand(string.Format("delete from Products where ProductName = '{0}'", name), cnn);
            cnn.Open();
            int etkilenen = cmd.ExecuteNonQuery();
            cnn.Close();
            if (etkilenen > 0)
            {
                MessageBox.Show("Veriniz Silindi.");
            }
            else
            {
                MessageBox.Show("Veriyi silerken bir hata oluştu.");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string name = txtBxProductName.Text;
            SqlConnection cnn = new SqlConnection("server=PC;database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand(string.Format("select ProductID,UnitPrice from Products where ProductName = '{0}'", name), cnn);
            cnn.Open();
            // ExecuteScalar => Tek bir değer döndüren sorgularda kullanıyorum. Object tipinde bir veri dönüyor.2 değer yazsak bile bize ilk değeri döndürecektir.
            gelenDeger = cmd.ExecuteScalar();
            cnn.Close();
            if (gelenDeger != null)
            {
                MessageBox.Show(name + " ismine ait ürünün id'si = " + gelenDeger.ToString());

            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Önce SELECT işlemi uygula daha sonra verileri ekleyip UPDATE işlemi yap.
            SqlConnection cnn = new SqlConnection("server=PC;database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand(string.Format("update Products set ProductName='{0}', UnitsInStock={1}, Discontinued={2} where ProductID={3} ", txtBxProductName.Text, txtBxUnitInStock.Text, txtBxDiscountinued.Text,gelenDeger), cnn);
            
            cnn.Open();
            int etkilenen = cmd.ExecuteNonQuery();
            if (etkilenen > 0)
            {
                MessageBox.Show("Update Başarılı");
            }
            else
            {
                MessageBox.Show("Yanlış İşlem Uyguladınız!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
