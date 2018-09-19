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
    public partial class YeniEkle : Form
    {
        public YeniEkle()
        {
            InitializeComponent();
        }
        private void UrunKategorisi()
        {

            List<Products> proList = new List<Products>();
            SqlCommand cmd = new SqlCommand("select ProductName from Products", SqlHelper.Cnn);
            SqlHelper.Cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Products pro = new Products();
                    pro.ProductName = reader[0].ToString();
                    proList.Add(pro);
                }
                cBxProducts.DataSource = proList;
            }
            SqlHelper.Cnn.Close();

        }

        private void YeniEkle_Load(object sender, EventArgs e)
        {
            UrunKategorisi();

        }


        private void UrunMiktari()
        {
            SqlCommand cmd = new SqlCommand("sp_UrunMiktari", SqlHelper.Cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@urunAdi", cBxProducts.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@urunMiktari", txtBxProductCount.Text);

            SqlHelper.Cnn.Open();
            object result = cmd.ExecuteScalar();
            SqlHelper.Cnn.Close();
            MessageBox.Show("Stock Güncellendi!");
            lblStock.Text = result.ToString();

        }
        int _click = 3;
        private void btnNewAdd_Click(object sender, EventArgs e)
        {
            // UrunMiktari();

            KategorileriYenidenOlustur();
            _click++;


        }


        private void KategorileriYenidenOlustur()
        {
            List<Products> list = new List<Products>();

            SqlCommand cmd1 = new SqlCommand("select ProductID, ProductName From Products", SqlHelper.Cnn);

            SqlHelper.Cnn.Open();
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.HasRows)
            {
                while (reader1.Read())
                {
                    Products pro = new Products();
                    pro.ProductID = (int)reader1[0];
                    pro.ProductName = (string)reader1[1];

                    list.Add(pro);

                }
            }
            SqlHelper.Cnn.Close();
            for (int i = 2; i < _click; i++)
            {
                ComboBox cBx = new ComboBox();
                cBx.Name = i.ToString();
                cBx.DataSource = list;
                cBx.Location = new Point(37, 43 * (i - 0));

                cBx.Size = new Size(140, 24);

                panel1.Controls.Add(cBx);

                Button btn = new Button();
                btn.Text = "Kaydet";
                btn.Name = i.ToString();
                btn.Location = new Point(420, 43 * i);
                btn.Size = new Size(85, 27);
                btn.Click += Btn_Click;
                panel1.Controls.Add(btn);

                Label lbl = new Label();

                lbl.Size = new Size(0, 17);
                lbl.Location = new Point(292, 43 * i);
                lbl.Text = "ds";
                panel1.Controls.Add(lbl);

                TextBox txtBx = new TextBox();

                txtBx.Size = new Size(140, 22);
                txtBx.Location = new Point(228, 43 * i);
                txtBx.Name = i.ToString();

                panel1.Controls.Add(txtBx);

            }
        }





        private void Btn_Click(object sender, EventArgs e)
        {
            int k = 2;
            Button btn = (Button)sender;


            while (k < _click)
            {
                if (btn.Text == "Kaydet" && btn.Name == k.ToString())
                {
                    UrunMiktari();

                }
                k++;

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listView();


        }

        List<OrderDetails> odList = new List<OrderDetails>();
        Form1 frm = new Form1();
        private void listView()
        {
            SqlCommand cmd = new SqlCommand("sp_Listele", SqlHelper.Cnn);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@urunAdi", cBxProducts.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@musteriAdi", frm._musteriAdi);
            cmd.Parameters.AddWithValue("@kargoAdi", frm._kargoAdi);
            cmd.Parameters.AddWithValue("@calisanAdi", frm._calisanAdi);
            cmd.Parameters.AddWithValue("@miktar", txtBxProductCount.Text);

            SqlHelper.Cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    OrderDetails od = new OrderDetails();
                    od.OrderID = (int)reader[0];
                    od.ProductID = (int)reader[1];
                    od.Discount = (int)reader[2];
                    od.Quantity = (int)reader[3];
                    od.UnitPrice = (int)reader[4];


                    ListViewItem li = new ListViewItem();
                    li.Tag = od;
                    li.Text = Convert.ToString(od.OrderID);
                    li.SubItems.Add(Convert.ToString(od.ProductID));
                    li.SubItems.Add(Convert.ToString(od.Discount));
                    li.SubItems.Add(Convert.ToString(od.Quantity));
                    li.SubItems.Add(Convert.ToString(od.UnitPrice));



                    lVSepetim.Items.Add(li);


                }

            }
            
            SqlHelper.Cnn.Close();

        }
    }
}
