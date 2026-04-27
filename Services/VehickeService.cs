using Valet_Parking_System.Classes;
using Valet_Parking_System.Repository.CRUD;

namespace Valet_Parking_System.Services
{
    internal class VehicleService
    {
        public static bool SetStatus(Vehicle vehicle, string status)
        {
            if (vehicle == null || string.IsNullOrWhiteSpace(status))
                return false;

            vehicle.Status = status;
            return VehicleRepository.EditVehicle(vehicle);
        }

        internal static int AddVehicleAndReturnId(Vehicle vehicle)
        {
            if (vehicle == null)
                return -1;

            int newId = VehicleRepository.AddVehicleAndReturnId(vehicle);

            if (newId > 0)
            {
                vehicle.ID = newId;
            }

            return newId;
        }
        public static bool EditVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
                return false;

            return VehicleRepository.EditVehicle(vehicle);
        }

        public static bool RemoveVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
                return false;

            return VehicleRepository.RemoveVehicle(vehicle);
        }

        
    }
}