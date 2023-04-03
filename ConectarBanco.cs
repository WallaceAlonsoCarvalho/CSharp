using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace Crud2
{
    public class ConectarBanco
    {

        public static string ConnStr = @"Data Source=192.168.15.175;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            var cn =new SqlConnection(ConnStr);

            return cn;
        }
    }
}
