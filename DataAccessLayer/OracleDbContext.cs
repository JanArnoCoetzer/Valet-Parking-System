using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Valet_Parking_System.DataAccessLayer
{
    internal static class OracleDbContext
    {
        private static string BuildConnectionString()
        {
            return "Data Source=studentoracle:1521/orcl;User ID=t00206990;Password=Wiarno911;";
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