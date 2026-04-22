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
                .Where(b => b.Status == "AwaitingStorage")
                .ToList();

            var awaitingPickup = _bookings
                .Where(b => b.Status == "AwaitingPickUp")
                .ToList();

            var awaitingOwner = _bookings
                .Where(b => b.Status == "AwaitingOwner")
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
                OperatorServices.SetStatusStored(bookingData, UsingOperator);
                ReloadBookings();
            }
        }

        public void SetStatusAwaitingOwner(Booking bookingData)
        {
            if (bookingData != null && UsingOperator != null)
            {
                OperatorServices.SetStatusAwaitingOwner(bookingData, UsingOperator);
                ReloadBookings();
            }
        }

        public void SetStatusHandedToOwner(Booking bookingData)
        {
            if (bookingData != null && UsingOperator != null)
            {
                bool success = OperatorServices.SetStatusHandedToOwner(bookingData, UsingOperator);

                if (success)
                {
                    ReloadBookings();
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

        //-----------------------------Helpers-----------------------------

        private void ReloadBookings()
        {
            MainLanding.LoadTables();
        }
    }
}