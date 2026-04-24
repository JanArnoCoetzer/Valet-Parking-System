using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;

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

            Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 30, 30)
            );
        }

        //-----------------------------Actions-----------------------------

        public void CloseAndDispose()
        {
            Close();
            Dispose();
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