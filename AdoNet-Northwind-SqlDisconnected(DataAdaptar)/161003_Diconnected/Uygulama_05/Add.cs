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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(string.Format("insert into Products(ProductName,Discontinued,UnitsInStock,UnitPrice) values('{0}',{1},{2},{3})",txtBxProductName.Text,cBxDiscontinued.SelectedIndex,txtBxUnitsInStock.Text,txtBxUnitPrice.Text), SqlHelper.Cnn);
            try
            {
                SqlHelper.Cnn.Open();
                int gelenDeger = cmd.ExecuteNonQuery();
                if (gelenDeger > 0)
                {
                    Listele list = new Listele();
                   
                    
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

      
    }
}
