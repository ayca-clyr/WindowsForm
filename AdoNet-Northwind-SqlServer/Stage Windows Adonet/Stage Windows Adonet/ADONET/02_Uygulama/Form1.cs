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
            SqlConnection cnn = new SqlConnection();
            //SqlConnection cnn2 = new SqlConnection(SqlHelper.ConnectionString);
            //SqlConnection cnn3 = new SqlConnection("server=.;database=Northwind;Integrated Security=true;");
            cnn.ConnectionString = SqlHelper.ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select CategoryID,CategoryName,Description from Categories";
            cmd.Connection = SqlHelper.cnn2;
            try
            {
                SqlHelper.cnn2.Open();
                //DataReader
                //1.Çoklu satırları okumaya yarar.
                //2.Satırları okurken geriye dönmez.
                SqlDataReader dataReader = cmd.ExecuteReader();
                //Sorgu sonucu geriye dönen bir değer var mı?
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        lstCatagories.Items.Add(dataReader["CategoryID"].ToString());
                        //lstCatagories.Items.Add(dataReader[0].ToString());
                        //lstCatagories.Items.Add(dataReader.GetString(0));
                        lstCatagories.Items.Add(dataReader[1].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

            finally
            {
                SqlHelper.cnn2.Close();
            }
        }
    }
}
