using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.Repository.CRUD
{
    internal static class ParkingSpaceRepository
    {
        internal static bool AddParkingSpace(ParkingSpace parkingSpace)
        {
            if (parkingSpace == null)
                return false;

            try
            {
                return DataBaseHelper.ExecuteNonQuery(parkingSpace.GetAddSql(), "AddParkingSpace");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"AddParkingSpace failed: {ex.Message}");
                return false;
            }
        }

        internal static bool EditParkingSpace(ParkingSpace parkingSpace)
        {
            if (parkingSpace == null)
                return false;

            try
            {
                return DataBaseHelper.ExecuteNonQuery(parkingSpace.GetUpdateSql(), "EditParkingSpace");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"EditParkingSpace failed: {ex.Message}");
                return false;
            }
        }

        internal static bool RemoveParkingSpace(ParkingSpace parkingSpace)
        {
            if (parkingSpace == null)
                return false;

            try
            {
                return DataBaseHelper.ExecuteNonQuery(parkingSpace.GetRemoveSql(), "RemoveParkingSpace");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"RemoveParkingSpace failed: {ex.Message}");
                return false;
            }
        }
    }
}