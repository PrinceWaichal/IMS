using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _1___Software_Package
{
    public class ServerInfo
    {
        public const string server = "server=localhost;user id=root;password=root;persistsecurityinfo=True;database=MastersSchema";

        public static MySqlConnection MySQLConnect = new MySqlConnection(server);

        public static MySqlCommand MySQLCommand = new MySqlCommand();

        public static MySqlDataAdapter MySQLDataAdapt = new MySqlDataAdapter();

        public static MySqlDataReader MySQLDataRead;
    }
}
