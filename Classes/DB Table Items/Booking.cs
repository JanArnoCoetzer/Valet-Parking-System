using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Valet_Parking_System.Classes.Constants.Database;

namespace Valet_Parking_System.Classes
{
    public class Booking
    {
        //Automatic
        public int BookingId { get; set; } = 0;
        public Customer Customer { get; set; } = null;
        public int CustomerId { get; set; } = 0;
        public Operator BookingOperator { get; set; } = null;
        public Operator StorageOperator { get; set; } = null;
        public Operator RetrievalOperator { get; set; } = null;
        public Operator HandingOverOperator { get; set; } = null;

        public List<int> EditedOperatorsIds { get; set; } = null;

        public ParkingSpace ParkingSpace { get; set; } = null;
        public int ParkingSpaceId { get; set; } = 0;
        public Vehicle Vehicle { get; set; } = null;
        public int VehicleId { get; set; } = 0;
        public string DateFrom { get; set; } = "";
        public string DateTo { get; set; } = "";
        public string TimeTo { get; set; } = "";
        public string TimeFrom { get; set; } = "";

        public string Status { get; set; } = "Null";

        public int validationResault = -1;

        public int ValidateBooking()
        {
            validationResault = GetValidationCode();
            return validationResault;
        }

        public int GetValidationCode()
        {
            // 0 = VALID 

            // 1 FullName empty
            if (Customer == null || string.IsNullOrWhiteSpace(Customer.FullName))
                return 1;

            // 2 FullName too long (>50 chars)
            if (Customer.FullName.Length > 50)
                return 2;

            // 3 Phone empty
            if (string.IsNullOrWhiteSpace(Customer.Telephone))
                return 3;

            // 4 Phone too short (<10 digits)
            var phoneDigits = new string(Customer.Telephone.Where(char.IsDigit).ToArray());
            if (phoneDigits.Length < 10)
                return 4;

            // 5 Address empty
            if (string.IsNullOrWhiteSpace(Customer.Address))
                return 5;

            // 6 Address too long (>100)
            if (Customer.Address.Length > 100)
                return 6;

            // 7 CarReg empty
            if (Vehicle == null || string.IsNullOrWhiteSpace(Vehicle.Registation))
                return 7;

            // 8 CarReg invalid format
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
            if (string.IsNullOrWhiteSpace(DateFrom) ||
                !DateTime.TryParseExact(DateFrom, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                return 13;

            // 14 DateTo empty/invalid
            if (string.IsNullOrWhiteSpace(DateTo) ||
                !DateTime.TryParseExact(DateTo, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                return 14;

            

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
                15 => "Valid time from required (HH:mm).",
                16 => "Valid time to required (HH:mm).",
                17 => "Booking end must be after booking start.",
                _ => "Fix form errors."
            };
            return validationMsg;
        }

        public string GetAddSql()
        {
            return $@"
        INSERT INTO {DBTableName.Bookings}
        (
            Customer_ID,
            Booking_Operator_ID,
            Storage_Operator_ID,
            Retrieval_Operator_ID,
            Handing_Over_Operator_ID,
            Parking_Space_ID,
            Vehicle_ID,
            Date_From,
            Date_To,
            Time_From,
            Time_To,
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
        )";
        }

        public string GetUpdateSql()
        {
            return $@"
        UPDATE {DBTableName.Bookings}
        SET
            Customer_ID = {Customer.CustomerID},
            Booking_Operator_ID = {(BookingOperator != null ? BookingOperator.OperatorID.ToString() : "NULL")},
            Storage_Operator_ID = {(StorageOperator != null ? StorageOperator.OperatorID.ToString() : "NULL")},
            Retrieval_Operator_ID = {(RetrievalOperator != null ? RetrievalOperator.OperatorID.ToString() : "NULL")},
            Handing_Over_Operator_ID = {(HandingOverOperator != null ? HandingOverOperator.OperatorID.ToString() : "NULL")},
            Parking_Space_ID = {(ParkingSpace != null ? ParkingSpace.SpaceID.ToString() : "NULL")},
            Vehicle_ID = {(Vehicle != null ? Vehicle.ID.ToString() : "NULL")},
            Date_From = '{DateFrom}',
            Date_To = '{DateTo}',
            Time_From = '{TimeFrom}',
            Time_To = '{TimeTo}',
            Status = '{Status}'
        WHERE Booking_ID = {BookingId}";
        }

        public string GetRemoveSql()
        {
            return $@"
        DELETE FROM {DBTableName.Bookings}
        WHERE Booking_ID = {BookingId}";
        }
    }
}