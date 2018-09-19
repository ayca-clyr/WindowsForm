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

namespace Part1
{
    public partial class CategoryEditForm : Form
    {
        public CategoryEditForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtBxCategoryName.Text = "";
        }

       internal Category category;
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {

                SqlCommand cmd = new SqlCommand(string.Format("insert into Category(Name) values('{0}')", txtBxCategoryName.Text), SqlHelper.Cnn);

                try
                {
                    SqlHelper.Cnn.Open();
                    int etkilenenDeger = cmd.ExecuteNonQuery();
                    SqlHelper.Cnn.Close();
                    if (etkilenenDeger > 0)
                    {
                        MessageBox.Show("Kaydetme işleminiz başarılı bir şekilde gerçekleşmiştir.");
                    }
                    else
                    {
                        MessageBox.Show("Kaydetme işlemini Başarısız!");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                             
                SqlCommand cmd = new SqlCommand(string.Format("update Category set Name = '{0}' where ID = {1}", txtBxCategoryName.Text,category.CategoryID), SqlHelper.Cnn);

                try
                {
                    SqlHelper.Cnn.Open();
                    int etkilenenDeger = cmd.ExecuteNonQuery();
                    SqlHelper.Cnn.Close();
                    if (etkilenenDeger > 0)
                    {
                        MessageBox.Show("Güncelleme işleminiz başarılı bir şekilde gerçekleşmiştir.");
                    }
                    else
                    {
                        MessageBox.Show("Gücelleme işlemini Başarısız!");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
   
