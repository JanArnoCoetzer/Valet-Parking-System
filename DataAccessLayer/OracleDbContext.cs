using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Valet_Parking_System.DataAccessLayer
{
    internal static class OracleDbContext
    {
        public static string DBConnectionString = "Data Source = oracle/orcl; User ID = t00206990; Password = sVsALN5KWdCxqy;";
        private static string BuildConnectionString()
        {
            return DBConnectionString;
        }

        public static OracleConnection GetConnection()
        {
            return new OracleConnection(BuildConnectionString());
        }

        public static bool TestConnection()
        {
            try
            {
                using (OracleConnection conn = GetConnection())
                {
                    conn.Open();
                    return conn.State == ConnectionState.Open;
                }
            }
            catch
            {
                //timeout is 15 seconds
                MessageBox.Show(
                $"General error: {"DataBase Connection Failed, Will Generate Data"}",
                "Application Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return false;
            }
        }

        public static OracleConnection GetOpenConnection()
        {
            OracleConnection connection = GetConnection();
            connection.Open();
            return connection;
        }
    }
}