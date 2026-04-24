using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Helpers;
using Valet_Parking_System.Services;
using Valet_Parking_System.SubForms.BookingWidgets.DataElements;
using Valet_Parking_System.SubForms.DashWidgets.DataElements;

namespace Valet_Parking_System.SubForms.Widgets
{
    public partial class UpcomingbookingsWidget : UserControl
    {
        private const string StoredStatus = "Stored";

        //-----------------------------Constructor-----------------------------

        public UpcomingbookingsWidget()
        {
            InitializeComponent();
            RegionHelper.ApplyRoundedRegion(this, 20);
        }

        //-----------------------------Display-----------------------------

        public void DisplayBookings(List<Booking> bookings)
        {
            UpcomingBookingsTableContentPanel.Controls.Clear();

            List<Booking> filteredBookings = BookingsService.FilterNearest(bookings);

            foreach (Booking booking in filteredBookings)
            {
                DeDashBookingsTableRow row = new DeDashBookingsTableRow(booking, false);
                UpcomingBookingsTableContentPanel.Controls.Add(row);
            }
        }

        internal void ClearTable()
        {
            UpcomingBookingsTableContentPanel.Controls.Clear();
        }

    } 
}

