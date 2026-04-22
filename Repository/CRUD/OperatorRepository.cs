using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.Repository.CRUD
{
    internal class OperatorRepository
    {
        internal static bool SetStorageOperator(Booking bookingdata, Operator usingOperator)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static bool SetHandingOffOperator(Booking bookingdata, Operator usingOperator)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool SetRetrievalOperator(Booking bookingdata, Operator usingOperator)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        
    }
}
