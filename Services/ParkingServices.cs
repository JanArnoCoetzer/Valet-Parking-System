using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.Services
{
    public  class ParkingServices
    {
        public static ParkingSpace GetNextAvailableSpace(List<ParkingSpace> parkingspaces)
        {
            if (parkingspaces == null || parkingspaces.Count == 0)
                return null;

            return parkingspaces
                .Where(ps => ps.Available)
                .OrderBy(ps => ps.SpaceID)
                .FirstOrDefault();
        }
    }
}
