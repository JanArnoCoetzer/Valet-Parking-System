using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valet_Parking_System.DataAccessLayer;

namespace Valet_Parking_System.Helpers
{
    internal class DataBaseHelper
    {
        public static bool ExecuteNonQuery(string sql, string operationName)
        {
            try
            {
                using OracleConnection conn = OracleDbContext.GetOpenConnection();
                using OracleCommand cmd = new OracleCommand(sql, conn);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{operationName} failed: {ex.Message}");
                return false;
            }
        }

        public static int ExecuteScalarInt(string sql, string operationName)
        {
            try
            {
                using OracleConnection conn = OracleDbContext.GetOpenConnection();
                using OracleCommand cmd = new OracleCommand(sql, conn);

                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    return -1;

                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{operationName} failed: {ex.Message}");
                return -1;
            }
        }
    }
}
