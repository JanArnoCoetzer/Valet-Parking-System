using Oracle.ManagedDataAccess.Client;
using Valet_Parking_System.Classes;
using Valet_Parking_System.DataAccessLayer;

namespace Valet_Parking_System.Repository.CRUD
{
    internal class AdminRepository
    {
        internal static bool AddSpace(ParkingSpace spacedata)
        {
            try
            {
                string sql = spacedata.GetAddSql();

                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        internal static bool EditSpace(ParkingSpace spacedata)
        {
            try
            {
                string sql = spacedata.GetUpdateSql();

                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        internal static bool RemoveSpace(ParkingSpace spacedata)
        {
            try
            {
                string sql = spacedata.GetRemoveSql();

                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        internal static bool AddOperator(Operator operatordata)
        {
            try
            {
                string sql = operatordata.GetAddSql();

                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        internal static bool EditOperator(Operator operatordata)
        {
            try
            {
                string sql = operatordata.GetUpdateSql();

                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        internal static bool RemoveOperator(Operator operatordata)
        {
            try
            {
                string sql = operatordata.GetRemoveSql();

                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}