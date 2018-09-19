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
    public partial class AuthorAddForm : Form
    {
        public AuthorAddForm()
        {
            InitializeComponent();
        }
        AuthorListForm aLForm = new AuthorListForm();
        internal Author author;
        private void Save()
        {
           
            SqlCommand cmd = new SqlCommand(string.Format("insert into Author(FirstName,LastName) values('{0}','{1}')", txtBxFirstName.Text, txtBxLastName.Text), SqlHelper.Cnn);

                SqlHelper.Cnn.Open();
                int etkilenenDeger = cmd.ExecuteNonQuery();
SqlHelper.Cnn.Close();
                if (etkilenenDeger > 0)
                {
                    MessageBox.Show("Ekleme İşleminiz başarıyla gerçekleşmiştir!");
                }
                else
                {
                    MessageBox.Show("Ekleme İşleminiz Başarısız!");
                }

            }
        private void Delete()
        {
             
            SqlCommand cmd = new SqlCommand(string.Format("delete from Author where ID={0}", author.ID), SqlHelper.Cnn);

                SqlHelper.Cnn.Open();
                int etkilenenDeger = cmd.ExecuteNonQuery();
SqlHelper.Cnn.Close();
                if (etkilenenDeger > 0)
                {
                    MessageBox.Show("Silme İşleminiz başarıyla gerçekleşmiştir!");
                }
                else
                {
                    MessageBox.Show("Silme İşleminiz Başarısız!");
                }

            }         
        
        private void btnSave_Click(object sender, EventArgs e)
        {            
            Save();
            Temizle();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            Temizle();
        }

        public void Temizle()
        {
            txtBxFirstName.Text = "";
            txtBxLastName.Text = "";
        }
       
        private void Update()
        {
             SqlCommand cmd = new SqlCommand(string.Format("update Author set FirstName = '{0}',LastName = '{1}' where ID = {2} ", txtBxFirstName.Text, txtBxLastName.Text,author.ID), SqlHelper.Cnn);

                SqlHelper.Cnn.Open();
                int etkilenenDeger = cmd.ExecuteNonQuery();
SqlHelper.Cnn.Close();
                if (etkilenenDeger > 0)
                {
                    MessageBox.Show("Güncelleme İşleminiz başarıyla gerçekleşmiştir!");
                }
                else
                {
                    MessageBox.Show("Güncelleme İşleminiz Başarısız!");
                }

            }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
            Temizle();

        }

     
    }
}
