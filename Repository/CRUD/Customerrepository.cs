using Oracle.ManagedDataAccess.Client;
using System;
using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.DataAccessLayer;

namespace Valet_Parking_System.Repository.CRUD
{
    internal class Customer_repository
    {
        internal static bool AddCustomer(Customer customer)
        {
            try
            {
                string sql = customer.GetAddSql();

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
            catch (Exception ex)
            {
                Debug.WriteLine("AddCustomer error: " + ex.Message);
                return false;
            }
        }

        internal static bool EditCustomer(Customer customer)
        {
            try
            {
                string sql = customer.GetUpdateSql();

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
            catch (Exception ex)
            {
                Debug.WriteLine("EditCustomer error: " + ex.Message);
                return false;
            }
        }

        internal static bool RemoveCustomer(Customer customer)
        {
            try
            {
                string sql = customer.GetRemoveSql();

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
            catch (Exception ex)
            {
                Debug.WriteLine("RemoveCustomer error: " + ex.Message);
                return false;
            }
        }
    }
}