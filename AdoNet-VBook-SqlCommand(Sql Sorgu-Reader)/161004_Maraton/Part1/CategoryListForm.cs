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
    public partial class CategoryListForm : Form
    {
        public CategoryListForm()
        {
            InitializeComponent();
        }

   int _id;
        public void Listele()
        {
            lstCategoryList.Items.Clear();


            SqlCommand cmd = new SqlCommand("select Id,Name from Category", SqlHelper.Cnn);
            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Category cat = new Category();
                        cat.CategoryID = int.Parse(reader[0].ToString());
                        cat.CategoryName = reader[1].ToString();
                       

                        lstCategoryList.Items.Add(cat);
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
        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        CategoryEditForm catEdit;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstCategoryList.SelectedIndex > -1)
            {
           
                catEdit = new CategoryEditForm();
                catEdit.MdiParent = SqlConnectionTestForm.ActiveForm;
                catEdit.Show();
                
                catEdit.btnSave.Text = "Update";

                
                Category cat =(Category)lstCategoryList.SelectedItem;
                catEdit.txtBxCategoryName.Text = cat.CategoryName;
                catEdit.category = cat;


                
            }
        }

        private void lstCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category cat = (Category)lstCategoryList.SelectedItems[0];
            
        }

   

    }
}
