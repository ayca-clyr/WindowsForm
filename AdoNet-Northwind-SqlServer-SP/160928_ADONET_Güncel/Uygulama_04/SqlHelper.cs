using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Uygulama_04
{
    class SqlHelper
    {
        // 1.Yöntem

        private static SqlConnection _connection;
        public static SqlConnection Connection {
            get { return _connection; }
        }   // Set sil

        static SqlHelper()
        {
            _connection = new SqlConnection();
            Connection.ConnectionString = "server=PC;database=Northwind;Integrated Security=true;";
        }

    }
}
