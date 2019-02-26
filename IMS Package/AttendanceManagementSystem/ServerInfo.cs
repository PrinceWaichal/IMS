using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace AttendanceManagementSystem
{
    class ServerInfo
    {
        public const string ServerAddress = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Prince Waichal\Source\Repos\IMS\IMS Package\AttendanceManagementSystem\DatabseFiles\AMSDB.mdf;Integrated Security=True";

        public static SqlConnection Connect = new SqlConnection(ServerAddress);
    }
}
