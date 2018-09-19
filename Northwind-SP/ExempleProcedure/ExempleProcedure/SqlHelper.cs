using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExempleProcedure
{
    class SqlHelper
    {
        private static SqlConnection _conn;
        public static SqlConnection Conn
        {
            get { return _conn; }
        }
        static SqlHelper()
        {
            _conn = new SqlConnection();
            _conn.ConnectionString = "Server=.;Database=NORTHWND;Integrated Security=True";
        }
    }
}
