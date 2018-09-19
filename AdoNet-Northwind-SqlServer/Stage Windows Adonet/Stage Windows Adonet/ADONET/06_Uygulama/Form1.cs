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

namespace _06_Uygulama
{
    public partial class txtName : Form
    {
        public txtName()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }
        List<Category> catList = new List<Category>();
        private void Listele()
        {
            listView1.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select ProductID,ProductName,UnitsInStock,UnitPrice,Discontinued,CategoryID from Products";
            cmd.Connection = SqlHelper.Cnn;

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
                        pro.ProductName = (string)dataReader[1];
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
                        listView1.Items.Add(li);
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

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            KategorileriGetir();
            groupBox1.Visible = true;
            
        }

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
                    cat.CategoryName = (string)reader[1];
                    
                    catList.Add(cat);

                }
                cmbCategory.DataSource = catList;
              
            }
            SqlHelper.Cnn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            Category cat = (Category)cmbCategory.SelectedValue;
            if(btnSave.Text=="Kaydet")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = string.Format("insert into Products(ProductName,UnitsInStock,UnitPrice,Discontinued,CategoryID) values ('{0}',{1},{2},'{3}',{4})", txtBxName.Text, txtStock.Text, txtPrice.Text, "true", cat.CategoryID);
                cmd.Connection = SqlHelper.Cnn;
                try
                {
                    SqlHelper.Cnn.Open();
                    int etkilenen = cmd.ExecuteNonQuery();
                    if (etkilenen > 0)
                        MessageBox.Show("Ürün başarıyla eklendi.");
                    else
                    {
                        MessageBox.Show("İnsert işleminde bir hata oluştu.");
                    }
                    SqlHelper.Cnn.Close();
                    groupBox1.Visible = true;
                    cmbCategory.DataSource = null;
                    Listele();
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
            else 
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = string.Format("update Products set ProductName='{0}',UnitsInStock={1},UnitPrice={2},CategoryID={3} where ProductID={4}",txtBxName.Text,txtStock.Text,txtPrice.Text,cat.CategoryID, updatePro.ProductID);
                cmd.Connection = SqlHelper.Cnn;
                try
                {
                    SqlHelper.Cnn.Open();
                    int etkilenen = cmd.ExecuteNonQuery();
                    if (etkilenen > 0)
                        MessageBox.Show("Ürün başarıyla güncellendi.");
                    else
                    {
                        MessageBox.Show("Güncelleme işleminde bir hata oluştu.");
                    }
                    SqlHelper.Cnn.Close();
                    groupBox1.Visible = false;
                    cmbCategory.DataSource = null;
                    Listele();
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
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Product pro = (Product)listView1.SelectedItems[0].Tag;
            SqlCommand cmd = new SqlCommand(string.Format("delete from Products where ProductID={0}", pro.ProductID), SqlHelper.Cnn);
            DialogResult dialog = MessageBox.Show("Silmek istediğinizden emin misiniz?","Sil",MessageBoxButtons.YesNo);
            if (dialog==DialogResult.Yes)
            {
                SqlHelper.Cnn.Open();
                cmd.ExecuteNonQuery();
                SqlHelper.Cnn.Close();
                Listele();
            }
            
        }
        Product updatePro;
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategorileriGetir();
            updatePro= (Product)listView1.SelectedItems[0].Tag;
            txtBxName.Text = updatePro.ProductName;
            txtPrice.Text = updatePro.UnitPrice.ToString();
            txtStock.Text = updatePro.UnitsInStock.ToString();
            foreach (Category item in catList)
            {
                if (item.CategoryID == updatePro.CategoryID)
                {
                    cmbCategory.SelectedItem = item;
                }
            }
            btnSave.Text = "Güncelle";
        }

    }
}
