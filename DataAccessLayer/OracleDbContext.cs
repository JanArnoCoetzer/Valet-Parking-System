using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;
using Valet_Parking_System.Classes.Constants.StaticDatabase;

namespace Valet_Parking_System.DataAccessLayer
{
    internal static class OracleDbContext
    {
        private static string BuildConnectionString()
        {
            string user = Logins_db.get_username();
            string pass = Logins_db.get_password();

            return $"Data Source=oracle/orcl;User Id={user};Password={pass};";
        }

        public static bool TestConnection()
        {
            try
            {
                using OracleConnection conn = GetOpenConnection();
                Debug.WriteLine("Login successful");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Login failed: {ex.Message}");
                return false;
            }
        }

        public static OracleConnection GetConnection()
        {
            string connectionString = BuildConnectionString();
            return new OracleConnection(connectionString);
        }

        public static OracleConnection GetOpenConnection()
        {
            OracleConnection connection = GetConnection();
            connection.Open();
            return connection;
        }
    }
}