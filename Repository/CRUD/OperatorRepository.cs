using System;
using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Repository.CRUD;

namespace Valet_Parking_System.Repository.CRUD
{
    internal static class OperatorRepository
    {
        internal static bool SetStorageOperator(Booking bookingData, Operator usingOperator)
        {
            try
            {
                bookingData.StorageOperator = usingOperator;
                return ExecuteBookingUpdate(bookingData, "SetStorageOperator");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"SetStorageOperator failed: {ex.Message}");
                return false;
            }
        }

        internal static bool SetHandingOffOperator(Booking bookingData, Operator usingOperator)
        {
            try
            {
                bookingData.HandingOverOperator = usingOperator;
                return ExecuteBookingUpdate(bookingData, "SetHandingOffOperator");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"SetHandingOffOperator failed: {ex.Message}");
                return false;
            }
        }

        internal static bool SetRetrievalOperator(Booking bookingData, Operator usingOperator)
        {
            try
            {
                bookingData.RetrievalOperator = usingOperator;
                return ExecuteBookingUpdate(bookingData, "SetRetrievalOperator");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"SetRetrievalOperator failed: {ex.Message}");
                return false;
            }
        }

        private static bool ExecuteBookingUpdate(Booking bookingData, string operationName)
        {
            try
            {
                return BookingRepository.EditBooking(bookingData);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{operationName} failed: {ex.Message}");
                return false;
            }
        }
    }
}