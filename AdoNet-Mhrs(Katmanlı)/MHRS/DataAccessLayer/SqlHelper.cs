using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{ 
    class SqlHelper
    {
        
        private const string MHRSConnectionString = "Data Source=213.14.92.74;Initial Catalog=alfa_v2_adonet_white_db;User=alfa_v2_adonet_white_user;password=FrabRet2";

        public static SqlCommand CreateSqlCommand()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = MHRSConnectionString;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }
    }
}
