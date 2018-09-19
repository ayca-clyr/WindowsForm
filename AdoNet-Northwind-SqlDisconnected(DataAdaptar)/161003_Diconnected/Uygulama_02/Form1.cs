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

namespace Uygulama_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetCategories_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            lVCategories.Items.Clear();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select CategoryID, CategoryName,Description from Categories",SqlHelper.Cnn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item["CategoryID"].ToString();
                li.SubItems.Add(item[1].ToString());
                li.SubItems.Add(item[2].ToString());

                lVCategories.Items.Add(li);
            }
         
            cBxCategories.DataSource = dt;
            cBxCategories.DisplayMember = "CategoryName";
            cBxCategories.ValueMember = "CategoryID";
        }

        private void cBxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string deger = cBxCategories.SelectedValue.ToString();
            label2.Text = deger;
            if (cBxCategories.SelectedIndex > 0)
            {
                label2.Visible = true;
            }
        }
    }
}
