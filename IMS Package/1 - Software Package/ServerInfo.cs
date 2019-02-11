using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _1___Software_Package
{
    class ServerInfo
    {
        public const string server = "server=localhost;user id=root;password=root;persistsecurityinfo=True;database=MastersSchema";

        MySqlConnection mySQLConnection = new MySqlConnection(server);
    }
}
