using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class SqlHelper
    {
        private static SqlConnection _cnn;
        public static SqlConnection Cnn
        {
            get { return _cnn; }
        }

        static SqlHelper()
        {
           _cnn = new SqlConnection("server=PC;database=VBookStore;User ID=bookstoreuser;password=St0r3!;");
        }
    }
}
