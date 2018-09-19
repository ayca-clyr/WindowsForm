using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    // Referance'ye Entites'i solution'dan ekle.
    public class SqlHelper

    {
        private const string Cnn = "server=DESKTOP-PKHMVN9\\SQLEXPRESS;database=Northwind;Integrated Security=true;";
        public static SqlCommand CreateSqlCommand()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Cnn;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            return cmd;
        }
    }
}
