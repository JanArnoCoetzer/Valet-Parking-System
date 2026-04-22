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
        public static List<Booking> LoadBookings()
        {
            List<Booking> fetchedBookings = new List<Booking>();
            return fetchedBookings;
        }

        public static List<Operator> LoadOperators()
        {
            List<Operator> fetchedOperators = new List<Operator>();
            return fetchedOperators;
        }

        public static List<ParkingSpace> LoadParkingSpaces()
        {
            List<ParkingSpace> fetchedParkingSpaces = new List<ParkingSpace>();
            return fetchedParkingSpaces;
        }

        public static List<Customer> LoadCustomers()
        {
            List<Customer> fetchedCustomers = new List<Customer>();

            return fetchedCustomers;
        }

    }
}