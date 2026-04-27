using Valet_Parking_System.Classes.Constants.Database;

namespace Valet_Parking_System.Classes
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string Registation { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Status { get; set; }

        public Vehicle(int iD, string registation, string model, string color, string status)
        {
            ID = iD;
            Registation = registation;
            Model = model;
            Color = color;
            Status = status;
        }

        public string GetAddSql()
        {
            string sql = "INSERT INTO " + DBTableName.Vehicles + " (Registration, Model, Color, Status) VALUES ('" +
                         Registation + "', '" + Model + "', '" + Color + "', '" + Status + "')";
            return sql;
        }

        public string GetUpdateSql()
        {
            string sql = "UPDATE " + DBTableName.Vehicles + " SET " +
                         "Registration = '" + Registation + "', " +
                         "Model = '" + Model + "', " +
                         "Color = '" + Color + "', " +
                         "Status = '" + Status + "' " +
                         "WHERE ID = " + ID;
            return sql;
        }

        public string GetRemoveSql()
        {
            string sql = "DELETE FROM " + DBTableName.Vehicles + " WHERE ID = " + ID;
            return sql;
        }
    }
}