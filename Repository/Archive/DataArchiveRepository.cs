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
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ArchiveOperator(Operator operatordata, string archiveReason = "Deleted by user")
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ArchiveParkingSpace(ParkingSpace spacedata, string archiveReason = "Deleted by user")
        {

            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ArchiveCustomer(Customer customer, string archiveReason = "Deleted by user")
        {

            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}