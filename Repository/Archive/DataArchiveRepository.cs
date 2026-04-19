using Oracle.ManagedDataAccess.Client;
using System;
using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.DataAccessLayer;

namespace Valet_Parking_System.Repository.Archive
{
    internal class DataArchiveRepository
    {
        public static bool ArchiveBooking(Booking booking, string archiveReason = "Deleted by user")
        {
            try
            {
                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    using (OracleTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertSql =
                                "INSERT INTO BookingArchive " +
                                "(OriginalBookingId, Status, OperatorId, DateFrom, FullName, CarReg, CarModel, CarColor, TimeFrom, DateTo, TimeTo, SpaceID, ArchivedAt, ArchiveReason) " +
                                "VALUES (" +
                                booking.BookingId + ", '" +
                                booking.Status + "', " +
                                booking.StorageOperator.OperatorID + ", '" +
                                booking.DateFrom + "', '" +
                                booking.Customer.CustomerID+ "', '" +
                                booking.CarReg + "', '" +
                                booking.CarModel + "', '" +
                                booking.CarColor + "', '" +
                                booking.TimeFrom + "', '" +
                                booking.DateTo + "', '" +
                                booking.TimeTo + "', " +
                                booking.Parkingspace.SpaceID + ", SYSDATE, '" +
                                archiveReason + "')";

                            string deleteSql =
                                "DELETE FROM Booking WHERE BookingId = " + booking.BookingId;

                            using (OracleCommand insertCmd = new OracleCommand(insertSql, conn))
                            {
                                insertCmd.Transaction = trans;
                                insertCmd.ExecuteNonQuery();
                            }

                            using (OracleCommand deleteCmd = new OracleCommand(deleteSql, conn))
                            {
                                deleteCmd.Transaction = trans;
                                int rows = deleteCmd.ExecuteNonQuery();

                                if (rows <= 0)
                                {
                                    trans.Rollback();
                                    return false;
                                }
                            }

                            trans.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            Debug.WriteLine("ArchiveBooking error: " + ex);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ArchiveBooking connection error: " + ex);
                return false;
            }
        }

        public static bool ArchiveOperator(Operator operatordata, string archiveReason = "Deleted by user")
        {
            try
            {
                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    using (OracleTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertSql =
                                "INSERT INTO OperatorArchive " +
                                "(OriginalOperatorId, FullName, DateJoined, FullAddress, Telephone, Email, ArchivedAt, ArchiveReason) " +
                                "VALUES (" +
                                operatordata.OperatorID + ", '" +
                                operatordata.fullName + "', '" +
                                operatordata.datejoined + "', '" +
                                operatordata.fulladdress + "', '" +
                                operatordata.telephone + "', '" +
                                operatordata.email + "', SYSDATE, '" +
                                archiveReason + "')";

                            string deleteSql =
                                "DELETE FROM Operators WHERE operatorID = " + operatordata.OperatorID;

                            using (OracleCommand insertCmd = new OracleCommand(insertSql, conn))
                            {
                                insertCmd.Transaction = trans;
                                insertCmd.ExecuteNonQuery();
                            }

                            using (OracleCommand deleteCmd = new OracleCommand(deleteSql, conn))
                            {
                                deleteCmd.Transaction = trans;
                                int rows = deleteCmd.ExecuteNonQuery();

                                if (rows <= 0)
                                {
                                    trans.Rollback();
                                    return false;
                                }
                            }

                            trans.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            Debug.WriteLine("ArchiveOperator error: " + ex);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ArchiveOperator connection error: " + ex);
                return false;
            }
        }

        public static bool ArchiveParkingSpace(ParkingSpace spacedata, string archiveReason = "Deleted by user")
        {
            try
            {
                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    using (OracleTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertSql =
                                "INSERT INTO ParkingSpaceArchive " +
                                "(OriginalSpaceId, LotIdentifier, Status, ArchivedAt, ArchiveReason) " +
                                "VALUES (" +
                                spacedata.SpaceID + ", '" +
                                spacedata.LotIdentifier + "', '" +
                                spacedata.Status + "', SYSDATE, '" +
                                archiveReason + "')";

                            string deleteSql =
                                "DELETE FROM ParkingSpace WHERE SpaceID = " + spacedata.SpaceID;

                            using (OracleCommand insertCmd = new OracleCommand(insertSql, conn))
                            {
                                insertCmd.Transaction = trans;
                                insertCmd.ExecuteNonQuery();
                            }

                            using (OracleCommand deleteCmd = new OracleCommand(deleteSql, conn))
                            {
                                deleteCmd.Transaction = trans;
                                int rows = deleteCmd.ExecuteNonQuery();

                                if (rows <= 0)
                                {
                                    trans.Rollback();
                                    return false;
                                }
                            }

                            trans.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            Debug.WriteLine("ArchiveParkingSpace error: " + ex);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ArchiveParkingSpace connection error: " + ex);
                return false;
            }
        }

        public static bool ArchiveCustomer(Customer customer, string archiveReason = "Deleted by user")
        {
            try
            {
                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    using (OracleTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertSql =
                                "INSERT INTO CustomerArchive " +
                                "(OriginalCustomerId, FullName, Telephone, Address, ArchivedAt, ArchiveReason) " +
                                "VALUES (" +
                                customer.CustomerID + ", '" +
                                customer.FullName + "', '" +
                                customer.Telephone + "', '" +
                                customer.Address + "', SYSDATE, '" +
                                archiveReason + "')";

                            string deleteSql =
                                "DELETE FROM Customer WHERE CustomerID = " + customer.CustomerID;

                            using (OracleCommand insertCmd = new OracleCommand(insertSql, conn))
                            {
                                insertCmd.Transaction = trans;
                                insertCmd.ExecuteNonQuery();
                            }

                            using (OracleCommand deleteCmd = new OracleCommand(deleteSql, conn))
                            {
                                deleteCmd.Transaction = trans;
                                int rows = deleteCmd.ExecuteNonQuery();

                                if (rows <= 0)
                                {
                                    trans.Rollback();
                                    return false;
                                }
                            }

                            trans.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            Debug.WriteLine("ArchiveCustomer error: " + ex);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ArchiveCustomer connection error: " + ex);
                return false;
            }
        }
    }
}