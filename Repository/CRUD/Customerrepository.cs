using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Classes.Constants.Database;
using Valet_Parking_System.DataAccessLayer;

namespace Valet_Parking_System.Repository.CRUD
{
    internal static class CustomerRepository
    {
        internal static int AddCustomerAndReturnId(Customer customer)
        {
            if (customer == null)
                return -1;

            try
            {
                bool success = DataBaseHelper.ExecuteNonQuery(customer.GetAddSql(), "AddCustomer");

                if (!success)
                    return -1;

                string sql =
                    "SELECT MAX(Customer_ID) FROM "+DBTableName.Customers+
                    " WHERE Full_Name = '" + customer.FullName + "'" +
                    " AND Telephone = '" + customer.Telephone + "'" +
                    " AND Address = '" + customer.Address + "'";

                int newId = DataBaseHelper.ExecuteScalarInt(sql, "GetCustomerId");

                if (newId > 0)
                {
                    customer.CustomerID = newId;
                }

                return newId;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"AddCustomerAndReturnId failed: {ex.Message}");
                return -1;
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