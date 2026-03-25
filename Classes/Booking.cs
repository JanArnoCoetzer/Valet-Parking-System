using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Valet_Parking_System.Classes
{
    public class Booking
    {
        //Automatic
        public int BookingId { get; set; } = 0;
        public int ParkingSpaceId { get; set; } = 0;
        public string Status { get; set; } = "PENDING";
        public int OperatorId { get; set; } = 0;
        public string DateFrom { get; set; } = "";

        //Manual
        public string FullName { get; set; } = "";
        public string TelephoneNum { get; set; } = "";
        public string Address { get; set; } = "";
        public string CarReg { get; set; } = "";
        public string CarModel { get; set; } = "";
        public string CarColor { get; set; } = "";    
        public string TimeFrom { get; set; } = "";
        public string DateTo { get; set; } = "";
        public string TimeTo { get; set; } = "";

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
            if (string.IsNullOrWhiteSpace(this.FullName))
                return 1;

            // 2 FullName too long (>50 chars)
            if (this.FullName.Length > 50)
                return 2;

            // 3 Phone empty
            if (string.IsNullOrWhiteSpace(this.TelephoneNum))
                return 3;

            // 4 Phone too short (<10 digits)
            var phoneDigits = new string(this.TelephoneNum.Where(char.IsDigit).ToArray());
            if (phoneDigits.Length < 10)
                return 4;

            // 5 Address empty
            if (string.IsNullOrWhiteSpace(this.Address))
                return 5;

            // 6 Address too long (>100)
            if (!string.IsNullOrWhiteSpace(this.Address) && this.Address.Length > 100)
                return 6;

            // 7 CarReg empty
            if (string.IsNullOrWhiteSpace(this.CarReg))
                return 7;

            // 8 CarReg invalid format (alphanumeric only)
            if (!System.Text.RegularExpressions.Regex.IsMatch(this.CarReg, @"^[A-Z0-9\s-]+$"))
                return 8;

            // 9 CarModel empty
            if (string.IsNullOrWhiteSpace(this.CarModel))
                return 9;

            // 10 CarModel too long (>30)
            if (this.CarModel.Length > 30)
                return 10;

            // 11 CarColor empty
            if (string.IsNullOrWhiteSpace(this.CarColor))
                return 11;

            // 12 CarColor too long (>20)
            if (this.CarColor.Length > 20)
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
    }

}
