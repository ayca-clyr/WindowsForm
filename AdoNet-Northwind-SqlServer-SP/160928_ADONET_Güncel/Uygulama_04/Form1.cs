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

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1.Yöntem
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select EmployeeID, FirstName,LastName,BirthDate,City from Employees";
            cmd.Connection = SqlHelper.Connection;

            try
            {
                SqlHelper.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {  // Geri dönen satır var mı? Varsa Geri dön.
                    while (dataReader.Read())  // Okuduğu sürece döngüde kalıyor.
                    {
                        // ListBox'a eklerken
                        string fullName = dataReader[1].ToString()+ " "+dataReader[2].ToString();  // Kaçıncı indisi yazdırcaksak sorgudaki kolon adlarından 0-1-2-3-...   0 --> EmployeeID 1 --> FirstName  2--> LastName
                        lstEmployees.Items.Add(fullName);
                        // ListView'a eklerken

                        ListViewItem li = new ListViewItem();
                        li.BackColor = Color.Red;
                        li.ForeColor = Color.Yellow;
                        li.Text = dataReader[0].ToString();
                        li.SubItems.Add(dataReader[1].ToString());
                        li.SubItems.Add(dataReader[2].ToString());
                        li.SubItems.Add(Convert.ToDateTime(dataReader[3]).ToString("dd/MM/yyyy"));
                        li.SubItems.Add(DateTime.Parse(dataReader[3].ToString()).ToShortDateString());
                        // li.SubItems.Add(((DateTime)(dataReader[3])).ToShortDateString());

                        li.SubItems.Add(dataReader[4].ToString());

                        lVEmployees.Items.Add(li);
                        
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            SqlHelper.Connection.Close();
        }
    }
}
