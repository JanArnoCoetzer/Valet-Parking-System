using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms.Widgets;

namespace Valet_Parking_System.SubForms
{
    public partial class DashBoardSubForm : UserControl
    {
        UpcommingbookingsWidget? upcommingWidget = null;
        public DashBoardSubForm()
        {
            InitializeComponent();
            if (this.upcommingbookingsWidget != null) 
            {
                upcommingbookingsWidget = this.upcommingbookingsWidget;
            }

        }

        public void Updatenearistbookings(List<Booking> bookings) 
        {
            upcommingbookingsWidget.DisplayBookings(bookings);
        }
    }
}
