using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.DataAccessLayer;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.Repository.CRUD
{
    internal static class CustomerRepository
    {
        internal static bool AddCustomer(Customer customer)
        {
            try
            {
                return DataBaseHelper.ExecuteNonQuery(customer.GetAddSql(), "AddCustomer");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"AddCustomer failed: {ex.Message}");
                return false;
            }
        }

        internal static bool EditCustomer(Customer customer)
        {
            try
            {
                return DataBaseHelper.ExecuteNonQuery(customer.GetUpdateSql(), "EditCustomer");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"EditCustomer failed: {ex.Message}");
                return false;
            }
        }

        internal static bool RemoveCustomer(Customer customer)
        {
            try
            {
                return DataBaseHelper.ExecuteNonQuery(customer.GetRemoveSql(), "RemoveCustomer");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"RemoveCustomer failed: {ex.Message}");
                return false;
            }
        }
    }
}