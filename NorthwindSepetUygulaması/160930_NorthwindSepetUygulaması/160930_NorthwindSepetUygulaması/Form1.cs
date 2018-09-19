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

namespace _160930_NorthwindSepetUygulaması
{
    public partial class Form1 : Form
    {
        Order order;
        int y = 15;
        int index =0;
        List<Basket> basketList = new List<Basket>();
        List<Product> productList = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            EmployeeList();
            CustomerList();
            SupplierList();
        }
        private void SupplierList()
        {
            List<Shipper> shipperList = new List<Shipper>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ShipperID,CompanyName from Shippers";
            cmd.Connection = SqlHelper.Conn;
            try
            {
                SqlHelper.Conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Shipper shipper = new Shipper();
                    shipper.ShipperID = (int)reader[0];
                    shipper.CompanyName = (string)reader[1];
                    shipperList.Add(shipper);
                }
                cBoxShippers.DataSource = shipperList;
                cBoxShippers.DisplayMember = "CompanyName";
                cBoxShippers.ValueMember = "ShipperID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlHelper.Conn.Close();
            }
        }
        private void CustomerList()
        {
            List<Customer> customerList = new List<Customer>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT CustomerID, CompanyName FROM Customers";
            cmd.Connection = SqlHelper.Conn;
            try
            {
                SqlHelper.Conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerID = (string)reader[0];
                    customer.CompanyName = (string)reader[1];
                    customerList.Add(customer);
                }
                cBoxCustemer.DataSource = customerList;
                cBoxCustemer.DisplayMember = "CompanyName";
                cBoxCustemer.ValueMember = "CustomerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlHelper.Conn.Close();
            }
        }
        private void EmployeeList()
        {
            List<Employee> employeeList = new List<Employee>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT EmployeeID, FirstName+' '+LastName FullName From Employees";
            cmd.Connection = SqlHelper.Conn;
            try
            {
                SqlHelper.Conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.EmployeeID = (int)reader[0];
                    employee.FullName = reader[1].ToString();
                    employeeList.Add(employee);
                }
                cBoxEmplyee.DataSource = employeeList;
                cBoxEmplyee.DisplayMember = "FullName";
                cBoxEmplyee.ValueMember = "EmployeeID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlHelper.Conn.Close();
            }
        }
        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            #region OrderAdd
            order = new Order();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_OrderAdd";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerID", cBoxCustemer.SelectedValue);
            cmd.Parameters.AddWithValue("@EmployeeID", cBoxEmplyee.SelectedValue);
            cmd.Parameters.AddWithValue("@ShipperID", cBoxShippers.SelectedValue);
            cmd.Connection = SqlHelper.Conn;
            try
            {
                SqlHelper.Conn.Open();
                order.OrderID = (int)cmd.ExecuteScalar();
                if (order.OrderID > 0)
                {
                    MessageBox.Show("Sipariş Kaydı gerçekleştirildi. Siparişe ürün ekleme sayfasına yönlediriliyorsunuz");
                }
                else
                {
                    MessageBox.Show("Sipariş gerçekleştirilemedi");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlHelper.Conn.Close();
            }
            #endregion
            MessageBox.Show("Ürünleri sepete eklemek için :\nÜrüne çift tıklayın veya Sağ tıklayıp sepete ekle seçeneğini kullanın");
            grpBasket.Visible = grpProduct.Visible = true;
            ProductList();
        }
        private void ProductList()
        {
            lViewProduct.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ProductList";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = SqlHelper.Conn;
            try
            {
                SqlHelper.Conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductID = (int)reader[0];
                    product.ProductName = (string)reader[1];
                    product.CategoryName = (string)reader[2];
                    product.QuantityPerUnit = (string)reader[3];
                    product.UnitPrice = double.Parse(reader[4].ToString());
                    product.UnitsInStock = int.Parse(reader[5].ToString());
                    ListViewItem item = new ListViewItem();
                    item.Tag = product;
                    productList.Add(product);
                    item.Text = product.ProductName;
                    item.SubItems.Add(product.CategoryName);
                    item.SubItems.Add(product.QuantityPerUnit);
                    item.SubItems.Add(product.UnitPrice.ToString());
                    item.SubItems.Add(product.UnitsInStock.ToString());
                    lViewProduct.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlHelper.Conn.Close();
            }
        }
        private void lViewProduct_DoubleClick(object sender, EventArgs e)
        {
            if (lViewProduct.SelectedItems.Count==1)
            {
                bool control = false;
                for (int i = 0; i < basketList.Count; i++)
                {
                    if (basketList[i].ProductID==((Product)lViewProduct.SelectedItems[0].Tag).ProductID)
                    {
                        control = true;
                    }
                }
                if (control)
                    MessageBox.Show("Ürün Sepette zaten ekli");
                else
                    BasketAdd(); 
            }
        }

        private void BasketAdd()
        {
            Basket basket = new Basket();
            Product product = (Product)lViewProduct.SelectedItems[0].Tag;
            basket.ProductID = product.ProductID;
            Label label = new Label();
            label.Name = "lblProductName"+index;
            label.Text = product.ProductName;
            label.Location = new Point(15, y);
            label.AutoSize = false;
            label.Size = new Size(120, 30);
            pnlBasket.Controls.Add(label);
            basket.ProductName = product.ProductName;

            Label label2 = new Label();
            label2.Name = "lblUnitPrice" + index;
            label2.Text = product.UnitPrice.ToString();
            label2.Location = new Point(140, y);
            label2.AutoSize = false;
            label2.Size = new Size(90,30);
            pnlBasket.Controls.Add(label2);
            basket.UnitPrice = product.UnitPrice;

            TextBox text = new TextBox();
            text.Name = "txtPiece" + index;
            text.Text = "1";
            text.Location = new Point(235,y-3);
            text.Size = new Size(50, 20);
            text.TextChanged += Text_TextChanged;
            pnlBasket.Controls.Add(text);
            basket.Piece =int.Parse( text.Text);

            Label label3 = new Label();
            label3.Name = "lblTotalPrice" + index;
            label3.Location = new Point(320, y);
            label3.Size = new Size(60, 13);
            double totalPrice = double.Parse(text.Text) * double.Parse(label2.Text);
            label3.Text = totalPrice.ToString()+" $";
            pnlBasket.Controls.Add(label3);
            basket.totlaPrice = totalPrice;
            basketList.Add(basket);
            GrandTotal();
            y += 43;
            index++;
        }
        private void Text_TextChanged(object sender, EventArgs e)
        {
            int indexed =-1;
            TextBox text = (TextBox)sender;
            int piece;
            double price=0;
            if (text.TextLength>0 && int.TryParse(text.Text,out piece))
            {
                foreach (var item in pnlBasket.Controls)
                {
                    if (item is TextBox)
                    {
                        indexed++;
                    }
                    if (item is Label && ((Label)item).Left==text.Left-95 && ((Label)item).Top==text.Top+3)
                    {
                        price = double.Parse(((Label)item).Text);
                    }
                    if (item is Label && ((Label)item).Left==text.Left+85 && ((Label)item).Top == text.Top+3)
                    {
                        ((Label)item).Text = (price * piece).ToString()+" $";
                        basketList[indexed].Piece = int.Parse(text.Text);
                        basketList[indexed].totlaPrice = price * piece;
                    }
                }   
            }
            GrandTotal();
        }
        private void GrandTotal()
        {
            double grandTotal = 0;
            for (int i = 0; i < basketList.Count; i++)
            {
                grandTotal += basketList[i].totlaPrice;
            }
            lblTotalPrice.Text = grandTotal.ToString() + " $";
        }

        private void sEPETEEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool control = false;
            for (int i = 0; i < basketList.Count; i++)
            {
                if (basketList[i].ProductID == ((Product)lViewProduct.SelectedItems[0].Tag).ProductID)
                {
                    control = true;
                }
            }
            if (control)
                MessageBox.Show("Ürün Sepette zaten ekli");
            else
                BasketAdd();
        }

        private void btnOrderSave_Click(object sender, EventArgs e)
        {
            List<Basket> saveBasketList = new List<Basket>();
            bool saveControl = true;
            for (int i = 0; i < basketList.Count; i++)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_UnitsInStockControl";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductID", basketList[i].ProductID);
                cmd.Parameters.AddWithValue("@Piece", basketList[i].Piece);
                cmd.Connection = SqlHelper.Conn;
                SqlHelper.Conn.Open();
                object control =cmd.ExecuteScalar();
                if (control.ToString()=="0")
                {
                    MessageBox.Show(basketList[i].ProductName + " Ürününü stok miktarından fazla adet girişi yaptınız.\nişlem gerçekleştirilemedi.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    saveControl = false;
                    SqlHelper.Conn.Close();
                    break;
                }
                else
                {
                    saveBasketList.Add(basketList[i]);
                }
                SqlHelper.Conn.Close();

                
            }
            if (saveControl)
            {
                for (int i = 0; i < saveBasketList.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "sp_OrderDetailsSave";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductID", saveBasketList[i].ProductID);
                    cmd.Parameters.AddWithValue("@OrderID", order.OrderID);
                    cmd.Parameters.AddWithValue("@UnitPrice",saveBasketList[i].UnitPrice);
                    cmd.Parameters.AddWithValue("@Quantity",saveBasketList[i].Piece);
                    cmd.Connection = SqlHelper.Conn;
                    SqlHelper.Conn.Open(); try
                    {

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    SqlHelper.Conn.Close();
                }
                MessageBox.Show("Tebrikler! ürünleri başarılı bir şekilde kaydettiniz...");
                grpBasket.Visible = grpProduct.Visible = false;
                pnlBasket.Controls.Clear();
                lblTotalPrice.Text = "0 $";
                y = 15;
                index = 0;
                basketList.Clear();
                productList.Clear();
            }
        }
    }
}