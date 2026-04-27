using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Classes.Constants.Database;
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
                    SELECT BOOKING_ID,Customer_ID,Vehicle_ID,Parking_Space_ID, DATE_FROM, DATE_TO, TIME_FROM, TIME_TO, STATUS
                    FROM " + DBTableName.Bookings;

                using OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Booking booking = new Booking
                    {
                        BookingId = reader["BOOKING_ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["BOOKING_ID"]),
                        CustomerId = reader["Customer_ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Customer_ID"]),
                        VehicleId = reader["Vehicle_ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Vehicle_ID"]),
                        ParkingSpaceId = reader["Parking_Space_ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Parking_Space_ID"]),
                        DateFrom = reader["DATE_FROM"] == DBNull.Value ? "" : reader["DATE_FROM"].ToString(),
                        DateTo = reader["DATE_TO"] == DBNull.Value ? "" : reader["DATE_TO"].ToString(),
                        TimeFrom = reader["TIME_FROM"] == DBNull.Value ? "" : reader["TIME_FROM"].ToString(),
                        TimeTo = reader["TIME_TO"] == DBNull.Value ? "" : reader["TIME_TO"].ToString(),
                        Status = reader["STATUS"] == DBNull.Value ? "" : reader["STATUS"].ToString(),
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
        public static Booking GetBookingById(int bookingId)
        {
            try
            {
                using OracleConnection connection = OracleDbContext.GetOpenConnection();
                using OracleCommand command = connection.CreateCommand();

                command.CommandText = @"
            SELECT BOOKING_ID, CUSTOMER_ID, CAR_STORED_ID, DATE_FROM, DATE_TO, TIME_FROM, TIME_TO, STATUS
            FROM " + DBTableName.Bookings + @"
            WHERE BOOKING_ID = :bookingId";

                command.Parameters.Add(":bookingId", OracleDbType.Int32).Value = bookingId;

                using OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Booking
                    {
                        BookingId = reader["BOOKING_ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["BOOKING_ID"]),
                        CustomerId = reader["CUSTOMER_ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["CUSTOMER_ID"]),
                        VehicleId = reader["CAR_STORED_ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["CAR_STORED_ID"]),
                        DateFrom = reader["DATE_FROM"] == DBNull.Value ? "" : reader["DATE_FROM"].ToString(),
                        DateTo = reader["DATE_TO"] == DBNull.Value ? "" : reader["DATE_TO"].ToString(),
                        TimeFrom = reader["TIME_FROM"] == DBNull.Value ? "" : reader["TIME_FROM"].ToString(),
                        TimeTo = reader["TIME_TO"] == DBNull.Value ? "" : reader["TIME_TO"].ToString(),
                        Status = reader["STATUS"] == DBNull.Value ? "" : reader["STATUS"].ToString(),
                    };
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"GetBookingById failed: {ex.Message}");
            }

            return null;
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
                    FROM " + DBTableName.Operators;

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
        public static Operator GetOperatorById(int operatorId)
        {
            try
            {
                using OracleConnection connection = OracleDbContext.GetOpenConnection();
                using OracleCommand command = connection.CreateCommand();

                command.CommandText = @"
            SELECT OPERATOR_ID, FULL_NAME, DATE_JOINED, FULL_ADDRESS, TELEPHONE, EMAIL, PASSWORD, PERMISSIONS
            FROM " + DBTableName.Operators + @"
            WHERE OPERATOR_ID = :operatorId";

                command.Parameters.Add(":operatorId", OracleDbType.Int32).Value = operatorId;

                using OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Operator
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
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"GetOperatorById failed: {ex.Message}");
            }

            return null;
        }
        //-----------------------------Parking Spaces-----------------------------
        public static int GetAvailableParkingSpaceId()
        {
            try
            {
                using OracleConnection connection = OracleDbContext.GetOpenConnection();
                using OracleCommand command = connection.CreateCommand();

                command.CommandText = @"
            SELECT SPACE_ID
            FROM " + DBTableName.ParkingSpaces + @"
            WHERE STATUS = 'Available'
            AND ROWNUM = 1";

                object result = command.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    return -1;

                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"GetAvailableParkingSpaceId failed: {ex.Message}");
                return -1;
            }
        }

        public static List<ParkingSpace> LoadParkingSpaces()
        {
            List<ParkingSpace> fetchedParkingSpaces = new();

            try
            {
                using OracleConnection connection = OracleDbContext.GetOpenConnection();
                using OracleCommand command = connection.CreateCommand();

                command.CommandText = @"
                    SELECT SPACE_ID, LOT_IDENTIFIER, STATUS
                    FROM " + DBTableName.ParkingSpaces;

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
        public static ParkingSpace GetParkingSpaceById(int spaceId)
        {
            try
            {
                using OracleConnection connection = OracleDbContext.GetOpenConnection();
                using OracleCommand command = connection.CreateCommand();

                command.CommandText = @"
            SELECT SPACE_ID, LOT_IDENTIFIER, STATUS
            FROM " + DBTableName.ParkingSpaces + @"
            WHERE SPACE_ID = :spaceId";

                command.Parameters.Add(":spaceId", OracleDbType.Int32).Value = spaceId;

                using OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader["SPACE_ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["SPACE_ID"]);
                    string lotIdentifier = reader["LOT_IDENTIFIER"] == DBNull.Value ? "" : reader["LOT_IDENTIFIER"].ToString();
                    string status = reader["STATUS"] == DBNull.Value ? "Error" : reader["STATUS"].ToString();

                    return new ParkingSpace(id, lotIdentifier, status);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"GetParkingSpaceById failed: {ex.Message}");
            }

            return null;
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
                    FROM " + DBTableName.Customers;

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
        public static Customer GetCustomerById(int customerId)
        {
            try
            {
                using OracleConnection connection = OracleDbContext.GetOpenConnection();
                using OracleCommand command = connection.CreateCommand();

                command.CommandText = @"
            SELECT CUSTOMER_ID, FULL_NAME, ADDRESS, TELEPHONE
            FROM " + DBTableName.Customers + @"
            WHERE CUSTOMER_ID = :customerId";

                command.Parameters.Add(":customerId", OracleDbType.Int32).Value = customerId;

                using OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader["CUSTOMER_ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["CUSTOMER_ID"]);
                    string fullName = reader["FULL_NAME"] == DBNull.Value ? "" : reader["FULL_NAME"].ToString();
                    string address = reader["ADDRESS"] == DBNull.Value ? "" : reader["ADDRESS"].ToString();
                    string telephone = reader["TELEPHONE"] == DBNull.Value ? "" : reader["TELEPHONE"].ToString();

                    return new Customer(id, fullName, telephone, address);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"GetCustomerById failed: {ex.Message}");
            }

            return null;
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
                    SELECT ID, REGISTRATION, MODEL, COLOR, STATUS
                    FROM " + DBTableName.Vehicles;

                using OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader["ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["ID"]);
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
        public static Vehicle GetVehicleById(int vehicleId)
        {
            try
            {
                using OracleConnection connection = OracleDbContext.GetOpenConnection();
                using OracleCommand command = connection.CreateCommand();

                command.CommandText = @"
            SELECT ID, REGISTRATION, MODEL, COLOR, STATUS
            FROM " + DBTableName.Vehicles + @"
            WHERE ID = :vehicleId";

                command.Parameters.Add(":vehicleId", OracleDbType.Int32).Value = vehicleId;

                using OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader["ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["ID"]);
                    string registration = reader["REGISTRATION"] == DBNull.Value ? "" : reader["REGISTRATION"].ToString();
                    string model = reader["MODEL"] == DBNull.Value ? "" : reader["MODEL"].ToString();
                    string color = reader["COLOR"] == DBNull.Value ? "" : reader["COLOR"].ToString();
                    string status = reader["STATUS"] == DBNull.Value ? "" : reader["STATUS"].ToString();

                    return new Vehicle(id, registration, model, color, status);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"GetVehicleById failed: {ex.Message}");
            }

            return null;
        }
    }
}