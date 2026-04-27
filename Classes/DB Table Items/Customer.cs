using System;
using System.Linq;
using System.Net;
using Valet_Parking_System.Classes.Constants.Database;

namespace Valet_Parking_System.Classes
{
    public class Customer
    {
        // Automatic
        public int CustomerID { get; set; } = 0;
        public bool CarStored = false;

        // Manual
        public string FullName { get; set; } = "";
        public string Telephone { get; set; } = "";
        public string Address { get; set; } = "";

        public int validationResault = -1;

        public Customer(int ID, string fullName, string telephone, string address)
        {
            CustomerID = ID;
            FullName = fullName;
            Telephone = telephone;
            Address = address;
        }


        public int ValidateCustomer()
        {
            validationResault = GetValidationCode();
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

            // 3 Telephone empty
            if (string.IsNullOrWhiteSpace(this.Telephone))
                return 3;

            // 4 Telephone too short (<10 digits)
            var phoneDigits = new string(this.Telephone.Where(char.IsDigit).ToArray());
            if (phoneDigits.Length < 10)
                return 4;

            // 5 Address empty
            if (string.IsNullOrWhiteSpace(this.Address))
                return 5;

            // 6 Address too long (>100 chars)
            if (!string.IsNullOrWhiteSpace(this.Address) && this.Address.Length > 100)
                return 6;

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
                3 => "Telephone required.",
                4 => "Telephone needs 10+ digits.",
                5 => "Address required.",
                6 => "Address too long (>100 chars).",
                _ => "Fix form errors."
            };

            return validationMsg;
        }

        public string GetAddSql()
        {
            string sql = "INSERT INTO " + DBTableName.Customers + " " +
                         "(Full_Name, Telephone, Address) " +
                         "VALUES ('" + FullName + "', '" + Telephone + "', '" + Address + "')";

            return sql;
        }

        public string GetUpdateSql()
        {
            string sql = "UPDATE " + DBTableName.Customers + " SET " +
                         "Full_Name = '" + FullName + "', " +
                         "Telephone = '" + Telephone + "', " +
                         "Address = '" + Address + "' " +
                         "WHERE Customer_ID = " + CustomerID;

            return sql;
        }

        public string GetRemoveSql()
        {
            string sql = "DELETE FROM " + DBTableName.Customers + " WHERE Customer_ID = " + CustomerID;
            return sql;
        }
    }
}