using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Services;
using Valet_Parking_System.SubForms.BookingWidgets;
using Valet_Parking_System.SubForms.BookingWidgets.DataElements;

namespace Valet_Parking_System.SubForms
{
    public partial class BookingSubForm : UserControl
    {
        private static readonly Random rand = new Random();

        private BookingsTable _bookingsTable;
        private BookingSearchBar _bookingSearch;

        private List<Booking> _loadedBookings;
        private List<ParkingSpace> _loadedParking;

        public MainLanding MainLanding;
        public Operator UsingOperator;

        //-----------------------------Constructor-----------------------------

        public BookingSubForm()
        {
            InitializeComponent();

            _bookingsTable = BookingTableWidget;
            _bookingSearch = SearchBookingsWidget;

            _bookingSearch.SetParentForm(this);
            _bookingsTable.SetParentForm(this);

            NewBookingWidget.BookingCreateRequest += OnBookingCreated;
        }

        //-----------------------------Setup / Loading-----------------------------

        public void LoadLists(List<Booking> bookings, List<ParkingSpace> parking)
        {
            _loadedBookings = bookings;
            _loadedParking = parking;

            _bookingsTable.DisplayBookingsAsync(_loadedBookings);
        }

        public void SetMainLanding(MainLanding mainLanding)
        {
            MainLanding = mainLanding;
        }

        //-----------------------------Filtering-----------------------------

        public void FilterBookings(string bookingIdText = "", string customerNameText = "", string carRegText = "")
        {
            List<Booking> filteredBookings = BookingsService.FilterBookings(
                _loadedBookings,
                bookingIdText,
                customerNameText,
                carRegText);

            _bookingsTable.DisplayBookingsAsync(filteredBookings);
        }

        //-----------------------------Database Actions-----------------------------

        private void OnBookingCreated(object sender, Booking booking)
        {
            booking.ParkingSpace = ParkingServices.GetNextAvailableSpace(_loadedParking);

            bool customerAdded = CustomerService.AddCustomer(booking.Customer);
            bool vehicleAdded = VehicleService.AddVehicle(booking.Vehicle);
            bool bookingAdded = false;

            if (customerAdded && vehicleAdded)
            {
                bookingAdded = BookingsService.AddBooking(booking, UsingOperator);
            }

            if (customerAdded && vehicleAdded && bookingAdded)
            {
                MainLanding.LoadTables();
            }
            else
            {
                MessageBox.Show("Booking could not be added.");
            }
        }

        public void EditBooking(Booking booking)
        {
            if (booking == null || booking.Customer == null || booking.Vehicle == null || UsingOperator == null)
            {
                MessageBox.Show("Booking data is incomplete.");
                return;
            }

            bool customerEdited = CustomerService.EditCustomer(booking.Customer);
            bool vehicleEdited = VehicleService.EditVehicle(booking.Vehicle);
            bool bookingEdited = false;

            if (customerEdited && vehicleEdited)
            {
                bookingEdited = BookingsService.EditBooking(booking, UsingOperator);
            }

            if (customerEdited && vehicleEdited && bookingEdited)
            {
                MainLanding?.LoadTables();
            }
            else
            {
                MessageBox.Show("Booking could not be updated.");
            }
        }
    }
}