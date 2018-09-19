
using _02_Entity.Data;
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

namespace _02_Entity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnected_Click(object sender, EventArgs e)
        {
            DateTime baslangic = DateTime.Now;
            SqlConnection cnn = new SqlConnection("server=.;database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand("select * from Orders", cnn);
            cnn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                lstConnected.Items.Add(read["OrderID"].ToString());
            }
            cnn.Close();
            DateTime bitis = DateTime.Now;
            TimeSpan fark = bitis - baslangic;
            lblConnected.Text = fark.Milliseconds.ToString();

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
            lstDisconnected.DisplayMember = "OrderID";         
            DateTime bitis = DateTime.Now;
            TimeSpan fark = bitis - baslangic;
            lblDisconnected.Text = fark.Milliseconds.ToString();


        }

        private void btnEntityFramework_Click(object sender, EventArgs e)
        {
            DateTime baslangic = DateTime.Now;
            NorthwindEntities2 db = new NorthwindEntities2(); 
            var query = (
                from o in db.Orders
                select o).ToList();
            lstEntity.DataSource = query;
            lstEntity.DisplayMember = "OrderID";
            DateTime bitis = DateTime.Now;
            TimeSpan fark = bitis - baslangic;
            lblEntityFramework.Text = fark.Milliseconds.ToString();
        }
    }
}
