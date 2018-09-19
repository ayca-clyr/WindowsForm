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

namespace View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select CategoryName,CategorySales from [Category Sales for 1997]",SqlHelper.Cnn); // Eğer yazdığımız View'de boşluklar varsa bunu [] içine yazıyoruz. Yoksa direk yazıyoruz.

            SqlHelper.Cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = reader[0].ToString();
                    li.SubItems.Add(reader[1].ToString());

                    lVCategories.Items.Add(li);
                }
            }
        }
    }
}
