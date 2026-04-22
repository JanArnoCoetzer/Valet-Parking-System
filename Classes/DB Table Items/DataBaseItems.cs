using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valet_Parking_System.Classes.DB_Table_Items
{
    public class DataBaseTables
    {
        public List<Booking> LoadedBookings;
        public List<ParkingSpace> LoadedParkingSpaces;
        public List<Operator> LoadedOperators;

        public DataBaseTables(List<Booking> loadedBookings, List<ParkingSpace> loadedParkingSpaces, List<Operator> loadedOperators) 
        {
            LoadedBookings = loadedBookings;
            LoadedParkingSpaces = loadedParkingSpaces;
            LoadedOperators = loadedOperators;
        }
    }
}
