
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Valet_Parking_System.Classes
{
    public class RetrievalQueueItem
    {
        public Booking bookingDetails = null;
        //-----------------BookingRelated-----------------
       
        public string Status { get; set; } = "inQueue";

        //-----------------QueueRelated-----------------
        public int Position { get; set; } = 0;
        
        public string RequestTime { get; set; } = "";

        public RetrievalQueueItem(Booking booking,int pos, string newStatus) 
        {      
            bookingDetails = booking;
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
