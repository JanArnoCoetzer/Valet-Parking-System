
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Valet_Parking_System.Classes
{
    public class RetrievalQueueItem
    {
        //-----------------BookingRelated-----------------
        public int BookingParkingSpaceId { get; set; } = 0;    
        public int BookingParkingOperatorId { get; set; } = 0;
        public string BookingDateFrom { get; set; } = "";
        public string BookingTimeFrom { get; set; } = "";
        public string BookingDateTo { get; set; } = "";
        public string BookingTimeTo { get; set; } = "";
        //-----------------Shared-----------------
        public string FullName { get; set; } = "";
        public string TelephoneNum { get; set; } = "";
        public string Address { get; set; } = "";
        public string CarReg { get; set; } = "";
        public string CarModel { get; set; } = "";
        public string CarColor { get; set; } = "";
        public string Status { get; set; } = "inQueue";

        //-----------------QueueRelated-----------------
        public int Position { get; set; } = 0;
        
        public string RequestTime { get; set; } = "";

        public RetrievalQueueItem(Booking booking,int pos, string newStatus) 
        {
            //-----------------BookingRelated-----------------     
            this.BookingParkingOperatorId = booking.OperatorId;       
            this.BookingDateFrom = booking.DateFrom;
            this.BookingTimeFrom = booking.TimeFrom;
            this.BookingDateTo = booking.DateTo;
            this.BookingTimeTo = booking.TimeTo;
            //-----------------Shared-----------------
            this.FullName = booking.FullName;
            this.TelephoneNum = booking.TelephoneNum;
            this.Address = booking.Address;
            this.CarReg = booking.CarReg;
            this.CarModel = booking.CarModel;
            this.CarColor = booking.CarColor;
            this.Status = newStatus;
            //-----------------QueueRelated-----------------
            Position = pos;
            setRequestTime();
        }

        private void setRequestTime() 
        {
            RequestTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); 
        }

    }


}
