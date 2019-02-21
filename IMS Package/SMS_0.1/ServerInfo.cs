using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SMS_0._1
{
    class ServerInfo
    {
        public const string String = "server=localhost;user id=root;persistsecurityinfo=True;database=sms";

        public static MySqlConnection mySQLConnect = new MySqlConnection(String);
    }
}
