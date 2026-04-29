using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.DataAccessLayer;

namespace Valet_Parking_System.Repository.CRUD
{
    internal static class BookingRepository
    {
        internal static bool AddBooking(Booking booking)
        {
            return DataBaseHelper.ExecuteNonQuery(booking.GetAddSql(), "AddBooking");
        }

        internal static bool EditBooking(Booking booking)
        {
            return DataBaseHelper.ExecuteNonQuery(booking.GetUpdateSql(), "EditBooking");
        }

        internal static bool DeleteBooking(Booking booking)
        {
            return DataBaseHelper.ExecuteNonQuery(booking.GetRemoveSql(), "DeleteBooking");
        }

        internal static bool UpdateBookingStatus(Booking booking, string status)
        {
            try
            {
                if (booking == null)
                {
                    return false;
                }

                booking.Status = status;
                return EditBooking(booking);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"UpdateBookingStatus failed: {ex.Message}");
                return false;
            }
        }
    }
}