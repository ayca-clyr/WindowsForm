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

namespace _10_Uygulama_Disconnected_Baglanti_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetCategory_Click(object sender, EventArgs e)
        {
            string query = "select CategoryID,CategoryName,Description from Categories";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query,SqlHelper.cnn);

            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item["categoryID"].ToString();
                li.SubItems.Add(item[1].ToString());
                li.SubItems.Add(item[2].ToString());
                lstCategori.Items.Add(li);
            }
            cmbEmploye.DataSource = dt;
            cmbEmploye.DisplayMember = "CategoryName";
            cmbEmploye.ValueMember = "CategoryID";
        }

        private void cmbEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            string deger = cmbEmploye.SelectedValue.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstCategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
