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
    public partial class AuthorListForm : Form
    {
        public AuthorListForm()
        {
            InitializeComponent();
        }
        int id;

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (lstBxAuthorList.SelectedIndex > -1)
            {
                autAdd = new AuthorAddForm();
                autAdd.MdiParent = SqlConnectionTestForm.ActiveForm;
                autAdd.Show();
                Author aut = (Author)lstBxAuthorList.SelectedItem;


                autAdd.txtBxFirstName.Text = aut.FirstName;
                autAdd.txtBxLastName.Text = aut.LastName;
                autAdd.author = aut;
            }






        }

        List<Author> autList = new List<Author>();

        AuthorAddForm autAdd;
        private void Listele()
        {


            SqlCommand cmd = new SqlCommand("select Id,FirstName,LastName from Author", SqlHelper.Cnn);


            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        Author author = new Author();
                        author.ID = (int)reader[0];
                        author.FirstName = reader[1].ToString();
                        author.LastName = reader[2].ToString();

                        lstBxAuthorList.Items.Add(author);
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
        private void AuthorListForm_Load(object sender, EventArgs e)
        {
            Listele();

        }
    }
}
