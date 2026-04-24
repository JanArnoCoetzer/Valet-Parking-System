using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.SubForms.BookingWidgets.FloatingWidgets
{
    public partial class InformationPanelWindow : Form
    {
        private Booking selectedBooking;

        //-----------------------------Constructor-----------------------------

        public InformationPanelWindow(BookingsTable bookingsTable, Booking selectedBooking)
        {
            InitializeComponent();
            RegionHelper.ApplyRoundedRegion(this, 20);

            this.selectedBooking = selectedBooking;

            

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

    }
}