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
    public partial class UpcomingbookingsWidget : UserControl
    {
        private const string StoredStatus = "Stored";

        //-----------------------------Constructor-----------------------------

        public UpcomingbookingsWidget()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 20, 20));
        }

        //-----------------------------Display-----------------------------

        public void DisplayBookings(List<Booking> bookings)
        {
            UpcomingBookingsTableContentPanel.Controls.Clear();

            List<Booking> filteredBookings = FilterNearest(bookings);

            foreach (Booking booking in filteredBookings)
            {
                DeDashBookingsTableRow row = new DeDashBookingsTableRow(booking, false);
                UpcomingBookingsTableContentPanel.Controls.Add(row);
            }
        }

        private List<Booking> FilterNearest(List<Booking> bookings)
        {
            if (bookings == null || bookings.Count == 0)
            {
                return new List<Booking>();
            }

            try
            {
                DateTime now = DateTime.Now;

                return bookings
                    .Where(b => b.Status == StoredStatus)
                    .Select(b =>
                    {
                        bool isValidDateTime = DateTime.TryParseExact(
                            $"{b.DateTo} {b.TimeTo}",
                            "dd/MM/yyyy HH:mm",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out DateTime pickupDateTime
                        );

                        return new
                        {
                            Booking = b,
                            IsValidDateTime = isValidDateTime,
                            PickupDateTime = pickupDateTime
                        };
                    })
                    .Where(x => x.IsValidDateTime)
                    .Where(x => x.PickupDateTime.Date == now.Date)
                    .Where(x => x.PickupDateTime >= now)
                    .OrderBy(x => x.PickupDateTime)
                    .Select(x => x.Booking)
                    .ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"FilterNearest failed: {ex.Message}");
                MessageBox.Show(
                    $"Error loading bookings: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return new List<Booking>();
            }
        }

        internal void ClearTable()
        {
            UpcomingBookingsTableContentPanel.Controls.Clear();
        }

        //-----------------------------Rendering-----------------------------

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

