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

namespace _03_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1.Yöntem =>SqlHelper da SqlConnection instance'ını oluşturup direk class'dan uygulamaya bağlantı sağlama
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select EmployeeID,FirstName,LastName,BirthDate,City from Employees";
            cmd.Connection = SqlHelper.Connection;
            try
            {
                SqlHelper.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        //listBox = Eklerken
                        string fullName=dataReader[1].ToString()+" "+dataReader[2].ToString();
                        lstEmployees.Items.Add(fullName);
                        
                        //ListView = Eklerken
                        ListViewItem lw = new ListViewItem();
                        
                        lw.Text = dataReader[0].ToString();
                        lw.SubItems.Add(dataReader[1].ToString());
                        lw.SubItems.Add(dataReader[2].ToString());
                        //lw.SubItems.Add(dataReader[3].ToString());
                        //lw.SubItems.Add(((DateTime)(dataReader[3])).ToShortDateString());
                        lw.SubItems.Add(DateTime.Parse(dataReader[3].ToString()).ToShortDateString());
                        lw.SubItems.Add(dataReader[4].ToString());

                        lvwEmployees.Items.Add(lw);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlHelper.Connection.Close();
            }
        }

        private void lvwEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
