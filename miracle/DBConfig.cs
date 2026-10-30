using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace miracle
{
    public static class DBConfig
    {
        public static string ConnectionString = "server=localhost; database=miracle; uid=root; pwd=your_pass";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

    }
}
