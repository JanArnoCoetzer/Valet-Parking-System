using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.BookingWidgets.FloatingWidgets
{
    public partial class InformationPanelWindow : Form
    {
        private Booking selectedBooking;

        //-----------------------------Constructor-----------------------------

        public InformationPanelWindow(BookingsTable bookingsTable, Booking selectedBooking)
        {
            InitializeComponent();

            this.selectedBooking = selectedBooking;

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            carInformation.SetInformation(selectedBooking.Vehicle);
            customerInformation.SetInformation(selectedBooking.Customer);
            storageInformation.SetInformation(
                selectedBooking.DateFrom,
                selectedBooking.TimeFrom,
                selectedBooking.DateTo,
                selectedBooking.TimeTo,
                selectedBooking.ParkingSpace,
                selectedBooking.StorageOperator
            );
        }

        //-----------------------------Actions-----------------------------

        private void btnCloseInformationPanel_Click(object sender, EventArgs e)
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