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
    public partial class ProductDML : Form
    {
        public ProductDML()
        {
            InitializeComponent();
        }

       
        private void ProductDML_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            listView1.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select ProductName,QuantityPerUnit,UnitPrice,UnitsInStock from products;";
            cmd.Connection = SqlHelper.cnn;
            try
            {
                SqlHelper.cnn.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = dataReader[0].ToString();
                        li.SubItems.Add(dataReader[1].ToString());
                        li.SubItems.Add(dataReader[2].ToString());
                        li.SubItems.Add(dataReader[3].ToString());
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

        private void btnİnsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlHelper.cnn;
            cmd.CommandText = string.Format("insert into Products(ProductName,QuantityPerUnit,UnitPrice,UnitsInStock) values ('{0}','{1}',{2},{3})", txtBxProductName.Text, txtBxQuantityPerUnit.Text, txtBxUnitPrice.Text, txtBxUnitsInStock.Text);
            try
            {
                
                SqlHelper.cnn.Open();
                cmd.ExecuteNonQuery();
                ListViewItem li = new ListViewItem();
                li.Text = txtBxProductName.Text;
                li.SubItems.Add(txtBxQuantityPerUnit.Text);
                li.SubItems.Add(txtBxUnitPrice.Text);
                li.SubItems.Add(txtBxUnitsInStock.Text);
                listView1.Items.Add(li);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlHelper.cnn.Close();
                Listele();
            }
        }
    }
}
