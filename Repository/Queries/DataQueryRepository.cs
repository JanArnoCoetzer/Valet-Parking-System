using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.DataAccessLayer;

namespace Valet_Parking_System.Repository.Queries
{
    internal static class DataQueryRepository
    {
        //-----------------------------Bookings-----------------------------

        public static List<Booking> LoadBookings()
        {
            List<Booking> fetchedBookings = new();

            try
            {
                using OracleConnection connection = OracleDbContext.GetOpenConnection();
                using OracleCommand command = connection.CreateCommand();

                command.CommandText = @"
                    SELECT BOOKING_ID, DATE_FROM, DATE_TO, TIME_FROM, TIME_TO, STATUS
                    FROM BOOKINGS";

                using OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Booking booking = new Booking
                    {
                        BookingId = reader["BOOKING_ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["BOOKING_ID"]),
                        DateFrom = reader["DATE_FROM"] == DBNull.Value ? "" : reader["DATE_FROM"].ToString(),
                        DateTo = reader["DATE_TO"] == DBNull.Value ? "" : reader["DATE_TO"].ToString(),
                        TimeFrom = reader["TIME_FROM"] == DBNull.Value ? "" : reader["TIME_FROM"].ToString(),
                        TimeTo = reader["TIME_TO"] == DBNull.Value ? "" : reader["TIME_TO"].ToString(),
                        Status = reader["STATUS"] == DBNull.Value ? "" : reader["STATUS"].ToString()
                    };

                    fetchedBookings.Add(booking);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"LoadBookings failed: {ex.Message}");
            }

            return fetchedBookings;
        }

        //-----------------------------Operators-----------------------------

        public static List<Operator> LoadOperators()
        {
            List<Operator> fetchedOperators = new();

            try
            {
                using OracleConnection connection = OracleDbContext.GetOpenConnection();
                using OracleCommand command = connection.CreateCommand();

                command.CommandText = @"
                    SELECT OPERATOR_ID, FULL_NAME, DATE_JOINED, FULL_ADDRESS, TELEPHONE, EMAIL, PASSWORD, PERMISSIONS
                    FROM OPERATORS";

                using OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Operator op = new Operator
                    {
                        OperatorID = reader["OPERATOR_ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["OPERATOR_ID"]),
                        fullName = reader["FULL_NAME"] == DBNull.Value ? "" : reader["FULL_NAME"].ToString(),
                        datejoined = reader["DATE_JOINED"] == DBNull.Value ? "" : reader["DATE_JOINED"].ToString(),
                        fulladdress = reader["FULL_ADDRESS"] == DBNull.Value ? "" : reader["FULL_ADDRESS"].ToString(),
                        telephone = reader["TELEPHONE"] == DBNull.Value ? "" : reader["TELEPHONE"].ToString(),
                        email = reader["EMAIL"] == DBNull.Value ? "" : reader["EMAIL"].ToString(),
                        Password = reader["PASSWORD"] == DBNull.Value ? "" : reader["PASSWORD"].ToString(),
                        Permissions = reader["PERMISSIONS"] == DBNull.Value ? "O" : reader["PERMISSIONS"].ToString()
                    };

                    fetchedOperators.Add(op);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"LoadOperators failed: {ex.Message}");
            }

            return fetchedOperators;
        }

        //-----------------------------Parking Spaces-----------------------------

        public static List<ParkingSpace> LoadParkingSpaces()
        {
            List<ParkingSpace> fetchedParkingSpaces = new();

            try
            {
                using OracleConnection connection = OracleDbContext.GetOpenConnection();
                using OracleCommand command = connection.CreateCommand();

                command.CommandText = @"
                    SELECT SPACE_ID, LOT_IDENTIFIER, STATUS
                    FROM PARKING_SPACE";

                using OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int spaceId = reader["SPACE_ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["SPACE_ID"]);
                    string lotIdentifier = reader["LOT_IDENTIFIER"] == DBNull.Value ? "" : reader["LOT_IDENTIFIER"].ToString();
                    string status = reader["STATUS"] == DBNull.Value ? "Error" : reader["STATUS"].ToString();

                    ParkingSpace parkingSpace = new ParkingSpace(spaceId, lotIdentifier, status);
                    fetchedParkingSpaces.Add(parkingSpace);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"LoadParkingSpaces failed: {ex.Message}");
            }

            return fetchedParkingSpaces;
        }

        //-----------------------------Customers-----------------------------

        public static List<Customer> LoadCustomers()
        {
            List<Customer> fetchedCustomers = new();

            try
            {
                using OracleConnection connection = OracleDbContext.GetOpenConnection();
                using OracleCommand command = connection.CreateCommand();

                command.CommandText = @"
                    SELECT CUSTOMER_ID, FULL_NAME, ADDRESS, TELEPHONE
                    FROM CUSTOMERS";

                using OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int customerId = reader["CUSTOMER_ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["CUSTOMER_ID"]);
                    string fullName = reader["FULL_NAME"] == DBNull.Value ? "" : reader["FULL_NAME"].ToString();
                    string address = reader["ADDRESS"] == DBNull.Value ? "" : reader["ADDRESS"].ToString();
                    string telephone = reader["TELEPHONE"] == DBNull.Value ? "" : reader["TELEPHONE"].ToString();

                    Customer customer = new Customer(customerId, fullName, telephone, address);
                    fetchedCustomers.Add(customer);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"LoadCustomers failed: {ex.Message}");
            }

            return fetchedCustomers;
        }

        //-----------------------------Vehicles-----------------------------

        public static List<Vehicle> LoadVehicles()
        {
            List<Vehicle> fetchedVehicles = new();

            try
            {
                using OracleConnection connection = OracleDbContext.GetOpenConnection();
                using OracleCommand command = connection.CreateCommand();

                command.CommandText = @"
                    SELECT VEHICLE_ID, REGISTRATION, MODEL, COLOR, STATUS
                    FROM VEHICLES";

                using OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader["VEHICLE_ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["VEHICLE_ID"]);
                    string registration = reader["REGISTRATION"] == DBNull.Value ? "" : reader["REGISTRATION"].ToString();
                    string model = reader["MODEL"] == DBNull.Value ? "" : reader["MODEL"].ToString();
                    string color = reader["COLOR"] == DBNull.Value ? "" : reader["COLOR"].ToString();
                    string status = reader["STATUS"] == DBNull.Value ? "" : reader["STATUS"].ToString();

                    Vehicle vehicle = new Vehicle(id, registration, model, color, status);
                    fetchedVehicles.Add(vehicle);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"LoadVehicles failed: {ex.Message}");
            }

            return fetchedVehicles;
        }
    }
}