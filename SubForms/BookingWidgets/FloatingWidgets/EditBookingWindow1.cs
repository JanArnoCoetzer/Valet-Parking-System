using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.SubForms.BookingWidgets
{
    public partial class EditBookingWindow1 : Form
    {
        private EditBookingWidget editBookingWidget;

        //-----------------------------Constructor-----------------------------

        public EditBookingWindow1(BookingsTable bookingsTable, Booking bookingData)
        {
            InitializeComponent();

            editBookingWidget = EditBookingWidget;
            editBookingWidget.SetParentTable(bookingsTable);
            editBookingWidget.SetBookingData(bookingData);
            editBookingWidget.SetParentForm(this);

            RegionHelper.ApplyRoundedRegion(this, 20);
        }

        //-----------------------------Actions-----------------------------

        public void CloseAndDispose()
        {
            Close();
            Dispose();
        }

       
    }
}