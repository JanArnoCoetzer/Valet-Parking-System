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
        }

        public void Updatenearistbookings(List<Booking> bookings) 
        {
            upcommingbookingsWidget.DisplayBookings(bookings);
        }


        public void UpdatestatusHotbarWidget(string todaysbookings, string spacesavailable, string carsforretrieval) 
        {
            statusHotbarWidget.setValues(todaysbookings, spacesavailable, carsforretrieval);
        }
    }
}
