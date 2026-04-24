using System.Globalization;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.SubForms.DashWidgets.DataElements
{
    public partial class StatusHotbarWidget : UserControl
    {
        private const string StoredStatus = "Stored";
        private const string AwaitingStorageStatus = "AwaitingStorage";
        private const string AwaitingPickUpStatus = "AwaitingPickUp";
        private const string AwaitingOwnerStatus = "AwaitingOwner";

        //-----------------------------Constructor-----------------------------

        public StatusHotbarWidget()
        {
            InitializeComponent();
            RegionHelper.ApplyRoundedRegion(this, 20);
        }

        //-----------------------------Setup-----------------------------

        public void SetValues(List<Booking> bookings, List<ParkingSpace> parkingSpaces)
        {
            bookings ??= new List<Booking>();
            parkingSpaces ??= new List<ParkingSpace>();

            txtStored.Text = bookings.Count(b => b.Status == StoredStatus).ToString();
            txtAwaitingStorage.Text = bookings.Count(b => b.Status == AwaitingStorageStatus).ToString();
            txtAwaitingPickUp.Text = bookings.Count(b => b.Status == AwaitingPickUpStatus).ToString();
            txtAwaitingOwner.Text = bookings.Count(b => b.Status == AwaitingOwnerStatus).ToString();

            txtUpcomingBookings.Text = bookings.Count(b =>
                DateTime.TryParseExact(
                    b.DateFrom,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime bookingDate
                ) &&
                bookingDate.Date == DateTime.Today
            ).ToString();

            txtAvailableParking.Text = parkingSpaces.Count(p => p.Available).ToString();
        }
    }
}