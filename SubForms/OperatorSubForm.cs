using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Services;

namespace Valet_Parking_System.SubForms
{
    public partial class OperatorSubForm : UserControl
    {
        private List<Booking> _bookings;

        public Operator UsingOperator;
        public MainLanding MainLanding;

        //-----------------------------Constructor-----------------------------

        public OperatorSubForm()
        {
            InitializeComponent();

            carStorageWidget.SetParent(this);
            carRetrievalWidget.SetParent(this);
            AwaitingOwnerWidget.SetParent(this);
        }

        //-----------------------------Parent / Setup-----------------------------

        public void SetMainLanding(MainLanding mainLanding)
        {
            MainLanding = mainLanding;
        }

        //-----------------------------Data Loading-----------------------------

        public void LoadBookings(List<Booking> bookings)
        {
            _bookings = bookings ?? new List<Booking>();

            var awaitingStorage = _bookings
                .Where(b => b.Status == BookingStatuses.AwaitingStorage)
                .ToList();

            var awaitingPickup = _bookings
                .Where(b => b.Status == BookingStatuses.AwaitingPickUp)
                .ToList();

            var awaitingOwner = _bookings
                .Where(b => b.Status == BookingStatuses.AwaitingOwner)
                .ToList();

            carStorageWidget.LoadBookings(awaitingStorage);
            carRetrievalWidget.LoadBookings(awaitingPickup);
            AwaitingOwnerWidget.LoadBookings(awaitingOwner);
        }

        //-----------------------------Status Actions-----------------------------

        public void SetStatusStored(Booking bookingData)
        {
            if (bookingData != null && UsingOperator != null)
            {
                bool success = OperatorServices.SetStatusStored(bookingData, UsingOperator);

                if (success)
                {
                    MainLanding.LoadTables();
                }
                else
                {
                    MessageBox.Show(
                        "Failed to update booking status to stored.",
                        "Operation Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        public void SetStatusAwaitingOwner(Booking bookingData)
        {
            if (bookingData != null && UsingOperator != null)
            {
                bool success = OperatorServices.SetStatusAwaitingOwner(bookingData, UsingOperator);

                if (success)
                {
                    MainLanding.LoadTables();
                }
                else
                {
                    MessageBox.Show(
                        "Failed to update booking status to awaiting owner.",
                        "Operation Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        public void SetStatusHandedToOwner(Booking bookingData)
        {
            if (bookingData != null && UsingOperator != null)
            {
                bool success = OperatorServices.SetStatusHandedToOwner(bookingData, UsingOperator);

                if (success)
                {
                    MainLanding.LoadTables();
                }
                else
                {
                    MessageBox.Show(
                        "Failed to archive and remove the booking.",
                        "Operation Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

    }
}