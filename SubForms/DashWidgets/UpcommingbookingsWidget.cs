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
            UpcomingBookingsTableContentPanel.Controls.Clear();
            var ListBookings = FilterNearest(bookings);

            foreach (var booking in ListBookings)
            {
                var row = new DeDashBookingsTableRow(booking,false);
                UpcomingBookingsTableContentPanel.Controls.Add(row);
            }
        }

        private List<Booking> FilterNearest(List<Booking> bookings)
        {
            try
            {
                if (bookings == null || bookings.Count == 0)
                    return null;

                DateTime now = DateTime.Now;

                var ordered = bookings
                    .Select(b => new
                    {
                        Booking = b,
                        PickupDateTime = DateTime.ParseExact(
                            $"{b.DateTo} {b.TimeTo}",
                            "dd/MM/yyyy HH:mm",
                            CultureInfo.InvariantCulture)
                    })
                    .Where(x => x.Booking.Status == "Stored")
                    .Where(x => x.PickupDateTime.Date == now.Date)
                    .Where(x => x.PickupDateTime >= now)
                    .OrderBy(x => x.PickupDateTime)
                    .Select(x => x.Booking)
                    .ToList();

                return ordered;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"FilterNearest failed: {ex.Message}");
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

        internal void ClearTable()
        {
            throw new NotImplementedException();
        }
    }
}
