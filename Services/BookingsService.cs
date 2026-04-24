using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Repository.CRUD;

namespace Valet_Parking_System.Services
{
    internal class BookingsService
    {
        internal static bool AddBooking(Booking booking, Operator usingOperator)
        {
            booking.BookingOperator = usingOperator;
            var result = BookingRepository.AddBooking(booking);
            return result;
        }

        internal static bool EditBooking(Booking booking, Operator usingOperator)
        {
            booking.EditedOperatorsIds.Add(usingOperator.OperatorID);
            var result = BookingRepository.EditBooking(booking);
            return result;
        }

        internal static bool DeleteBooking(Booking booking, Operator usingOperator)
        {
            var result = BookingRepository.DeleteBooking(booking);
            return result;
        }

        public static List<Booking> FilterNearest(List<Booking> bookings)
        {
            if (bookings == null || bookings.Count == 0)
            {
                return new List<Booking>();
            }

            try
            {
                DateTime now = DateTime.Now;

                return bookings
                    .Where(b => b.Status == "Stored")
                    .Select(b =>
                    {
                        bool isValidDateTime = DateTime.TryParseExact(
                            $"{b.DateTo} {b.TimeTo}",
                            "dd/MM/yyyy HH:mm",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out DateTime pickupDateTime
                        );

                        return new
                        {
                            Booking = b,
                            IsValidDateTime = isValidDateTime,
                            PickupDateTime = pickupDateTime
                        };
                    })
                    .Where(x => x.IsValidDateTime)
                    .Where(x => x.PickupDateTime.Date == now.Date)
                    .Where(x => x.PickupDateTime >= now)
                    .OrderBy(x => x.PickupDateTime)
                    .Select(x => x.Booking)
                    .ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"FilterNearest failed: {ex.Message}");
                MessageBox.Show(
                    $"Error loading bookings: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return new List<Booking>();
            }
        }
    }
}
