using MySql.Data.MySqlClient;

namespace Sample
{
    public class DBConnection
    {
        private static string server = "localhost";
        private static string database = "sportdb";
        private static string uid = "root";
        private static string password = "clarissa";   

        public static string ConnectionString =
            $"Server={server};Database={database};Uid={uid};Pwd={password};";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();
                return true;
            }
            catch { return false; }
        }
    }
}