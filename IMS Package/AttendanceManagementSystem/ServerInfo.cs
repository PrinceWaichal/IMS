using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AttendanceManagementSystem
{
    class ServerInfo
    {
        public const string ServerAddress = "server=localhost;user id=root;" +
            "persistsecurityinfo=True;database=AMSDb;tablecaching=True";

        public static MySqlConnection Connect = new MySqlConnection(ServerAddress);
    }
}
