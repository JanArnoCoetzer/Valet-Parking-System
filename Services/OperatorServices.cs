using Valet_Parking_System.Classes;
using Valet_Parking_System.Classes.Constants.Vehicle;
using Valet_Parking_System.Repository.Archive;
using Valet_Parking_System.Repository.CRUD;

namespace Valet_Parking_System.Services
{
    public static class OperatorServices
    {
        public static bool SetStatusStored(Booking bookingData, Operator usingOperator)
        {
            bool statusUpdated = BookingRepository.UpdateBookingStatus(bookingData, BookingStatuses.Stored);
            bool storageOperatorSet = OperatorRepository.SetStorageOperator(bookingData, usingOperator);
            bool vehicleStatusSet = VehicleService.SetStatus(bookingData.Vehicle, VehicleStatus.InStorage);

            return statusUpdated && storageOperatorSet && vehicleStatusSet;
        }

        public static bool SetStatusAwaitingOwner(Booking bookingData, Operator usingOperator)
        {
            bool statusUpdated = BookingRepository.UpdateBookingStatus(bookingData, BookingStatuses.AwaitingOwner);
            bool retrievalOperatorSet = OperatorRepository.SetRetrievalOperator(bookingData, usingOperator);
            bool vehicleStatusSet = VehicleService.SetStatus(bookingData.Vehicle, VehicleStatus.AwaitingOwner);

            return statusUpdated && retrievalOperatorSet && vehicleStatusSet;
        }

        public static bool SetStatusHandedToOwner(Booking bookingData, Operator usingOperator)
        {
            bool statusUpdated = BookingRepository.UpdateBookingStatus(bookingData, BookingStatuses.HandedOff);
            bool handingOffOperatorSet = OperatorRepository.SetHandingOffOperator(bookingData, usingOperator);
            bool vehicleStatusSet = VehicleService.SetStatus(bookingData.Vehicle, VehicleStatus.HandedToOwner);

            if (!statusUpdated || !handingOffOperatorSet || !vehicleStatusSet)
            {
                return false;
            }

            bool archiveCreated = DataArchiveRepository.ArchiveBooking(bookingData, "Car Handed Over To Customer");

            if (!archiveCreated)
            {
                return false;
            }

            return BookingsService.DeleteBooking(bookingData, usingOperator);
        }
    }
}