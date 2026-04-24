using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Valet_Parking_System.Classes
{
    public class Booking
    {
        //Automatic
        public int BookingId { get; set; } = 0;
        public Customer Customer { get; set; } = null;
        //public string FullName 
        //public string Telephone 
        //public string Address 
        public Operator BookingOperator { get; set; } = null;
        public Operator StorageOperator { get; set; } = null;
        public Operator RetrievalOperator { get; set; } = null;
        public Operator HandingOverOperator { get; set; } = null;
        //public int operatorID 
        //public string fullName 
        //public string datejoined 
        //public string fulladdress 
        //public string telephone 
        //public string email

        public List<int> EditedOperatorsIds { get; set; } = null;

        public ParkingSpace ParkingSpace { get; set; } = null;
        //public int SpaceID;
        //public string LotIdentifier;b
        //public string Status;
        public Vehicle Vehicle { get; set; } = null;
        //public string ID 
        //public string Registation 
        //public string Model
        //public string Color 
        //public string Status

        
        public string DateFrom { get; set; } = "";
        public string DateTo { get; set; } = "";
        public string TimeTo { get; set; } = "";
        public string TimeFrom { get; set; } = "";

        public string Status { get; set; } = "Null";



        public int validationResault = -1;

        public int ValidateBooking()
        {
            validationResault =  GetValidationCode();
            return validationResault;
        }
        
        public int GetValidationCode() 
        {
            // 0 = VALID 

            // 1 FullName empty
            if (string.IsNullOrWhiteSpace(this.Customer.FullName))
                return 1;

            // 2 FullName too long (>50 chars)
            if (this.Customer.FullName.Length > 50)
                return 2;

            // 3 Phone empty
            if (string.IsNullOrWhiteSpace(this.Customer.Telephone))
                return 3;

            // 4 Phone too short (<10 digits)
            var phoneDigits = new string(this.Customer.Telephone.Where(char.IsDigit).ToArray());
            if (phoneDigits.Length < 10)
                return 4;

            // 5 Address empty
            if (string.IsNullOrWhiteSpace(this.Customer.Address))
                return 5;

            // 6 Address too long (>100)
            if (!string.IsNullOrWhiteSpace(this.Customer.Address) && this.Customer.Address.Length > 100)
                return 6;

            // 7 CarReg empty
            if (string.IsNullOrWhiteSpace(Vehicle.Registation))
                return 7;

            // 8 CarReg invalid format (alphanumeric only)
            if (!System.Text.RegularExpressions.Regex.IsMatch(Vehicle.Registation, @"^[A-Z0-9\s-]+$"))
                return 8;

            // 9 CarModel empty
            if (string.IsNullOrWhiteSpace(Vehicle.Model))
                return 9;

            // 10 CarModel too long (>30)
            if (Vehicle.Model.Length > 30)
                return 10;

            // 11 CarColor empty
            if (string.IsNullOrWhiteSpace(Vehicle.Color))
                return 11;

            // 12 CarColor too long (>20)
            if (Vehicle.Color.Length > 20)
                return 12;
            // 13 DateFrom empty/invalid
            if (string.IsNullOrWhiteSpace(this.DateFrom) ||
                !DateTime.TryParseExact(this.DateFrom, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                return 13;

            // 14 DateTo empty/invalid
            if (string.IsNullOrWhiteSpace(this.DateTo) ||
                !DateTime.TryParseExact(this.DateTo, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                return 14;

            // 15 DateFrom >= DateTo
            if (DateTime.ParseExact(this.DateFrom, "dd/MM/yyyy", CultureInfo.InvariantCulture) >=
                DateTime.ParseExact(this.DateTo, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                return 15;

            // ALL PASS
            return 0;
        }

        public string GetValidationErrorMsg()
        {
            
            string validationMsg = this.validationResault switch
            {
                0 => "",
                1 => "Name required.",
                2 => "Name too long (>50 chars).",
                3 => "Telephone required.",
                4 => "Telephone needs 10+ digits.",
                5 => "Address required.",
                6 => "Address too long (>100 chars).",
                7 => "Car reg required.",
                8 => "Invalid car reg format.",
                9 => "Car model required.",
                10 => "Car model too long (>30 chars).",
                11 => "Car color required.",
                12 => "Car color too long (>20 chars).",
                13 => "Valid date from required (dd/MM/yyyy).",
                14 => "Valid date to required (dd/MM/yyyy).",
                15 => "Date to must be after date from.",
                _ => "Fix form errors."
            };
            return validationMsg;
            
        }

        public string GetAddSql()
        {
            return $@"
        INSERT INTO Bookings
        (
            CustomerId,
            BookingOperatorId,
            StorageOperatorId,
            RetrievalOperatorId,
            HandingOverOperatorId,
            ParkingSpaceId,
            VehicleId,
            DateFrom,
            DateTo,
            TimeFrom,
            TimeTo,
            Status
        )
        VALUES
        (
            {Customer.CustomerID},
            {(BookingOperator != null ? BookingOperator.OperatorID.ToString() : "NULL")},
            {(StorageOperator != null ? StorageOperator.OperatorID.ToString() : "NULL")},
            {(RetrievalOperator != null ? RetrievalOperator.OperatorID.ToString() : "NULL")},
            {(HandingOverOperator != null ? HandingOverOperator.OperatorID.ToString() : "NULL")},
            {(ParkingSpace != null ? ParkingSpace.SpaceID.ToString() : "NULL")},
            {(Vehicle != null ? Vehicle.ID.ToString() : "NULL")},
            '{DateFrom}',
            '{DateTo}',
            '{TimeFrom}',
            '{TimeTo}',
            '{Status}'
        );";
        }

        public string GetUpdateSql()
        {
            return $@"
        UPDATE Bookings
        SET
            CustomerId = {Customer.CustomerID},
            BookingOperatorId = {(BookingOperator != null ? BookingOperator.OperatorID.ToString() : "NULL")},
            StorageOperatorId = {(StorageOperator != null ? StorageOperator.OperatorID.ToString() : "NULL")},
            RetrievalOperatorId = {(RetrievalOperator != null ? RetrievalOperator.OperatorID.ToString() : "NULL")},
            HandingOverOperatorId = {(HandingOverOperator != null ? HandingOverOperator.OperatorID.ToString() : "NULL")},
            ParkingSpaceId = {(ParkingSpace != null ? ParkingSpace.SpaceID.ToString() : "NULL")},
            VehicleId = {(Vehicle != null ? Vehicle.ID.ToString() : "NULL")},
            DateFrom = '{DateFrom}',
            DateTo = '{DateTo}',
            TimeFrom = '{TimeFrom}',
            TimeTo = '{TimeTo}',
            Status = '{Status}'
        WHERE BookingId = {BookingId};";
        }

        public string GetRemoveSql()
        {
            return $@"
        DELETE FROM Bookings
        WHERE BookingId = {BookingId};";
        }

    }

}
