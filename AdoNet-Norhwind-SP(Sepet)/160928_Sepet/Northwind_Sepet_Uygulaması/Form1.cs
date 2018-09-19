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
        List<Orders> ordList = new List<Orders>();
        public string _kargoAdi = " ";
        public string _musteriAdi = " ";
        public string _calisanAdi = " ";
        private void KargoKategorisi()
        {
            SqlCommand cmd3 = new SqlCommand("select  distinct ShipVia from Orders", SqlHelper.Cnn);
            SqlHelper.Cnn.Open();
            SqlDataReader reader = cmd3.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Orders ord = new Orders();

                    ord.ShipVia = reader[0].ToString();

                    ordList.Add(ord);
                }
                cBxShipVia.DataSource = ordList;
            }
            SqlHelper.Cnn.Close();
        }


        private void CalisanKategorisi()
        {
            SqlCommand cmd2 = new SqlCommand("select EmployeeID, FirstName,LastName from Employees", SqlHelper.Cnn);
            SqlHelper.Cnn.Open();
            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.HasRows)//
            {

                while (reader.Read())
                {
                    Employees emp = new Employees();
                    emp.EmployeeID = (int)reader[0];

                    emp.FirstName = reader[1].ToString();
                    emp.LastName = reader[2].ToString();
                    empList.Add(emp);

                }
                cBxEmployees.DataSource = empList;
            }
            SqlHelper.Cnn.Close();
        }

        private void MüsteriKategorisi()
        {

            SqlCommand cmd = new SqlCommand("select CustomerID,CompanyName from Customers", SqlHelper.Cnn);
            SqlHelper.Cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {

                while (reader.Read())
                {



                    Customers cus = new Customers();
                    cus.CustomerID = reader[0].ToString();
                    cus.CompanyName = reader[1].ToString();

                    cusList.Add(cus);

                }
                cBxCustomers.DataSource = cusList;


            }
            SqlHelper.Cnn.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



            YeniEkle yeniEkle = new YeniEkle();
            yeniEkle.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MüsteriKategorisi();
            CalisanKategorisi();
            KargoKategorisi();
        }

        private void cBxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            _calisanAdi = cBxEmployees.SelectedItem.ToString();

        }

        private void cBxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _musteriAdi = cBxCustomers.SelectedItem.ToString();
        }

        private void cBxShipVia_SelectedIndexChanged(object sender, EventArgs e)
        {
            _kargoAdi = cBxShipVia.SelectedItem.ToString();
        }
    }
}
