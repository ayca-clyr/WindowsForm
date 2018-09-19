using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SqlHelper
    {
        private const string NorthwindConnectionString = "server=AYCACALAYIR\\SQLEXPRESS;database=Northwind; Integrated Security=true;";

        public static SqlCommand CreateSqlCommand()
        {
            SqlConnection conneciton = new SqlConnection();
            conneciton.ConnectionString = NorthwindConnectionString;
            SqlCommand command = new SqlCommand();
            command.Connection = conneciton;
            return command;
        }

    }
}
