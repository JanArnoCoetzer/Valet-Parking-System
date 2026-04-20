using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Valet_Parking_System.Classes
{
    public class Operator
    {
        public int OperatorID = 0;
        public string fullName = "";
        public string datejoined = "";
        public string fulladdress = "";
        public string telephone = "";
        public string email = "";
        public string Password = "12345678";
        public int validationResault = -1;

        public Operator()
        {
        }

        public Operator(int operatorID, string fullName, string datejoined, string address, string telephone, string email)
        {
            this.OperatorID = operatorID;
            this.fullName = fullName;
            this.datejoined = datejoined;
            this.fulladdress = address;
            this.telephone = telephone;
            this.email = email;
        }

        public int ValidateOperator()
        {
            validationResault = GetValidationCode();
            return validationResault;
        }

        public int GetValidationCode()
        {
            // 0 = VALID

            // 1 FullName empty
            if (string.IsNullOrWhiteSpace(this.fullName))
                return 1;

            // 2 FullName too long (>50 chars)
            if (this.fullName.Length > 50)
                return 2;

            // 3 DateJoined empty/invalid
            if (string.IsNullOrWhiteSpace(this.datejoined) ||
                !DateTime.TryParseExact(this.datejoined, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                return 3;

            // 4 Address empty
            if (string.IsNullOrWhiteSpace(this.fulladdress))
                return 4;

            // 5 Address too long (>100 chars)
            if (!string.IsNullOrWhiteSpace(this.fulladdress) && this.fulladdress.Length > 100)
                return 5;

            // 6 Telephone invalid (<10 digits)
            var phoneDigits = new string(this.telephone.ToString().Where(char.IsDigit).ToArray());
            if (phoneDigits.Length < 10)
                return 6;

            // 7 Email empty
            if (string.IsNullOrWhiteSpace(this.email))
                return 7;

            // 8 Email invalid format
            if (!Regex.IsMatch(this.email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return 8;

            // ALL PASS
            return 0;
        }

        public string GetValidationErrorMsg()
        {
            string validationMsg = this.validationResault switch
            {
                0 => "",
                1 => "Full name required.",
                2 => "Full name too long (>50 chars).",
                3 => "Valid date joined required (dd/MM/yyyy).",
                4 => "Address required.",
                5 => "Address too long (>100 chars).",
                6 => "Telephone needs 10+ digits.",
                7 => "Email required.",
                8 => "Invalid email format.",
                _ => "Fix form errors."
            };

            return validationMsg;
        }

        public string GetAddSql()
        {
            string sql = "INSERT INTO OperatorTable (operatorID, fullName, datejoined, fulladdress, telephone, email) VALUES (" +
                         OperatorID + ", '" + fullName + "', '" + datejoined + "', '" + fulladdress + "', '" + telephone + "', '" + email + "')";
            return sql;
        }

        public string GetUpdateSql()
        {
            string sql = "UPDATE OperatorTable SET " +
                         "fullName = '" + fullName + "', " +
                         "datejoined = '" + datejoined + "', " +
                         "fulladdress = '" + fulladdress + "', " +
                         "telephone = '" + telephone + "', " +
                         "email = '" + email + "' " +
                         "WHERE operatorID = " + OperatorID;
            return sql;
        }

        public string GetRemoveSql()
        {
            string sql = "DELETE FROM OperatorTable WHERE operatorID = " + OperatorID;
            return sql;
        }
    }
}