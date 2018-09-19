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

namespace Tekrar_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewAdd_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Add";
            Temizle();
            groupAdd.Visible = true;
            KategorileriGetir();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            lVProductList.Items.Clear();
            SqlCommand cmd = new SqlCommand(string.Format("select ProductID,ProductName,UnitsInStock,UnitPrice,Discontinued,CategoryID from products"), SqlHelper.Cnn);

            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Product pro = new Product();
                        pro.ProductID = (int)dataReader[0];
                        pro.ProductName = dataReader[1].ToString();
                        pro.UnitsInStock = int.Parse(dataReader[2].ToString());
                        pro.UnitPrice = double.Parse(dataReader[3].ToString());
                        pro.Discontinued = (bool)dataReader[4];
                        pro.CategoryID = (int)dataReader[5];

                        ListViewItem li = new ListViewItem();
                        li.Tag = pro;
                        li.Text = pro.ProductID.ToString();
                        li.SubItems.Add(pro.ProductName);
                        li.SubItems.Add(pro.UnitsInStock.ToString());
                        li.SubItems.Add(pro.UnitPrice.ToString());
                        li.SubItems.Add(pro.Discontinued.ToString());

                        lVProductList.Items.Add(li);
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

        Product upDate;
        private void btnSave_Click(object sender, EventArgs e)
        {
             upDate = (Product)lVProductList.SelectedItems[0].Tag;
            Category cat = (Category)cBxCategory.SelectedValue;
            if (btnSave.Text == "Add")
            {

                SqlCommand cmd = new SqlCommand(string.Format("insert into Products(ProductName,UnitsInStock,UnitPrice,Discontinued, CategoryID) values('{0}', {1}, {2}, '{3}',{4})", txtBxProductName.Text, txtBxStock.Text, txtBxPrice.Text, "true", cat.CategoryID), SqlHelper.Cnn);


                try
                {
                    SqlHelper.Cnn.Open();
                    int etkilenenDeger = cmd.ExecuteNonQuery();
                    if (etkilenenDeger > 0)
                    {
                        MessageBox.Show("Ürün Başarıyla Eklenmiştir");
                    }
                    else

                        MessageBox.Show("Bir Hata Oluştu!");
                    SqlHelper.Cnn.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
                finally
                {

                    SqlHelper.Cnn.Close();
                    groupAdd.Visible = false;
                    cBxCategory.DataSource = null;
                    Listele();
                }
            }
            else
            {
                
                if (btnSave.Text == "Update")
                {
                    SqlCommand cmd = new SqlCommand(string.Format("update Products set ProductName='{0}',UnitsInStock={1},UnitPrice={2},CategoryID={3} where ProductID={4}",txtBxProductName.Text,txtBxStock.Text,txtBxPrice.Text,cat.CategoryID,upDate.ProductID), SqlHelper.Cnn);

                    try
                    {
                        SqlHelper.Cnn.Open();
                        int etkilenenDeger = cmd.ExecuteNonQuery();
                        if (etkilenenDeger > 0)
                        {
                            MessageBox.Show("Ürün Başarıyla Güncellendi");
                        }
                        else

                            MessageBox.Show("Bir Hata Oluştu!");
                        SqlHelper.Cnn.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                    finally
                    {

                        SqlHelper.Cnn.Close();
                        groupAdd.Visible = false;
                        cBxCategory.DataSource = null;
                        Listele();
                    }
                }

            }





        }
        public void Temizle()
        {
            txtBxProductName.Text = "";
            txtBxPrice.Text = "";
            txtBxStock.Text = "";
            cBxCategory.SelectedIndex = -1;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            groupAdd.Visible = false;
            Product pro = (Product)lVProductList.SelectedItems[0].Tag;
            SqlCommand cmd = new SqlCommand(string.Format("delete from Products where ProductID={0}", pro.ProductID), SqlHelper.Cnn);

            DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misini? ", "Sil", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                    SqlHelper.Cnn.Open();
                    int etkilenenDeger = cmd.ExecuteNonQuery();
                    if (etkilenenDeger > 0)
                    {
                        MessageBox.Show("Seçtiğiniz Ürün Silinmiştir!");
                    }
                    else

                        MessageBox.Show("Bir Hata Oluştu!");
                    SqlHelper.Cnn.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    SqlHelper.Cnn.Close();
                    Listele();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            KategorileriGetir();
            Product pro = (Product)lVProductList.SelectedItems[0].Tag;
            groupAdd.Visible = true;
            txtBxProductName.Text = pro.ProductName;
            txtBxStock.Text = pro.UnitsInStock.ToString();
            txtBxPrice.Text = pro.UnitPrice.ToString();



            foreach (Category item in catList)
            {
                if (item.CategoryID == pro.CategoryID)
                {
                    cBxCategory.SelectedItem = item;
                }


            }
            btnSave.Text = "Update";
            
           
        }
        List<Category> catList = new List<Category>();
        private void KategorileriGetir()
        {
            SqlCommand cmd = new SqlCommand("select CategoryID, CategoryName from Categories", SqlHelper.Cnn);
            SqlHelper.Cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    Category cat = new Category();
                    cat.CategoryID = (int)reader[0];
                    cat.CategoryName = reader[1].ToString();

                    catList.Add(cat);
                }
                cBxCategory.DataSource = catList;
            }

            SqlHelper.Cnn.Close();
        }
    }
}
