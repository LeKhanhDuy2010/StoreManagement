using System.Data.SqlClient;

namespace StoreManagement.Utils
{
    class Connection
    {
        private static readonly string ConnectionString = @"Data Source=DESKTOP-DIIDZ\MAYDUY;Initial Catalog=StoreManagement;Integrated Security=True";

        public static SqlConnection Getconnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
