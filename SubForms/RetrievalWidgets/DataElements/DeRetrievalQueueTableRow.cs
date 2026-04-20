using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.BookingWidgets.DataElements
{
    public partial class DeRetrievalQueueTableRow : UserControl
    {
        RetrievalQueueItem RetrievalQueueItemData;
        public DeRetrievalQueueTableRow(RetrievalQueueItem item)
        {
            InitializeComponent();
            this.RetrievalQueueItemData = item;
            txtPosition.Text = RetrievalQueueItemData.Position.ToString();
            txtRequestTime.Text = RetrievalQueueItemData.RequestTime;
            txtRegistration.Text = RetrievalQueueItemData.bookingDetails.Vehicle.Registation;
            txtSpace.Text = RetrievalQueueItemData.bookingDetails.ParkingSpace.LotIdentifier; 
        }
    }
}
