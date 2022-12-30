using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cafe
{
    //ПОДКЛЮЧЕНИЕ К БД
    internal class dbConnection
    {
        public static MySqlConnection connect = new MySqlConnection("server=127.0.0.1; port=3306; username=root; password=root; database=cafe");
        public static MySqlDataAdapter adap = new MySqlDataAdapter();
        public static MySqlDataReader reader;
    }
}
