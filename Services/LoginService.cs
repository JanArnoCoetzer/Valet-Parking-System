using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Classes.Constants.Login;

namespace Valet_Parking_System.Services
{
    public static class LoginService
    {
        public static LoginResult CheckLogin(List<Operator> operators, string name, string password)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
            {
                return LoginResult.MissingInput;
            }

            if (operators == null || operators.Count == 0)
            {
                return LoginResult.DatabaseUnavailable;
            }

            Operator foundOperator = FindOperator(operators, name, password);

            return foundOperator == null
                ? LoginResult.InvalidCredentials
                : LoginResult.Success;
        }

        public static Operator FindOperator(List<Operator> operators, string name, string password)
        {

            if (operators == null || operators.Count == 0)
            {
                return null;
            }

            return operators.Find(op =>
                op.fullName.Equals(name, StringComparison.OrdinalIgnoreCase) &&
                op.Password == password);
        }
    }
}