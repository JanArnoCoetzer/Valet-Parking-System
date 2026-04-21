using System;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Valet_Parking_System.Classes
{
    public class TestFunctions
    {
        public readonly Random rand = new Random();

        // Shared data arrays
        private readonly string[] firstNames = {
            "John", "Jane", "Bob", "Alice", "Mike", "Sarah", "Tom", "Emma", "David", "Lisa"
        };

        private readonly string[] lastNames = {
            "Doe", "Smith", "Wilson", "Brown", "Taylor", "Davis", "Clark", "Lewis", "Walker", "Hall"
        };

        private readonly string[] models = {
            "Toyota Corolla", "Ford Focus", "VW Golf", "Honda Civic", "BMW 3 Series",
            "Mercedes C-Class", "Audi A4", "Skoda Octavia", "Hyundai i30", "Kia Sportage"
        };

        private readonly string[] colors = {
            "Blue", "Red", "Black", "White", "Grey", "Silver", "Green", "Yellow", "Purple", "Orange"
        };

        private readonly string[] streets = {
            "High St", "Main St", "Park Ave", "Garden St", "King St",
            "Queen St", "O'Connell St", "Abbey St"
        };

        private readonly string[] phonePrefixes = { "087", "086", "085", "083", "089" };

        private readonly string[] statusList = { "Stored", "AwaitingStorage", "AwaitingPickUp", "AwaitingOwner" };
        private readonly float[] statusWeights = { 0.6f, 0.1f, 0.1f,0.2f};


        // -------------------------------------Test data generators-------------------------------------


        public List<Booking> CreateTestBookings(
            List<ParkingSpace> parkingSpaces,
            List<Customer> customers,
            List<Operator> operators,
            List<Vehicle> vehicles,
            int amount = 25)
        {
            var bookings = new List<Booking>();

            string todayStr = DateTime.Today.ToString("dd/MM/yyyy");
            int firstBatch = Math.Min(20, amount);

            // Available parking spaces
            var availableSpaces = parkingSpaces != null && parkingSpaces.Any()
                ? (parkingSpaces.Any(ps => ps.Available)
                    ? parkingSpaces.Where(ps => ps.Available)
                              .OrderBy(ps => ps.SpaceID)
                              .ToList()
                    : parkingSpaces.OrderBy(ps => ps.SpaceID).ToList())
                : new List<ParkingSpace>();

            // Customers
            var owningCustomers = customers != null && customers.Any()
                ? (customers.Any(c => c.CarStored)
                    ? customers.Where(c => c.CarStored)
                              .OrderBy(c => c.CustomerID)
                              .ToList()
                    : customers.OrderBy(c => c.CustomerID).ToList())
                : new List<Customer>();

            // All operators 
            var storageOperators = operators != null && operators.Any()
                ? operators.OrderBy(o => o.OperatorID).ToList()
                : new List<Operator>();
            
            // All operators 
            var storedVehicles = vehicles != null && vehicles.Any()
                ? vehicles.OrderBy(v => v.ID).ToList()
                : new List<Vehicle>();

            for (int i = 0; i < amount; i++)
            {
                ParkingSpace? space = availableSpaces.FirstOrDefault();
                if (space != null)
                {
                    space.setStatus("Occupied");
                    availableSpaces.Remove(space);
                }

                var selectedCustomer = GetRandomItem(owningCustomers);
                var selectedOperator = GetRandomItem(storageOperators);
                var selectedVehicle = GetRandomItem(storedVehicles);
                bool isTodayBooking = i < firstBatch;

                var booking = new Booking
                {
                    BookingId = i + 1,
                    Customer = selectedCustomer,
                    ParkingSpace = space,
                    StorageOperator = selectedOperator,
                    Vehicle = selectedVehicle,
                    Status = WeightedStatuses(statusList, statusWeights),

                    DateFrom = isTodayBooking
                        ? todayStr
                        : DateTime.Now.AddDays(-rand.Next(1, 365)).ToString("dd/MM/yyyy"),
                    DateTo = isTodayBooking
                        ? todayStr
                        : DateTime.Now.AddDays(rand.Next(1, 30)).ToString("dd/MM/yyyy"),
                    TimeFrom = isTodayBooking
                        ? $"{rand.Next(8, 18):D2}:{rand.Next(0, 60):D2}"
                        : $"{rand.Next(0, 24):D2}:{rand.Next(0, 60):D2}",
                    TimeTo = isTodayBooking
                        ? $"{rand.Next(16, 22):D2}:{rand.Next(0, 60):D2}"
                        : $"{rand.Next(0, 24):D2}:{rand.Next(0, 60):D2}",
                };

                bookings.Add(booking);
            }

            return bookings;
        }

        public List<ParkingSpace> CreateTestParking()
        {
            var parkingSpaces = new List<ParkingSpace>();

            char[] buildings = { 'A', 'B' };
            char[] floors = { 'A', 'B', 'C' };

            int spaceId = 1;

            foreach (char building in buildings)
            {
                foreach (char floor in floors)
                {
                    for (int spaceNum = 1; spaceNum <= 50; spaceNum++)
                    {
                        var space = new ParkingSpace(
                            spaceId++,
                            $"{building}_{floor}{spaceNum:D2}",
                            "Available"
                        );
                        parkingSpaces.Add(space);
                    }
                }
            }

            return parkingSpaces;
        }

        public List<Operator> CreateTestOperators(int amount = 15)
        {
            var operators = new List<Operator>();
            string todayStr = DateTime.Today.ToString("dd/MM/yyyy");

            var opAdmin = new Operator(
                    1, "A","Admin", todayStr, GenerateRandomAddress(), GenerateRandomPhone(), "Admin@gmail.com"
                    );
            operators.Add(opAdmin);
            var opOperator = new Operator(
                    2, "O","Operator", todayStr, GenerateRandomAddress(), GenerateRandomPhone(), "Operator@gmail.com"
                    );
            operators.Add(opOperator);

            for (int i = 3; i < amount; i++)
            {
                

                string fullName = GenerateRandomFullName();
                string address = GenerateRandomAddress();
                string telephone = GenerateRandomPhone();
                string email = $"{fullName.Replace(" ", ".").ToLower()}@example.com";

                var op = new Operator(
                    operatorID: i + 1,
                    "O",
                    fullName: fullName,
                    datejoined: todayStr,
                    address: address,
                    telephone: telephone,
                    email: email
                );

                operators.Add(op);
            }

            return operators;
        }

        public List<Customer> CreateTestCustomers(int amount = 20)
        {
            var customers = new List<Customer>();

            for (int i = 0; i < amount; i++)
            {
                var customer = new Customer(
                    i + 1,
                    GenerateRandomFullName(),
                    GenerateRandomPhone(),
                    GenerateRandomAddress()
                );

                customers.Add(customer);
            }

            return customers;
        }

        public List<Vehicle> CreateTestVehcles(int amount = 20) 
        {
            var Vehicles = new List<Vehicle>();
            for (int i = 0; i < amount; i++)
            {
                var vehicle = new Vehicle(
                    i + 1, GenerateIrishPlate(), GenerateRandomCarModel(), GenerateRandomCarColor()
                    ,"Stored"

                );
                Vehicles.Add(vehicle);
            }
          return Vehicles;
        }


        // -------------------------------------Helper functions-------------------------------------
        private string WeightedStatuses(string[] statusList, float[] statusWeights)
        {
            
            float totalWeight = statusWeights.Sum();

            float randomValue = (float)(rand.NextDouble() * totalWeight);
            float cumulativeWeight = 0f;

            for (int i = 0; i < statusList.Length; i++)
            {
                cumulativeWeight += statusWeights[i];

                if (randomValue < cumulativeWeight)
                    return statusList[i];
            }

            return statusList[statusList.Length - 1];
        }
        private string GenerateRandomFullName()
        {
            string firstName = firstNames[rand.Next(firstNames.Length)];
            string lastName = lastNames[rand.Next(lastNames.Length)];
            return $"{firstName} {lastName}";
        }

        private string GenerateRandomPhone()
        {
            int choice = rand.Next(100);

       
            if (choice < 80)
            {
                string prefix = phonePrefixes[rand.Next(phonePrefixes.Length)];
                string number = rand.Next(1000000, 10000000).ToString();
                return $"{prefix} {number}";
            }

        
            int part1 = rand.Next(100, 1000);
            int part2 = rand.Next(10, 100);
            int part3 = rand.Next(100, 1000);
            int part4 = rand.Next(1000, 10000);

            return $"({part1}) {part2:D2} {part3:D3} {part4:D4}";
        }

        private string GenerateRandomAddress()
        {
            int houseNum = rand.Next(1, 999);
            string street = streets[rand.Next(streets.Length)];
            int dublinArea = rand.Next(1, 25);
            return $"{houseNum} {street}, Dublin {dublinArea}";
        }

        private string GenerateRandomCarModel()
        {
            return models[rand.Next(models.Length)];
        }

        private string GenerateRandomCarColor()
        {
            return colors[rand.Next(colors.Length)];
        }

        private string GenerateIrishPlate()
        {
            string[] countyCodes =
            {
                 "C", "CE", "CN", "CW", "D", "DL", "G", "KE", "KK", "KY",
                  "L", "LD", "LH", "LK", "LM", "LS", "MH", "MN", "MO", "OY",
                 "RN", "SO", "T", "W", "WH", "WX", "WW"
            };

            int year = rand.Next(2013, DateTime.Now.Year + 1);
            int half = rand.Next(1, 3); // 1 = Jan-Jun, 2 = Jul-Dec

            string yearCode = $"{year % 100:D2}{half}";
            string county = countyCodes[rand.Next(countyCodes.Length)];
            int sequence = rand.Next(1, 999999);

            return $"{yearCode}-{county}-{sequence}";
        }

        private T GetRandomItem<T>(IList<T> list)
        {
            if (list == null || list.Count == 0)
                return default!;

            return list[rand.Next(list.Count)];
        }
    }
}