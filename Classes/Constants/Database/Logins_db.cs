using System.Diagnostics;
using System.Text.Json;

namespace Valet_Parking_System.Classes.Constants.StaticDatabase
{
    public static class Logins_db
    {
        public static string username = "t00206990";
        public static string password = "Wiarno911";

        public static string get_username() { return username; }
        public static string get_password() { return password; }

        private class LoginJson
        {
            public string username { get; set; }
            public string password { get; set; }
        }


    }
}
