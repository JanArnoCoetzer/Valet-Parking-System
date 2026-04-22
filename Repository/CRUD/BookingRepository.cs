using Oracle.ManagedDataAccess.Client;
using Valet_Parking_System.Classes;
using Valet_Parking_System.DataAccessLayer;

namespace Valet_Parking_System.Repository.CRUD
{
    public class BookingRepository
    {
        

        internal static bool AddBooking(Booking booking)
        {
            try
            {
                string sql = booking.GetAddSql();

                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error");
                return false;
            }
        }

        internal static bool EditBooking(Booking booking)
        {
            try
            {
                string sql = booking.GetUpdateSql();

                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error");
                return false;
            }
        }

        internal static bool DeleteBooking(Booking booking)
        {
            try
            {
                string sql = booking.GetRemoveSql();

                using (OracleConnection conn = OracleDbContext.GetConnection())
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error");
                return false;
            }
        }

        internal static bool UpdateBookingStatus(Booking booking, string status)
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