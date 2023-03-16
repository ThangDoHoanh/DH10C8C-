using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DS_SV
{
    internal class Connection
    {
        public static string strConnection = @"Data Source=ADMIN;Initial Catalog=DH10C8;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(strConnection);
        }

    }
}
