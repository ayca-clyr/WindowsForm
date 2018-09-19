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

namespace Uygulama_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select distinct ShipCountry from Orders";
            cmd.Connection = SqlHelper.Cnn;

            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())  // == true desen'de olur.
                    {
                        cBxCountry.Items.Add(dataReader[0].ToString());
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

        private void cBxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = cBxCountry.SelectedItem.ToString();
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = string.Format("select count(OrderID) from Orders where ShipCountry = '{0}'",country);
            //cmd.Connection = SqlHelper.Cnn;

            SqlCommand cmd2 = new SqlCommand(string.Format("select count(OrderID) from Orders where ShipCountry = '{0}'", country), SqlHelper.Cnn);

            SqlHelper.Cnn.Open();
            object result = cmd2.ExecuteScalar();
            SqlHelper.Cnn.Close();

            txtBxCount.Text = result.ToString();
        }
    }
}
