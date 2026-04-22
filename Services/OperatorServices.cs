using Valet_Parking_System.Classes;
using Valet_Parking_System.Repository.Archive;
using Valet_Parking_System.Repository.CRUD;

namespace Valet_Parking_System.Services
{
    public static class OperatorServices
    {
        public static bool SetStatusStored(Booking bookingdata, Operator usingOperator)
        {
            BookingRepository.UpdateBookingStatus(bookingdata, "Stored");
            OperatorRepository.SetStorageOperator(bookingdata, usingOperator);
            return true;
        }

        public static bool SetStatusAwaitingOwner(Booking bookingdata, Operator usingOperator)
        {
            BookingRepository.UpdateBookingStatus(bookingdata, "AwaitingOwner");
            OperatorRepository.SetRetrievalOperator(bookingdata, usingOperator);
            return true;
        }

        public static bool SetStatusHandedToOwner(Booking bookingdata, Operator usingOperator)
        {
            BookingRepository.UpdateBookingStatus(bookingdata, "HandedOff");
            OperatorRepository.SetHandingOffOperator(bookingdata, usingOperator);

            var result = DataArchiveRepository.ArchiveBooking(bookingdata, "Car Handed Over To Customer");

            if (result)
            {
                return BookingsService.DeleteBooking(bookingdata, usingOperator);
            }

            return false;
        }
    }
}