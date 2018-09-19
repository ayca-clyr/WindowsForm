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

namespace Uygulama_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            SqlCommand cmd = new SqlCommand("select ProductID,ProductName,UnitsInStock,UnitPrice from Products", SqlHelper.Cnn);

            
            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = reader[0].ToString();
                        li.SubItems.Add(reader[1].ToString());
                        li.SubItems.Add(reader[2].ToString());
                        li.SubItems.Add(reader[3].ToString());

                

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

      

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           Add addForm = new Add();
            addForm.MdiParent = this;
            addForm.Show();
          
        }
    }
}
