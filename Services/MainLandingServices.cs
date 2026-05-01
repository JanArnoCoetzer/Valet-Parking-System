using Valet_Parking_System.Classes;
using Valet_Parking_System.Classes.Constants.Operator;
using Valet_Parking_System.Repository.Queries;

namespace Valet_Parking_System.Services
{
    internal static class MainLandingServices
    {
        
        

        //-----------------------------Data Loading-----------------------------
        internal static MainlandingData LoadAllDataFromGenerators(int customerAmount, int operatorAmount, int parkingSpacesAmount)
        {
            List<ParkingSpace> parkingSpaces = TestFunctions.CreateTestParking(parkingSpacesAmount);
            List<Customer> customers = TestFunctions.CreateTestCustomers(customerAmount);
            List<Vehicle> vehicles = TestFunctions.CreateTestVehcles(customerAmount);
            List<Operator> operators = TestFunctions.CreateTestOperators(operatorAmount);

            List<Booking> bookings = TestFunctions.CreateTestBookings(
                parkingSpaces ?? new List<ParkingSpace>(),
                customers ?? new List<Customer>(),
                operators ?? new List<Operator>(),
                vehicles ?? new List<Vehicle>(),
                customerAmount
            );

            return new MainlandingData
            {
                Bookings = bookings ?? new List<Booking>(),
                ParkingSpaces = parkingSpaces ?? new List<ParkingSpace>(),
                Operators = operators ?? new List<Operator>(),
                Customers = customers ?? new List<Customer>(),
                Vehicles = vehicles ?? new List<Vehicle>()
            };


        }

        internal static MainlandingData LoadAllDataFromDb()
        {
            MainlandingData data = new MainlandingData
            {
                Bookings = DataQueryRepository.LoadBookings(),
                ParkingSpaces = DataQueryRepository.LoadParkingSpaces(),
                Operators = DataQueryRepository.LoadOperators(),
                Customers = DataQueryRepository.LoadCustomers(),
                Vehicles = DataQueryRepository.LoadVehicles()
            };

            foreach (Booking booking in data.Bookings)
            {
                booking.Customer = DataQueryRepository.GetCustomerById(booking.CustomerId);
                booking.Vehicle = DataQueryRepository.GetVehicleById(booking.VehicleId);
                booking.ParkingSpace = DataQueryRepository.GetParkingSpaceById(booking.VehicleId);
            }

            return data;
        }

     

        //-----------------------------Permissions-----------------------------

        internal static bool CanAccessDashboard(string permissions)
        {
            return permissions == OperatorPermissions.Admin ||
                   permissions == OperatorPermissions.Operator;
        }

        internal static bool CanAccessBookings(string permissions)
        {
            return permissions == OperatorPermissions.Admin ||
                   permissions == OperatorPermissions.Operator;
        }

        internal static bool CanAccessOperators(string permissions)
        {
            return permissions == OperatorPermissions.Admin ||
                   permissions == OperatorPermissions.Operator;
        }

        internal static bool CanAccessAdmin(string permissions)
        {
            return permissions == OperatorPermissions.Admin;
        }

        
    }

    
}