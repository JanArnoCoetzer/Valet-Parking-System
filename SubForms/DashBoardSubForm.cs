using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms.Widgets;

namespace Valet_Parking_System.SubForms
{
    public partial class DashBoardSubForm : UserControl
    {
        public Operator UsingOperator;
        UpcomingbookingsWidget? upcommingWidget = null;
        public DashBoardSubForm()
        {
            InitializeComponent();
        }

        public void UpdateData(List<Booking> bookings, List<ParkingSpace> spaces) 
        {
            upcommingbookingsWidget.DisplayBookings(bookings);
            statusHotbarWidget.SetValues(bookings, spaces);
        }


    }
}
