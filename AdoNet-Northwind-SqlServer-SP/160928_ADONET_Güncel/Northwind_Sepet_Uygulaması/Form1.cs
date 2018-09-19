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

namespace Northwind_Sepet_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Customers> cusList = new List<Customers>();
        List<Employees> empList = new List<Employees>();
        private void KategorileriGetir()
        {

            SqlCommand cmd = new SqlCommand("select CustomerID,CompanyName from Customers", SqlHelper.Cnn);
            SqlCommand cmd2 = new SqlCommand("select EmployeeID, FirstName,LastName from Employees", SqlHelper.Cnn);
            SqlHelper.Cnn.Open();
            
            
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader.HasRows && reader2.HasRows)
            {

                while (reader.Read() && reader2.Read())
                {
                    Employees emp = new Employees();
                    emp.EmployeeID = (int)reader[0];

                    emp.FirstName = reader[1].ToString();
                    emp.LastName = reader[2].ToString();
                    empList.Add(emp);


                    Customers cus = new Customers();
                    cus.CustomerID = (int)reader[3];
                    cus.CompanyName = reader[4].ToString();

                    cusList.Add(cus);
                }
                cBxCustomers.DataSource = cusList;
                cBxEmployees.DataSource = empList;
            
            }
            SqlHelper.Cnn.Close();
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            YeniEkle yeniEkle = new YeniEkle();
            yeniEkle.Show();

        }
    }
}
