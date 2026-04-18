using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.DataAccessLayer;

namespace Valet_Parking_System.Repository.Queries
{
    internal class DataQueryRepository
    {
        public static bool LoadBookings(List<Booking> bookings)
        {
            try
            {
                bookings.Clear();

                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    string sql = "SELECT BookingId, Status, OperatorId, DateFrom, FullName, TelephoneNum, Address, CarReg, CarModel, CarColor, TimeFrom, DateTo, TimeTo FROM Booking";
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Booking booking = new Booking
                            {
                                BookingId = Convert.ToInt32(reader["BookingId"]),
                                Status = reader["Status"].ToString(),
                                OperatorId = Convert.ToInt32(reader["OperatorId"]),
                                DateFrom = reader["DateFrom"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                TelephoneNum = reader["TelephoneNum"].ToString(),
                                Address = reader["Address"].ToString(),
                                CarReg = reader["CarReg"].ToString(),
                                CarModel = reader["CarModel"].ToString(),
                                CarColor = reader["CarColor"].ToString(),
                                TimeFrom = reader["TimeFrom"].ToString(),
                                DateTo = reader["DateTo"].ToString(),
                                TimeTo = reader["TimeTo"].ToString()
                            };

                            bookings.Add(booking);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LoadBookings error: " + ex.Message);
                return false;
            }
        }

        public static bool LoadOperators(List<Operator> operators)
        {
            try
            {
                operators.Clear();

                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    string sql = "SELECT operatorID, fullName, datejoined, fulladdress, telephone, email FROM OperatorTable";
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Operator op = new Operator(
                                Convert.ToInt32(reader["operatorID"]),
                                reader["fullName"].ToString(),
                                reader["datejoined"].ToString(),
                                reader["fulladdress"].ToString(),
                                reader["telephone"].ToString(),
                                reader["email"].ToString()
                            );

                            operators.Add(op);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LoadOperators error: " + ex.Message);
                return false;
            }
        }

        public static bool LoadParkingSpaces(List<ParkingSpace> spaces)
        {
            try
            {
                spaces.Clear();

                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    string sql = "SELECT SpaceID, LotIdentifier, Status FROM ParkingSpace";
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ParkingSpace space = new ParkingSpace(
                                Convert.ToInt32(reader["SpaceID"]),
                                reader["LotIdentifier"].ToString(),
                                reader["Status"].ToString()
                            );

                            spaces.Add(space);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LoadParkingSpaces error: " + ex.Message);
                return false;
            }
        }

        public static bool LoadRetrievalQueue(List<RetrievalQueueItem> queue, List<Booking> bookings)
        {
            try
            {
                queue.Clear();

                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    string sql = "SELECT BookingId, Status, Position, RequestTime FROM RetrievalQueueItem";
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int bookingId = Convert.ToInt32(reader["BookingId"]);
                            Booking foundBooking = bookings.Find(b => b.BookingId == bookingId);

                            if (foundBooking != null)
                            {
                                RetrievalQueueItem item = new RetrievalQueueItem(
                                    foundBooking,
                                    Convert.ToInt32(reader["Position"]),
                                    reader["Status"].ToString()
                                );

                                item.RequestTime = reader["RequestTime"].ToString();
                                queue.Add(item);
                            }
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LoadRetrievalQueue error: " + ex.Message);
                return false;
            }
        }
        public static bool LoadCustomers(List<Customer> customers)
        {
            try
            {
                customers.Clear();

                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    string sql = "SELECT CustomerID, FullName, Telephone, Address FROM Customer";
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer
                            {
                                CustomerID = Convert.ToInt32(reader["CustomerID"]),
                                FullName = reader["FullName"].ToString(),
                                Telephone = reader["Telephone"].ToString(),
                                Address = reader["Address"].ToString()
                            };

                            customers.Add(customer);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LoadCustomers error: " + ex.Message);
                return false;
            }
        }

    }
}