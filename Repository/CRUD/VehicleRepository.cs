using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.DataAccessLayer;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.Repository.CRUD
{
    internal static class VehicleRepository
    {
        internal static bool AddVehicle(Vehicle vehicle)
        {
            try
            {
                return DataBaseHelper.ExecuteNonQuery(vehicle.GetAddSql(), "AddVehicle");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"AddVehicle failed: {ex.Message}");
                return false;
            }
        }

        internal static bool EditVehicle(Vehicle vehicle)
        {
            try
            {
                return DataBaseHelper.ExecuteNonQuery(vehicle.GetUpdateSql(), "EditVehicle");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"EditVehicle failed: {ex.Message}");
                return false;
            }
        }

        internal static bool RemoveVehicle(Vehicle vehicle)
        {
            try
            {
                return DataBaseHelper.ExecuteNonQuery(vehicle.GetRemoveSql(), "RemoveVehicle");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"RemoveVehicle failed: {ex.Message}");
                return false;
            }
        }
    }
}