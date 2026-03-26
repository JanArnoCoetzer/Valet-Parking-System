using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms.BookingWidgets.DataElements;
using Valet_Parking_System.SubForms.DashWidgets.DataElements;

namespace Valet_Parking_System.SubForms.Widgets
{
    public partial class UpcommingbookingsWidget : UserControl
    {
    
        public UpcommingbookingsWidget()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 20, 20));
        }

        public async void DisplayBookings(List<Booking> bookings)
        {

            var ListBookings = FilterNearestFive(bookings);

            foreach (var booking in ListBookings)
            {
                var row = new DeDashBookingsTableRow(booking,false);
                UpcomingBookingsTableContentPanel.Controls.Add(row);
            }
        }

        private List<Booking> FilterNearestFive(List<Booking> bookings) 
        {
            try
            {
                if (bookings == null || bookings.Count == 0)
                    return null;

                DateTime today = DateTime.Today;

                
                var todayBookings = new List<Booking>();

                foreach (var b in bookings)
                {
                    
                    DateTime fromDate = DateTime.ParseExact(
                        b.DateFrom,
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture); // [web:11]

                    if (fromDate.Date == today)
                    {
                        todayBookings.Add(b);
                    }
                }

                
                var ordered =
                    todayBookings
                        .OrderBy(b =>
                            DateTime.ParseExact(
                                $"{b.DateFrom} {b.TimeFrom}",
                                "dd/MM/yyyy HH:mm",
                                CultureInfo.InvariantCulture))
                        .Take(8) 
                        .ToList();

                return ordered;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"FilterNearestFive failed: {ex.Message}");
                MessageBox.Show($"Error loading bookings: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }


        ///-----------------------------Rendering-----------------------------
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );


    }
}
