using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valet_Parking_System.Classes
{
    public class MainlandingData
    {
        public List<Booking> Bookings { get; set; } = new();
        public List<ParkingSpace> ParkingSpaces { get; set; } = new();
        public List<Operator> Operators { get; set; } = new();
        public List<Customer> Customers { get; set; } = new();
        public List<Vehicle> Vehicles { get; set; } = new();
    }
}
