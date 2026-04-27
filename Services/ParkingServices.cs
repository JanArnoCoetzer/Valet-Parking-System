using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Repository.CRUD;
using Valet_Parking_System.Repository.Queries;

namespace Valet_Parking_System.Services
{
    public  class ParkingServices
    {
        public static ParkingSpace GetNextAvailableSpace()
        {
            int id = DataQueryRepository.GetAvailableParkingSpaceId();
            return DataQueryRepository.GetParkingSpaceById(id);
        }

        public static bool SetStatus(ParkingSpace parkingSpace, string status)
        {

            if (parkingSpace == null)
                return false;

            if (string.IsNullOrWhiteSpace(status))
                return false;

            parkingSpace.Status = status;

            return ParkingSpaceRepository.EditParkingSpace(parkingSpace);
        }
    }
}
