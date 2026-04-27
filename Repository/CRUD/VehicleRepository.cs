using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Classes.Constants.Database;
using Valet_Parking_System.DataAccessLayer;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.Repository.CRUD
{
    internal static class VehicleRepository
    {


        internal static int AddVehicleAndReturnId(Vehicle vehicle)
        {
            if (vehicle == null)
                return -1;

            try
            {
                bool success = DataBaseHelper.ExecuteNonQuery(vehicle.GetAddSql(), "AddVehicle");

                if (!success)
                    return -1;

                string sql =
                    "SELECT MAX(ID) FROM " + DBTableName.Vehicles +
                    " WHERE Registration = '" + vehicle.Registation + "'" +
                    " AND Model = '" + vehicle.Model + "'" +
                    " AND Color = '" + vehicle.Color + "'" +
                    " AND Status = '" + vehicle.Status + "'";

                int newId = DataBaseHelper.ExecuteScalarInt(sql, "GetVehicleId");

                if (newId > 0)
                {
                    vehicle.ID = newId;
                }

                return newId;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"AddVehicleAndReturnId failed: {ex.Message}");
                return -1;
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