﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlHelper
{
    class SqlHelper
    {
        private static SqlConnection _cnn;

        public static SqlConnection Cnn
        {
            get
            {
                return _cnn;
            }

        }
        static SqlHelper()
        {
            _cnn = new SqlConnection();
            _cnn.ConnectionString = "server=AYCACALAYIR\\SQLEXPRESS;database=NORTHWND; Integrated Security=true;";
        }
    }
}
