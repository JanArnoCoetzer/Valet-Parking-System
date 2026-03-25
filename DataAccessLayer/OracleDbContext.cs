using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;
using Valet_Parking_System.Classes.dblogins;

namespace Valet_Parking_System.DataAccessLayer
{
    internal class OracleDbContext
    {
        private string _connectionString;


        public bool TestConnection()
        {
            if (!TryLogin()) return false;

            using var conn = CreateConnection();
            return conn.State == System.Data.ConnectionState.Open;
        }


        private bool TryLogin()
        {
            string user = Logins_db.get_username();
            string pass = Logins_db.get_password();

            _connectionString = $"Data Source=oracle/orcl;User Id={user};Password={pass};";

            try
            {
                using var testConn = new OracleConnection(_connectionString);
                testConn.Open();
                Debug.WriteLine("Login successful");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Login failed: {ex.Message}");
                return false;
            }
        }


        public OracleConnection CreateConnection()
        {
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Must call TestConnection() first");

            return new OracleConnection(_connectionString);
        }
    }
}
