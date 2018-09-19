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

namespace Uygulama_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetCategories_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dA = new SqlDataAdapter(string.Format("select ProductID,ProductName,UnitsInStock,UnitPrice from Products where CategoryID={0} ", txtBxCategoryID.Text), SqlHelper.Cnn);
            DataTable dt = new DataTable();
            dA.Fill(dt);

            dGVProductsList.DataSource = dt;
           
        }

        private void btnGetCategoriesName_Click(object sender, EventArgs e)
        {
           SqlCommand cmd = new SqlCommand(string.Format("select p.ProductID,p.ProductName, p.UnitsInStock, p.UnitPrice from Products p join Categories c on c.CategoryID = c.CategoryID where c.CategoryName = '{0}'", txtBxCategoryName.Text), SqlHelper.Cnn);

            // Dışarı taşmadan bu işlemi yapıyor.
            SqlCommand cmd2 = new SqlCommand(string.Format("select p.ProductID,p.ProductName, p.UnitsInStock, p.UnitPrice from Products p join Categories c on c.CategoryID = c.CategoryID where c.CategoryName = @name"), SqlHelper.Cnn);
            cmd2.Parameters.AddWithValue("@name", txtBxCategoryName.Text);   // Bu kodlar B' or 1=1 or CategoryName=' bunu yazdığımızda getirmeyecek!
            // Beverages ' or 1=1 or CategoryName='

            // Sql Injection 
           // 'or 1=1 or CategoryName ='  Tüm ürünleri getirdik.
            try
            {
                SqlHelper.Cnn.Open();
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

                        lVCategoryName.Items.Add(li);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                SqlHelper.Cnn.Close();
            }
            
        }
    }
}
