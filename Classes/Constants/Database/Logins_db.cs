using System.Diagnostics;
using System.Text.Json;

namespace Valet_Parking_System.Classes.Constants.StaticDatabase
{
    public static class Logins_db
    {
        public static string username = "";
        public static string password = "";

        public static string get_username() { return username; }
        public static string get_password() { return password; }


        public static bool GetLogin(string FileName = "Logins.json")
        {
            try
            {

                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName);

                if (!File.Exists(fullPath))
                {
                    Debug.WriteLine("Logins.json not found at: " + fullPath);
                    return false;
                }

                string json = File.ReadAllText(fullPath);
                var login = JsonSerializer.Deserialize<LoginJson>(json);

                username = login.username;
                password = login.password;

                Debug.WriteLine($"Loaded username: {username}");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"JSON load error: {ex.Message}");
                return false;
            }
        }

        private class LoginJson
        {
            public string username { get; set; }
            public string password { get; set; }
        }
    }
}
