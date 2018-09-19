using _02_Uygulama.Data;
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


namespace _02_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnected_Click(object sender, EventArgs e)
        {
            lstconnected.Items.Clear();
            DateTime baslangic = DateTime.Now;
            SqlConnection cnn = new SqlConnection("server=.;database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand("select * from Orders", cnn);
            cnn.Open();
           SqlDataReader reader = cmd.ExecuteReader();
           while (reader.Read())
           {

               lstconnected.Items.Add(reader["OrderID"].ToString()); 
           }
           cnn.Close();
           DateTime bitis = DateTime.Now;
           TimeSpan fark = bitis - baslangic; //TimeSpan => Zaman farkı
           lblConnected.Text = fark.Milliseconds.ToString(); //en ince ayrıntısına kadar alır.
        }

        private void btnDisconnected_Click(object sender, EventArgs e)
        {
            lstDisconnected.DataSource = null;

             DateTime baslangic = DateTime.Now;
            SqlConnection cnn = new SqlConnection("server=.;database=Northwind;Integrated Security=true;");
            SqlDataAdapter da = new SqlDataAdapter("select * from Orders", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lstDisconnected.DataSource = dt;
            lstDisconnected.DisplayMember = "OrderID";   //Bize görünen       
            DateTime bitis = DateTime.Now;
            TimeSpan fark = bitis - baslangic; //TimeSpan => Zaman farkı
           lblDisconnected.Text = fark.Milliseconds.ToString(); 
        }

        private void btnEntityFramework_Click(object sender, EventArgs e)
        {
            DateTime baslangic = new DateTime();
            NorthwindEntities db = new NorthwindEntities();
            var query = (
                from o in db.Orders
                select o
                ).ToList();
            lstEntity.DataSource = query;
            lstEntity.DisplayMember = "OrderID";
            DateTime bitis = DateTime.Now;
            TimeSpan fark = bitis - baslangic;
            lblEntity.Text = fark.Milliseconds.ToString();
        }
    }
}
