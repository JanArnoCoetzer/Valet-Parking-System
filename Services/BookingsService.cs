using System.Diagnostics;
using System.Globalization;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Repository.CRUD;

namespace Valet_Parking_System.Services
{
    internal static class BookingsService
    {
        internal static bool AddBooking(Booking booking, Operator usingOperator)
        {
            booking.BookingOperator = usingOperator;
            return BookingRepository.AddBooking(booking);
        }

        internal static bool EditBooking(Booking booking, Operator usingOperator)
        {
            booking.EditedOperatorsIds.Add(usingOperator.OperatorID);
            return BookingRepository.EditBooking(booking);
        }

        internal static bool DeleteBooking(Booking booking, Operator usingOperator)
        {
            return BookingRepository.DeleteBooking(booking);
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
                    .Where(b => b.Status == BookingStatuses.Stored)
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
                return new List<Booking>();
            }
        }

        public static List<Booking> FilterBookings(
                                                    List<Booking> bookings,
                                                    string bookingIdText = "",
                                                    string customerNameText = "",
                                                    string carRegText = ""
                                                  )
        {
            if (bookings == null)
            {
                return new List<Booking>();
            }

            IEnumerable<Booking> query = bookings;

            if (!string.IsNullOrWhiteSpace(bookingIdText) &&
                int.TryParse(bookingIdText, out int id))
            {
                query = query.Where(b => b.BookingId == id);
            }

            if (!string.IsNullOrWhiteSpace(customerNameText))
            {
                query = query.Where(b =>
                    b.Customer != null &&
                    !string.IsNullOrWhiteSpace(b.Customer.FullName) &&
                    b.Customer.FullName.IndexOf(customerNameText, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(carRegText))
            {
                query = query.Where(b =>
                    b.Vehicle != null &&
                    !string.IsNullOrWhiteSpace(b.Vehicle.Registation) &&
                    b.Vehicle.Registation.IndexOf(carRegText, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            return query.ToList();
        }

        
    }
}