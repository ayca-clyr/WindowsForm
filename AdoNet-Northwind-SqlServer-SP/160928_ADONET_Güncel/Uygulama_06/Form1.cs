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

namespace Uygulama_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int id;
        private void Form1_Load(object sender, EventArgs e)
        {
            Yenileme();
        }

        

        private void Yenileme()
        {
            lVCategories.Items.Clear();
             SqlCommand cmd = new SqlCommand(string.Format("select CategoryID, CategoryName, Description from Categories"), SqlHelper.Cnn);

            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Category cat = new Category();
                        // Data Mapping
                        cat.CategoryID = (int)dataReader[0];
                        cat.CategoryName =(string)dataReader[1];
                        cat.Description = (string)dataReader[2];
                        id = cat.CategoryID;
                        
                        //Listview'a eklemek için
                        ListViewItem li = new ListViewItem();
                        li.Tag = cat;  // Categorinin kendisini direk atıyor.
                        li.Text = cat.CategoryID.ToString();
                        li.SubItems.Add(cat.CategoryName);
                        li.SubItems.Add(cat.Description);

                        lVCategories.Items.Add(li);
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


        

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category cat = (Category)lVCategories.SelectedItems[0].Tag;// Seçtiğimizin ID'sini getirecek.
            txtBxName.Text = cat.CategoryName;
            txtBxDesciption.Text = cat.Description;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(string.Format("update Categories set CategoryName ='{0}', Description='{1}' where CategoryID= {2}",txtBxName.Text,txtBxDesciption.Text,id), SqlHelper.Cnn);

            try
            {
                SqlHelper.Cnn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Güncelleme İşlemi Başarılı!");
                }
                else
                {
                    MessageBox.Show("Güncelleme Gerçekleştirilmedi!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
            finally
            {
                SqlHelper.Cnn.Close();
                Yenileme();
                Temizle();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category cat = (Category)lVCategories.SelectedItems[0].Tag;// Seçtiğimizin ID'sini getirecek.
            txtBxName.Text = cat.CategoryName;
            txtBxDesciption.Text = cat.Description;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Category cat = (Category)lVCategories.SelectedItems[0].Tag;
            cat.CategoryName = txtBxName.Text;
            cat.Description = txtBxDesciption.Text;
        }
        public void Temizle()
        {
            txtBxName.Text = "";
            txtBxDesciption.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             SqlCommand cmd = new SqlCommand(string.Format("delete from Categories where CategoryID={0} ",id), SqlHelper.Cnn);
            try
            {
                SqlHelper.Cnn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Silme İşlemi Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu!");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlHelper.Cnn.Close();
                Yenileme();
                Temizle();
               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(string.Format("insert into Categories(CategoryName,Description) values('{0}','{1}')", txtBxName.Text, txtBxDesciption.Text), SqlHelper.Cnn);
             try
            {
                SqlHelper.Cnn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Ekleme İşlemi Gerçekleşti!");
                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu!");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlHelper.Cnn.Close();
                Yenileme();
                Temizle();
               
            }
        
        }
        
    }
}
