using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.DataAccessLayer;

namespace Valet_Parking_System.Repository.CRUD
{
    internal static class AdminRepository
    {
        //-----------------------------Parking Spaces-----------------------------

        internal static bool AddSpace(ParkingSpace spaceData)
        {
            return DataBaseHelper.ExecuteNonQuery(spaceData.GetAddSql(), "AddSpace");
        }

        internal static bool EditSpace(ParkingSpace spaceData)
        {
            return DataBaseHelper.ExecuteNonQuery(spaceData.GetUpdateSql(), "EditSpace");
        }

        internal static bool RemoveSpace(ParkingSpace spaceData)
        {
            return DataBaseHelper.ExecuteNonQuery(spaceData.GetRemoveSql(), "RemoveSpace");
        }

        //-----------------------------Operators-----------------------------

        internal static bool AddOperator(Operator operatorData)
        {
            return DataBaseHelper.ExecuteNonQuery(operatorData.GetAddSql(), "AddOperator");
        }

        internal static bool EditOperator(Operator operatorData)
        {
            return DataBaseHelper.ExecuteNonQuery(operatorData.GetUpdateSql(), "EditOperator");
        }

        internal static bool RemoveOperator(Operator operatorData)
        {
            return DataBaseHelper.ExecuteNonQuery(operatorData.GetRemoveSql(), "RemoveOperator");
        } 
    }
}