using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Classes.Constants.ParkingSpace;
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

            int customerId = CustomerService.AddCustomerAndReturnId(booking.Customer);

            if (customerId <= 0)
            {
                MessageBox.Show("Customer could not be added.");
                return;
            }

            booking.Customer.CustomerID = customerId;

            int vehicleId = VehicleService.AddVehicleAndReturnId(booking.Vehicle);
            if (vehicleId <= 0)
            {
                MessageBox.Show("Vehicle could not be added.");
                return;
            }

            booking.Vehicle.ID = vehicleId;

            bool bookingAdded = BookingsService.AddBooking(booking, UsingOperator);

            if (bookingAdded)
            {
                ParkingServices.SetStatus(booking.ParkingSpace, ParkingSpaceStatus.Occupied);
                MainLanding.LoadTables();
            }
            else
            {
                MessageBox.Show("Booking could not be added.");
                CustomerService.RemoveCustomer(booking.Customer);
                VehicleService.RemoveVehicle(booking.Vehicle);
                ParkingServices.SetStatus(booking.ParkingSpace,ParkingSpaceStatus.Available);
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
                MainLanding.LoadTables();
            }
            else
            {
                MessageBox.Show("Booking could not be updated.");
            }
        }

        internal void MarkForRetrieval(Booking selectedBooking)
        {
            if (OperatorServices.SetStatusAwaitingPickUp(selectedBooking, UsingOperator)) 
            {
                MainLanding.LoadTables();
            }
            else
            {
                MessageBox.Show("Could not mark for retrieval.");
            }
        }
    }
}