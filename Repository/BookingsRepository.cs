using Oracle.ManagedDataAccess.Client;
using Valet_Parking_System.Classes;
using Valet_Parking_System.DataAccessLayer;

namespace Valet_Parking_System.Repository
{
    public class BookingsRepository()
    {

        private readonly OracleDbContext _db;



        public bool CreateBooking(Booking booking)
        {
            string sql = @"
                INSERT INTO BOOKINGS (
                    BOOKING_ID, FULL_NAME, PHONE, ADDRESS, CAR_REG, CAR_MODEL, CAR_COLOR,
                    DATE_FROM, DATE_TO, PARKING_SPACE_ID, OPERATOR_ID, STATUS, REQUEST_TIME
                )
                VALUES (
                    SEQ_BOOKINGS.NEXTVAL, :fullName, :phone, :address, :carReg, :carModel, :carColor,
                    TO_DATE(:dateFrom, 'YYYY-MM-DD'), TO_DATE(:dateTo, 'YYYY-MM-DD'), 
                    :spaceId, :operatorId, :status, SYSDATE
                )";

            var parameters = new OracleParameter[]
            {
                new() { ParameterName = "fullName", Value = booking.FullName},
                new() { ParameterName = "phone", Value = booking.TelephoneNum},
                new() { ParameterName = "address", Value = booking.Address},
                new() { ParameterName = "carReg", Value = booking.CarReg},
                new() { ParameterName = "carModel", Value = booking.CarModel},
                new() { ParameterName = "carColor", Value = booking.CarColor},
                new() { ParameterName = "dateFrom", Value = booking.DateFrom},
                new() { ParameterName = "dateTo", Value = booking.DateTo},
                new() { ParameterName = "operatorId", Value = booking.OperatorId},
                new() { ParameterName = "status", Value = booking.Status}
            };

            return true;
        }
    }
}
