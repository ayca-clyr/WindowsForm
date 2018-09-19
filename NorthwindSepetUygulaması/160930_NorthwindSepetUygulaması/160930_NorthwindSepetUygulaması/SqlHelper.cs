using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _160930_NorthwindSepetUygulaması
{
    class SqlHelper
    {
        private static SqlConnection _conn;

        public static SqlConnection Conn
        {
            get
            {
                return _conn;
            }
        }
        static SqlHelper()
        {
            _conn = new SqlConnection();
            _conn.ConnectionString = "Data Source=.;Initial Catalog=NORTHWND;Integrated Security=True";
        }
    }
}
