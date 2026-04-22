using System;
using System.Collections.Generic;
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
    }
}
