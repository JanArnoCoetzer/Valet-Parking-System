using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.DataAccessLayer;

namespace Valet_Parking_System.Repository.Queries
{
    internal class DataQueryRepository
    {
        public static bool LoadBookings(List<Booking> bookings)
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

        public static bool LoadOperators(List<Operator> operators)
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

        public static bool LoadParkingSpaces(List<ParkingSpace> spaces)
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

        public static bool LoadCustomers(List<Customer> customers)
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