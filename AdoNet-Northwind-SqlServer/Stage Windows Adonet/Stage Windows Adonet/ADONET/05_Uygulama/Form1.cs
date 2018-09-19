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

namespace _05_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void Yenile()
        {
            lvwCategories.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select CategoryID,CategoryName,Description from Categories";
            cmd.Connection = SqlHelper.cnn;
            try
            {
                SqlHelper.cnn.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Category cat = new Category();
                        //Data Mapping
                        cat.CategoryID = (int)dataReader[0];
                        cat.CategoryName = (string)dataReader[1];
                        cat.Description = (string)dataReader[2];

                        ListViewItem li = new ListViewItem();
                        li.Tag = cat;
                        li.Text = cat.CategoryID.ToString();
                        li.SubItems.Add(cat.CategoryName);
                        li.SubItems.Add(cat.Description);

                        lvwCategories.Items.Add(li);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlHelper.cnn.Close();

            }
        }

        int id;
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id=int.Parse(lvwCategories.SelectedItems[0].Text);
            Category cat = (Category)lvwCategories.SelectedItems[0].Tag;
            txtBxCategoryName.Text = cat.CategoryName;
            txtBxDescription.Text = cat.Description;
            id = cat.CategoryID;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("update Categories set CategoryName='{0}',Description='{1}' where CategoryID={2}", txtBxCategoryName.Text, txtBxDescription.Text, id);
            cmd.Connection = SqlHelper.cnn;
            try
            {
                SqlHelper.cnn.Open();
                cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlHelper.cnn.Close();
                Yenile();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            Category cat = (Category)lvwCategories.SelectedItems[0].Tag;
            cmd.CommandText = string.Format("delete from Categories where CategoryID={0}", cat.CategoryID);
            cmd.Connection = SqlHelper.cnn;
            SqlHelper.cnn.Open();
            int result = cmd.ExecuteNonQuery();
            SqlHelper.cnn.Close();
            Yenile();


        }


    }
}
