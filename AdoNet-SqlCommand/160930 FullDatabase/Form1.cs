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

namespace _160930_FullDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string database = "";
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = reader[0].ToString();
                item.Text = reader[0].ToString();
                menuItemDB.DropDownItems.Add(item);
            }
            conn.Close();
            foreach (ToolStripDropDownItem item in menuItemDB.DropDownItems)
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog="+item.Name+";Integrated Security=true;");
                cmd = new SqlCommand("Select name FROM sys.tables", conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ToolStripMenuItem subItem = new ToolStripMenuItem();
                    subItem.Name = reader[0].ToString();
                    subItem.Text = reader[0].ToString();
                    subItem.Click += SubItem_Click;
                    item.DropDownItems.Add(subItem);
                }
                conn.Close();
            }
        }

        private void SubItem_Click(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = (ToolStripDropDownItem)sender;
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=" + item.OwnerItem.Text + ";Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * FROM "+item.Text,conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dtatGridTable.DataSource = table;
            conn.Close();
        }
    }
}
