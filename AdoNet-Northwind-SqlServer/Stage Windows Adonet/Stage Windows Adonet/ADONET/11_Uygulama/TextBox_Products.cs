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

namespace _11_Uygulama
{
    public partial class TextBox_Products : Form
    {
        public TextBox_Products()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Products_Load(object sender, EventArgs e)
        {

        }

        private void btnProductShow_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlHelper.cnn;
            cmd.CommandText=string.Format("select ProductID,ProductName,p.UnitsInStock,UnitPrice from Products p join Categories c on p.CategoryID=c.CategoryID where c.CategoryName=@name",txtCategoryName.Text);
            cmd.Parameters.AddWithValue("@name", txtCategoryName.Text);

            //Sql Injection => B' or 1=1 or CategoryName'
            try
            {
                SqlHelper.cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = dr[0].ToString();
                        li.SubItems.Add(dr[1].ToString());
                        li.SubItems.Add(dr[2].ToString());
                        li.SubItems.Add(dr[3].ToString());
                        listView1.Items.Add(li);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlHelper.cnn.Close();
            }
        }
    }
}
