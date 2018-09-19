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

namespace _04_Uygulama
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
            cmd.Connection = SqlHelper.cnn;
            try
            {
                SqlHelper.cnn.Open();
                SqlDataReader dateReader = cmd.ExecuteReader();
                if (dateReader.HasRows)
                {
                    while (dateReader.Read())
                    {
                        cmbCountry.Items.Add(dateReader[0].ToString());
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

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country=cmbCountry.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select count(OrderID) from Orders where ShipCountry='" + country + "'";
            cmd.CommandText = string.Format("select count(OrderID) from Orders where ShipCountry='{0}'", country);
            cmd.Connection = SqlHelper.cnn;

            SqlHelper.cnn.Open();
            object result = cmd.ExecuteScalar();
            SqlHelper.cnn.Close();

            cmbCount.Text = result.ToString();
        }
    }
}
